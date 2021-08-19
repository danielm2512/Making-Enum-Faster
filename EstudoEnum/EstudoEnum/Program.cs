using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace EstudoEnum
{
    public class Program
    {
        static void Main(string[] args)
        {

            //notamos as diveras formas de usar o Enum, dependendo da letra que vc utilizar no ToString ira ter um retorno diferente

            //var simpleString = HumanStates.Working.ToString("G");
            //var flags = HumanStates.Working.ToString("F");
            //var inText = HumanStates.Working.ToString("D");
            //var hexText = HumanStates.Working.ToString("X");


            //Console.WriteLine(simpleString);
            //Console.WriteLine(flags);
            //Console.WriteLine(inText);
            //Console.WriteLine(hexText);

            
            BenchmarkRunner.Run<Benchy>();
            



        }

        [MemoryDiagnoser]
        public class Benchy
        {
            [Benchmark]
            public string NativeString()
            {
                //notamos que o NativeString demora em torno de 40ns e aloca 24B de memoria
                return HumanStates.Dead.ToString();
            }

            [Benchmark]
            public string FastToString()
            {
                //notamos que dessa maneira demora 1ns e aloca 0B de memoria
                return FastToString(HumanStates.Dead);
            }

            private static string FastToString(HumanStates states)
            {
                switch (states)
                {
                    case HumanStates.Idle:
                        return nameof(HumanStates.Idle);
                    case HumanStates.Working:
                        return nameof(HumanStates.Working);
                    case HumanStates.Sleeping:
                        return nameof(HumanStates.Sleeping);
                    case HumanStates.Eating:
                        return nameof(HumanStates.Eating);
                    case HumanStates.Dead:
                        return nameof(HumanStates.Dead);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(states), states, null);

                }
            }
        }

        


        public enum HumanStates
        {
            Idle,
            Working,
            Sleeping,
            Eating,
            Dead
        }
    }
}
