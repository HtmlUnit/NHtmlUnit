using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public class HtmlElementNotFoundException : ApplicationException
   {
      public HtmlElementNotFoundException(string message) : base(message)
      {
      }

      public HtmlElementNotFoundException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }
}
