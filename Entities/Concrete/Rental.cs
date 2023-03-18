﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {

            [Key]
            public int RentId{ get; set; }
            
            public int CarId { get; set; }
            public int CustomerID { get; set; }
            public DateTime RentDate { get; set; }
            public DateTime ReturnDate { get; set; }
    }
}
