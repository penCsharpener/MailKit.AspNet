using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.MailKit.Infrastructure.Internal
{
    public class MailKitOptions
    {
        public MailKitOptions()
        {

        }

        /// <summary>
        /// SMTP Server address
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// SMTP Server Port ,default is 25
        /// </summary>
        public int Port { get; set; } = 25;

        /// <summary>
        /// send user name
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// send user email
        /// </summary>
        public string SenderEmail { get; set; }

        /// <summary>
        /// send user account,may be equal to senderemail
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// send user password
        /// </summary>
        public string Passord { get; set; }

        /// <summary>
        /// enable ssl 
        /// </summary>
        public bool SSL { get; set; } = false;
    }
}