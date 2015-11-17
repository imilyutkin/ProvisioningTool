using System;
using System.CodeDom;
using System.Collections.Generic;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.Container.Contract
{
    public interface ITemplatesPackage
    {
        void SetDepencies(params ITemplatesPackage[] packages);

        List<ITemplateModel> GetSiteModels();

        ITemplateModel GetModel(String baseModelName);
    }
}
