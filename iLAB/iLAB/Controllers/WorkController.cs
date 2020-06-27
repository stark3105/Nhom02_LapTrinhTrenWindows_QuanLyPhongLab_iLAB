using iLAB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLAB.Controllers
{
    public class WorkController
    {
        public static List<Work> GetListWorkByDay(DateTime date)
        {
            using (var _context = new DBILABEntities())
            {
                var works = (from w in _context.Works.AsEnumerable()
                             where w.CheckIn >= date.Date
                             select w).Select(x => new Work
                             {
                                 ID = x.ID,
                                 CheckIn = x.CheckIn,
                                 CheckOut = x.CheckOut,
                                 IDEmployee = x.IDEmployee
                             }).ToList();
                if (works.Count > 0)
                {
                    return works;
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Work> GetListWorkByIDEmp(string IDEmp)
        {
            using (var _context = new DBILABEntities())
            {
                var works = (from w in _context.Works.AsEnumerable()
                             where w.IDEmployee == IDEmp
                             select w).ToList();

                if (works.Count > 0)
                {
                    return works;
                }
                return null;
            }
        }

        public static int GetIDFromDB()
        {
            using (var _context = new DBILABEntities())
            {
                var ids = (from t in _context.Works
                           select t.ID).ToList();

                if (ids.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    return ids[ids.Count - 1] + 1;
                }
            }
        }

        public static void AddWork(Work work)
        {
            using (var _context = new DBILABEntities())
            {
                _context.Works.Add(work);
                _context.SaveChanges();
            }
        }

        public static void UpdateWork(Work work)
        {
            using (var _context = new DBILABEntities())
            {
                _context.Works.AddOrUpdate(work);
                _context.SaveChanges();
            }
        }
    }
}
