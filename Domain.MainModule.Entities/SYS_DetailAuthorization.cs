//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatSolution.Domain.MainModule.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_DetailAuthorization
    {
        public string UserId { get; set; }
        public short OptionId { get; set; }
        public byte CompanyId { get; set; }
        public short DetailOptionId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string UserRegistration { get; set; }
        public string UserModification { get; set; }
    
        public virtual SYS_Authorization SYS_Authorization { get; set; }
    }
}
