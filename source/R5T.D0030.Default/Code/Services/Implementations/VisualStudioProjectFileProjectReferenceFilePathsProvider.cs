using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0029;
using R5T.T0002;using R5T.T0064;


namespace R5T.D0030.Default
{[ServiceImplementationMarker]
    public class VisualStudioProjectFileProjectReferenceFilePathsProvider : IVisualStudioProjectFileProjectReferenceFilePathsProvider,IServiceImplementation
    {
        private IVisualStudioProjectFileSerializer VisualStudioProjectFileSerializer { get; }


        public VisualStudioProjectFileProjectReferenceFilePathsProvider(
            IVisualStudioProjectFileSerializer visualStudioProjectFileSerializer)
        {
            this.VisualStudioProjectFileSerializer = visualStudioProjectFileSerializer;
        }

        public Task<List<string>> GetProjectReferenceFilePaths(IVisualStudioProjectFile visualStudioProjectFile)
        {
            var projectReferenceFilePaths = visualStudioProjectFile.GetDependencyProjectFilePaths();

            return Task.FromResult(projectReferenceFilePaths);
        }

        public async Task<List<string>> GetProjectReferenceFilePathsRecursive(IVisualStudioProjectFile visualStudioProjectFile)
        {
            var projectReferenceFilePaths = await visualStudioProjectFile.GetDependencyProjectFilePathsRecursive(this.VisualStudioProjectFileSerializer);
            return projectReferenceFilePaths;
        }
    }
}
