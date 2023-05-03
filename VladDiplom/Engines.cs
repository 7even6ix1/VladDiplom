//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VladDiplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Engines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Engines()
        {
            this.TechInformation = new HashSet<TechInformation>();
        }
    
        public int Id { get; set; }
        public int Type { get; set; }
        public int Volume { get; set; }
        public int Fuel { get; set; }
        public int Cilinders { get; set; }
        public string Name { get; set; }
    
        public virtual EngineTypes EngineTypes { get; set; }
        public virtual EngineVolume EngineVolume { get; set; }
        public virtual FuelType FuelType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechInformation> TechInformation { get; set; }
    }
}