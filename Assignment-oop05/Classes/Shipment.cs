using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Assignment_oop05.Classes
{
    public  abstract partial class Shipment
    {
        #region Feilds
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;
        private static int TotalShipmentsCreated;


        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        #endregion

        #region Prop

        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }

        public abstract decimal EstimatedCost { get; }

        #endregion

        #region Constructor
        public Shipment(string trackingCode)
        {
            TotalShipmentsCreated++;
            _trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                _trackingCode = trackingCode;
            }
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;

        }

        #endregion

        #region Methodes
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
                {
                }
            }
        }

        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraWeight)
        {
            Weight = newWeight + extraWeight;
        }
        public abstract void PrintShipment();

        public Shipment CopyShipment(Shipment shipmentCopy)
        {
            Shipment shipment = shipmentCopy;
            return shipment;
        }

        public Shipment ShallowCopy()
        {
            Shipment original =(Shipment)MemberwiseClone();
            return original;
        }

        public Shipment DeepCopy()
        {
           
            Shipment deep = Serialization.Deep(this);
            return deep;
        }
        public static class Serialization
        {
            private static readonly JsonSerializerOptions options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            public static Shipment Deep(Shipment source)
            {
                string json = JsonSerializer.Serialize(source, source.GetType(), options);
                return (Shipment)JsonSerializer.Deserialize(json, source.GetType(), options);
            }
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated; 
        }


            partial void OnTrackingStatusChanged(string newStatus)
            {
                Console.WriteLine($"Tracking status changed to: {newStatus}");
            }
        
        #endregion
       
    }
}
