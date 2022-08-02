using System;
using System.Collections.Generic;

#nullable disable

namespace Shop.Data.Repository.Models
{
    public class WorkEmployeeSchedule
    {
        public long EmployeeId { get; set; }
        public long ShopId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
