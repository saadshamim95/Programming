//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Main class Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("1: Singleton Design Pattern");
            Console.WriteLine("2: Factory Design Pattern");
            Console.WriteLine("3: Prototype Design Pattern");
            Console.WriteLine("4: Adapter Design Pattern");
            Console.WriteLine("5: Facade Design Pattern");
            Console.WriteLine("6: Proxy Design Pattern");
            Console.WriteLine("7: Observer Design Pattern");
            Console.WriteLine("8: Visitor Design Pattern");
            Console.WriteLine("9: Mediator Design Pattern");
            Console.WriteLine("10: Reflection");
            Console.WriteLine("11: LateBinding using Reflection");
            Console.WriteLine("12: Dependency Injection");
            Console.WriteLine("13: Exception Handling");
            Console.Write("Enter you choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    SingletonMain singletonMain = new SingletonMain();
                    singletonMain.CreateObject();
                    break;
                case 2:
                    FactoryProgram factoryProgram = new FactoryProgram();
                    factoryProgram.Test();
                    break;
                case 3:
                    PrototypeMain prototypeMain = new PrototypeMain();
                    prototypeMain.Test();
                    break;
                case 4:
                    AdapterMain adapterMain = new AdapterMain();
                    adapterMain.Test();
                    break;
                case 5:
                    FacadeMain facadeMain = new FacadeMain();
                    facadeMain.Test();
                    break;
                case 6:
                    ProxyMain proxyMain = new ProxyMain();
                    proxyMain.Test();
                    break;
                case 7:
                    ObserverMain observerMain = new ObserverMain();
                    observerMain.Test();
                    break;
                case 8:
                    ShoppingCartClient shoppingCartClient = new ShoppingCartClient();
                    shoppingCartClient.Test();
                    break;
                case 9:
                    ChatClient chatClient = new ChatClient();
                    chatClient.Test();
                    break;
                case 10:
                    ReflectionProgram reflectionProgram = new ReflectionProgram();
                    reflectionProgram.Test();
                    break;
                case 11:
                    Reflection.LateBinding lateBinding = new Reflection.LateBinding();
                    lateBinding.Test();
                    break;
                case 12:
                    DependencyInjection dependencyInjection = new DependencyInjection();
                    dependencyInjection.Test();
                    break;
                case 13:
                    ExceptionHandling exceptionHandling = new ExceptionHandling();
                    exceptionHandling.Test();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }            
        }
    }
}