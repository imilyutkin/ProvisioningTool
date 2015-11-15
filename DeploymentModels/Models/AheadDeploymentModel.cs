﻿using System;
using DeploymentModels.ModelsContract;

namespace DeploymentModels.Models
{
    public class AheadDeploymentModel : IProvisionCodeModel
    {
        public String SiteUrl
        {
            get;
            set;
        }

        public String UserName
        {
            get;
            set;
        }

        public AheadDeploymentModel(String siteUrl, String userName)
        {
            SiteUrl = siteUrl;
            UserName = userName;
        }

        public void Provision()
        {
            Console.WriteLine("Deploy ahead to site: [{0}] by user :[{1}]", SiteUrl, UserName);
        }
    }
}
