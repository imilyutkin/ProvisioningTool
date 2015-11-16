using System.Collections.Generic;

namespace DeploymentModels.Models.Contract
{
    public interface IDeployableModel
    {
        IEnumerable<ModelNode> GetProvisionModels();

        void CompleteProvision();
    }
}