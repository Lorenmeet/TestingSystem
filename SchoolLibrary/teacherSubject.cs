//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class teacherSubject
    {
        public int id { get; set; }
        public Nullable<int> teacherId { get; set; }
        public Nullable<int> subjectId { get; set; }
    
        public virtual subject subject { get; set; }
        public virtual teacher teacher { get; set; }
    }
}