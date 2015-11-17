using System;
using System.Collections.Generic;
using System.Linq;
using DeploymentModels.Models.Contract;
using Templates.Container.Contract;

namespace Templates.Container.Impl
{
    public class TemplateContainer : ITemplateContainer
    {
        protected IDictionary<String, ITemplateModel> ModelsContainer
        {
            get;
            set;
        }

        public TemplateContainer()
        {
            ModelsContainer = new Dictionary<String, ITemplateModel>();
        }

        public TemplateContainer(params ITemplatesPackage[] packages)
        {
            ModelsContainer = new Dictionary<String, ITemplateModel>();
            LoadPackages(packages);
        }

        public void Register(ITemplateModel siteTemplate)
        {
            if (ModelsContainer.ContainsKey(siteTemplate.Title))
            {
                throw new Exception(String.Format("Site Template model with name \"{0}\" was registered", siteTemplate.Title));
            }
            ModelsContainer.Add(siteTemplate.Title, siteTemplate);
        }

        public ITemplateModel Resolve(String modelName)
        {
            if (ModelsContainer.ContainsKey(modelName))
            {
                return ModelsContainer[modelName];
            }
            throw new Exception(String.Format("Model with name \"{0}\" not found", modelName));
        }

        public void LoadPackages(params ITemplatesPackage[] packages)
        {
            if (packages != null)
            {
                packages.ToList().ForEach(package =>
                {
                    package.GetSiteModels().ForEach(Register);
                });
            }
        }
    }
}
