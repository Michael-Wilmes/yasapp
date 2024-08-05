using System;
using System.Collections.Generic;
using Yasapp.Domain.Entities.Masterdata;

namespace Yasapp.Application.Services.Profiles
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
