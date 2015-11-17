using System;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Container.Contract
{
    public interface ITemplateContainer
    {
        ITemplateModel Resolve(String modelName);

        void LoadPackages(params ITemplatesPackage[] packages);
    }
}
