using System.Collections.Generic;
using DeploymentModels.Container.Impl;
using DeploymentModels.MetadataModels.Base;
using DeploymentModels.MetadataModels.Dossier;
using DeploymentModels.Models;
using DeploymentModels.Models.Contract;

namespace TemplateSites
{
    public class DossierSitesPackage : BaseTemplatePackage
    {
        public DossierSiteSettings Settings
        {
            get;
            set;
        }

        public DossierSitesPackage(DossierSiteSettings settings)
        {
            Settings = settings;
        }

        public ITemplateModel DossierTemplate
        {
            get
            {
                ITemplateModel baseModel = GetModel("BaseTemplate");
                return Model.Create("DossierTemplate", baseModel)
                    .AddModel(new DossierContentTypesModel())
                    .AddModel(new DossierTemplateListsModel())
                    .AddModel(new AheadCustomActionDeploymentModel(Settings.DivletSiteUrl, Settings.AheadPackageFile));
            }
        }
        
        public override List<ITemplateModel> GetSiteModels()
        {
            var listOfTemplates = new List<ITemplateModel>();
            listOfTemplates.Add(DossierTemplate);
            return listOfTemplates;
        }
    }
}
