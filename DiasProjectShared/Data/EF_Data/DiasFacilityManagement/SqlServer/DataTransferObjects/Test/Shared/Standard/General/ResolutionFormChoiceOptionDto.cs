﻿using DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.BaseDto;
using System;

namespace DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Test.Shared.Standard
{
    public class ResolutionFormChoiceOptionDto : BaseDevelopmentStandartDto
    {
        public int Id { get; set; }
        public string ChoiceOptionText { get; set; }
    }
}
