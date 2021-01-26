using System;

namespace CSharpIntermediate
{

    public class Human
            
    {
        //getters and setters 
        private DateTime _birthday; //cannot access this field from the instance of a class

        //or
        public string LastName { get; set; }

        public string Name { get; private set; } //CSharp compiler internally creates a private field. Keyword private means readonly, therefore you need to create a constructor for that field to have an access to it

        public Human(string name)
        {
            Name = name;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - _birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;

        }

        public DateTime GetBirthday()
        {
            return _birthday;
        }
    }

    
}
