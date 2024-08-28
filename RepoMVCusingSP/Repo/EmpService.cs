using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepoMVCusingSP.Data;
using RepoMVCusingSP.Models;

namespace RepoMVCusingSP.Repo
{
    public class EmpService : EmpRepo
    {
        private readonly ApplicationDbContext db;

        public EmpService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Emp> GetAllEmps()
        {
            return db.Emp.FromSqlRaw("EXEC GetAllEmps").ToList();
        }

        public void NewEmp(Emp e)
        {
            db.Database.ExecuteSqlRaw("EXEC NewEmp @p0, @p1", e.Name, e.Salary);
        }

        public void RemoveEmp(int id)
        {
            db.Database.ExecuteSqlRaw("EXEC RemoveEmp @p0", id);
        }

        public Emp GetEmpById(int id)
        {
            return db.Emp.FromSqlRaw("EXEC GetEmpById @p0", id).FirstOrDefault();
        }

        public void ModifyEmp(Emp e)
        {
            db.Database.ExecuteSqlRaw("EXEC ModifyEmp @p0, @p1, @p2", e.Id, e.Name, e.Salary);
        }

        public List<Emp> SearchEmp(string searchTerm)
        {
            return db.Emp.FromSqlRaw("EXEC SearchEmp @p0", searchTerm).ToList();
        }
    }
}
