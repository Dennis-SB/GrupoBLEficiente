using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;

namespace BackEnd.Areas.Identity.Data;

// Add profile data for application users by adding properties to the GrupoBLUser class
public class GrupoBLUser : IdentityUser
{
    public int? IdEmployee { get; set; }

    public virtual Employee? IdEmployeeNavigation { get; set; }
}