using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHomework.Data.Implementations;
using ApiHomework.Data.Interfaces;
using ApiHomework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHomework.Controllers
{
    [Route("workspace")]
    [ApiController]
    public class WorkspaceController : ControllerBase
    {
        private readonly IWorkspace _workspace;
        private readonly IEmployee _employee;
        public WorkspaceController(IWorkspace workspace, IEmployee employee)
        {
            _workspace = workspace;
            _employee = employee;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<Workspace>> GetWorkspace()
        {
            var workspace = _workspace.GetWorkspaces();
            return Ok(workspace);
        }
        /*
        [HttpGet("{id}")]
        public ActionResult<Workspace> GetWorkspace(int id)
        {
            Workspace workspace = _workspace.GetWorkspace(id);
            if(workspace != null)
            {
                return Ok(workspace);
            }
            else
            {
                return NotFound();
            }
        }
        */
        [HttpPost]
        public ActionResult<Workspace> Create([FromBody] Workspace workspace)
        {
            Workspace createWorkspace = new Workspace();
            createWorkspace.Id = workspace.Id;
            createWorkspace.Name = workspace.Name;
            createWorkspace.Description = workspace.Description;
            createWorkspace.CreatedAt = DateTime.Now;
            createWorkspace.UpdatedAt = DateTime.Now;
            _workspace.Create(workspace);
            return Ok();
        }
        
        [HttpPut("{id}")]
        public ActionResult<Workspace> Update([FromBody] Workspace workspace)
        {
            _workspace.Update(workspace);
            return Ok();
        }
        

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            _workspace.Delete(id);
            return Ok();
        }
        

        [HttpGet("ById/{id}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesGetEmployeesByWorkspaceId(int id)
        {
            IEnumerable<Employee> employees = _employee.GetEmployeesByWorkspaceId(id);
            if(employees != null)
            {
                return Ok(employees);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("ByName/{name}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesGetEmployeesByWorkspaceName(string name)
        {
            IEnumerable<Employee> employees = _employee.GetEmployeesByWorkspaceName(name);
            if (employees != null)
            {
                return Ok(employees);
            }
            else
            {
                return NotFound();
            }
        }


    }
}
