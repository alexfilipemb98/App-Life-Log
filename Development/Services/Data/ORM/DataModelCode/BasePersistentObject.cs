using DevExpress.Xpo;
using System;
namespace Data.ORM.DataModelCode
{

    public partial class BasePersistentObject
    {
        public BasePersistentObject() { }
        public BasePersistentObject(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();

            EdittingMode = false;
            SavingMode = false;
        }

        protected override void OnLoading()
        {
            base.OnLoading();

            EdittingMode = true;
            SavingMode = false;
        }

        protected override void OnSaving()
        {
            if (!SavingMode)
            {
                //Session.Delete(this);
                return;
            }

            if (Session.IsNewObject(this))
            {
                Id = Id != Guid.Empty ? Id : Guid.NewGuid();
                CreatedAt = DateTime.Now;
            }

            UpdatedAt = DateTime.Now;

            base.OnSaving();
        }

        protected override void OnSaved()
        {
            base.OnSaved();

            EdittingMode = true;
            SavingMode = false;
        }
    }

}
