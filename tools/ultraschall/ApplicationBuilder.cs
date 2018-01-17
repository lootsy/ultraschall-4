using System;
using System.Collections.Generic;
using System.Linq;

namespace ultraschall
{
   public class ApplicationBuilder
   {
      public static Application Create(List<String> args) {
         Application result = null;

         if(args.Count > 0) {
            switch(args[0].ToLower()) {
               case "import":
                  result = new ImportApplication();
                  break;

               default:
                  Console.WriteLine("ultraschall: '{0}' is not an ultraschall command. See 'ultraschall --help'.", args[0]);
                  result = null;
                  break;
            }
         }

         if(result != null) {
            result.Configure(ParseCommandLine(args.Skip(1).ToList()));
         }

         return result;
      }

      static Dictionary<String, String> ParseCommandLine(List<String> args) {
         Dictionary<String, String> options = new Dictionary<String, String>();
         int i = 0;
         while(i < args.Count()) {
            String current = args[0].ToLower();
            if(IsOptionOrFlag(current) == true) {
               if(i < (args.Count() - 1)) {
                  if(IsOptionOrFlag(args[i + 1]) == false) {
                     options.Add(args[i], args[i + 1]);
                     i++;
                  }
                  else {
                     options.Add(args[i], "true");
                  }
               }
               else {
                  options.Add(args[i], "true");
               }
            }
            else if(options.ContainsKey("$") == false) {
               options.Add("$", args[i]);
            }

            i++;
         }

         return options;
      }

      static bool IsOptionOrFlag(String arg) {
         return arg.StartsWith("--", StringComparison.CurrentCulture);
      }

   }
}
