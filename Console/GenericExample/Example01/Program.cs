using System;

namespace Example01
{
     class GenericExample<T>
        {
            private T genericVariable;

            public GenericExample(T genericValue)
            {
                this.genericVariable = genericValue;
            }

            public void Display()
            {
                Console.WriteLine(this.genericVariable);
            }
        }

        class Test
        {
            static void Main(string[] args)
            {
                GenericExample<int> g = new GenericExample<int>(5);

                GenericExample<string> g1 = new GenericExample<string>("Example of Generic");

                g.Display();
                g1.Display();
            }
        }
    }
