﻿#nullable enable
using System;

namespace Base.Entity
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime RecDate { get; set; } = DateTime.Now;
        public DateTime? ChangeDate { get; set; }
        public string? RecAuditLog { get; set; }
        public long RecVersion { get; set; }
        public string Status { get; set; } = Constants.Status.Active;
        public char RecStatus { get; set; } = 'A';
    }
}