using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public class Deparment
    {
        private int _id = 0;
        private string _shortName = string.Empty;
        private string _longName = string.Empty;

        public int Id { get { return _id; } set { _id = value; } }
        public string ShortName { get { return _shortName; } set { _shortName = value; } }
        public string LongName { get { return _longName; } set { _longName = value; } }

        public Deparment(int id, string shortName, string longName)
        {
            Id = id;
            ShortName = shortName;
            LongName = longName;
        }
    }
}
