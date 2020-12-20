using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Response
{
    public class InteractionResponseModel
    {
        public int interactionId { get; set; }
        public string employeeName { get; set; }
        public string employeeDesignation { get; set; }
        public string clientName { get; set; }
        public string clientEmail { get; set; }
        public string clientPhone { get; set; }
        public string intType { get; set; }
        public DateTime IntDate { get; set; }
        public string remarks { get; set; }
    }
}
