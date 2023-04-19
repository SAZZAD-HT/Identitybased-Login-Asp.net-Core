﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace logInv2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the userlgn class
public class userlgn : IdentityUser
{
    public String? FirstName { get; set; }
    public string? lastName { get; set; }
}

