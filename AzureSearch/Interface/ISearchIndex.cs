using Azure.Search.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.Interface
{
    public interface ISearchIndex
    {
        SearchIndexClient SearchIndexClient { get; }
    }
}
