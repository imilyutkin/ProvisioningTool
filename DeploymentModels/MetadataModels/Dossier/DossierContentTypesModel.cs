using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Dossier
{
    public class DossierContentTypesModel : IModel
    {
        public ModelNode GetModel()
        {
            return new ModelNode("Dossier Content Types");
        }
    }
}
