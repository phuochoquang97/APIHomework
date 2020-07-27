using ApiHomework.Data.Interfaces;
using ApiHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHomework.Data.Implementations
{
    public class WorkspaceRepository : IWorkspace
    {
        public List<Workspace> _workspaces = new List<Workspace>()
        {
            new Workspace()
            {
                Id=1,
                Name="IT",
                Description="Coding",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            },
            new Workspace()
            {
                Id=2,
                Name="IT",
                Description="Coding",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            },
            new Workspace()
            {
                Id=3,
                Name="IT",
                Description="Coding",
                CreatedAt=DateTime.Now.AddDays(0),
                UpdatedAt=DateTime.Now.AddDays(0)
            }
        };

        public Workspace Create(Workspace workspace)
        {
            _workspaces.Add(workspace);
            return workspace;
        }
        public Workspace Find(int id)
        {
            return _workspaces.FirstOrDefault(x => x.Id == id);
        }

        public Workspace Update(Workspace workspace)
        {
            var UpdateWorkspace = _workspaces.FirstOrDefault(x => x.Id == workspace.Id);
            if(UpdateWorkspace != null)
            {
                UpdateWorkspace.Name = workspace.Name;
                UpdateWorkspace.Description = workspace.Description;
                UpdateWorkspace.UpdatedAt = DateTime.Now;
                return UpdateWorkspace;
            }
            return null;
        }

        public bool Delete(int id)
        {
            Workspace workspace = new Workspace();
            workspace = _workspaces.FirstOrDefault(x => x.Id == id);
            if(workspace == null)
            {
                return false;
            }
            _workspaces.Remove(workspace);
            return true;
        }
        
        public IEnumerable<Workspace> GetWorkspaces()
        {
            return _workspaces;
        }
        
    }
}
