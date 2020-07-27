using ApiHomework.Data.Interfaces;
using ApiHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHomework.Data.Implementations
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> _employees = new List<Employee>()
        {
            new Employee()
            {
                Id=1,
                FirstName="An",
                LastName="Nguyen",
                Dob=DateTime.Now.AddYears(-24),
                CreatedAt=DateTime.Now,
                UpdatedAt=DateTime.Now,
                WorkspaceId=1
            },
            new Employee()
            {
                Id=2,
                FirstName="Phuoc",
                LastName="Ho",
                Dob=DateTime.Now.AddYears(-21),
                CreatedAt=DateTime.Now,
                UpdatedAt=DateTime.Now,
                WorkspaceId=3
            },
            new Employee()
            {
                Id=3,
                FirstName="Binh",
                LastName="Ngo",
                Dob=DateTime.Now.AddYears(-15),
                CreatedAt=DateTime.Now,
                UpdatedAt=DateTime.Now,
                WorkspaceId=1
            },
        };

        public List<Workspace> _workspaces = new List<Workspace>()
        {
            new Workspace()
            {
                Id=1,
                Name="IT1",
                Description="Coding1",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            },
            new Workspace()
            {
                Id=2,
                Name="IT2",
                Description="Coding2",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            },
            new Workspace()
            {
                Id=3,
                Name="IT3",
                Description="Coding3",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            }
        };

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }

        // Get a list of employees in a workspace by Id
        public IEnumerable<Employee> GetEmployeesByWorkspaceId(int id)
        {
            List<Employee> employeeByID = new List<Employee>();
            foreach(Employee employee in _employees)
            {
                if(employee.WorkspaceId == id)
                {
                    employeeByID.Add(employee);
                }
            }
            return employeeByID;
        }

        // Get a list of employees in a workspace by Name
        public IEnumerable<Employee> GetEmployeesByWorkspaceName(string name)
        {
            List<Employee> employeeByName = new List<Employee>();
            foreach(Workspace workspace in _workspaces)
            {
                if(workspace.Name == name)
                {
                    employeeByName = (List<Employee>)GetEmployeesByWorkspaceId(workspace.Id);
                    break;
                }
            }
            return employeeByName;
        }


    }
}
