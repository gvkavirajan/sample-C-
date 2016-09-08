using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TimeEntries te = new TimeEntries();
                if (te.m_ProjectID != "NA")
                {

                    te.GetTimeEntries();

                    te.ParseXML();

                    te.SendNotifications();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                
            }
        }

    }
}
