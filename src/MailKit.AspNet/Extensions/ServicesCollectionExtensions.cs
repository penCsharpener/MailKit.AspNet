using MailKit.AspNet.Infrastructure;
using MailKit.AspNet.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MailKit.AspNet.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddMailKit(this IServiceCollection serviceCollection, Action<MailKitOptionsBuilder> optionsAction)
        {
            Check.Argument.IsNotNull(serviceCollection, nameof(serviceCollection), "IServiceCollection is not dependency injection");
            Check.Argument.IsNotNull(optionsAction, nameof(optionsAction));

            optionsAction.Invoke(new MailKitOptionsBuilder(serviceCollection));

            return serviceCollection;
        }
    }
}
