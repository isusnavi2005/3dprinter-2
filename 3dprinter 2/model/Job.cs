using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3dprinter_2.model
{
    public class Job
    {
        public int JobId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int UserId { get; set; }
        
    }


}