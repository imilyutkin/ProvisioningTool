using System;
using System.Collections.Generic;
using DeploymentModels.Models.Contract;

namespace DeploymentModels
{
    public class DeploymentModel : IDeployableModel
    {
        protected IEnumerable<ModelNode> Models
        {
            get;
            set;
        }

        protected IEnumerable<Action> ProvisioningsActions
        {
            get;
            set;
        }   

        public DeploymentModel(IEnumerable<ModelNode> models, IEnumerable<Action> provisioningActions)
        {
            Models = models;
            ProvisioningsActions = provisioningActions;
        }

        public IEnumerable<ModelNode> GetProvisionModels()
        {
            return Models;
        }

        public void CompleteProvision()
        {
            foreach (var provisioningAction in ProvisioningsActions)
            {
                provisioningAction();
            }
        }
    }
}
