//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lagu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public long Id_album { get; set; }
        public Nullable<int> jml_album { get; set; }
        public string nama_album_ { get; set; }
        public Nullable<int> tahun { get; set; }
        public string foto_album { get; set; }
        public long id_genre { get; set; }
        public long id_band { get; set; }
    }
}