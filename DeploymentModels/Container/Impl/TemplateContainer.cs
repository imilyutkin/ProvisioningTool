using System;
using System.Collections.Generic;
using System.Linq;
using DeploymentModels.Container.Contract;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Container.Impl
{
    public class TemplateContainer : ITemplateContainer
    {
        protected IDictionary<String, ITemplateModel> TemplatesModels
        {
            get;
            set;
        }

        public TemplateContainer(params ITemplatesPackage[] packages)
        {
            LoadPackages(packages);
        }

        public ITemplateModel Resolve(String modelName)
        {
            if (TemplatesModels.ContainsKey(modelName))
            {
                return TemplatesModels[modelName];
            }
            throw new Exception(String.Format("Template with name \"{0}\" not found.", modelName));
        }

        public void LoadPackages(params ITemplatesPackage[] packages)
        {
            TemplatesModels = new Dictionary<String, ITemplateModel>();
            if (packages != null)
            {
                packages.ToList().ForEach(package =>
                {
                    package.GetSiteModels().ForEach(model => TemplatesModels.Add(model.Title, model));
                });
            }
        }
    }
}
