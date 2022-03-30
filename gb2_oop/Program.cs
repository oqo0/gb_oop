using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            Building building = Creator.CreateBuild(100, 8, 220, 4);
            
            Console.WriteLine(building.Number); // 1
            Console.WriteLine(building.GetFloorHeight());
            Console.WriteLine(building.GetFlatsInEntranceAmount());
            Console.WriteLine(building.GetFlatsOnFloorAmount());
            Console.WriteLine(building.GetFlatsOnFloorInEntranceAmount());
        }
    }
}