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
    
    public partial class Classe_Details
    {
        public string eleve { get; set; }
        public string classe { get; set; }
        public string annee { get; set; }
        public string ancienne { get; set; }
    
        public virtual Ancienne_Classe Ancienne_Classe { get; set; }
        public virtual Annee_Scolaire Annee_Scolaire { get; set; }
        public virtual Classe Classe1 { get; set; }
        public virtual Eleve Eleve1 { get; set; }
    }
}
