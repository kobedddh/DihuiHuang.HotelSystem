using AutoMapper;
using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.MappingProfiles
{
    public class HotelMappingProfiles:Profile
    {
        public HotelMappingProfiles()
        {
            CreateMap<Service, ServiceResponseModel>();
            CreateMap<Room, RoomResponseModel>();
            CreateMap<RoomType, RoomTypeResponseModel>();
            CreateMap<Customer, CustomerResponseModel>();

            CreateMap<ServiceRequestModel, Service>();
            CreateMap<RoomRequestModel, Room>();
            CreateMap<RoomTypeRequestModel, RoomType>();
            CreateMap<CustomerRequestModel, Customer>();
        }

        

    }
}
