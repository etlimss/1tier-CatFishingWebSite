﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CatFishingWebSite.Model;

namespace CatFishingWebSite.wwwroot
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, IdOfUser>();
        }
    }
}
