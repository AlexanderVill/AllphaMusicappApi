//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllphaMusicapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbAlbum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TbAlbum()
        {
            this.CompraT = new HashSet<CompraT>();
            this.TrackT = new HashSet<TrackT>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string label { get; set; }
        public System.DateTime released { get; set; }
        public double price { get; set; }
        public string category { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraT> CompraT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackT> TrackT { get; set; }
    }
}
