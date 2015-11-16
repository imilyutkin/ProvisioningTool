using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Dossier
{
    public class DossierTemplateListsModel : IModel
    {
        public ModelNode GetModel()
        {
            return new ModelNode("Dossier template lists");
        }
    }
}
