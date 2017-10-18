using System;
using System.Collections.Generic;

using AbstractFactory.Factory;
using Strategy;
using State;
using Builder;
using ExtensionMethods;
using Inheritance;
using ExplicitCast;
using Overload;
using Command;
using EII;
using Adapter;
using Composite;
using TemplateMethod;
using Indexer;
using System.Linq;
using StaticCtorException;
using Logger;
using PropertyInitializers;
using FPCircle;
using InterlockedTest;
using LazyTest;
using Coords;

namespace VSCode
{
    class Program
    {
        static void Main(string[] args)
        {           
            StructTest();
        }

        static void StructTest()
        {
            Coordinates coords;
            // error if struct contains unassigned fields
            coords.x = 1;
            coords.y = 2;

            coords.PrintCoordinates();
        }

        static void LazyTest()
        {
            var laiska = new LazyInit();
            laiska.Init();
        }

        static void Interlocked()
        {
            var locks = new LockTest();
            locks.Run();
            System.Console.WriteLine($"{LockTest.totalCount}");
        }

        static void FpCircle() 
        {
            var radius = 12.3;
            var circle = new FpCircle(radius);

            // get circle's info
            System.Console.WriteLine($"Circumference: {circle.Circumference}");
            System.Console.WriteLine($"Area: {circle.Area}");
            System.Console.WriteLine($"Radius {circle.Radius}");

            // get stats tuple
            var stats = circle.Stats;
            System.Console.WriteLine($"Area: {stats.Area}, Circumference: {stats.Circumference}");
        }

        static void FuncTest()
        {
            Func<int, int> triple = x => x * 3;
            var range = Enumerable.Range(1,3);
            // filter
            // .Select === Map in functional lang
            var triples = range.Select(triple);
            foreach (var item in triples)
            {
                System.Console.WriteLine(item);
            }
        }

        static void PropertyInitializers()
        {
            var test = new PropertyInitializerTest();
            
            System.Console.WriteLine($"TestInt: {test.TestInt}");
            System.Console.WriteLine($"Overridden in constructor from 200 to => {test.TestIntOverride}");
            System.Console.WriteLine($"Always same: {test.AlwaysSame}");                
        }

        static void Logger()
        {
            var logger = new LoggerTest();
            CombineIEnumerables();
        }

        static void CombineIEnumerables() 
        {
            var names = new string[] { "Risto", "Pertti", "Erska" };
            var ages = new int[] { 34, 64, 29 };
            var combined = names.Zip(ages, CombineNameAndAge);
            foreach (var item in combined)
            {
                System.Console.WriteLine(item);
            }
        }

        static string CombineNameAndAge(string name, int age) 
        {
            return name + " : " + age;
        }

        static void StaticCtorException()
        {
            try
            {
            // throws exception
            var str = ClassWithStaticCtor.Name;                
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Exception");
            }

            try 
            {
                // doesn't work
                var instance = new ClassWithStaticCtor();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Class is kaput");
            }            

        }

        static void Yield()
        {
            var someNumbers = Enumerable.Range(1, 10);
            var evenNumbers = GetEvenNumbersUsingYield(someNumbers);
            foreach (var number in evenNumbers)
            {
                System.Console.WriteLine($"Even number: {number}");
            }
        }

        static IEnumerable<int> GetEvenNumbersUsingYield(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if(number % 2 == 0) 
                {
                    yield return number;
                }
            }
        }

        static void Indexer()
        {
            var reiska = new Student();
            System.Console.WriteLine($"Reiskan toinen koenumero: {reiska[1]}");
        }

        static void TemplateMethod()
        {
            var jsonProvider = new JsonProvider();
            var dbProvider = new DbProvider();
            jsonProvider.RegisterProviders();
            dbProvider.RegisterProviders();
        }

        static void Composite()
        {
            var root = new Hoitotapahtuma("root", 0.0);
            var tapahtuma1 = new Hoitotapahtuma("Vastaanotto", 29.35);
            var tervehdys = new Toimenpide("Tervehdys", 12.95);
            var valohoito = new Toimenpide("Valohoito", 35.00);

            var tapahtuma2 = new Hoitotapahtuma("Kontrolli", 29.35);

            root.Add(tapahtuma1);
            tapahtuma1.Add(tervehdys);
            tapahtuma1.Add(valohoito);
            root.Add(tapahtuma2);
            tapahtuma2.Add(tervehdys);
            tapahtuma2.Add(valohoito);

            root.Display(1);            
            System.Console.WriteLine($"Total cost: {root.GetCost()}");
        }

        static void Adapter()
        {
            var mapAdapter = new MapAdpater();
            System.Console.WriteLine($"3D Map: {mapAdapter.Get3DMap()}");
        }

        static void EII()
        {
            Box box = new Box();
            IDimensions eiiBox = (IDimensions)box;

            // ei toimi, koska explicitly implemented interface -> private
            // System.Console.WriteLine(box.Width());

            // tää toimii
            System.Console.WriteLine(eiiBox.Width());
            System.Console.WriteLine(eiiBox.Height());
        }

        static void Command()
        {
            var cartUser = new Invoker();
            var hammer = new Product { Id = 1, Name = "Hammer", Price = 12.95 };
            var anvil = new Product { Id = 2, Name = "Anvil", Price = 270.00 };
            var nail = new Product { Id = 3, Name = "Nail", Price = 0.25 };

            cartUser.AddToCart(hammer);
            cartUser.AddToCart(anvil);
            cartUser.AddToCart(nail);
            cartUser.GetShoppingCartContents();

            cartUser.RemoveFromCart(hammer);
            cartUser.RemoveFromCart(anvil);
            cartUser.GetShoppingCartContents();
        }

        static void OptionalParameters(int i = 1)
        {
            System.Console.WriteLine($"optional param: {i}");
        }

        static void Overload()
        {
            short s = 12;
            OverloadTest.Display(s);
        }

        static void ExplicitCast()
        {
            var celsius = new Celsius(21.5f);
            var convertedFahr = (Fahrenheit)celsius;
            System.Console.WriteLine($"Celsius {celsius.Degrees} converted to Fahrenheit {convertedFahr.Degrees}");

            var fahrenheit = new Fahrenheit(70.7f);
            var convertedCelsius = (Celsius)fahrenheit;
            System.Console.WriteLine($"Fahrenheit {fahrenheit.Degrees} converted to Celsius {convertedCelsius.Degrees}");
        }

        static void Inheritance()
        {
            var derived = new Derived();
        }

        static void ExtensionMethods()
        {
            string s = "Testing string word counter extension";
            var wordCount = s.WordCount();
            System.Console.WriteLine(wordCount);
        }

        static void Builder()
        {
            var fighterBuilder = new FighterBuilder();
            var bomberBuilder = new BomberBuilder();
            var director = new Director(fighterBuilder);
            var fighter = director.Construct();
            System.Console.WriteLine(fighter.ToString());
            director = new Director(bomberBuilder);
            var bomber = director.Construct();
            System.Console.WriteLine(bomber.ToString());
        }

        static void State()
        {
            var context = new RiskContext();
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.IncreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
            context.DecreaseRisk(10);
        }

        static void Strategy()
        {
            var customer1 = new Prospect();
            var customer2 = new StandardCustomer();
            var customer3 = new GoldCustomer();

            var context = new Context();
            context.SetCustomerStrategy(customer1);
            System.Console.WriteLine("Customer1 discount rate: " + context.GetCustomerDiscountRate());
            context.SetCustomerStrategy(customer2);
            System.Console.WriteLine("Customer2 discount rate: " + context.GetCustomerDiscountRate());
            context.SetCustomerStrategy(customer3);
            System.Console.WriteLine("Customer3 discount rate: " + context.GetCustomerDiscountRate());
        }

        static void AbstractFactory()
        {
            IAutoFactory toyotaFactory = new ToyotaFactory();
            IAutoFactory bmwFactory = new BmwFactory();

            var bmwLux = bmwFactory.CreateLuxuryAuto();
            var toyotaLux = toyotaFactory.CreateLuxuryAuto();
            var bmwBasic = bmwFactory.CreateBasicAuto();
            var toyotaBasic = toyotaFactory.CreateBasicAuto();

            System.Console.WriteLine(bmwLux.GetType().Name);
            System.Console.WriteLine(toyotaLux.GetType().Name);
            System.Console.WriteLine(bmwBasic.GetType().Name);
            System.Console.WriteLine(toyotaBasic.GetType().Name);
        }
    }
}
