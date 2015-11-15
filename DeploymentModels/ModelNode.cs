using System;

namespace DeploymentModels
{
    public class ModelNode
    {
        public String Title
        {
            get;
            set;
        }

        public ModelNode(String title)
        {
            Title = title;
        }
    }
}
