using Catalog.Common.Base;
using Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories.Implementations;

public class BrandRepository : BaseRepository<Brand, DbContext>, IBrandRepository
{
	public BrandRepository(DbContext context) : base(context)
	{
	}
}
