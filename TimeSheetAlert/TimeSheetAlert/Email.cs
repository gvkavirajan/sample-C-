using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace TimeSheetAlert
{
    /// <summary>
    /// Email wrapper
    /// </summary>
    public class Email
    {

        #region Properties
        // public MailMessage MailMessage { get; set; }
        public MailPriority MailPriority { get; set; }// {get;set;} = MailPriority.Normal;
        public string SMTPServerName { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ToAddressCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachments { get; set; }
        public bool IsBodyHTML { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Create a standard Email message
        /// </summary>
        public Email()
        {
            MailPriority = System.Net.Mail.MailPriority.Normal;
            SMTPServerName = string.Empty;
            FromAddress = string.Empty;
            ToAddress = string.Empty;
            ToAddressCC = string.Empty;
            Subject = string.Empty;
            Body = string.Empty;
            Attachments = string.Empty;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="smtpServerName">Name of the SMTP server.</param>
        /// <param name="fromAddress">From address.</param>
        /// <param name="toAddress">To address.</param>
        /// <param name="toAddressCC">To address CC.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="priority">The priority.</param>
        public Email(string smtpServerName, string fromAddress, string toAddress,
               string toAddressCC, string subject, string body, MailPriority priority)
            : this(smtpServerName, fromAddress, toAddress, toAddressCC, subject, body, string.Empty, priority, false) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="smtpServerName">Name of the SMTP server.</param>
        /// <param name="fromAddress">From address.</param>
        /// <param name="toAddress">To address.</param>
        /// <param name="toAddressCC">To address CC.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="isBodyHtml">if set to <c>true</c> [is body HTML].</param>
        public Email(string smtpServerName, string fromAddress, string toAddress,
               string toAddressCC, string subject, string body, MailPriority priority, bool isBodyHtml)
            : this(smtpServerName, fromAddress, toAddress, toAddressCC, subject, body, string.Empty, priority, isBodyHtml) { }



        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="smtpServerName">Name of the SMTP server.</param>
        /// <param name="fromAddress">From address.</param>
        /// <param name="toAddress">To address.</param>
        /// <param name="toAddressCC">To address CC.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="attachments">The attachments.</param>
        /// <param name="priority">The priority.</param>
        public Email(string smtpServerName, string fromAddress, string toAddress,
               string toAddressCC, string subject, string body, string attachments, MailPriority priority)
            : this(smtpServerName, fromAddress, toAddress, toAddressCC, subject, body, attachments, priority, false) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="smtpServerName">Name of the SMTP server.</param>
        /// <param name="fromAddress">From address.</param>
        /// <param name="toAddress">To address.</param>
        /// <param name="toAddressCC">To address CC.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="attachments">The attachments.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="isBodyHtml">if set to <c>true</c> [is body HTML].</param>
        public Email(string smtpServerName, string fromAddress, string toAddress,
       string toAddressCC, string subject, string body, string attachments, MailPriority priority, bool isBodyHtml)
            : this()
        {
            SMTPServerName = smtpServerName;
            FromAddress = fromAddress;
            ToAddress = toAddress;
            ToAddressCC = toAddressCC;
            Subject = subject;
            Body = body;
            Attachments = attachments;
            MailPriority = priority;
            IsBodyHTML = isBodyHtml;
        }



        #endregion

        #region Public Methods
        /// <summary>
        /// Send a message with an attachment(s)
        /// </summary>
        /// <param name="attachments">Attachment location or list attachments separated by a ';'.</param>
        /// <returns></returns>
        public bool SendMessage(string attachments)
        {
            Attachments = attachments;
            return SendMessage();
        }
        /// <summary>
        /// Send a messages with a specified priority
        /// </summary>
        /// <param name="priority">the priority of the message</param>
        /// <returns></returns>
        public bool SendMessage(MailPriority priority)
        {
            MailPriority = priority;
            return SendMessage();
        }
        /// <summary>
        /// Save message with a specified priority and documentpath
        /// </summary>
        /// <param name="priority">the priority of the message</param>
        /// <returns></returns>
        public bool SaveMessage(MailPriority priority, string DocumentPath)
        {
            MailPriority = priority;
            return SaveMessage(DocumentPath);
        }
        /// <summary>
        /// Send a message with a specified priority and attachment(s).
        /// </summary>
        /// <param name="priority">The priority of the message</param>
        /// <param name="attachment">Attachment location or list attachments separated by a ';'.</param>
        /// <returns></returns>
        public bool SendMessage(MailPriority priority, string attachment)
        {
            Attachments = attachment;
            MailPriority = priority;
            return SendMessage();
        }

        /// <summary>
        /// Send a message with a specified priority and attachment(s).
        /// </summary>
        /// <param name="priority">The priority of the message</param>
        /// <param name="attachments">Attachment locations listed individually with a param array.</param>
        /// <returns></returns>
        public bool SendMessage(MailPriority priority, params string[] attachments)
        {
            if (attachments != null && attachments.Length > 0)
                Attachments = String.Join(";", attachments);
            MailPriority = priority;
            return SendMessage();
        }

        public Boolean SendMessage()
        {
            using (var MailMessage = new MailMessage())
            {
                MailMessage.From = new MailAddress(FromAddress);
                MailMessage.Subject = Subject;
                MailMessage.Body = Body;
                MailMessage.Priority = MailPriority;
                MailMessage.IsBodyHtml = IsBodyHTML;


                string[] toAddressSplit = ToAddress.Split(';');
                var toContacts = (from item in toAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (toContacts.Length > 0)
                { MailMessage.To.Add(String.Join(",", toContacts)); }


                // Add the To CC Email Address in Bulk
                string[] toCCAddressSplit = ToAddressCC.Split(';');
                var ccContacts = (from item in toCCAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (ccContacts.Length > 0)
                { MailMessage.CC.Add(String.Join(",", ccContacts)); }

                // Add message attachments in bulk
                if (Attachments != null && Attachments != string.Empty)
                {
                    string[] attachmentsTemp = Attachments.Split(';');

                    foreach (string attachTemp in attachmentsTemp)
                    {
                        Attachment attach = new Attachment(attachTemp);
                        attach.TransferEncoding = System.Net.Mime.TransferEncoding.QuotedPrintable;
                        MailMessage.Attachments.Add(new Attachment(attachTemp));
                    }
                }


                using (SmtpClient client = new SmtpClient(SMTPServerName))
                {
                    client.Send(MailMessage);
                    // MailMessage.Attachments.Dispose();

                }
                return true;
            }
        }

        /// <summary>
        /// Send the message.
        /// </summary>
        /// <returns></returns>
        public Boolean SendMessageWithSevenBit()
        {
            using (var MailMessage = new MailMessage())
            {
                MailMessage.From = new MailAddress(FromAddress);
                MailMessage.Subject = Subject;
                MailMessage.Body = Body;
                MailMessage.Priority = MailPriority;
                MailMessage.IsBodyHtml = IsBodyHTML;


                string[] toAddressSplit = ToAddress.Split(';');
                var toContacts = (from item in toAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (toContacts.Length > 0)
                { MailMessage.To.Add(String.Join(",", toContacts)); }


                // Add the To CC Email Address in Bulk
                string[] toCCAddressSplit = ToAddressCC.Split(';');
                var ccContacts = (from item in toCCAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (ccContacts.Length > 0)
                { MailMessage.CC.Add(String.Join(",", ccContacts)); }

                // Add message attachments in bulk
                if (Attachments != null && Attachments != string.Empty)
                {
                    string[] attachmentsTemp = Attachments.Split(';');

                    foreach (string attachTemp in attachmentsTemp)
                    {
                        Attachment attach = new Attachment(attachTemp);
                        attach.TransferEncoding = System.Net.Mime.TransferEncoding.SevenBit;
                        MailMessage.Attachments.Add(new Attachment(attachTemp));
                    }
                }


                using (SmtpClient client = new SmtpClient(SMTPServerName))
                {
                    client.Send(MailMessage);
                    // MailMessage.Attachments.Dispose();

                }
                return true;
            }
        }


        public Boolean SendMessageWithQP()
        {
            using (var MailMessage = new MailMessage())
            {
                MailMessage.From = new MailAddress(FromAddress);
                MailMessage.Subject = Subject;
                MailMessage.Body = Body;
                MailMessage.Priority = MailPriority;
                MailMessage.IsBodyHtml = IsBodyHTML;


                string[] toAddressSplit = ToAddress.Split(';');
                var toContacts = (from item in toAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (toContacts.Length > 0)
                { MailMessage.To.Add(String.Join(",", toContacts)); }


                // Add the To CC Email Address in Bulk
                string[] toCCAddressSplit = ToAddressCC.Split(';');
                var ccContacts = (from item in toCCAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (ccContacts.Length > 0)
                { MailMessage.CC.Add(String.Join(",", ccContacts)); }

                // Add message attachments in bulk
                if (Attachments != null && Attachments != string.Empty)
                {
                    string[] attachmentsTemp = Attachments.Split(';');

                    foreach (string attachTemp in attachmentsTemp)
                    {
                        Attachment attach = new Attachment(attachTemp);
                        attach.TransferEncoding = System.Net.Mime.TransferEncoding.QuotedPrintable;
                        MailMessage.Attachments.Add(new Attachment(attachTemp));
                    }
                }


                using (SmtpClient client = new SmtpClient(SMTPServerName))
                {
                    client.Send(MailMessage);
                    // MailMessage.Attachments.Dispose();

                }
                return true;
            }
        }
        /// <summary>
        /// save the message.
        /// </summary>
        /// <returns></returns>
        public Boolean SaveMessage(string DocumentPath)
        {
            using (var MailMessage = new MailMessage())
            {
                MailMessage.From = new MailAddress(FromAddress);
                MailMessage.Subject = Subject;
                MailMessage.Body = Body;
                MailMessage.Priority = MailPriority;
                MailMessage.IsBodyHtml = IsBodyHTML;


                string[] toAddressSplit = ToAddress.Split(';');
                var toContacts = (from item in toAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (toContacts.Length > 0)
                { MailMessage.To.Add(String.Join(",", toContacts)); }


                // Add the To CC Email Address in Bulk
                string[] toCCAddressSplit = ToAddressCC.Split(';');
                var ccContacts = (from item in toCCAddressSplit where !String.IsNullOrWhiteSpace(item) select item).ToArray();
                if (ccContacts.Length > 0)
                { MailMessage.CC.Add(String.Join(",", ccContacts)); }

                // Add message attachments in bulk
                if (Attachments != null && Attachments != string.Empty)
                {
                    string[] attachmentsTemp = Attachments.Split(';');

                    foreach (string attachTemp in attachmentsTemp)
                    {
                        MailMessage.Attachments.Add(new Attachment(attachTemp));
                    }
                }


                using (SmtpClient client = new SmtpClient(SMTPServerName))
                {
                    client.PickupDirectoryLocation = DocumentPath;
                    client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    client.Send(MailMessage);
                }
                return true;
            }
        }
        #endregion
    }
}
