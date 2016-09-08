using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Xml;
using System.Data;

namespace TimeSheetAlert
{
    public class TimeEntryDetail
    {
        public string spenton;
        public double hours;
        public string user;
        public string activity;
    }

    public class TimeEntries
    {
        private readonly string URL = "http://inia.object-frontier.com/redmine" ;
        private time_entries m_TimeEntries;
        private string m_XML;

        private List<DateTime> m_listDates;

        private ConfigSettings m_Config;


        private DataTable m_dtTimeEntries;

        public string m_ProjectID;
        public TimeEntries()
        {
            m_dtTimeEntries = new DataTable();
            m_Config = new ConfigSettings();
            m_XML = string.Empty;
            m_listDates = new List<DateTime>();

            GetTimePeriods();

             GetProjectID();
        }

        private void GetProjectID()
        {

            
            WebRequest request = WebRequest.Create(string.Format(@"{0}projects.xml",m_Config.URL));
            request.Method = "GET";

            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(string.Format("{0}:{1}", m_Config.UserName, m_Config.Password)));

            string responseValue = "";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                {
                    if (response != null)
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            responseValue = reader.ReadToEnd();

                            if (!String.IsNullOrEmpty(responseValue))
                            {
                                Console.WriteLine("Received response for service");

                                XmlDocument doc = new XmlDocument();
                                doc.LoadXml(responseValue);

                                var nodes = doc.GetElementsByTagName("project");

                                foreach (XmlElement node in nodes)
                                {
                                    if (node.ChildNodes[1].InnerText.ToLower() == m_Config.ProjectName.ToLower())
                                    {
                                        m_ProjectID = node.ChildNodes[0].InnerText;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("Response COde" + response.StatusCode + "\t" + response.StatusDescription);

            if (m_ProjectID == "NA")
            {
                Console.WriteLine("Project " + m_Config.ProjectName + " is unavailable");
            }
            

        }
    

        private void GetTimePeriods()
        {
            switch (m_Config.ReportType)
            {
                case "Weekly":
                    DateTime from = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek) + 1);
                    DateTime to = DateTime.Now;
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        from = from.AddDays(-7);
                        to = from.AddDays(4); //take a week's data
                    }
                    else
                        to = DateTime.Today.AddDays( - 1);//leave current day
                    TimeSpan diff = to - from;

                    for (int i = 0; i <= diff.Days; i++)
                    {
                        
                        m_listDates.Add(from.AddDays(i));
                    }
            break;
                case "Monthly":
                    break;
                case "Daily":
                    break;
            }
        }
        public void GetTimeEntries()
        {
            Console.WriteLine("Get Time entries start");
            
            foreach(var dt in m_listDates )
            {
                
                WebRequest request = WebRequest.Create(string.Format(@"{3}time_entries.xml?project_id={0}&project_type=2&from={1}&to={2}&limit=500", m_ProjectID, dt.ToString("yyyy-MM-dd"), dt.ToString("yyyy-MM-dd"), m_Config.URL));
                request.Method = "GET";

                request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(string.Format("{0}:{1}", m_Config.UserName, m_Config.Password)));

                string responseValue = "";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var stream = response.GetResponseStream())
                    {
                        if (response != null)
                        {
                            using (var reader = new StreamReader(stream))
                            {
                                responseValue = reader.ReadToEnd();

                                if (!String.IsNullOrEmpty(responseValue))
                                {
                                    Console.WriteLine("Received response for service");
                                    if (m_XML == "")
                                        m_XML = responseValue;
                                    else
                                    {
                                        m_XML = m_XML.Replace("</time_entries>", "");
                                        responseValue = responseValue.Replace("</time_entries>", "");

                                        int start = responseValue.IndexOf("<time_entry>");

                                        responseValue = responseValue.Substring(start);

                                        m_XML += responseValue;
                                    }

                                }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Response COde" + response.StatusCode + "\t" + response.StatusDescription);
            }

            if (m_XML.IndexOf("</time_entries>") < 0)
                m_XML += "</time_entries>";
            m_TimeEntries = time_entries.Load(m_XML);

            

        }

        public void ParseXML()
        {

            Console.WriteLine("Parse XML start");

            var dates = m_TimeEntries.time_entry.AsQueryable().OrderBy(r => r.spent_on).Select(r => r.spent_on).Distinct();

            

            var users = m_TimeEntries.time_entry.AsQueryable().Select(r => r.user[0].name).Distinct();



            m_dtTimeEntries.Columns.Add("User", Type.GetType("System.String"));

            foreach (var date in dates)
            {
                m_dtTimeEntries.Columns.Add(date.ToString(), Type.GetType("System.Decimal"));
            }

            m_dtTimeEntries.Columns.Add("Total Time", Type.GetType("System.Decimal"));

            foreach (var user in m_Config.ProjectUsers)
            {
                DataRow dr = m_dtTimeEntries.NewRow();
                dr[0] = user;

                m_dtTimeEntries.Rows.Add(dr);
            }


            var details = (from time_entriesTime_entry in m_TimeEntries.time_entry select time_entriesTime_entry).GroupBy(x => new { x.user[0].name, x.spent_on   }).Select(x => new TimeEntryDetail {user = x.FirstOrDefault().user[0].name, spenton = x.FirstOrDefault().spent_on, hours = x.Sum(y => y.hours_int) });

            foreach (var user in m_Config.ProjectUsers)
            {
                var details_user = details.AsQueryable().Where(r => r.user == user);
                DataRow[] drRows = m_dtTimeEntries.Select("user = '" + user + "'");
                if (drRows.Count() == 1)
                {
                    DataRow dr = drRows[0];
                    dr["Total Time"] = details_user.Sum(r => r.hours);

                    foreach (var detail in details_user)
                    {

                        int indx = m_dtTimeEntries.Columns.IndexOf(detail.spenton);
                        if (indx > 0)
                        {
                               dr[indx] = detail.hours.ToString();

                        }

                    }
                }
            }




            //Add totals
            DataRow drTemp = m_dtTimeEntries.NewRow();
            drTemp[0] = "Total Time";
            m_dtTimeEntries.Rows.Add(drTemp);
            foreach (var date in dates)
            {
                int indx = m_dtTimeEntries.Columns.IndexOf(date);
                if (indx > 0)
                {
                    drTemp[indx] = m_TimeEntries.time_entry.AsQueryable().Where(x => x.spent_on == date).Sum(y => y.hours_int);


                }
                drTemp[m_dtTimeEntries.Columns.Count - 1] = details.Sum(r => r.hours);
            }
        }




        public void SendNotifications()
        {
            try
            {
                Email email = new Email();

                
                email.FromAddress = m_Config.EmailFrom;
                email.ToAddress = m_Config.EmailTo;
                if(!String.IsNullOrEmpty(m_Config.EmailCC))
                    email.ToAddressCC = m_Config.EmailCC;

                email.SMTPServerName = m_Config.SMTPServer;

                email.Subject = string.Format(m_Config.EmailSubject, m_listDates[0].ToString("dd-MMM-yyyy"), m_listDates[m_listDates.Count -1].ToString("dd-MMM-yyyy"));
                email.Body = GetHTMLMessage();
                email.IsBodyHTML = true;

                email.SendMessage();
                Console.WriteLine("Email sent successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
        }

        private string GetHTMLMessage()
        {
            StringBuilder message = new StringBuilder();

    
            var dates = m_TimeEntries.time_entry.AsQueryable().OrderBy(r => r.spent_on).Select(r => r.spent_on).Distinct();
            message.Append("<table class='tablestyle textcontent'><tr class='tableheaderrow'>");
            message.Append("<th class='tableheadercell'>User</th>");

            foreach (var date in dates)
            {
                message.Append("<th class='tableheadercell'>" + DateTime.Parse(date).ToString("dd-MMM-yyyy") + "</th>");
            }

            message.Append("<th class='tableheadercell'>" + "Total Time" + "</th>");
            message.Append("</tr>");

            foreach (DataRow dr in m_dtTimeEntries.Rows)
            {
                if (dr[0].ToString() == "Total Time")
                    message.Append("<tr class='tablefooterrow'><th class='tablefootercell'>" + dr[0].ToString() + "</th>");
                else
                    message.Append("<tr><td class='tablerowcontentUserName'>" + dr[0].ToString() + "</td>");
                for (int i = 1; i < m_dtTimeEntries.Columns.Count; i++)
                {
                    if (dr[0].ToString() == "Total Time")
                        message.Append("<th class='tablefootercell'>" + dr[i].ToString() + "</th>");
                    else if( string.IsNullOrEmpty(dr[i].ToString()))
                        message.Append("<td class='tablerowcellifempty'>" + dr[i].ToString() + "</td>");
                    
                    else
                        message.Append("<td class='tablerowcontent'>" + dr[i].ToString() + "</td>");

                }
                
            }

            message.Append("</tr></table>");
            string mailContent = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(),"Mail Template\\MailTemplate.html" ));

            mailContent = mailContent.Replace("$TimeEntries" , message.ToString());
            mailContent = mailContent.Replace("$FromDate", m_listDates[0].ToString("dd-MMM-yyyy"));
            mailContent = mailContent.Replace("$ToDate", m_listDates[m_listDates.Count - 1].ToString("dd-MMM-yyyy"));



            
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "MailCopy.html"), mailContent.ToString());

            return mailContent.ToString();

            
        }

       
    }
}
