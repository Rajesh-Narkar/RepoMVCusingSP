using RepoMVCusingSP.Models;

namespace RepoMVCusingSP.Repo
{
    public interface EmpRepo
    {
        void NewEmp(Emp e);
        List<Emp> GetAllEmps();
        void RemoveEmp(int id);
        Emp GetEmpById(int id);
        void ModifyEmp(Emp e);
        List<Emp> SearchEmp(string searchTerm);
    }
}
