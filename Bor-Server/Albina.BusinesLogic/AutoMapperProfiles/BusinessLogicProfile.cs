using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinesLogic.AutoMapperProfiles
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<UserRto, UserInformationBlo>()
        }
    }
}
