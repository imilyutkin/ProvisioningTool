using System;
using DeploymentModels.Models.Contract;
using DeploymentModels.Services.Contract;

namespace DeploymentModels.Services.Impl
{
    public class DeployManagerService : IDeployManagerService
    {
        public void Deploy(IDeployableModel deployDeployableModels)
        {
            var models = deployDeployableModels.GetProvisionModels();
            foreach (var modelNode in models)
            {
                Console.WriteLine("Deploy model: \"{0}\"", modelNode.Title);
            }

            deployDeployableModels.CompleteProvision();

            Console.WriteLine("Provision Complete");
        }
    }
}
