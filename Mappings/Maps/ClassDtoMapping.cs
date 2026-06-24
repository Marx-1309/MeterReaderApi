using AutoMapper;
using MeterReaderApi.Mappings.Dto_s;
using MeterReaderApi.Models;

namespace MeterReaderApi.Mappings.Maps
{
    public class ClassDtoMapping : Profile
    {
        public ClassDtoMapping()
        {
            CreateMap<Reading, UpdateReadingDto>().ReverseMap();
            CreateMap<ImageSyncDto, UpdateReadingDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}