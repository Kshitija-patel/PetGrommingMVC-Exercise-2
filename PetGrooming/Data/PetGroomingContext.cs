﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetGrooming.Data
{
    public class PetGroomingContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PetGroomingContext() : base("name=PetGroomingContext")
        {
        }

        public System.Data.Entity.DbSet<PetGrooming.Models.Pet> Pets { get; set; }

        public System.Data.Entity.DbSet<PetGrooming.Models.Species> Species { get; set; }
        public System.Data.Entity.DbSet<PetGrooming.Models.Groomer> Groomers { get; set; }
        public System.Data.Entity.DbSet<PetGrooming.Models.GroomService> GroomServices { get; set; }
        System.Data.Entity.DbSet<PetGrooming.Models.GroomBooking> GroomerBookings { get; set; }
        System.Data.Entity.DbSet<PetGrooming.Models.Owner> Owners { get; set; }
    }
}
