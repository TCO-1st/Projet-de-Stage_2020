//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Niveau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Niveau()
        {
            this.Classes = new HashSet<Classe>();
        }
    
        public int id { get; set; }
        public string libelle { get; set; }
        public string option { get; set; }
        public Nullable<int> capacite_Classe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classe> Classes { get; set; }
    }
}
