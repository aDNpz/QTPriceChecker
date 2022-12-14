//@GeneratedCode
namespace QTPriceChecker.AspMvc.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class ProductXSupplier
    {
        ///
        /// Generated by the generator
        ///
        static ProductXSupplier()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public ProductXSupplier()
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
        public System.Decimal MinPrice
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Decimal MaxPrice
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
        public QTPriceChecker.AspMvc.Models.Base.Supplier? Supplier
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public QTPriceChecker.AspMvc.Models.Base.Product? Product
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Collections.Generic.List<QTPriceChecker.AspMvc.Models.App.PriceHistory> PriceHistories
        {
            get;
            set;
        }
        = new();
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.ProductXSupplier Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.AspMvc.Models.Base.ProductXSupplier();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.ProductXSupplier Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.AspMvc.Models.Base.ProductXSupplier();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.AspMvc.Models.Base.ProductXSupplier Create(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.AspMvc.Models.Base.ProductXSupplier();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
        static partial void AfterCreate(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier instance, QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                SupplierId = other.SupplierId;
                ProductId = other.ProductId;
                MinPrice = other.MinPrice;
                MaxPrice = other.MaxPrice;
                CurrentPrice = other.CurrentPrice;
                Supplier = other.Supplier != null ? QTPriceChecker.AspMvc.Models.Base.Supplier.Create((object)other.Supplier) : null;
                Product = other.Product != null ? QTPriceChecker.AspMvc.Models.Base.Product.Create((object)other.Product) : null;
                PriceHistories = other.PriceHistories.Select(e => QTPriceChecker.AspMvc.Models.App.PriceHistory.Create((object)e)).ToList();
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.Base.ProductXSupplier other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                SupplierId = other.SupplierId;
                ProductId = other.ProductId;
                MinPrice = other.MinPrice;
                MaxPrice = other.MaxPrice;
                CurrentPrice = other.CurrentPrice;
                Supplier = other.Supplier;
                Product = other.Product;
                PriceHistories = other.PriceHistories;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.AspMvc.Models.Base.ProductXSupplier other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.ProductXSupplier other)
            {
                result = IsEqualsWith(RowVersion, other.RowVersion)
                && Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(SupplierId, ProductId, MinPrice, MaxPrice, CurrentPrice, Supplier, HashCode.Combine(Product, PriceHistories, RowVersion, Id));
        }
    }
}
