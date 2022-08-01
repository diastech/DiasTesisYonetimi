﻿using DiasDataAccessLayer.DataAccessLayers.EF_Layers.DiasFacilityManagement.SqlServer.Test.BaseModel;
using System;
using System.Collections.Generic;

#nullable disable

namespace DiasDataAccessLayer.DataAccessLayers.EF_Layers.DiasFacilityManagement.SqlServer.Test.Models
{
    public partial class WorkShift : DevelopmentBaseEntity
    {
        public WorkShift()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string ShiftName { get; set; }
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }

        public virtual User AddedByUser { get; set; }
        public virtual User LastModifiedByUser { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
