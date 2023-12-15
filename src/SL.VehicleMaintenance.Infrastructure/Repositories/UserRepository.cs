using Microsoft.EntityFrameworkCore;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Domain.Models.Grids;
using SL.VehicleMaintenance.Infrastructure.Data.Context;

namespace SL.VehicleMaintenance.Infrastructure.Data.Repositories
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		public UserRepository(VehicleMaintenanceSqlContext context) : base(context)
		{ }

		public async Task<ICollection<UserGridList>> GridList()
		{
			var query =	from user in DbSet
						orderby user.CreatedDate descending
						select new UserGridList()
						{
							Id = user.Id,
							Name = user.Name,
							CreatedDate = user.CreatedDate,
							IsActive = user.IsActive,
							IsDeleted = user.IsDeleted
						};

			// TODO: @sergiolucascaps - Aplicar paginação

			return await query.ToListAsync();
		}
		
		public async Task<User?> GetById(Guid id)
		{
			return await DbSet
						.Include(x => x.Phones)
						.Include(x => x.Emails)
						.Include(x => x.Vehicles)
							.ThenInclude(x => x.Model)
								.ThenInclude(x => x.Brand)
						.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}