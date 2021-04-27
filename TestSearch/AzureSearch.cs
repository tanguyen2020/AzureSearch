using Azure.Search.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSearch
{
    public class AzureSearch
    {
        [SearchableField(IsFilterable = true)]
        public string StreetAddress { get; set; }
        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string City { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string StateProvince { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string PostalCode { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string Country { get; set; }
    }
}
