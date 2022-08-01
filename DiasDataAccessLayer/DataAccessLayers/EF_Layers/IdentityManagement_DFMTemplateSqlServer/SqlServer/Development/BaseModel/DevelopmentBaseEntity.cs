﻿using DiasDataAccessLayer.InterfacesAbstracts.Interfaces.DataAccessLayers.EF_Layers.IdentityManagement_DFMTemplate.SqlServer.Development;
using System;

namespace DiasDataAccessLayer.DataAccessLayers.EF_Layers.IdentityManagement_DFMTemplate.SqlServer.Development.BaseModel
{
    public class DevelopmentBaseEntity : IDevelopmentBaseEntity
    {
        //TODO : burada sistem kullanıcı olarak ilgili  enumdan gelen int default değer olacak
        public int AddedByUserId { get; set; } = 1;
        public DateTime AddedTime { get; set; } = DateTime.Now;
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public bool? IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
