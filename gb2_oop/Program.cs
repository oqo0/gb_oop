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
            
            Console.WriteLine(building.Number);
            
            
            Building building2 = new Building();
            Console.WriteLine(building.Number);
        }
    }
}