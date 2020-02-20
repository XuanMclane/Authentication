﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class SecretController : Controller
    {
        [Authorize]
        public string Index()
        {
            return "Secret message";
        }
    }
}
