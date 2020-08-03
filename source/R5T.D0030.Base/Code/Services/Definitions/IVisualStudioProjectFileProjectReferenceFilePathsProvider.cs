using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0002;


namespace R5T.D0030
{
    public interface IVisualStudioProjectFileProjectReferenceFilePathsProvider
    {
        Task<List<string>> GetProjectReferenceFilePaths(IVisualStudioProjectFile visualStudioProjectFile);
        Task<List<string>> GetProjectReferenceFilePathsRecursive(IVisualStudioProjectFile visualStudioProjectFile);
    }
}
