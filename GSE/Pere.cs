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
    
    public partial class Pere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pere()
        {
            this.Eleves = new HashSet<Eleve>();
        }
    
        public string cin { get; set; }
        public string nom_Ar { get; set; }
        public string nom_Fr { get; set; }
        public string prenom_Ar { get; set; }
        public string prenom_Fr { get; set; }
        public Nullable<System.DateTime> date_Naissance { get; set; }
        public string lieu_Naissance_Ar { get; set; }
        public string lieu_Naissance_Fr { get; set; }
        public string sexe { get; set; }
        public byte[] photo { get; set; }
        public string metier { get; set; }
        public string tele { get; set; }
        public string fix { get; set; }
        public string adresse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eleve> Eleves { get; set; }
    }
}
