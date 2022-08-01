﻿using DiasShared.Errors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DiasDataAccessLayer.Enums.BusinessLogicMessageCodes;
using DevelopmentDto = DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.Shared.Standard;


namespace DiasBusinessLogic.InterfacesAbstracts.Interfaces.BusinessRules.DiasFacilityManagementSqlServer.SqlServer.Development.Standart
{
    public interface IAssignmentGroupBusinessRules
    {
        public Task<Tuple<Error, IEnumerable<DevelopmentDto.AssignmentGroupDto>>> GetAssignmentGroupListAsync();

        public Task<Tuple<Error, IEnumerable<DevelopmentDto.AssignmentGroupDto>>> GetManagedAssignmentGroupsByUserId(int kullaniciId);
    }
}