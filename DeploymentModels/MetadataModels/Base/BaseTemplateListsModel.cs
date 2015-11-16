using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Base
{
    public class BaseTemplateListsModel : IModel
    {
        public ModelNode GetModel()
        {
            return new ModelNode("Base template lists");
        }
    }
}
