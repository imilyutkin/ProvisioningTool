using System;
using DeploymentModels.Models.Contract;

namespace DeploymentModels.MetadataModels.Base
{
    public class AheadCustomActionDeploymentModel : IModel
    {
        public String DivletUrl
        {
            get;
            set;
        }

        public String PackageFile
        {
            get;
            set;
        }

        public AheadCustomActionDeploymentModel(String divletUrl, String packageFile)
        {
            DivletUrl = divletUrl;
            PackageFile = packageFile;
        }

        public ModelNode GetModel()
        {
            return new ModelNode(String.Format("Install custom action from [{0}]. DivletUrl: [{1}]", PackageFile, DivletUrl));
        }
    }
}
