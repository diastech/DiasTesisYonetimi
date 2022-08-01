﻿using DiasBusinessLogic.InterfacesAbstracts.Abstracts.BusinessRules;
using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.BaseBusinessRules.SqlServer.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionalInterface = DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Test.Custom;
using DevelopmentUserInterface = DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Test.Standart;
using DevelopmentDto = DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.Shared.Standard;
using CustomDto = DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.Shared.Custom;
using DiasDataAccessLayer.Enums;
using DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.Shared.Standard;
using DiasBusinessLogic.BusinessRules.DiasFacilityManagementSql.Configuration;
using DiasBusinessLogic.Shared.Configuration;
using DevelopmentContext = DiasDataAccessLayer.DataAccessLayers.EF_Layers.DiasFacilityManagement.SqlServer.Test.Models;
using static DiasDataAccessLayer.Enums.BusinessLogicMessageCodes;
using DiasBusinessLogic.AutoMapper.Configuration;
using CustomDevelopmentPeriodicTicketProfile = DiasBusinessLogic.AutoMapper.EF_Automapper.DiasFacilityManagementSqlServer.Profiles.CustomProfiles.Test;
using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.Base.SqlServer.Custom;
using DiasShared.Services.Communication.BusinessLogicMessage.ThirdPartyLibrary.DevExpress;
using DiasShared.Errors;
using DiasBusinessLogic.Shared.Error;

namespace DiasBusinessLogic.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Test.Custom
{
    public class PeriodicTicketWrapperBusinessRules : BusinessRuleAbstract, TransactionalInterface.IPeriodicTicketWrapperBusinessRules, IBasePeriodicTicketWrapperBusinessRules
    {
        private readonly DevelopmentUserInterface.IPeriodicTicketBusinessRules _periodicTicketBusinessRules;
        private static AutoMapperProfileMapper<CustomDevelopmentPeriodicTicketProfile.CustomPeriodicTicketProfile> DtoMapper_DiasFacilityManagementSqlServer_Development
            => new(new(DataContextHelper.GetDataContextTypeViaConfiguration("DiasFacilityManagementSqlServerTest")));

        public PeriodicTicketWrapperBusinessRules() : this(DI_ServiceLocator.Current.Get<DevelopmentUserInterface.IPeriodicTicketBusinessRules>())
        {
        }
        private PeriodicTicketWrapperBusinessRules(DevelopmentUserInterface.IPeriodicTicketBusinessRules periodicTicketBusinessRules)
        {
            _periodicTicketBusinessRules = periodicTicketBusinessRules;
        }

        public async Task<Tuple<Error, IEnumerable<CustomDto.CustomPeriodicTicketDto>>> GetAllPeriodicTicketsWrapperAsync(DevExpressRequest devExpressRequestObj)
        {
            Type dataContextType = DataContextHelper.GetDataContextTypeViaConfiguration("DiasFacilityManagementSqlServerTest");

            if ((dataContextType == null) || (dataContextType.Name == null) || (dataContextType.Name == ""))
            {
                return new(Errors.General.ConnectionTimeout(), null);
            }
            else
            {
                switch (dataContextType.Name)
                {
                    case "DiasFacilityManagementSqlServer":
                        {
                            DevelopmentContext.DiasFacilityManagementSqlServer DiasFacilityManagementSqlServerContext = new();
                            Tuple<Error, List<DevelopmentDto.PeriodicTicketDto>> resultGetTicketList = await _periodicTicketBusinessRules.GetAllPeriodicTicketsAsync(devExpressRequestObj);
                            

                            try
                            {
                                if ((resultGetTicketList.Item1.BusinessOperationSucceed == true) && (resultGetTicketList.Item2 != null))
                                {
                                    List<CustomDto.CustomPeriodicTicketDto> returnDtoList = new List<CustomDto.CustomPeriodicTicketDto>();

                                    returnDtoList = DtoMapper_DiasFacilityManagementSqlServer_Development.
                                        Map<List<DevelopmentDto.PeriodicTicketDto>, List<CustomDto.CustomPeriodicTicketDto>>(resultGetTicketList.Item2);

                                    return new Tuple<Error, IEnumerable<CustomDto.CustomPeriodicTicketDto>>(resultGetTicketList.Item1, returnDtoList);
                                }
                                else
                                {
                                    return new Tuple<Error, IEnumerable<CustomDto.CustomPeriodicTicketDto>>(resultGetTicketList.Item1, null);
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    default:
                        {
                            return new(Errors.General.NotFoundDatabaseServer(), null);
                        }
                }
            }            
        }

        public async Task<Tuple<Error, CustomDto.CustomPeriodicTicketDto>> GetPeriodicTicketWrapperByIdAsync(int Id)
        {
            Type dataContextType = DataContextHelper.GetDataContextTypeViaConfiguration("DiasFacilityManagementSqlServerTest");

            if ((dataContextType == null) || (dataContextType.Name == null) || (dataContextType.Name == ""))
            {
                return new(Errors.General.ConnectionTimeout(), null);
            }
            else
            {
                switch (dataContextType.Name)
                {
                    case "DiasFacilityManagementSqlServer":
                        {
                            DevelopmentContext.DiasFacilityManagementSqlServer DiasFacilityManagementSqlServerContext = new();
                            Tuple<Error, DevelopmentDto.PeriodicTicketDto> resultGetTicket = await _periodicTicketBusinessRules.GetPeriodicTicketByIdAsync(Id);

                            try
                            {
                                if ((resultGetTicket.Item1.BusinessOperationSucceed == true && (resultGetTicket.Item2 != null)))
                                {
                                    CustomDto.CustomPeriodicTicketDto returnDto = new CustomDto.CustomPeriodicTicketDto();
                                    CustomDto.CustomPeriodicTicketDto convertedDto = DtoMapper_DiasFacilityManagementSqlServer_Development.Map<DevelopmentDto.PeriodicTicketDto, CustomDto.CustomPeriodicTicketDto>(resultGetTicket.Item2);
                                    
                                    returnDto = convertedDto;

                                    return new Tuple<Error, CustomDto.CustomPeriodicTicketDto>(resultGetTicket.Item1, returnDto);
                                }
                                else
                                {
                                    return new Tuple<Error, CustomDto.CustomPeriodicTicketDto>(resultGetTicket.Item1, null);
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                    default:
                        {
                            return new(Errors.General.NotFoundDatabaseServer(), null);
                        }
                }
            }
        }
    }
}
