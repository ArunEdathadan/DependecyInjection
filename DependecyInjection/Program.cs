//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DependecyInjection
//{
//   class Program
//   {
//      static void Main(string[] args)
//      {
//         Employee employee1 = new Employee(new LoggerOne());
//         Employee employee2 = new Employee(new LoggerTwo());

//         Console.ReadLine();
//      }
//   }
//   public class Employee
//   {
//      public Employee(ILogger logger)
//      {
//         logger.WriteToLog("New employee created");
//      }
//   }

//   public interface ILogger
//   {
//      void WriteToLog(string text);
//   }

//   public class LoggerOne : ILogger
//   {
//      public void WriteToLog(string text)
//      {
//         Console.WriteLine(text+"LoggerOne");
//      }
//   }

//   public class LoggerTwo : ILogger
//   {
//      public void WriteToLog(string text)
//      {
//         Console.WriteLine("***********\n {0}\n***********", text+"LoggerTwo");
//      }
//   }
//}
