using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            //verificação dentro do construtor
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-Out date must be after Check-In date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public Reservation()
        {
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);     //pegar a diferença entre os dois instantes - datas
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                //lançar uma nova exceção personalizada
                throw new DomainException ("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException ("Error in reservation: Check-Out date must be after Check-In date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", Check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
}
