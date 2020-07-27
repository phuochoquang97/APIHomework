using ApiHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHomework.Data.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetEmployees();
        IEnumerable<Employee> GetEmployeesByWorkspaceId(int id);
        IEnumerable<Employee> GetEmployeesByWorkspaceName(string name);
    }
}
