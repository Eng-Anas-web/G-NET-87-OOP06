using Assignment_oop05.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        #region Constructor
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5);

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion
    }
}
