using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications.Implementation.ModelSpecification
{
    public class ProductSpecParams
    {
        private const int _maxPageSize = 50;
        private int _pageSize = 6;
        public int PageSize 
        { get => _pageSize; 
          set => _pageSize = (value > _maxPageSize ? _maxPageSize : value); 
        }
        public int PageIndex { get; set; } = 1;
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public string Sort { get; set; }
        private string _search;
        public string Search 
        { 
            get => _search; 
            set => _search = value.ToLower(); 
        }
    }
}
