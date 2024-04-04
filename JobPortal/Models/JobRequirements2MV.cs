using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
    public class JobRequirements2MV
    {
        public JobRequirements2MV()
        {
            Details = new List<JobRequirementDetailMV>();
        }
        public int JobRequirementID { get; set; }
        public string JobRequirementTitle { get; set; }
        public List<JobRequirementDetailMV> Details {  get; set; }
    }
}