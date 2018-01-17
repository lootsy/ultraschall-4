using System;
using System.Collections.Generic;
using System.Linq;

namespace ultraschall
{
   public class ImportApplication : Application, IActivation
   {
      public void Start() {
         Console.WriteLine("ImportApplication starting...");
         foreach(KeyValuePair<String, String> item in Options) {
            Console.WriteLine("{0} : {1}", item.Key, item.Value);
         }
      }
   }
}
