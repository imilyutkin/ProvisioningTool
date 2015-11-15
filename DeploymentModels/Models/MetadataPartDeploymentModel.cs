using System;
using DeploymentModels.ModelsContract;

namespace DeploymentModels.Models
{
    public class MetadataPartDeploymentModel : IProvisionCodeModel
    {
        public String SiteUrl
        {
            get;
            set;
        }

        public MetadataPartDeploymentModel(String siteUrl)
        {
            SiteUrl = siteUrl;
        }

        public void Provision()
        {
            Console.WriteLine("Deploy MetaData part to site: [{0}]", SiteUrl);
        }
    }
}
