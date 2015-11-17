using System;
using DeploymentModels.MetadataModels.Base;
using DeploymentModels.MetadataModels.Dossier;
using DeploymentModels.Models;
using DeploymentModels.Services.Contract;
using DeploymentModels.Services.Impl;

namespace ProvisionTool
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeployManagerService deployService = new DeployManagerService();

            var baseModel = Model.Create("BaseTemplate")
                .AddModel(new BaseContentTypesModel())
                .AddModel(new BaseTemplateListsModel())
                .AddProvisionCode(new MetadataPartDeploymentModel());

            var dossierModel = Model.Create("DossierTemplate", baseModel)
                .AddModel(new DossierContentTypesModel())
                .AddModel(new DossierTemplateListsModel())
                .AddModel(new AheadCustomActionDeploymentModel("http://divlets.com", "package_ahead.json"))
                .BuildModel();

            Console.WriteLine("Deploy Base template");
            deployService.Deploy(baseModel.BuildModel());
            Console.WriteLine();
            Console.WriteLine("Deploy Dossier tempalte");
            deployService.Deploy(dossierModel);

            Console.Read();
        }
    }
}
