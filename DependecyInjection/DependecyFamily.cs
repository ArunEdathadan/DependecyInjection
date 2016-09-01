using System;

namespace DependencyInjection
{
   class DependencyFamily
   {
      static void Main(string[] args)
      {
         ElderSon Eson = new ElderSon();
         Dad dad = new Dad(Eson);
         Console.WriteLine(dad.NotifySon("Get me the knife"));


         YoungerSon Yson = new YoungerSon();
         Dad dad2 = new Dad(Yson);
         Console.WriteLine(dad2.NotifySon("Get me the fork").ToString());


         Mom mom = new Mom();
         Console.WriteLine(mom.NotifySon(Yson, "Help Me"));
         Console.WriteLine(mom.NotifySon(Eson, "Help Me"));


         StepFather StFather = new StepFather();
         StFather.FirstSon = Yson;
         StFather.SecondSon = Eson;
         Console.WriteLine(StFather.NotifySon("Get the hell out of the house"));


         StepMother StMother = new StepMother();
         StMother.FirstSon = Yson;
         Console.WriteLine(StMother.NotifySon("First son get out, second son may stay"));


         Console.ReadKey();
      }

      public interface ISon
      {
         string Help(string Message);
      }

      public class ElderSon : ISon
      {
         public string Help(string Message)
         {
            Console.WriteLine(Message);
            return "Elder son helping";
         }
      }

      public class YoungerSon : ISon
      {
         public string Help(string Message)
         {
            Console.WriteLine(Message);
            return "Younger Son Helping";
         }
      }

      public class Dad
      {
         ISon son = null;
         public Dad(ISon SelectedSon)
         {
            son = SelectedSon;
         }


         public string GetHelp(ISon Cson, string Message)
         {
            return Cson.Help(Message);
         }


         public string NotifySon(string Message)
         {
            return son.Help(Message);
         }
        
      }

      public class Mom
      {
         public string NotifySon(ISon Cson, string Message)
         {
            return Cson.Help(Message);
         }
                 
      }

      public class StepFather
      {
         public ISon FirstSon { get; set; }
         public ISon SecondSon { get; set; }
         public string NotifySon(string Message)
         {
            FirstSon.Help(Message);
            SecondSon.Help(Message);
            return "Both are kicked out";
         }

      }

      public class StepMother
      {
         public ISon FirstSon { get; set; }
         public ISon SecondSon { get; set; }
         public string NotifySon(string Message)
         {
            string Result = "";
            if (FirstSon != null)
            {
               FirstSon.Help(Message);
               Result += "First one kicked out ";
            }

            if (SecondSon != null)
            {
               Result += "Second one kicked out";
               SecondSon.Help(Message);
            }

            return Result;
         }

      }
   }
}