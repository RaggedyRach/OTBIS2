﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OTBIS.Web.Data

{
    public class CompType
    {
        
        public int CompId { get; set; }

        public string CompTypeName { get; set; }
        public int GA { get; set; }
        public int Price1 { get; set; }
        public int Price2 { get; set; }
        public int SWest { get; set;}

    }
}
