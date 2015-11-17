using System;
using System.Collections.Generic;

namespace DeploymentModels.Models.Contract
{
    public interface ITemplateModel
    {
        String Title
        {
            get;
            set;
        }

        IList<IModel> Models
        {
            get;
            set;
        }

        IList<IProvisionCodeModel> ProvisionCodeModels
        {
            get;
            set;
        }

        IDeployableModel BuildModel();

        SiteTemplateModel AddModel(IModel model);

        SiteTemplateModel AddProvisionCode(IProvisionCodeModel provisionCodeModel);
    }
}
