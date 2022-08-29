using AutoMapper;
using DataModel= StudentAdminPortal.API.DataModel;
using StudentAdminPortal.API.DomainModel;


public class AutoMapperProfile : Profile
{
	public AutoMapperProfile()
	{
		CreateMap<DataModel.Student, Student>().ReverseMap();
	}
}