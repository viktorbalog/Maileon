﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

using Maileon.Utils.JSON;

namespace Maileon.Transactions
{
    /// <summary>
    /// A class for wrapping Maileon JSON contact references
    /// </summary>
    public class ContactReference : IMaileonJsonSerializable
    {
        /// <summary>
        /// The id of this contact
        /// </summary>
        [MaileonJson("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The external id of the contact
        /// </summary>
        [MaileonJson("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The email address of the contact
        /// </summary>
        [MaileonJson("email")]
        public string Email { get; set; }

        public bool IsEmpty()
        {
            return Email == null && ExternalId == null && Id == null;
        }

        public ContactReference(int? id)
        {
            this.Id = id;
        }

        public ContactReference(string email)
        {
            this.Email = email;
        }

        public ContactReference() { }
    }
}
