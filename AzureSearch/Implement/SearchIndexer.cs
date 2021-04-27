using Azure.Search.Documents.Indexes;
using AzureSearch.ConfigSettings;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.Interface
{
    public class SearchIndexer : ISearchIndex
    {
        private IConfigKeyAzure _configKeyAzure;
        public SearchIndexer(IConfigKeyAzure configKeyAzure)
        {
            _configKeyAzure = configKeyAzure;
        }
        public SearchIndexClient SearchIndexClient => new SearchIndexClient(_configKeyAzure.SearchSeviceUri, _configKeyAzure.KeyCredential);
    }
}
