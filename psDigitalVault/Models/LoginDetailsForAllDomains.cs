using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psDigitalVault.Models
{
    public class LoginDetailsForAllDomains
    {
        public List<LoginDetails> Banks { get; set; }
        public List<LoginDetails> EmailAccts { get; set; }
        public List<LoginDetails> Additionals { get; set; }
    }
}
