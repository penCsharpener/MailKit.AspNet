using MailKit.AspNet.Infrastructure.Internal;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;

namespace MailKit.AspNet
{
    public interface IMailKitProvider
    {
        /// <summary>
        /// mailkit options
        /// </summary>
        MailKitOptions Options { get; }

        /// <summary>
        /// smtp client
        /// </summary>
        SmtpClient SmtpClient { get; }

        /// <summary>
        /// pop3 client
        /// </summary>
        Pop3Client Pop3Client { get; }

        /// <summary>
        /// imap client
        /// </summary>
        ImapClient ImapClient { get; }
    }
}
