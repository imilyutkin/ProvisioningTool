using System.Collections.Generic;

namespace DeploymentModels.ModelsContract
{
    public interface IDeployableModel
    {
        IEnumerable<ModelNode> GetProvisionModels();

        void CompleteProvision();
    }
}