using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers.WhatToEat.Shared.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public Guid? CreateUserId { get; set; }
        public DateTime? CreateDate { get; set; }

        public Guid? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        public void Create()
        {
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void Update()
        {
        }
    }
}