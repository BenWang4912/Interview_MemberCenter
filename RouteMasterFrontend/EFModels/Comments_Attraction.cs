﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class Comments_Attraction
    {
        public Comments_Attraction()
        {
            Comments_AttractionImages = new HashSet<Comments_AttractionImage>();
            ReportedAttractionComments = new HashSet<ReportedAttractionComment>();
        }

        public int Id { get; set; }
        public int MemberId { get; set; }
        public int AttractionId { get; set; }
        public int Score { get; set; }
        public string? Content { get; set; }
        public int? StayHours { get; set; }
        public int? Price { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsHidden { get; set; }

        public virtual Attraction Attraction { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Comments_AttractionImage> Comments_AttractionImages { get; set; }
        public virtual ICollection<ReportedAttractionComment> ReportedAttractionComments { get; set; }
    }
}