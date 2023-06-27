using System;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            var context = new DataContext<Person, Payment, Subscription>();
            context.Save(person);
        }
    }

    public class DataContext<P, PA, S>
        where P : IPerson
        where PA : Payment
        where S : Subscription
    {
        public void Save(P entity)
        {

        }

        public void Save(PA entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public class Person : IPerson
    {

    }

    public class Payment
    {

    }

    public class Subscription
    {

    }

    public interface IPerson
    {

    }
}