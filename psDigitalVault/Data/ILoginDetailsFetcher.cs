using psDigitalVault.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psDigitalVault.Data
{
    interface ILoginDetailsFetcher
    {
        LoginDetails getDetails(string domainId);

        List<LoginDetails> getAllDomainDetails(string domain);

        List<LoginDetails> getBankDetails(string domain);
        List<LoginDetails> getAdditionalDetails(string domain);

        List<LoginDetails> getEmailAcctsDetails(string domain);

    }
}
