using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public static class ShipmentExtensions
    {

        
        public static string GetSummary(this Shipment shipment)
        {

            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight}KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if(shipment != null && string.Equals(shipment.TrackingStatus , "Delivered", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
