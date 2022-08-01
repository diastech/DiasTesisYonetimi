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
    public class AssignmentGroupProfile : Profile
    {
        public AssignmentGroupProfile() { }
        public AssignmentGroupProfile(Type dataContextType)
        {            
            switch (dataContextType.Name)
            {
                case "DiasFacilityManagementSqlServer":
                    {
                        CreateMap<Model.AssignmentGroup, Dto.AssignmentGroupDto>();

                        CreateMap<Dto.AssignmentGroupDto, Model.AssignmentGroup>();

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
