using SargeStoreDomain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SargeStoreDomain.Entities.Base
{
    /// <summary>Сущность</summary>
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
