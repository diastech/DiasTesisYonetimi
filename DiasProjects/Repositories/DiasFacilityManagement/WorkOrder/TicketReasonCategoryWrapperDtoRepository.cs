﻿using DiasDataAccessLayer.Enums;
using DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.Shared.Custom;
using DiasWebApi.InterfacesAbstracts.Interfaces.Repositories.DiasFacilityManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DiasDataAccessLayer.Enums.BusinessLogicMessageCodes;
using static DiasWebApi.Shared.Enums.WebApiApplicationEnums;
using DevelopmentRepositoryInterface = DiasWebApi.InterfacesAbstracts.Interfaces.Repositories.DiasFacilityManagement;
using BusinessWrapperInterface = DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Development.Custom;
using DiasWebApi.Shared.Operations.BusinessLogicOperations.SimpleInjectorOperations;
using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.Generic.DiasFacilityManagementSqlServer.Development;
using DiasBusinessLogic.AutoMapper.EF_Automapper.DiasFacilityManagementSqlServer.Profiles.CustomProfiles.Development;
using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.Base.SqlServer.Custom;
using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Development.Custom;
using TestDto = DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.Shared.Custom;
using BusinessWrapperTestInterface = DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Test.Custom;
using DiasShared.Errors;
using DiasBusinessLogic.Shared.Error;

namespace DiasWebApi.Repositories.DiasFacilityManagement
{
    public class TicketReasonCategoryWrapperDtoRepository : ITicketReasonCategoryWrapperDtoRepository
    {
        private IBaseTicketReasonCategoryWrapperBusinessRules _baseTicketReasonCategoryWrapperBusinessRules;
        private ApplicationBusinessLogicEnvironment _applicationBusinessLogicEnvironment;
        private bool businessLogicContainerStatus { get; set; }


        #region WebClient
        #region Development
        public TicketReasonCategoryWrapperDtoRepository(IBaseTicketReasonCategoryWrapperBusinessRules baseTicketReasonCategoryWrapperBusinessRules, ApplicationBusinessLogicEnvironment applicationBusinessLogicEnvironment)
        {
            businessLogicContainerStatus = SimpleInjectorContainerOperations.VerifyContainer();
            if (businessLogicContainerStatus)
            {
                _baseTicketReasonCategoryWrapperBusinessRules = baseTicketReasonCategoryWrapperBusinessRules;
            }
        }
        public async Task<Tuple<Error, IEnumerable<CustomTicketReasonCategoryDto>>> GetAllTicketReasonCategoriesWrapperAsync()
        {
            if (businessLogicContainerStatus)
            {
                switch (_applicationBusinessLogicEnvironment)
                {
                    case ApplicationBusinessLogicEnvironment.Development:
                        {
                            ITicketReasonCategoryWrapperBusinessRules businessRule =
                                (ITicketReasonCategoryWrapperBusinessRules)_baseTicketReasonCategoryWrapperBusinessRules;
                            return await businessRule.GetAllTicketReasonCategoriesWrapperAsync();
                        }
                    case ApplicationBusinessLogicEnvironment.Test:
                        {
                            return new Tuple<Error, IEnumerable<CustomTicketReasonCategoryDto>>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                    case ApplicationBusinessLogicEnvironment.Live:
                        {
                            return new Tuple<Error, IEnumerable<CustomTicketReasonCategoryDto>>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                    default:
                        {
                            return new Tuple<Error, IEnumerable<CustomTicketReasonCategoryDto>>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                }
            }
            else
            {
                return new Tuple<Error, IEnumerable<CustomTicketReasonCategoryDto>>(Errors.General.GeneralServerError(), null);
            }
        }

        public async Task<Tuple<Error, CustomTicketReasonCategoryDto>> GetTicketReasonCategoryWrapperByIdAsync(string hierarchyId)
        {
            if (businessLogicContainerStatus)
            {
                switch (_applicationBusinessLogicEnvironment)
                {
                    case ApplicationBusinessLogicEnvironment.Development:
                        {
                            ITicketReasonCategoryWrapperBusinessRules businessRule =
                                (ITicketReasonCategoryWrapperBusinessRules)_baseTicketReasonCategoryWrapperBusinessRules;
                            return await businessRule.GetTicketReasonCategoryWrapperByIdAsync(hierarchyId);
                        }
                    case ApplicationBusinessLogicEnvironment.Test:
                        {
                            return new Tuple<Error, CustomTicketReasonCategoryDto>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                    case ApplicationBusinessLogicEnvironment.Live:
                        {
                            return new Tuple<Error, CustomTicketReasonCategoryDto>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                    default:
                        {
                            return new Tuple<Error, CustomTicketReasonCategoryDto>(Errors.General.NotFoundDatabaseServer(), null);
                        }
                }
            }
            else
            {
                return new Tuple<Error, CustomTicketReasonCategoryDto>(Errors.General.GeneralServerError(), null);
            }
        }
        #endregion

        #region Test
        public async Task<Tuple<ErrorCodes, IEnumerable<TestDto.CustomTicketReasonCategoryDto>>> GetAllTicketReasonCategoriesWrapperTestAsync()
        {
            if (businessLogicContainerStatus)
            {
                switch (_applicationBusinessLogicEnvironment)
                {
                    case ApplicationBusinessLogicEnvironment.Development:
                        {
                            return new Tuple<ErrorCodes, IEnumerable<TestDto.CustomTicketReasonCategoryDto>>(ErrorCodes.UnknownError, null);

                        }
                    case ApplicationBusinessLogicEnvironment.Test:
                        {
                            BusinessWrapperTestInterface.ITicketReasonCategoryWrapperBusinessRules businessRule =
                                (BusinessWrapperTestInterface.ITicketReasonCategoryWrapperBusinessRules)_baseTicketReasonCategoryWrapperBusinessRules;

                            return await businessRule.GetAllTicketReasonCategoriesWrapperAsync();
                        }
                    case ApplicationBusinessLogicEnvironment.Live:
                        {
                            return new Tuple<ErrorCodes, IEnumerable<TestDto.CustomTicketReasonCategoryDto>>(ErrorCodes.UnknownError, null);
                        }
                    default:
                        {
                            return new Tuple<ErrorCodes, IEnumerable<TestDto.CustomTicketReasonCategoryDto>>(ErrorCodes.UnknownError, null);
                        }
                }
            }
            else
            {
                return new Tuple<ErrorCodes, IEnumerable<TestDto.CustomTicketReasonCategoryDto>>(ErrorCodes.UnknownError, null);
            }
        }

        public async Task<Tuple<ErrorCodes, TestDto.CustomTicketReasonCategoryDto>> GetTicketReasonCategoryWrapperByIdTestAsync(string hierarchyId)
        {
            if (businessLogicContainerStatus)
            {
                switch (_applicationBusinessLogicEnvironment)
                {
                    case ApplicationBusinessLogicEnvironment.Development:
                        {
                            return new Tuple<ErrorCodes, TestDto.CustomTicketReasonCategoryDto>(ErrorCodes.UnknownError, null);

                        }
                    case ApplicationBusinessLogicEnvironment.Test:
                        {
                            BusinessWrapperTestInterface.ITicketReasonCategoryWrapperBusinessRules businessRule =
                                (BusinessWrapperTestInterface.ITicketReasonCategoryWrapperBusinessRules)_baseTicketReasonCategoryWrapperBusinessRules;

                            return await businessRule.GetTicketReasonCategoryWrapperByIdAsync(hierarchyId);
                        }
                    case ApplicationBusinessLogicEnvironment.Live:
                        {
                            return new Tuple<ErrorCodes, TestDto.CustomTicketReasonCategoryDto>(ErrorCodes.UnknownError, null);
                        }
                    default:
                        {
                            return new Tuple<ErrorCodes, TestDto.CustomTicketReasonCategoryDto>(ErrorCodes.UnknownError, null);
                        }
                }
            }
            else
            {
                return new Tuple<ErrorCodes, TestDto.CustomTicketReasonCategoryDto>(ErrorCodes.UnknownError, null);
            }
        }
        #endregion

        #endregion

        #region Mobile

        #endregion

    }
}
