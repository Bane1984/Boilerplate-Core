﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace BoilerplateCore.Models
{
    public class Uredjaj:Entity
    {
        public string ImeUredjaja { get; set; }
    }
}