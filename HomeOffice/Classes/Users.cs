using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail2.Classes
{
    public class User
    {
        public int ID { get; set; }
        public String FIRSTNAME { get; set; }
        public String LASTNAME { get; set; }
        public String PASSWORD { get; set; }
        public Boolean ADMIN { get; set; }
        public String ADRESS1 { get; set; }
        public String ADRESS2 { get; set; }
        public String CITY { get; set; }
        public String STATE { get; set; }
        public int FISCAL { get; set; }
        public String SCHOOL { get; set; }
        public String CLASS_NAME { get; set; }
        public int CLASS_NUMBER { get; set; }
        public String PHONE { get; set; }
        public String EMAIL { get; set; }
        public String DATECREATED { get; set; }
		public String INFO { get; set; }
        public String DATACONNECTION { get; set; }
    }
}
