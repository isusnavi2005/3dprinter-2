using System;
using System.Data.SqlClient;
using _3dprinter_2.model;

namespace _3dprinter_2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly string connectionStr =
            "Server=tcp:myserverreeb.database.windows.net,1433;Initial Catalog=MyDB;Persist Security Info=False;User ID=isusnavi2005;Password=Alegria1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Notification GetLastNotification()
        {
            Notification notif = null;
            const string lastNotif = "select top 1 * from Notification order by NotId desc";
            using (var databaseConnection = new SqlConnection(connectionStr))
            {
                databaseConnection.Open();
                using (var cmd = new SqlCommand(lastNotif, databaseConnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                                notif = ReadNotification(reader);
                            
                        }
                        return notif;
                    }
                }
            }
        }

        private Notification ReadNotification(SqlDataReader reader)
        {
            int notifId = reader.GetInt32(0);
            DateTime notifDate = reader.GetDateTime(1);
            DateTime notifTime = reader.GetDateTime(2);

            Notification notif = new Notification()
            {
                NotId = notifId,
                NotDate = notifDate,
                NotTime = notifTime
            };
            return notif;
        }

        public int DeleteAllNotifications()
        {
            throw new NotImplementedException();
        }

        public Job SetFinishedJob(DateTime currenTime)
        {
            throw new NotImplementedException();
        }

        public Job GetLastJob()
        {
            throw new NotImplementedException();
        }
    }
}