using System;
using System.Collections.Generic;
using System.Linq;

namespace ultraschall
{
   public class CommandLineScanner
   {
      private HashSet<String> Options {
         get; set;
      } = new HashSet<String>();

      private HashSet<String> Flags {
         get; set;
      } = new HashSet<String>();

      private Dictionary<String, String> Shortcuts {
         get; set;
      } = new Dictionary<String, String>();

      public Dictionary<String, String> Parameters {
         get; private set;
      } = new Dictionary<String, String>();

      public void Scan(String[] args) {
         List<String> arguments = new List<String>();
         arguments.AddRange(args);


      }

      static bool IsOptionOrFlag(String arg) {
         return arg.StartsWith("-", StringComparison.CurrentCulture);
      }

      public bool AddOption(String name, String shortcut) {
         bool result = false;
         if(Options.Contains(name) == false) {
            Options.Add(name);
            if(String.IsNullOrEmpty(shortcut) == false) {
               Shortcuts.Add(shortcut, name);
            }

            result = true;
         }

         return result;
      }

      public bool AddFlag(String name, String shortcut) {
         bool result = false;
         if(Flags.Contains(name) == false) {
            Flags.Add(name);
            if(String.IsNullOrEmpty(shortcut) == false) {
               Shortcuts.Add(shortcut, name);
            }

            result = true;
         }

         return result;
      }
   }
}
