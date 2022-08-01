﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = DiasDataAccessLayer.DataAccessLayers.EF_Layers.DiasFacilityManagement.SqlServer.Development.Models;
using Dto = DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.Shared.Standard;

namespace DiasBusinessLogic.AutoMapper.EF_Automapper.DiasFacilityManagementSqlServer.Profiles.StandartProfiles.Development
{
    public class ResolutionFormYesNoProfile : Profile
    {
        public ResolutionFormYesNoProfile() { }
        public ResolutionFormYesNoProfile(Type dataContextType)
        {
            switch (dataContextType.Name)
            {
                case "DiasFacilityManagementSqlServer":
                    {
                        CreateMap<Model.ResolutionFormYesNo, Dto.ResolutionFormYesNoDto>();
                        
                        CreateMap<Dto.ResolutionFormYesNoDto, Model.ResolutionFormYesNo>();

                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}