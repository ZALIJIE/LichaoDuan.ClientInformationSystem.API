using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Response
{
    //Reture this model when Client name is clicked on Home page
    public class ClientInteractionResponseModel
    {
        public int Id { get; set; }
        public string IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
        public EmployeeResponseModel EmpInfo { get; set; }
    }
}
