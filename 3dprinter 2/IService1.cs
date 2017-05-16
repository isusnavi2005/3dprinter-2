using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using _3dprinter_2.model;

namespace _3dprinter_2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "notifications/")]
        Notification GetLastNotification();


        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "notifications")]
        int DeleteAllNotifications();

        //???what should be the Uri for this contract? not sure if notifications/ because it returns int. or?


        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "jobs/")]
        Job SetFinishedJob(DateTime currenTime);


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,UriTemplate = "jobs/")]
        Job GetLastJob();

    }


}
