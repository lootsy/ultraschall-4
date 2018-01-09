using System;
using System.Collections.Generic;

namespace ultraschall
{
   public interface IConfiguration
   {
      void Configure(Dictionary<String, String> options);
   }
}
