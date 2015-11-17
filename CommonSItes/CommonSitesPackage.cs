using System.Collections.Generic;
using DeploymentModels.Container.Impl;
using DeploymentModels.MetadataModels.Base;
using DeploymentModels.Models;
using DeploymentModels.Models.Contract;

namespace CommonSItes
{
    public class CommonSitesPackage : BaseTemplatePackage
    {
        public CommonSitesSettings Settings
        {
            get;
            set;
        }

        public CommonSitesPackage(CommonSitesSettings settings)
        {
            Settings = settings;
        }

        public ITemplateModel BaseTemplate => Model.Create("BaseTemplate")
            .AddModel(new BaseContentTypesModel())
            .AddModel(new BaseTemplateListsModel())
            .AddProvisionCode(new MetadataPartDeploymentModel());

        public override List<ITemplateModel> GetSiteModels()
        {
            var listTemplates = new List<ITemplateModel> {BaseTemplate};
            return listTemplates;
        }
    }
}
