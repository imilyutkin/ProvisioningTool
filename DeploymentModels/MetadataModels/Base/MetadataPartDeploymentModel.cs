using System;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Base
{
    public class MetadataPartDeploymentModel : IProvisionCodeModel
    {
        public void Provision()
        {
            Console.WriteLine("Deploy MetaData part");
        }
    }
}
