using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Holloman_DataModelling_HW.Models;

namespace Holloman_DataModelling_HW.Data
{
    public class DataModellingDb : DbContext
    {
        public DataModellingDb (DbContextOptions<DataModellingDb> options)
            : base(options)
        {
        }

        public DbSet<Holloman_DataModelling_HW.Models.Customer> Customer { get; set; } = default!;
    }
}
