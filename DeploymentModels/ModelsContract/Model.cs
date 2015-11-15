using System;

namespace DeploymentModels.ModelsContract
{
    public class Model
    {
        public static SiteTemplateModel Create(String siteTemplateTitle)
        {
            return new SiteTemplateModel(siteTemplateTitle);
        }
    }
}
