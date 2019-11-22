using SargeStoreDomain.Entities.Base;
using SargeStoreDomain.Entities.Base.Interfaces;

namespace SargeStoreDomain.Entities
{
    /// <summary>Секция</summary>
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        int? ParentId { get; set; }
    }
}
