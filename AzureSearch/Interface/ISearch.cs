using Azure.Search.Documents;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Models;
using System.Threading.Tasks;

namespace AzureSearch.Interface
{
    public interface ISearch
    {
        Task<SearchResults<TDocument>> SearchIndex<TDocument>(string indexName, string searchText, SearchOptions options = null);
        Task<SearchIndex> CreateIndex<TDocument>(string indexName);
        Task<int> DeleteIndex(string indexName);
    }
}
