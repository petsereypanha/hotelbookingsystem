using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Services.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class BookingNotifier
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void BookingCreated(string bookingDetails)
        {
            Notify($"New booking created: {bookingDetails}");
        }

        public void BookingCancelled(string bookingDetails)
        {
            Notify($"Booking cancelled: {bookingDetails}");
        }
    }
}