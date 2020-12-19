using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Response
{
    //Reture this model when Employee name is clicked on Home page
    public class EmployeeIteractionResponseModel
    {
        public int Id { get; set; }
        public string IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
        //Include the corresponded Client information
        public ClientResponseModel ClientInfo { get; set; }

    }
}
