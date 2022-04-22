using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Reservation
    {
        public User Madeby { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;

            if (Madeby == user)
                return true;
            return false;
        }

    }
    public class User
    {
        public bool IsAdmin { get; set; }
    }
}

