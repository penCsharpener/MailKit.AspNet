using MailKit.AspNet.Infrastructure;
using MailKit.AspNet.Infrastructure.Internal;
using MailKit.AspNet.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace MailKit.AspNet.Extensions
{
    public static class MailKitOptionsBuilderExtension
    {
        public static IMailKitOptionsBuilder UseMailKit(IMailKitOptionsBuilder builder, MailKitOptions options, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            Check.Argument.IsNotNull(builder, nameof(builder), "The MailKitOptionsBuilder is null");
            Check.Argument.IsNotNull(options, nameof(options), "The MailKitOptions is null");

            return builder.UseMailKit(options, lifetime);
        }
    }
}
