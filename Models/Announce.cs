﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR30Web.Data
{
[Table("tbAnnounce")]
    public partial class Announce
    {
        [Key]
        [Column("cId")]
        public int CId { get; set; }
        [Required]
        [Column("cAnnounceId")]
        [StringLength(20)]
        public string CAnnounceId { get; set; }
        [Column("cSource")]
        public byte CSource { get; set; }
        [Column("cMailerType")]
        public byte CMailerType { get; set; }
        [Column("cPhone1")]
        public int? CPhone1 { get; set; }
        [Column("cPhone2")]
        public int? CPhone2 { get; set; }
    }
}