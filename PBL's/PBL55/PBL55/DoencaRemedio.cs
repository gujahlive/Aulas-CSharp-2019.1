//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL55
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoencaRemedio
    {
        public int Id { get; set; }
        public int RemedioId { get; set; }
        public int DoencaId { get; set; }
        public Gravidade Gravidade { get; set; }
    
        public virtual Doenca Doenca { get; set; }
        public virtual Remedio Remedio { get; set; }
    }
}
