//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrarySchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionVariant
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int VariantID { get; set; }
        public Nullable<bool> IsCorrect { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Variant Variant { get; set; }
    }
}
