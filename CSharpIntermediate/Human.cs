using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class Human
        {
            private DateTime _birthday; //cannot access this field from the instance of a class

            public void SetBirthdate(DateTime birthday)
            {
                _birthday = birthday;

            }

            public DateTime GetBirthday()
            {
                return _birthday;
            }
        }

    }
}
