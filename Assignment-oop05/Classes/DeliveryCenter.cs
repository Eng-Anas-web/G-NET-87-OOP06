using Assignment_oop05.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public class DeliveryCenter
    {
        #region Feilds
        private Shipment[] _shipment;
        #endregion

        public DeliveryCenter()
        {
            _shipment = new Shipment[20];
        }

        #region Indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipment.Length)
                {
                    return _shipment[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 && index < _shipment.Length)
                {
                    _shipment[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipment.Length; i++)
                {
                    if (_shipment[i].TrackingCode == trackingCode)
                    {
                        return _shipment[i];
                    }
                }

                return default;
            }
        }

        #endregion


        #region Methodes
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i] == null)
                {
                    _shipment[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string tracingCode)
        {
            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i] != null && _shipment[i].TrackingCode == tracingCode)
                {
                    _shipment[i] = null;
                    return true;
                }

            }
            return false;
        }

        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < 20; i++)
            {
                if (_shipment[i] != null)
                {
                    Console.WriteLine(((ITrackable)_shipment[i]).GetTrackingStatus());
                }
            }
        }
        #endregion
    }
}
