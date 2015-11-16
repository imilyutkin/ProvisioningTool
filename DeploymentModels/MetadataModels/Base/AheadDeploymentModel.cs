using System;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Base
{
    public class AheadDeploymentModel : IProvisionCodeModel
    {
        public String SiteUrl
        {
            get;
            set;
        }

        public String UserName
        {
            get;
            set;
        }

        public AheadDeploymentModel(String siteUrl, String userName)
        {
            SiteUrl = siteUrl;
            UserName = userName;
        }

        public void Provision()
        {
            Console.WriteLine("Deploy ahead to site: [{0}] by user :[{1}]", SiteUrl, UserName);
        }
    }
}
