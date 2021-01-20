using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //default constructor
        public Customer()
        {
            Orders = new List<Order>();
        }


        //constructor overloading with different attributes

        //just an id
        public Customer(int id)
            
            : this()//this line calls default constructor first than the constructor specified

        {
            Id = id;
        }

        //both, id and name
        public Customer(int id, string name)

            : this(id)//this line calls id constructor first then it calls default constructor than the constructor specified

        { 
            Name = name; 
        }
        
    }
}
