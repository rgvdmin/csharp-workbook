using System;

namespace _03Week
{
    class Program
    {
        static void Main(string[] args)
        {




            RockPaperScissors rockgame = new RockPaperScissors();
            rockgame.Run();





            // //get the name of the hood
            // Console.WriteLine("What u want yo hood to be called?");
            // Land land = new Land();
            // land.hoodName = Console.ReadLine();
            // Console.WriteLine("Your hood name be called {0}", land.hoodName);
            // Console.WriteLine("How many traps should {0} be having?", land.hoodName);
            // land.houses = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("so you saying u wanna have {0} many traps at this hood named {1}?", land.houses, land.hoodName);
            // int countHouse = 1;
            // int countFloor = 1;
            // int countRooms = 1;
            // while (countHouse <= land.houses)
            // {

            //     House house = new House();
            //     Console.WriteLine("So in house {0}, how many floors do you want this trap to be?", countHouse);
            //     house.floorNum = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("so you saying u wanna have {0} many floors at this pad", house.floorNum);
            //     while (countFloor <= house.floorNum)
            //     {

            //         Console.WriteLine("How many rooms would you like?");
            //         house.rooms = Convert.ToInt32(Console.ReadLine());
            //         string response = string.Format("Your house has {0} Rooms;", house.rooms);
            //         Console.WriteLine(response);

            //         while (countRooms <= house.rooms)
            //         {
            //             Room room = new Room();

            //             Console.WriteLine("what kind of room is room #{0}?", countRooms);
            //             room.roomType = Console.ReadLine();

            //             Console.WriteLine("what color is this room?");
            //             room.color = Console.ReadLine();

            //             Console.WriteLine("what floor for this here room?");
            //             room.floorType = Console.ReadLine();

            //             Console.WriteLine("how many lights do you want in here?");
            //             room.lightFix = Convert.ToInt32(Console.ReadLine());

            //             Console.WriteLine("This room is a {0}, that is color {1}, with the {3} type floors, with {4} lighting fixtures.", room.roomType, room.color, room.floorType, room.lightFix);




            //             countRooms++;

            //         }
            //         countFloor++;
            //     }
            // }
        }
    }
}
