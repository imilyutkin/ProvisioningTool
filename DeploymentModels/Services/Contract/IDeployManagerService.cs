using DeploymentModels.ModelsContract;

namespace DeploymentModels.Services.Contract
{
    public interface IDeployManagerService
    {
        void Deploy(IDeployableModel deployDeployableModels);
    }
}
