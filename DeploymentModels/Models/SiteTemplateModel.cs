using System;
using System.Collections.Generic;
using System.Linq;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Models
{
    public class SiteTemplateModel : ITemplateModel
    {
        public String Title
        {
            get;
            set;
        }

        internal IList<IModel> Models
        {
            get;
            set;
        }

        internal IList<IProvisionCodeModel> ProvisionCodeModels
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


        public SiteTemplateModel(String siteTemplateTitle, SiteTemplateModel parentModel)
        {
            Title = siteTemplateTitle;
            Models = new List<IModel>(parentModel.Models);
            ProvisionCodeModels = new List<IProvisionCodeModel>(parentModel.ProvisionCodeModels);
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