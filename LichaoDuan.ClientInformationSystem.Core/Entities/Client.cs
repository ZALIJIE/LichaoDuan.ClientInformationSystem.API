using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Core.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public string Phones { get; set; }
        public string Address { get; set; }
        public DateTime AddedOn { get; set; }
        public List<Interaction> Interaction { get; set; }
    }
}
