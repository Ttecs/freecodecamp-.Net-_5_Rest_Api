using System;

namespace Catalog.Entities
{
    public  record Item
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; init; }
         

    }
}