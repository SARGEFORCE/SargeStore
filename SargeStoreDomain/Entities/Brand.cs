using SargeStoreDomain.Entities.Base;
using SargeStoreDomain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SargeStoreDomain.Entities
{
    /// <summary>Брэнд</summary>
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
