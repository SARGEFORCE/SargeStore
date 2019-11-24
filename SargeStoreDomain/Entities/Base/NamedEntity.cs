using SargeStoreDomain.Entities.Base.Interfaces;

namespace SargeStoreDomain.Entities.Base
{
    /// <summary>Именованная сущность</summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }


}
