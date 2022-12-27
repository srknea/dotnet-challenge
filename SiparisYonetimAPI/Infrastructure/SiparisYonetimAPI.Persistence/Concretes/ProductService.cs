using SiparisYonetimAPI.Application.Abstractions;
using SiparisYonetimAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new() { 
                new() {Id = Guid.NewGuid(), Name="Product1", Price=100, Stock=10},
                new() {Id = Guid.NewGuid(), Name="Product2", Price=200, Stock=10},
                new() {Id = Guid.NewGuid(), Name="Product3", Price=300, Stock=10},
                new() {Id = Guid.NewGuid(), Name="Product4", Price=400, Stock=10},
                new() {Id = Guid.NewGuid(), Name="Product5", Price=500, Stock=10},
            }; 
    }
}
