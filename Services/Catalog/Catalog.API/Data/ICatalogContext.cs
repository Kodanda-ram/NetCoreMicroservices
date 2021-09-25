using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        [Required]
        IMongoCollection<Product> Products { get; }
    }
}
