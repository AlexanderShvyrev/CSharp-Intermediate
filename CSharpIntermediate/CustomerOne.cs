using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class CustomerOne
    {
        public int Id;
        public string Name;
        public readonly List<OrderOne> Orders = new List<OrderOne>(); //readOnly avoids loosing information if List<OrderOne> is reinitialized somewhere else


        public CustomerOne(int id)
        {
            Id = id;
        }

        public CustomerOne(int id, string name)
            : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            //...
        }
    }
}
 