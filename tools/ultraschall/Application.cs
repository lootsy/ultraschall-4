using System;
using System.Collections.Generic;

namespace ultraschall
{
   public class Application : IConfiguration
   {
      public Dictionary<String, String> Options {
         get; private set;
      }

      public void Configure(Dictionary<String, String> options) {
         Options = options;
      }
   }
}
