using System;
namespace LeetcodeProblems {
    public class EnumHelper {
        enum Fruits {
            Apple = 1,
            Mango = 2,
            Grapes = 3,
            Pineple = 4,
            Orange = 5

        }
        public void MainMethod() {

            //foreach (string s in Enum.GetNames(typeof(Fruits)))
            //    Console.WriteLine(s);

            //string name = Enum.GetName(typeof(Fruits), 2);
            //Console.WriteLine(name);


            int mangoInt = 2;
            //var mangovar = GetEnumValue<Fruits>(mango);
            //Console.WriteLine(mangovar);

            //Fruits foo = (Fruits)Enum.Parse(typeof(Fruits), mango.ToString());
            //Console.WriteLine("type" + foo);
            Fruits fruitsValue = GetEnumFromInt<Fruits>(mangoInt);
            Console.WriteLine(fruitsValue);

            int appleInt = 1;
            Fruits apple = (Fruits)Enum.Parse(typeof(Fruits), appleInt.ToString());
            Console.WriteLine(apple);
        }

        public static T GetEnumValue<T>(int intValue) where T : struct, IConvertible {
            Type enumType = typeof(T);
            if (!enumType.IsEnum) {
                throw new Exception("T must be an Enumeration type.");
            }

            return (T)Enum.ToObject(enumType, intValue);
        }

        public static T GetEnumFromInt<T>(int intValue) where T : struct, IConvertible {
            T foo = (T)Enum.Parse(typeof(T), intValue.ToString());
            return foo;
        }


    }
}
