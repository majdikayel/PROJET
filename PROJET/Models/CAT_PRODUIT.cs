//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_PRODUIT
    {
        public int CODE_PRODUIT { get; set; }
        public Nullable<int> CODE_CATEGORIE { get; set; }
        public string LIBELLE_PRODUIT { get; set; }
        public string DESCRIPTION_PRODUIT { get; set; }
        public string IMAGE_PRODUIT { get; set; }
        public string URL_IMAGE_PRODUIT { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
    
        public virtual CAT_CATEGORIE CAT_CATEGORIE { get; set; }
    }
}
