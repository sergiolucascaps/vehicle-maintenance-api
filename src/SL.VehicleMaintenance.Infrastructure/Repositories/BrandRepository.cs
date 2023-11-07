using Microsoft.EntityFrameworkCore;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Domain.Models.Grids;
using SL.VehicleMaintenance.Infrastructure.Data.Context;


namespace SL.VehicleMaintenance.Infrastructure.Data.Repositories
{
	public class BrandRepository : Repository<Brand>, IBrandRepository
	{
		public BrandRepository(VehicleMaintenanceSqlContext context) : base(context)
		{ }

		public async Task<ICollection<BrandGridList>> GridList()
		{
			var query =	from brand in DbSet
						orderby brand.CreatedDate descending
						select new BrandGridList()
						{
							Id = brand.Id,
							Name = brand.Name,
							CreatedDate = brand.CreatedDate,
							IsActive = brand.IsActive,
							IsDeleted = brand.IsDeleted
						};

			// TODO: @sergiolucascaps - Aplicar paginação

			return await query.ToListAsync();
		}

		public async Task<Brand?> GetById(Guid id)
		{
			return await DbSet
						.Include(x => x.VehicleModels)
						.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}