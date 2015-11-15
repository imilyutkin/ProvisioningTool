using DeploymentModels.ModelsContract;

namespace DeploymentModels.Models
{
    public class BaseContentTypesModel : IModel
    {
        public ModelNode GetModel()
        {
            return new ModelNode("Base Content Types");
        }
    }
}
