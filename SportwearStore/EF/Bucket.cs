//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportwearStore.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bucket
    {
        public int ID { get; set; }
        public int IDClient { get; set; }
        public int IDProduct { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Clothes Clothes { get; set; }
    }
}
