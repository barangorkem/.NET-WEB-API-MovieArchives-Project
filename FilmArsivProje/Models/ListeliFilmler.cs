//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmArsivProje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListeliFilmler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListeliFilmler()
        {
            this.ListeliFilmKategori = new HashSet<ListeliFilmKategori>();
            this.ListeliFilmOyuncu = new HashSet<ListeliFilmOyuncu>();
            this.ListeliFilmYorumları = new HashSet<ListeliFilmYorumları>();
            this.FilmElestirileri = new HashSet<FilmElestirileri>();
        }
    
        public int filmid { get; set; }
        public string filmadi { get; set; }
        public string filmicerik { get; set; }
        public string filmresim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListeliFilmKategori> ListeliFilmKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListeliFilmOyuncu> ListeliFilmOyuncu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListeliFilmYorumları> ListeliFilmYorumları { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmElestirileri> FilmElestirileri { get; set; }
    }
}
