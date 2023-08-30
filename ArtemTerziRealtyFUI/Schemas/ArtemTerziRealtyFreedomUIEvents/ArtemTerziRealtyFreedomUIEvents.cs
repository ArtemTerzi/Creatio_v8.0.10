 namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Common;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    [EntityEventListener(SchemaName = "ArtemTerziRealtyFUI")]
    public class RealtyEntityEventListener : BaseEntityEventListener
    {
        public override void OnInserting(object sender, EntityBeforeEventArgs e)
        {
            base.OnInserting(sender, e);
            Entity realty = (Entity)sender;
            decimal price = realty.GetTypedColumnValue<decimal>("ArtemTerziPriceUSD");
            if (price > 1000000000)
            {
                e.IsCanceled = true;

                string messageTemplate = new LocalizableString(realty.UserConnection.ResourceStorage, 
                    "ArtemTerziRealtyFreedomUIEvents", "LocalizableStrings.ValueIsTooBig.Value").ToString();

                string message = string.Format(messageTemplate, "1.0B$");
                throw new Exception(message);
            }
        }
    }
}