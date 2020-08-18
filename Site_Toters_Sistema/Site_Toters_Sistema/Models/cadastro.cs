using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Site_Toters_Sistema.Models
{
    public class cadastro: DbContext
    {
        DbSet<toter> toter { get; set; }
    }
}