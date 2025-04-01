using System;
                using System.Collections.Generic;
                using System.Linq;
                using HotelBookingSystem.Models;
                using HotelBookingSystem.Data.Repository;
                
                namespace HotelBookingSystem.Services.Facade
                {
                    public class BookingFacade
                    {
                        private readonly BookingRepository _bookingRepository;
                        private readonly CustomerRepository _customerRepository;
                        private readonly RoomRepository _roomRepository;
                        public BookingFacade(BookingRepository bookingRepository, CustomerRepository customerRepository, RoomRepository roomRepository)
                        {
                            _bookingRepository = bookingRepository;
                            _customerRepository = customerRepository;
                            _roomRepository = roomRepository;
                        }
                
                        public void CreateBooking(Booking booking)
                        {
                            // Logic to create a booking
                            _bookingRepository.Add(booking);
                        }
                
                        public Booking GetBooking(int bookingId)
                        {
                            // Logic to retrieve a booking by ID
                            return _bookingRepository.GetById(bookingId);
                        }
                
                        public List<Booking> GetAllBookings()
                        {
                            // Logic to retrieve all bookings
                            return _bookingRepository.GetAll().ToList();
                        }
                
                        public void UpdateBooking(Booking booking)
                        {
                            // Logic to update a booking
                            _bookingRepository.Update(booking);
                        }
                
                        public void DeleteBooking(int bookingId)
                        {
                            // Logic to delete a booking
                            _bookingRepository.Delete(bookingId);
                        }
                
                        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
                        {
                            // Get all rooms and all bookings
                            var rooms = _roomRepository.GetAll().ToList();
                            var bookings = _bookingRepository.GetAll();
                            
                            // Filter out rooms that are booked during the specified date range
                            var bookedRoomIds = bookings
                                .Where(b => (startDate < b.EndDate && endDate > b.StartDate))
                                .Select(b => b.RoomId)
                                .ToList();
                            
                            return rooms.Where(r => !bookedRoomIds.Contains(r.RoomId)).ToList();
                        }
                
                        public Customer GetCustomer(int customerId)
                        {
                            // Logic to retrieve a customer by ID
                            return _customerRepository.GetById(customerId);
                        }
                
                        public void AddCustomer(Customer customer)
                        {
                            // Logic to add a new customer
                            _customerRepository.Add(customer);
                        }
                    }
                }