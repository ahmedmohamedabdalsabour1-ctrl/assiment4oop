using System;
using System.Collections.Generic;
using System.Text;

namespace assiment4oop
{
    public abstract class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }
        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentException("Tracking code cannot be empty.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty.");

            if (weight <= 0)
                throw new ArgumentException("Weight must be greater than 0.");

            if (deliveryFee < 0)
                throw new ArgumentException("Delivery fee cannot be negative.");

            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();


    }
}
