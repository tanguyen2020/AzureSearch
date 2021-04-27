using AzureSearch.ConfigSettings;
using AzureSearch.Interface;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents;
using Azure.Search.Documents.Models;
using System.Threading.Tasks;
using System;

namespace AzureSearch.Implement
{
    public class Search : ISearch
    {
        private ISearchIndex _searchIndex;
        public Search(ISearchIndex searchIndex)
        {
            _searchIndex = searchIndex;
        }

        public async Task<SearchResults<TDocument>> SearchIndex<TDocument>(string indexName, string searchText, SearchOptions options = null)
        {
            try
            {
                return await _searchIndex.SearchIndexClient.GetSearchClient(indexName).SearchAsync<TDocument>(searchText, options);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> DeleteIndex(string indexName)
        {
            try
            {
                var deleted = await _searchIndex.SearchIndexClient.DeleteIndexAsync(indexName);
                return deleted.Status;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<SearchIndex> CreateIndex<TDocument>(string indexName)
        {
            try
            {
                FieldBuilder fieldBuilder = new FieldBuilder();
                var searchFields = fieldBuilder.Build(typeof(TDocument));
                var definition = new SearchIndex(indexName, searchFields);
                return await _searchIndex.SearchIndexClient.CreateOrUpdateIndexAsync(definition);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
