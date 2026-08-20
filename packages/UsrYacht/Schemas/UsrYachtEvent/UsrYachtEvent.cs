namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Common;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    [EntityEventListener(SchemaName = "UsrYacht")] // decorator tell its an eventlistener having schema name UrsYacht
    public class YachtEntityEventListener : BaseEntityEventListener
    {
        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            base.OnSaving(sender, e); // implement base and then run other lines
            Entity yacht = (Entity)sender; // down cast object to entity
            decimal price = yacht.GetTypedColumnValue<decimal>("UsrPrice"); //get yacht UrsPrice
            if (price > 100000)
            {
                e.IsCanceled = true; //silent cancelation of operation not db level

                string messageTemplate = new LocalizableString(yacht.UserConnection.ResourceStorage, //conection of metadata and csharp code, localized message like we did in validation
                    "UsrYachtEvents", "LocalizableStrings.ValueIsTooBig.Value").ToString();

                string message = string.Format(messageTemplate, "100 000 EUR");
                throw new Exception(message);
            }
        }
    }
}