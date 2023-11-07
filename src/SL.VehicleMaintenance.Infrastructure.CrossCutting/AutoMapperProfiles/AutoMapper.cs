using AutoMapper;
using SL.VehicleMaintenance.Application.ViewModels;
using SL.VehicleMaintenance.Application.ViewModels.Grids;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Domain.Models.Grids;

namespace SL.VehicleMaintenance.Infrastructure.CrossCutting.AutoMapperProfiles
{
	public class AutoMapper : Profile
	{
		public AutoMapper()
		{
			CreateMap<Brand, BrandViewModel>().ReverseMap();
			CreateMap<BrandGridList, BrandGridListViewModel>().ReverseMap();
			CreateMap<VehicleModel, VehicleViewModel>().ReverseMap();
		}
	}
}