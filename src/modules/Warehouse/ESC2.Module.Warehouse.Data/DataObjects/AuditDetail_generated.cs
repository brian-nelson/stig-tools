using System;
using System.Collections.Generic;
using ESC2.Library.Data.Interfaces;

// This file is generated from the database.  Do not manually edit.
// Generated by: https://github.com/brian-nelson/repo-generator
// To extend the class beyond a POCO, create a additional partial class
// named AuditDetail.cs

namespace ESC2.Module.System.Data.DataObjects
{
    public partial class AuditDetail : IGuidObject
    {
        public AuditDetail()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid AuditId { get; set; }
        public Guid? RuleId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
