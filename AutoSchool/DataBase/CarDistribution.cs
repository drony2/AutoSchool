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
    
    public partial class CarDistribution
    {
        public int Id { get; set; }
        public int IdCar { get; set; }
        public int IdEmployee { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
