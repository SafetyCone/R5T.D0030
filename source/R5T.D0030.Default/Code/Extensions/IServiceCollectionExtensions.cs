using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0029;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.D0030.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="FileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider"/> implementation of <see cref="IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileProjectReferenceFilePathsProvider> visualStudioProjectFileProjectReferenceFilePathsProviderAction,
            IServiceAction<IVisualStudioProjectFileSerializer> visualStudioProjectFileSerializerAction)
        {
            services
                .AddSingleton<IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider, FileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider>()
                .Run(visualStudioProjectFileProjectReferenceFilePathsProviderAction)
                .Run(visualStudioProjectFileSerializerAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="FileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider"/> implementation of <see cref="IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static
            IServiceAction<IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider> 
        AddFileBasedVisualStudioProjectFileProjectReferenceFilePathsProviderAction(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileProjectReferenceFilePathsProvider> visualStudioProjectFileProjectReferenceFilePathsProviderAction,
            IServiceAction<IVisualStudioProjectFileSerializer> visualStudioProjectFileSerializerAction)
        {
            var serviceAction = ServiceAction.New<IFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider>(() => services.AddFileBasedVisualStudioProjectFileProjectReferenceFilePathsProvider(
                visualStudioProjectFileProjectReferenceFilePathsProviderAction,
                visualStudioProjectFileSerializerAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileProjectReferenceFilePathsProvider"/> implementation of <see cref="IVisualStudioProjectFileProjectReferenceFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileProjectReferenceFilePathsProvider(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileSerializer> visualStudioProjectFileSerializer)
        {
            services
                .AddSingleton<IVisualStudioProjectFileProjectReferenceFilePathsProvider, VisualStudioProjectFileProjectReferenceFilePathsProvider>()
                .Run(visualStudioProjectFileSerializer)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileProjectReferenceFilePathsProvider"/> implementation of <see cref="IVisualStudioProjectFileProjectReferenceFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static
            IServiceAction<IVisualStudioProjectFileProjectReferenceFilePathsProvider>
        AddVisualStudioProjectFileProjectReferenceFilePathsProviderAction(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileSerializer> visualStudioProjectFileSerializer)
        {
            var serviceAction = ServiceAction.New<IVisualStudioProjectFileProjectReferenceFilePathsProvider>(() => services.AddVisualStudioProjectFileProjectReferenceFilePathsProvider(
                visualStudioProjectFileSerializer));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileProjectReferencePathProvider"/> implementation of <see cref="IVisualStudioProjectFileProjectReferencePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileProjectReferencePathProvider(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IVisualStudioProjectFileProjectReferencePathProvider, VisualStudioProjectFileProjectReferencePathProvider>()
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileProjectReferencePathProvider"/> implementation of <see cref="IVisualStudioProjectFileProjectReferencePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileProjectReferencePathProvider> AddVisualStudioProjectFileProjectReferencePathProviderAction(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<IVisualStudioProjectFileProjectReferencePathProvider>(() => services.AddVisualStudioProjectFileProjectReferencePathProvider(
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
