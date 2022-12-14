//@GeneratedCode
namespace QTPriceChecker.AspMvc.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using TAccessModel = QTPriceChecker.Logic.Entities.Base.SupplierXProduct;
    using TViewModel = QTPriceChecker.AspMvc.Models.Base.SupplierXProduct;
    using TFilterModel = QTPriceChecker.AspMvc.Models.Base.SupplierXProductFilter;
    using TAccessContract = QTPriceChecker.Logic.Contracts.Base.ISupplierXProductsAccess<QTPriceChecker.Logic.Entities.Base.SupplierXProduct>;
    ///
    /// Generated by the generator
    ///
    public sealed partial class SupplierXProductsController : Controllers.FilterGenericController<TAccessModel, TViewModel, TFilterModel, TAccessContract>
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
        protected override string ControllerName => "SupplierXProducts";
        ///
        /// Generated by the generator
        ///
        public SupplierXProductsController(QTPriceChecker.Logic.Contracts.Base.ISupplierXProductsAccess<TAccessModel> other)
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
        protected override TViewModel ToViewModel(TAccessModel accessModel, ActionMode actionMode)
        {
            var handled = false;
            var result = default(TViewModel);
            BeforeToViewModel(accessModel, actionMode, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = TViewModel.Create(accessModel);
            }
            AfterToViewModel(result, actionMode);
            return BeforeView(result, actionMode);
        }
        partial void BeforeToViewModel(TAccessModel accessModel, ActionMode actionMode, ref TViewModel? viewModel, ref bool handled);
        partial void AfterToViewModel(TViewModel viewModel, ActionMode actionMode);
    }
}
