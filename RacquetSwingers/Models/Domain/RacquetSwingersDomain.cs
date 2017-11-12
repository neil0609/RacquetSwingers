using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RacquetSwingers.Models.Domain
{
    public class RacquetSwingersDomain
    {
        public int ID { get; set; }
        public string Court { get; set; }
        public DateTime Time { get; set; }
    }
}
