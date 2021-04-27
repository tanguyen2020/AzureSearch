using Azure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.ConfigSettings
{
    public class ConfigKeyAzure : IConfigKeyAzure
    {
        public Uri SearchSeviceUri => new Uri("");

        public AzureKeyCredential KeyCredential => new AzureKeyCredential("");
    }
}
