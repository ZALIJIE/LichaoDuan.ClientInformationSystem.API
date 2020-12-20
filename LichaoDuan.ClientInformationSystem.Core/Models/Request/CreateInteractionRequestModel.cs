using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Request
{
    public class CreateInteractionRequestModel
    {
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public string IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
    }
}
