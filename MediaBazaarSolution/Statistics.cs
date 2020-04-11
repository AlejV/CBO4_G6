using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarSolution
{
    public class Statistics
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string position { get; set; }
        public string department { get; set; }

        public Statistics(int id, string firstName, string position, string department)
        {
            this.id = id;
            this.firstName = firstName;
            this.position = position;
            this.department = department;

        }

        public string[] GetDetails()
        {
            string[] details = new string[3];
            //details[0] = firstName;
            details[0] = position;
            details[1] = department;
            return details;
        }
        public override string ToString()
        {
            return $"{id}, {firstName}, {position}";
       
        }
    }
}
