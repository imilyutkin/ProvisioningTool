using System;

namespace DeploymentModels.Models
{
    public class Model
    {
        public static SiteTemplateModel Create(String siteTemplateTitle)
        {
            return new SiteTemplateModel(siteTemplateTitle);
        }

        public static SiteTemplateModel Create(String siteTemplateTitle, SiteTemplateModel parentSiteModel)
        {
            return new SiteTemplateModel(siteTemplateTitle, parentSiteModel);
        }
    }
}
