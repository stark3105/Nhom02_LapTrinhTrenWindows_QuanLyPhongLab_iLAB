using iLAB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLAB.Controllers
{
    public class SalaryController
    {
        public static int GetIDFromDB()
        {
            using (var _context = new DBILABEntities())
            {
                var salaries = (from s in _context.Salaries
                                select s.ID).ToList();

                if (salaries.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    return salaries[salaries.Count - 1] + 1;
                }
            }
        }

        public static Salary GetSalaryByIDEmpMY(string IDEmployee, int Month, int Year)
        {
            using (var _context = new DBILABEntities())
            {
                var salary = (from s in _context.Salaries.AsEnumerable()
                              where s.IDEmployee == IDEmployee && s.Month == Month && s.Year == Year
                              select s).Select(x => new Salary
                              {
                                  ID = x.ID,
                                  TotalHours = x.TotalHours,
                                  Rewards = x.Rewards,
                                  Month = x.Month,
                                  Year = x.Year,
                                  TotalSalary = x.TotalSalary,
                                  IDEmployee = x.IDEmployee
                              }).ToList();

                if (salary.Count == 1)
                {
                    return salary[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Salary> GetSalaryByIDEmp(string IDEmployee)
        {
            using (var _context = new DBILABEntities())
            {
                var salary = (from s in _context.Salaries.AsEnumerable()
                             where s.IDEmployee == IDEmployee
                              select s).ToList();

                if (salary.Count > 0)
                {
                    return salary;
                }
                return null;
            }
        }
        public static List<SalaryEmployee> GetListSalary(int Month, int Year)
        {
            using (var _context = new DBILABEntities())
            {
                var salaries = (from s in _context.Salaries.AsEnumerable()
                                where s.Month == Month && s.Year == Year
                                select s).Select(x => new Salary
                                {
                                    ID = x.ID,
                                    TotalHours = x.TotalHours,
                                    Rewards = x.Rewards,
                                    Month = x.Month,
                                    Year = x.Year,
                                    TotalSalary = x.TotalSalary,
                                    IDEmployee = x.IDEmployee
                                }).ToList();

                List<SalaryEmployee> salaryEmployees = new List<SalaryEmployee>();

                if (salaries.Count > 0)
                {
                    foreach (Salary s in salaries)
                    {
                        Employee e = EmployeeController.GetEmployeeByID(s.IDEmployee);

                        SalaryEmployee salaryEmployee = new SalaryEmployee
                        {
                            IDEmp = s.IDEmployee,
                            NameEmp = e.Name,
                            TotalHours = s.TotalHours,
                            Rewards = s.Rewards,
                            TotalSalary = s.TotalSalary
                        };

                        salaryEmployees.Add(salaryEmployee);
                    }
                }
                return salaryEmployees;
            }
        }

        public static void CaculateSalaryByMY(int month, int year)
        {
            List<Employee> employees = EmployeeController.GetListEmployee();

            foreach (Employee employee in employees)
            {
                Salary salary = SalaryController.GetSalaryByIDEmpMY(employee.ID, month, year);

                List<Models.Task> tasks = TaskController.GetListTaskByIDEmp(employee.ID);

                tasks = tasks.Where(t => t.EndDate.Value.Month == month && t.EndDate.Value.Year == year).ToList();

                if (salary == null)
                {
                    int id = SalaryController.GetIDFromDB();
                    salary = new Salary
                    {
                        ID = id,
                        TotalHours = 0,
                        Rewards = 0,
                        Month = month,
                        Year = year,
                        TotalSalary = 0,
                        IDEmployee = employee.ID
                    };
                }
                salary.Rewards = tasks.Count;
                salary.TotalHours = 0;

                List<Work> works = WorkController.GetListWorkByIDEmp(employee.ID);

                if (works != null)
                {
                    foreach (Work work in works)
                    {
                        DateTime dateTime = DateTime.Parse(work.CheckIn.ToString());

                        if (dateTime.Month == month && dateTime.Year == year)
                        {
                            if (work.CheckOut != null)
                            {
                                TimeSpan totalDate = DateTime.Parse(work.CheckOut.ToString()) - DateTime.Parse(work.CheckIn.ToString());

                                salary.TotalHours += totalDate.TotalHours;
                            }
                        }
                    }
                }

                salary.TotalHours = Math.Round(Convert.ToDouble(salary.TotalHours), 2);

                salary.TotalSalary = Convert.ToInt32(salary.TotalHours * employee.HourlyWages + salary.Rewards * 100000);

                UpdateSalary(salary);
            }
        }

        public static void UpdateSalary(Salary salary)
        {
            using (var _context = new DBILABEntities())
            {
                _context.Salaries.AddOrUpdate(salary);
                _context.SaveChanges();
            }
        }

        public static void AddSalary(Salary salary)
        {
            using (var _context = new DBILABEntities())
            {
                _context.Salaries.Add(salary);
                _context.SaveChanges();
            }
        }
    }
}
