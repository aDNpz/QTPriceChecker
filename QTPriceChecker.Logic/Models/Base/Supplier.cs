//@GeneratedCode
namespace QTPriceChecker.Logic.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class Supplier
    {
        ///
        /// Generated by the generator
        ///
        static Supplier()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public Supplier()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        new internal QTPriceChecker.Logic.Entities.Base.Supplier Source
        {
            get => (QTPriceChecker.Logic.Entities.Base.Supplier)(_source ??= new QTPriceChecker.Logic.Entities.Base.Supplier());
            set => _source = value;
        }
        public System.String Name
        {
            get => Source.Name;
            set => Source.Name = value;
        }
        public QTPriceChecker.Logic.Modules.Common.State State
        {
            get => Source.State;
            set => Source.State = value;
        }
        public System.Collections.Generic.List<QTPriceChecker.Logic.Models.Base.ProductXSupplier> ProductXSuppliers
        {
            get => Source.ProductXSuppliers.Select(e => QTPriceChecker.Logic.Models.Base.ProductXSupplier.Create(e)).ToList();
            set => Source.ProductXSuppliers = value.Select(e => e.Source).ToList();
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(QTPriceChecker.Logic.Entities.Base.Supplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Name = other.Name;
                State = other.State;
                ProductXSuppliers = other.ProductXSuppliers.Select(e => QTPriceChecker.Logic.Models.Base.ProductXSupplier.Create((object)e)).ToList();
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Entities.Base.Supplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Entities.Base.Supplier other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTPriceChecker.Logic.Models.Base.Supplier other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Name = other.Name;
                State = other.State;
                ProductXSuppliers = other.ProductXSuppliers;
                RowVersion = other.RowVersion;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTPriceChecker.Logic.Models.Base.Supplier other, ref bool handled);
        partial void AfterCopyProperties(QTPriceChecker.Logic.Models.Base.Supplier other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Supplier other)
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
            return HashCode.Combine(Name, State, ProductXSuppliers, RowVersion, Id);
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.Supplier Create()
        {
            BeforeCreate();
            var result = new QTPriceChecker.Logic.Models.Base.Supplier();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.Supplier Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new QTPriceChecker.Logic.Models.Base.Supplier();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.Supplier Create(QTPriceChecker.Logic.Models.Base.Supplier other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Base.Supplier();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTPriceChecker.Logic.Models.Base.Supplier Create(QTPriceChecker.Logic.Entities.Base.Supplier other)
        {
            BeforeCreate(other);
            var result = new QTPriceChecker.Logic.Models.Base.Supplier();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.Supplier instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.Supplier instance, object other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Models.Base.Supplier other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.Supplier instance, QTPriceChecker.Logic.Models.Base.Supplier other);
        static partial void BeforeCreate(QTPriceChecker.Logic.Entities.Base.Supplier other);
        static partial void AfterCreate(QTPriceChecker.Logic.Models.Base.Supplier instance, QTPriceChecker.Logic.Entities.Base.Supplier other);
    }
}
