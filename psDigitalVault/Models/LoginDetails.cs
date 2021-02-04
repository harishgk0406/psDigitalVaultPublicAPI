using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psDigitalVault.Models
{
    public class LoginDetails
    {
        public string WebSite { get; set; }
        public string WebSiteUserName { get; set; }
        public string WebSiteSecretKey { get; set; }

        public LoginDetails(string w, string u, string s)
        {
            WebSite = w;
            WebSiteUserName = u;
            WebSiteSecretKey = s;
        }


    }
}
