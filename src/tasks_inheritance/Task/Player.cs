using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Player : Person
    {
        private string _position;
        private DateTime _joinDate;
        public string Position { get { return _position; } set {  _position = value; } }
        public DateTime JoinDate { get { return _joinDate; } set { _joinDate = value; } }
        public Player(string firstName, string lastName, DateTime birthDate, string position, DateTime joinDate) : base(firstName, lastName, birthDate)
        {
            Position = position;
            JoinDate = joinDate;
        }
        public Player() : base()
        {
            Position = "default";
            JoinDate = DateTime.Now;
        }
        public override string ToString()
        {
            return base.ToString() + $", position: {Position}, team joining date: {JoinDate.ToShortDateString()}";
        }
    }
}
