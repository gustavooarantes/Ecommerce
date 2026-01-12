using Catalog.Common.Abstractions;
using Catalog.Entities;

namespace Catalog.Repositories;

public interface IProductRepository : IBaseRepository<Product>
{
	Task<IEnumerable<Product>> GetProductsByName(string name);
	Task<IEnumerable<Product>> GetProductsByBrand(string name);
}
