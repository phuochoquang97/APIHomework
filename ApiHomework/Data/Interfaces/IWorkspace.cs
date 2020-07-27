using ApiHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHomework.Data.Interfaces
{
    public interface IWorkspace
    {
        IEnumerable<Workspace> GetWorkspaces();

        // Create a new workspace
        Workspace Create(Workspace workspace);

        // Find a workspace by Id
        Workspace Find(int id);

        // Update a workspace
        Workspace Update(Workspace workspace);

        //Delete a workspace
        bool Delete(int id);
    }
}
