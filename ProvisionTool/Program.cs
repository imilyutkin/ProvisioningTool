using System;
using DeploymentModels.Models;
using DeploymentModels.ModelsContract;
using DeploymentModels.Services.Contract;
using DeploymentModels.Services.Impl;

namespace ProvisionTool
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeployManagerService deployService = new DeployManagerService();

            var dossierModel = Model.Create("DossierTemplate")
                .AddModel(new BaseContentTypesModel())
                .AddProvisionCode(new AheadDeploymentModel("http://dossier.com", "ivan"))
                .AddProvisionCode(new MetadataPartDeploymentModel("http://dossier.com"))
                .BuildModel();

            deployService.Deploy(dossierModel);

            Console.Read();
        }
    }
}
