﻿using DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.BaseDto;

namespace DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.Shared.Standard
{
    public class AssignmentGroupEmployeeDto : BaseDevelopmentStandartDto
    {
        public int Id { get; set; }
        public int AssignmentGroupId { get; set; }
        public int EmployeeUserId { get; set; }
    }
}
