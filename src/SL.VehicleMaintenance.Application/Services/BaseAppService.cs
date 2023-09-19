using AutoMapper;
using SL.VehicleMaintenance.Application.Interfaces;

namespace SL.VehicleMaintenance.Application.Services
{
	public abstract class BaseAppService : IBaseAppService
	{
		protected readonly IMapper _mapper;

		protected BaseAppService(IMapper mapper)
		{
			_mapper = mapper;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}