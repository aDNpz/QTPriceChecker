//@GeneratedCode
namespace QTPriceChecker.WebApi.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class SupplierXProductEdit
    {
        ///
        /// Generated by the generator
        ///
        static SupplierXProductEdit()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public SupplierXProductEdit()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.Int32 SupplierId
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Int32 ProductId
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Decimal CurrentPrice
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.WebApi.Models.Base.Supplier? Supplier
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.WebApi.Models.Base.Product? Product
        {
            get;
            set;
        }
    }
}
