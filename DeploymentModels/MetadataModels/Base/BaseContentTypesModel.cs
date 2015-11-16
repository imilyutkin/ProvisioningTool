using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Base
{
    public class BaseContentTypesModel : IModel
    {
        public ModelNode GetModel()
        {
            return new ModelNode("Base Content Types");
        }
    }
}
