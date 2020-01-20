using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Visigothia.Local.Standard;


namespace R5T.Visigothia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the standard <see cref="IUserProfileDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddLocalUserProfileDirectoryProvider();

            return services;
        }
    }
}
