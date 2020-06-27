using iLAB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLAB.Controllers
{
    public class EmployeeController
    {
        public static Employee GetEmployeeByID(string ID)
        {
            using (var _context = new DBILABEntities())
            {
                var employees = (from e in _context.Employees.AsEnumerable()
                                 where e.ID == ID
                                 select e).Select(x => new Employee
                                 {
                                     ID = x.ID,
                                     Name = x.Name,
                                     Major = x.Major,
                                     Position = x.Position,
                                     Birthday = x.Birthday,
                                     Phone = x.Phone,
                                     Email = x.Email,
                                     HourlyWages = x.HourlyWages,
                                     PassWord = x.PassWord,
                                     EmpImage = x.EmpImage
                                 }).ToList();
                if (employees.Count == 1)
                {
                    return employees[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Employee> GetListEmployee()
        {
            using (var _context = new DBILABEntities())
            {
                var employees = (from e in _context.Employees.AsEnumerable()
                                 select e).Select(x => new Employee
                                 {
                                     ID = x.ID,
                                     Name = x.Name,
                                     Major = x.Major,
                                     Position = x.Position,
                                     Birthday = x.Birthday,
                                     Phone = x.Phone,
                                     Email = x.Email,
                                     EmpImage = x.EmpImage,
                                     HourlyWages = x.HourlyWages,
                                     PassWord = x.PassWord,
                                 }).ToList();
                return employees;
            }
        }
        public static bool AddEmployee(Employee emloyee)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    _context.Employees.Add(emloyee);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateEmployee(Employee emloyee)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    _context.Employees.AddOrUpdate(emloyee);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteEmployee(string ID)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    Employee employee = (from e in _context.Employees
                                         where e.ID == ID
                                         select e).Single();

                    #region DeleteWork

                    List<Work> works = WorkController.GetListWorkByIDEmp(ID);

                    if (works != null)
                    {
                        foreach (Work work in works)
                        {
                            bool oldValidateOnSaveEnabled = _context.Configuration.ValidateOnSaveEnabled;
                            try
                            {
                                _context.Configuration.ValidateOnSaveEnabled = false;

                                _context.Works.Attach(work);
                                _context.Entry(work).State = System.Data.Entity.EntityState.Deleted;
                                _context.SaveChanges();
                            }
                            finally
                            {
                                _context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                            }
                        }
                    }
                    #endregion
                    #region DeleteSalary

                    List<Salary> salaries = SalaryController.GetSalaryByIDEmp(ID);

                    if (salaries != null)
                    {
                        foreach (Salary salary in salaries)
                        {
                            bool oldValidateOnSaveEnabled = _context.Configuration.ValidateOnSaveEnabled;
                            try
                            {
                                _context.Configuration.ValidateOnSaveEnabled = false;

                                _context.Salaries.Attach(salary);
                                _context.Entry(salary).State = System.Data.Entity.EntityState.Deleted;
                                _context.SaveChanges();
                            }
                            finally
                            {
                                _context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                            }
                        }
                    }
                    #endregion

                    #region DeleteTask
                    foreach (var task in employee.Tasks)
                    {
                        foreach (var e in task.Employees)
                        {
                            if (e.ID == employee.ID)
                            {
                                task.Employees.Remove(e);
                                break;
                            }
                        }
                    }

                    #endregion
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
