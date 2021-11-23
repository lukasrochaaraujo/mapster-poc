using MapsterCodeGenPOC.Models;

namespace MapsterCodeGenPOC.Dtos
{
    public static partial class StateMapper
    {
        public static StateDto AdaptToDto(this State p1)
        {
            return p1 == null ? null : new StateDto() {Name = p1.Name};
        }
    }
}