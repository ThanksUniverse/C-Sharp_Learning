using System;
namespace OrientacaoAObjetosC4
{
    class Program
    {
        static void Main()
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSouldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSouldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }

        public class Room
        {
            public int Seats { get; set; }
            private int SeatsInUse = 0;

            public Room(int seats)
            {
                Seats = seats;
                SeatsInUse = 0;
            }

            public void ReserveSeat()
            {
                if (SeatsInUse >= Seats)
                {
                    OnRoomSoldOut(EventArgs.Empty);
                }
                else
                {
                    SeatsInUse++;
                    Console.WriteLine($"SeatsInuse: {SeatsInUse} : Seats: {Seats}");
                }
            }

            public event EventHandler RoomSoldOutEvent;

            protected virtual void OnRoomSoldOut(EventArgs e)
            {
                EventHandler handler = RoomSoldOutEvent;
                handler?.Invoke(this, e);
            }

        }
    }
}