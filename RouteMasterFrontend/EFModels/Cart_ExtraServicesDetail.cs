﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class Cart_ExtraServicesDetail
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ExtraServiceProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual ExtraServiceProduct ExtraServiceProduct { get; set; }
    }
}