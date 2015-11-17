using System;
using DeploymentModels.Models.Contract;

namespace Templates.Container.Contract
{
    public interface ITemplateContainer
    {
        void Register(ITemplateModel siteTemplate);

        ITemplateModel Resolve(String modelName);

        void LoadPackages(params ITemplatesPackage[] packages);
    }
}
