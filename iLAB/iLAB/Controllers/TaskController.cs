using iLAB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = iLAB.Models.Task;

namespace iLAB.Controllers
{
    public class TaskController
    {
        public static List<Task> getListTaskByProject(int idProject)
        {
            using (var _context = new DBILABEntities())
            {
                var tasks = (from t in _context.Tasks.AsEnumerable()
                             where t.IDProject == idProject
                             select t)

                                .Select(x => new Task
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Description = x.Description,
                                    StartDate = x.StartDate,
                                    EndDate = x.EndDate,
                                    Status = x.Status,
                                    IDProject = x.IDProject,
                                }).ToList();
                return tasks;
            }
        }

        public static List<Task> GetListTaskByIDEmp(string IDEmp)
        {
            List<Task> tasks = new List<Models.Task>();

            using (var _context = new DBILABEntities())
            {
                Employee employee = (from e in _context.Employees
                                     where e.ID == IDEmp
                                     select e).Single();

                foreach (var task in employee.Tasks)
                {
                    tasks.Add(task);
                }
                return tasks;
            }
        }

        public static Task GetTasktByID(int id)
        {
            using (var _context = new DBILABEntities())
            {
                var task = (from t in _context.Tasks.AsEnumerable()
                            where t.ID == id
                            select t)
                                .Select(x => new Task
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Description = x.Description,
                                    StartDate = x.StartDate,
                                    EndDate = x.EndDate,
                                    Status = x.Status,
                                    IDProject = x.IDProject,
                                    LinkDocuments = x.LinkDocuments,
                                    Project = x.Project,
                                    Employees = x.Employees
                                }).Single();
                return task;
            }
        }

        public static bool AddTask(Task task)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {

                    foreach (var employee in task.Employees)
                    {
                        var employeedb = (from e in _context.Employees
                                          where e.ID== employee.ID
                                          select e).Single();
                        employeedb.Tasks.Add(task);
                    }
                    task.Employees.Clear();

                    _context.Tasks.AddOrUpdate(task);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateTask(Task task)
        {
            try
            {
                DeleteTask(task.ID);
                AddTask(task);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteTask(int id)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    var dbtask = (from t in _context.Tasks
                                  where t.ID == id
                                  select t).SingleOrDefault();

                    foreach (var e in _context.Employees)
                    {
                        foreach (var t in e.Tasks)
                        {
                            if (t.ID == dbtask.ID)
                            {
                                e.Tasks.Remove(t);
                                break;
                            }
                        }
                    }

                    var dbProject = (from p in _context.Projects
                                     where p.ID == dbtask.IDProject
                                     select p).SingleOrDefault();

                    dbProject.Tasks.Remove(dbtask);

                    _context.Tasks.Remove(dbtask);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<int> getListTasksID()
        {
            using (var _context = new DBILABEntities())
            {
                var ids = (from t in _context.Tasks.AsEnumerable()
                           select t.ID).ToList();
                return ids;
            }
        }

        public static int GetNextTaskID()
        {
            using (var _context = new DBILABEntities())
            {
                var ids = getListTasksID();
                if (ids.Count <= 0)
                    return 1;
                else
                {
                    int id = 1;
                    while (true)
                    {
                        if (ids.Contains(id)) { id++; }
                        else { return id; }
                    }
                }
            }
        }
    }
}
