using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0030
{
    [ServiceDefinitionMarker]
    public interface IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider : IServiceDefinition
    {
        Task<List<string>> GetProjectReferenceFilePaths(string visualStudioProjectFilePath);
        Task<List<string>> GetProjectReferenceFilePathsRecursive(string visualStudioProjectFilePath);
    }
}
