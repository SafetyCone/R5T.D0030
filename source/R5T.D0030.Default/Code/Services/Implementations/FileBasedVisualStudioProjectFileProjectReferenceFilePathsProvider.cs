using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0029;


namespace R5T.D0030.Default
{
    public class FileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider : IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider
    {
        private IVisualStudioProjectFileProjectReferenceFilePathsProvider VisualStudioProjectFileProjectReferenceFilePathsProvider { get; }
        private IVisualStudioProjectFileSerializer VisualStudioProjectFileSerializer { get; }


        public FileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider(
            IVisualStudioProjectFileProjectReferenceFilePathsProvider visualStudioProjectFileProjectReferenceFilePathsProvider,
            IVisualStudioProjectFileSerializer visualStudioProjectFileSerializer)
        {
            this.VisualStudioProjectFileProjectReferenceFilePathsProvider = visualStudioProjectFileProjectReferenceFilePathsProvider;
            this.VisualStudioProjectFileSerializer = visualStudioProjectFileSerializer;
        }

        public async Task<List<string>> GetProjectReferenceFilePaths(string visualStudioProjectFilePath)
        {
            var projectFile = await this.VisualStudioProjectFileSerializer.DeserializeAsync(visualStudioProjectFilePath);

            var projectReferenceFilePaths = await this.VisualStudioProjectFileProjectReferenceFilePathsProvider.GetProjectReferenceFilePaths(projectFile);
            return projectReferenceFilePaths;
        }

        public async Task<List<string>> GetProjectReferenceFilePathsRecursive(string visualStudioProjectFilePath)
        {
            var projectFile = await this.VisualStudioProjectFileSerializer.DeserializeAsync(visualStudioProjectFilePath);

            var projectReferenceFilePaths = await this.VisualStudioProjectFileProjectReferenceFilePathsProvider.GetProjectReferenceFilePathsRecursive(projectFile);
            return projectReferenceFilePaths;
        }
    }
}
