using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Request
{
    public class CreateClientRequestModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
