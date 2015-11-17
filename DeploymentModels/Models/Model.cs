using System;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Models
{
    public class Model
    {
        public static SiteTemplateModel Create(String siteTemplateTitle)
        {
            return new SiteTemplateModel(siteTemplateTitle);
        }

        public static SiteTemplateModel Create(String siteTemplateTitle, ITemplateModel parentSiteModel)
        {
            return new SiteTemplateModel(siteTemplateTitle, parentSiteModel);
        }
    }
}
