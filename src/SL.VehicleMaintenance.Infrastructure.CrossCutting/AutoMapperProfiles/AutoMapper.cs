using AutoMapper;
using SL.VehicleMaintenance.Application.ViewModels;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.CrossCutting.AutoMapperProfiles
{
	public class AutoMapper : Profile
	{
		public AutoMapper()
		{
			CreateMap<Brand, BrandViewModel>().ReverseMap();
		}
	}
}