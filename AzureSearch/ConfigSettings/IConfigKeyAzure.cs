using Azure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.ConfigSettings
{
    public interface IConfigKeyAzure
    {
        Uri SearchSeviceUri { get; }
        AzureKeyCredential KeyCredential { get; }
    }
}
