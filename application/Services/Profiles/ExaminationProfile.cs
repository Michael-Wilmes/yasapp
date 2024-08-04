using System;
using System.Collections.Generic;
using yasapp.Domain.Entities.Masterdata;

namespace yasapp.Application.Services.Profiles
{
    public class ExaminationProfile : Profile
    {
        public ExaminationProfile()
        {
            CreateMap<Examination,  ExaminationModel>();
            CreateMap<ExaminationModel, Examination>();
        }
    }
}
