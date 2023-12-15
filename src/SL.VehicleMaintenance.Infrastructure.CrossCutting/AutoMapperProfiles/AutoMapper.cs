using AutoMapper;
using SL.VehicleMaintenance.Application.Enumerators;
using SL.VehicleMaintenance.Application.ViewModels;
using SL.VehicleMaintenance.Application.ViewModels.Grids;
using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;
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
			
			CreateMap<Email, EmailViewModel>().ReverseMap();

			CreateMap<Phone, PhoneViewModel>().ReverseMap();
			
			CreateMap<UserGridList, UserGridListViewModel>().ReverseMap();
			CreateMap<User, UserViewModel>().ReverseMap();

			CreateMap<UserVehicle, UserVehicleViewModel>().ReverseMap();

			CreateMap<VehicleModel, VehicleViewModel>().ReverseMap();

			// Enumerators
			CreateMap<EmailTypeEnumModel, EmailTypeEnumViewModel>().ReverseMap();
			CreateMap<PhoneTypeEnumModel, PhoneTypeEnumViewModel>().ReverseMap();
		}
	}
}