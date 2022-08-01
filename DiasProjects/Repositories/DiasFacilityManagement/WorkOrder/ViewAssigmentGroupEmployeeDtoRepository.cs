﻿using DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.BaseBusinessRules.SqlServer.Standart;
using DiasWebApi.InterfacesAbstracts.Interfaces.Repositories.DiasFacilityManagement;
using DiasWebApi.Shared.Operations.BusinessLogicOperations.SimpleInjectorOperations;
using static DiasWebApi.Shared.Enums.WebApiApplicationEnums;

namespace DiasWebApi.Repositories.DiasFacilityManagement
{
    public class ViewAssigmentGroupEmployeeDtoRepository : IViewAssigmentGroupEmployeeDtoRepository
    {
        private IBaseViewAssigmentGroupEmployeeBusinessRules _baseViewAssigmentGroupEmployeeBusinessRules;
        private ApplicationBusinessLogicEnvironment _applicationBusinessLogicEnvironment;
        private bool businessLogicContainerStatus { get; set; }
        public ViewAssigmentGroupEmployeeDtoRepository(IBaseViewAssigmentGroupEmployeeBusinessRules baseViewAssigmentGroupEmployeeBusinessRules, ApplicationBusinessLogicEnvironment applicationBusinessLogicEnvironment)
        {
            businessLogicContainerStatus = SimpleInjectorContainerOperations.VerifyContainer();

            if (businessLogicContainerStatus)
            {
                _baseViewAssigmentGroupEmployeeBusinessRules = baseViewAssigmentGroupEmployeeBusinessRules;
                _applicationBusinessLogicEnvironment = applicationBusinessLogicEnvironment;
            }
        }
    }
}
