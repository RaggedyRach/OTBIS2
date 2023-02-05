﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data
{
    public class ArenaEventCapacity
    {
        
        public int ArenaCapacityId { get; set; }
        public string Inventory { get; set; }
        public int TotalTickets { get; set; }
        public int GA { get; set; }

        public int Price1 { get; set; } 
        public int Price2 { get; set; } 

        public int Disa { get; set; }
        public int six { get; set; }
        public int seven { get; set; }  
    }
}
