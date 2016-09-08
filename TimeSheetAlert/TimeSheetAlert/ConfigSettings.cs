using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetAlert
{
    public class ConfigSettings
    {
        AppSettingsSection m_AppSettings;
        public ConfigSettings()
        {
            ReadSettings();
        }

        private void ReadSettings()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            m_AppSettings = configFile.AppSettings;


        }

        public string URL
        {
            get
            {
               return m_AppSettings.Settings["URL"].Value.ToString();
            }
                
        }

        public string UserName
        {
            get
            {
                return m_AppSettings.Settings["UserName"].Value.ToString();
            }

        }

        public string Password
        {
            get
            {
                return m_AppSettings.Settings["Password"].Value.ToString();
            }

        }

        public string EmailFrom
        {
            get
            {
                return m_AppSettings.Settings["EmailFrom"].Value.ToString();
            }

        }

        public string EmailTo
        {
            get
            {
                return m_AppSettings.Settings["EmailTo"].Value.ToString();
            }

        }

        public string EmailCC
        {
            get
            {
                return m_AppSettings.Settings["EmailCC"].Value.ToString();
            }

        }

        public string SMTPServer
        {
            get
            {
                return m_AppSettings.Settings["SMTPServer"].Value.ToString();
            }

        }

        public string ProjectName
        {
            get
            {
                return m_AppSettings.Settings["ProjectName"].Value.ToString();
            }

        }

        public string EmailSubject
        {
            get
            {
                return m_AppSettings.Settings["EmailSubject"].Value.ToString();
            }

        }

        public string ReportType
        {
            get
            {
                return m_AppSettings.Settings["ReportType"].Value.ToString();
            }

        }

        public string[] ProjectUsers
        {
            get
            {
                return m_AppSettings.Settings["ProjectUsers"].Value.ToString().Split(',');
            }
        }
    }
}
