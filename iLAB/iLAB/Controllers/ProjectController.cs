using iLAB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task = iLAB.Models.Task;

namespace iLAB.Controllers
{
    public class ProjectController
    {
        public static List<Project> getListProjects()
        {
            using (var _context = new DBILABEntities())
            {
                var projects = (from p in _context.Projects.AsEnumerable()
                                select p)

                                .Select(x => new Project
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Description = x.Description,
                                    StartDate = x.StartDate,
                                    EndDate = x.EndDate,
                                    Status = x.Status,
                                    IDLeader = x.IDLeader,
                                }).ToList();
                return projects;
            }    
        }

        public static List<int> getListProjectsID()
        {
            using (var _context = new DBILABEntities())
            {
                var ids = (from p in _context.Projects.AsEnumerable()
                           select p.ID).ToList();
                return ids;
            }
        }

        public static Project GetProjectByID(int id)
        {
            using (var _context = new DBILABEntities())
            {
                var project = (from p in _context.Projects.AsEnumerable()
                                where p.ID == id
                                select p)

                                .Select(x => new Project
                                {
                                    ID = x.ID,
                                    Name = x.Name,
                                    Description = x.Description,
                                    StartDate = x.StartDate,
                                    EndDate = x.EndDate,
                                    Status = x.Status,
                                    IDLeader = x.IDLeader,
                                }).Single();
                return project;
            }
        }

        public static int GetNextProjectID()
        {
            using (var _context = new DBILABEntities())
            {
                var ids = getListProjectsID();
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

        public static bool AddProject(Project project)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    _context.Projects.AddOrUpdate(project);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool DeleteProject(int id)
        {
            try
            {
                using (var _context = new DBILABEntities())
                {
                    var dbproject = (from p in _context.Projects
                                  where p.ID == id
                                  select p).SingleOrDefault();

                    List<Task> dbtask = TaskController.getListTaskByProject(id);

                    if(dbtask.Count > 0)
                    {
                        foreach (Task task in dbtask)
                        {
                            /*
                            bool oldValidateOnSaveEnabled = _context.Configuration.ValidateOnSaveEnabled;

                            try
                            {
                                _context.Configuration.ValidateOnSaveEnabled = false;

                                _context.Tasks.Attach(task);
                                _context.Entry(task).State = EntityState.Deleted;
                                _context.SaveChanges();
                            }
                            finally
                            {
                                _context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                            }*/
                            TaskController.DeleteTask(task.ID);
                        }
                    }    
                    
                    _context.Projects.Remove(dbproject);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<Project> GetListProjectsByIDLeader(string IDLeader)
        {
            using (var _context = new DBILABEntities())
            {
                var projects = (from p in _context.Projects.AsEnumerable()
                                where p.IDLeader == IDLeader
                                select p).ToList();
                if (projects.Count > 0)
                {
                    return projects;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
