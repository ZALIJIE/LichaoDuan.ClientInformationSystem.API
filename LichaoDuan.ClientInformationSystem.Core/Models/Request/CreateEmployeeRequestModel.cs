using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Request
{
    public class CreateEmployeeRequestModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
    }
}
