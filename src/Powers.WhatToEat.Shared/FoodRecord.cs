using Powers.WhatToEat.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers.WhatToEat.Shared
{
    /// <summary>
    /// 食物选中记录
    /// </summary>
    public class FoodRecord : EntityBase
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public Guid? FoodId { get; set; }
        public Food? Food { get; set; }
    }
}