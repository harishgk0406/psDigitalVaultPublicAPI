using psDigitalVault.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psDigitalVault.Data
{
    public class LoginDetailsSqlFetcher : ILoginDetailsFetcher
    {
        public List<LoginDetails> getAdditionalDetails(string domain)
        {
            throw new NotImplementedException();
        }

        public List<LoginDetails> getAllDomainDetails(string domain)
        {
            throw new NotImplementedException();
        }

        public List<LoginDetails> getBankDetails(string domain)
        {
            throw new NotImplementedException();
        }

        public LoginDetails getDetails(string domainId)
        {
            throw new NotImplementedException();
        }

        public List<LoginDetails> getEmailAcctsDetails(string domain)
        {
            throw new NotImplementedException();
        }
    }
}
