using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            Building building = new Building();
            
            building.Height = 100;
            building.FloorsAmount = 9;
            building.ApartamentAmount = 200;
            building.EntranceAmount = 3;

            Console.WriteLine(building.Number); // 1
            Console.WriteLine(building.GetFloorHeight());
            Console.WriteLine(building.GetFlatsInEntranceAmount());
            Console.WriteLine(building.GetFlatsOnFloorAmount());
            Console.WriteLine(building.GetFlatsOnFloorInEntranceAmount());
            
            Console.WriteLine("------------");
            Building building2 = new Building();
            Console.WriteLine(building.Number);  // 2
        }
    }
}