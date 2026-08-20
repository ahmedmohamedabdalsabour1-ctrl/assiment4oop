using System;
using System.Collections.Generic;
using System.Text;

namespace assiment4oop
{
    public class DeliveryCenter
    {
        private List<Shipment> shipments = new List<Shipment>();

        public void AddShipment(Shipment shipment)
        {
            if (shipment == null)
                throw new ArgumentNullException(nameof(shipment));

            shipments.Add(shipment);
        }
        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine("------------------------------------------");
            }
        }
        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in shipments)
            {
                ITrackable trackable = (ITrackable)shipment;
                Console.WriteLine(trackable.GetTrackingStatus());
            }
        }
    }
}
