using System;
using System.Collections.Generic;
using System.Linq;

namespace DeploymentModels.ModelsContract
{
    public class SiteTemplateModel
    {
        public String Title
        {
            get;
            protected set;
        }

        protected IList<IModel> Models
        {
            get;
            set;
        }

        protected IList<IProvisionCodeModel> ProvisionCodeModels
        {
            get;
            set;
        }

        public SiteTemplateModel(String siteTemplateTitle)
        {
            Title = siteTemplateTitle;
            Models = new List<IModel>();
            ProvisionCodeModels = new List<IProvisionCodeModel>();
        }

        public SiteTemplateModel AddModel(IModel model)
        {
            Models.Add(model);
            return this;
        }

        public SiteTemplateModel AddProvisionCode(IProvisionCodeModel provisionCodeModel)
        {
            ProvisionCodeModels.Add(provisionCodeModel);
            return this;
        }

        public IDeployableModel BuildModel()
        {
            IEnumerable<ModelNode> modelNodes = Models.Select(model => model.GetModel());
            IEnumerable<Action> provisioningActions = ProvisionCodeModels.Select(model => new Action(model.Provision));
            return new DeploymentModel(modelNodes,provisioningActions);
        }
    }
}