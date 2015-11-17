using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeploymentModels.Container.Contract;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Container.Impl
{
    public abstract class BaseTemplatePackage : ITemplatesPackage
    {
        protected List<ITemplatesPackage> Dependencies
        {
            get;
            set;
        }

        public abstract List<ITemplateModel> GetSiteModels();

        public ITemplateModel GetModel(String baseModelName)
        {
            foreach (var templatesPackage in Dependencies)
            {
                var baseTemplate =
                    templatesPackage.GetSiteModels().FirstOrDefault(template => template.Title.Equals(baseModelName));
                if (baseTemplate != null)
                {
                    return baseTemplate;
                }
            }
            return null;
        }

        public void SetDepencies(params ITemplatesPackage[] packages)
        {
            Dependencies = new List<ITemplatesPackage>(packages);
        }
    }
}
