using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Entities
{
    public class Interaction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public string IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }
    }
}
