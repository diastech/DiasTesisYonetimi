﻿using DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.BaseDto;

namespace DiasShared.Data.EF_Data.DiasFacilityManagement.SqlServer.DataTransferObjects.Development.Shared.Standard
{
    public class ResolutionFormSingleQuestionDto : BaseDevelopmentStandartDto
    {
        public int Id { get; set; }
        public int TicketFormId { get; set; }
        public string QuestionText { get; set; }
        public bool? IsMandatory { get; set; }
    }
}
