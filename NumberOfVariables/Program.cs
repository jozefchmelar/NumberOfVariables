using System;
using System.Linq;
using Plc;
using Vortex.Connector.ValueTypes;

namespace NumberOfVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            var shouldBe5 = NumberOfVariables(typeof(StructWith5Variables));
            var shouldBe68 = NumberOfVariables(typeof(StructWith68Variables));
            var shouldBe50 = NumberOfVariables(typeof(StructWith50Variables));
            Console.WriteLine(shouldBe5);
            Console.WriteLine(shouldBe68);
            Console.WriteLine(shouldBe50);

            //write the values to the plc
            Entry.Plc.Connector.BuildAndStart();
            Entry.Plc.MAIN.ShouldBe5.Cyclic = (short)shouldBe5;
            Entry.Plc.MAIN.ShouldBe68.Cyclic = (short)shouldBe68;
            Entry.Plc.MAIN.ShouldBe50.Cyclic = (short)shouldBe50;
            Console.Read();
        }
        private static int NumberOfVariables(Type ofType) => ofType
            .GetProperties()
            .Where(x => typeof(OnlinerBaseType).IsAssignableFrom(x.PropertyType))
            .Count();

    }

}
