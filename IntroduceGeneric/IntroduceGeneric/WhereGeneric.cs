using System.Collections.Generic;

namespace IntroduceGeneric
{
    public class WhereGenericStruct<T> where T : struct
    {
        public T Value { get; set; }
    }

    public class WhereGenericClass<T> where T : class
    {
        public T Value { get; set; }
    }

    public class WhereGenericNew<T> where T : new()
    {
        public T Value { get; set; }

        WhereGenericNew(int a)
        {
            
        }
    }

    public class WhereGenericClassName<T> where T : Person
    {
        public T Value { get; set; } = null;

        WhereGenericClassName()
        {
            Value.GetName();
        }
    }

    public class WhereGenericInterfaceName<T> where T : IEnumerable<T>
    {
        public T Value { get; set; }
    }

    public class Person
    {
        public string GetName()
        {
            return "hwanhee";
        }
    }
}