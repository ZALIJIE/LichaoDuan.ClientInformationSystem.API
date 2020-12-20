using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Models.Response
{
    public class EmployeeClientResponseModel
    {
        public EmployeeResponseModel EmpInfo { get; set; }
        public ClientResponseModel ClientInfo { get; set; }
    }
}
