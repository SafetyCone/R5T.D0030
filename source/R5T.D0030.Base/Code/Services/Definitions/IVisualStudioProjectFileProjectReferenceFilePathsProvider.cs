using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0002;
using R5T.T0064;


namespace R5T.D0030
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileProjectReferenceFilePathsProvider : IServiceDefinition
    {
        Task<List<string>> GetProjectReferenceFilePaths(IVisualStudioProjectFile visualStudioProjectFile);
        Task<List<string>> GetProjectReferenceFilePathsRecursive(IVisualStudioProjectFile visualStudioProjectFile);
    }
}
