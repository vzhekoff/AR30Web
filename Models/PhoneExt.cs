﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR30Web.Data
{
[Table("tbPhoneExt")]
    public partial class PhoneExt
    {
        [Key]
        [Column("cId")]
        public int CId { get; set; }
        [Column("cType")]
        public byte CType { get; set; }
        [Column("cOwner")]
        public int COwner { get; set; }
        [Column("cPhone")]
        public int CPhone { get; set; }
    }
}