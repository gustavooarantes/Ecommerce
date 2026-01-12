using Catalog.Common.Base;
using Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories.Implementations;

public class ProductRepository : BaseRepository<Product, DbContext>, IProductRepository
{
	public ProductRepository(DbContext context) : base(context)
	{

	}
}
