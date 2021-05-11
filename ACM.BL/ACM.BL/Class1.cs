using System;

namespace ACM.BL
{
    public class Customer
    {

        public int  CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName
        {
            get;
            set;
        }
        public string FullName
        {
            get
            {
                return LastName+ ", "+ FirstName;
            }
        }  

        private string _lastname;
        private string firstname;

        public string LastName
        {

            get { return _lastname; }
            set { _lastname = value; }
        }


    }
}
