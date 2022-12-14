//@GeneratedCode
namespace QTPriceChecker.WebApi.Controllers.Base
{
    ///
    /// Generated by the generator
    ///
    public sealed partial class SupplierXProductsController : Controllers.GenericController<QTPriceChecker.Logic.Entities.Base.SupplierXProduct, QTPriceChecker.WebApi.Models.Base.SupplierXProductEdit, QTPriceChecker.WebApi.Models.Base.SupplierXProduct>
    {
        ///
        /// Generated by the generator
        ///
        static SupplierXProductsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public SupplierXProductsController(QTPriceChecker.Logic.Contracts.Base.ISupplierXProductsAccess<QTPriceChecker.Logic.Entities.Base.SupplierXProduct> other)
        : base(other)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        protected override QTPriceChecker.WebApi.Models.Base.SupplierXProduct ToOutModel(QTPriceChecker.Logic.Entities.Base.SupplierXProduct accessModel)
        {
            var handled = false;
            var result = default(QTPriceChecker.WebApi.Models.Base.SupplierXProduct);
            BeforeToOutModel(accessModel, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = QTPriceChecker.WebApi.Models.Base.SupplierXProduct.Create(accessModel);
            }
            AfterToOutModel(result);
            return result;
        }
        partial void BeforeToOutModel(QTPriceChecker.Logic.Entities.Base.SupplierXProduct accessModel, ref QTPriceChecker.WebApi.Models.Base.SupplierXProduct? outModel, ref bool handled);
        partial void AfterToOutModel(QTPriceChecker.WebApi.Models.Base.SupplierXProduct outModel);
    }
}
