using DeploymentModels.Models.Contract;

namespace DeploymentModels.Services.Contract
{
    public interface IDeployManagerService
    {
        void Deploy(IDeployableModel deployDeployableModels);
    }
}
