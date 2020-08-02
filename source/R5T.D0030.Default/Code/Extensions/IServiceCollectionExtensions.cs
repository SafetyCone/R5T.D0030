using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.D0030.Default
{
    public static class IServiceCollectionExtensions
    {
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
