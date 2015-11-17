using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeploymentModels.Models.Contract;

namespace Templates.Container.Contract
{
    public interface ITemplatesPackage
    {
        List<ITemplateModel> GetSiteModels();
    }
}
