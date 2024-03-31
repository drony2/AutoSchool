//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoSchool.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarDistribution = new HashSet<CarDistribution>();
            this.DecommissionedCars = new HashSet<DecommissionedCars>();
        }
    
        public int Id { get; set; }
        public string CarNum { get; set; }
        public int IdBodyType { get; set; }
        public int IdDrive { get; set; }
        public int IdCarBrand { get; set; }
        public string Model { get; set; }
        public int IdCountry { get; set; }
        public string YearRelease { get; set; }
        public bool State { get; set; }
        public string StateNumber { get; set; }
        public int IdColor { get; set; }
        public int IdTypeKPP { get; set; }
        public int IdEngineCapacity { get; set; }
    
        public virtual BodyType BodyType { get; set; }
        public virtual CarBrand CarBrand { get; set; }
        public virtual Color Color { get; set; }
        public virtual Country Country { get; set; }
        public virtual Drive Drive { get; set; }
        public virtual EngineCapacity EngineCapacity { get; set; }
        public virtual TypeKPP TypeKPP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarDistribution> CarDistribution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DecommissionedCars> DecommissionedCars { get; set; }
    }
}