using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.D0030
{
    public interface IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider
    {
        Task<List<string>> GetProjectReferenceFilePaths(string visualStudioProjectFilePath);
        Task<List<string>> GetProjectReferenceFilePathsRecursive(string visualStudioProjectFilePath);
    }
}
