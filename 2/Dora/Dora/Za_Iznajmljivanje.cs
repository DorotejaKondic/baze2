//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dora
{
    using System;
    using System.Collections.Generic;
    
    public partial class Za_Iznajmljivanje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Za_Iznajmljivanje()
        {
            this.Clans = new HashSet<Clan>();
        }
    
        public string Datum_Iznajmljivanja { get; set; }
        public short PrimerakID_Primerka { get; set; }
    
        public virtual Primerak Primerak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clan> Clans { get; set; }
    }
}