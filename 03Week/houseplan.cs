using System;

namespace _03Week
{

    public class Land
    {

        public string hoodName { get; set; }
        public int houses { get; set; }

        

    }

    public class House
    {

        
        public int floorNum { get; set; }
        public int rooms { get; set; }
        
    }
    public class Room
    {

        public string roomType { get; set; }
        public string color { get; set; }
        public string floorType { get; set; }
        public int lightFix {get;set;}

    }

}