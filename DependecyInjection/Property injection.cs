//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DependecyInjection
//{
//   class Property_injection
//   {
//      public interface IService
//      {
//         void Serve();
//      }

//      public class Service : IService
//      {
//         public void Serve()
//         {
//            Console.WriteLine("Service Called");
//            //To Do: Some Stuff
//         }
//      }

//      public class Client
//      {
//         private IService _service;

//         public IService Service
//         {
//            set
//            {
//               this._service = value;
//            }
//         }

//         public void Start()
//         {
//            Console.WriteLine("Service Started");
//            this._service.Serve();
//            //To Do: Some Stuff
//         }
//      }
//      class Program
//      {
//         static void Main(string[] args)
//         {
//            Client client = new Client();
//            client.Service = new Service();
//            client.Start();

//            Console.ReadKey();
//         }
//      }
//   }
//}
