using MailKit.AspNet.Core;
using MailKit.AspNet.Infrastructure.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Collections.Generic;

namespace MailKit.AspNet.Infrastructure
{
    public class MailKitOptionsBuilder : IMailKitOptionsBuilder
    {
        /// <summary>
        /// Gets the service collection in which the interception based services are added.
        /// </summary>
        public IServiceCollection serviceCollection { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/> service collection</param>
        public MailKitOptionsBuilder(IServiceCollection services)
        {
            serviceCollection = services;
        }

        /// <summary>
        ///  add email service to di
        /// </summary>
        /// <param name="options"></param>
        /// <param name="lifetime"></param>
        /// <returns></returns>
        public IMailKitOptionsBuilder UseMailKit(MailKitOptions options, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            AddProviderService(options);
            serviceCollection.TryAdd(new ServiceDescriptor(typeof(IEmailService), typeof(EmailService), lifetime));
            return this;
        }

        private void AddProviderService(MailKitOptions options)
        {
            var provider = new MailKitProvider(options);
            serviceCollection.TryAddSingleton<IMailKitProvider>(provider);
        }
    }
}
