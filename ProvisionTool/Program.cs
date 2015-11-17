using System;
using CommonSItes;
using DeploymentModels.Container.Impl;
using DeploymentModels.Services.Contract;
using DeploymentModels.Services.Impl;
using TemplateSites;

namespace ProvisionTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var commonPackage = new CommonSitesPackage(new CommonSitesSettings());
            var dossierPackage = new DossierSitesPackage(new DossierSiteSettings { AheadPackageFile = "package_ahead.json", DivletSiteUrl = "http://divlets.com/"});
            dossierPackage.SetDepencies(commonPackage);
            var container = new TemplateContainer(commonPackage, dossierPackage);
            var dossierTemplate = container.Resolve("DossierTemplate");

            IDeployManagerService deployService = new DeployManagerService();
            
            Console.WriteLine("Deploy Dossier tempalte");
            deployService.Deploy(dossierTemplate.BuildModel());
            Console.Read();
        }
    }
}
