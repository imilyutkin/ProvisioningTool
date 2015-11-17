using System;

namespace DeploymentModels.Models.Contract
{
    public interface ITemplateModel
    {
        String Title
        {
            get;
            set;
        }

        IDeployableModel BuildModel();

        SiteTemplateModel AddModel(IModel model);

        SiteTemplateModel AddProvisionCode(IProvisionCodeModel provisionCodeModel);
    }
}
