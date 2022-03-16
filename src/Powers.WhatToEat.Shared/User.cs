using Powers.WhatToEat.Shared.Base;

namespace Powers.WhatToEat.Shared
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : EntityBase
    {
        public string? Account { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}