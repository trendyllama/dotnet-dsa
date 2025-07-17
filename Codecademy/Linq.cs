

namespace dotnet_dsa.Codecademy
{
   class ExampleLinq
    {

        static void Run()
        {
            List<double> marathons = [144.07, 143.12];

            List<double> marathons2 = [144.07, 143.12, 146.73, 146.33,];

            // Do not delete the code below
            double time = marathons2[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

            Console.WriteLine(marathons[1]);

            var filteredMarathons = from marathon in marathons2
                                    where marathon < 145
                                    select marathon;

            Console.WriteLine("Marathons under 145 minutes:");
            foreach (var marathon in filteredMarathons)
            {
                Console.WriteLine(marathon);
            }
        }
    }
}