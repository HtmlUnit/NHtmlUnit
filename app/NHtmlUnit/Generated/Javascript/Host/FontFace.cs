// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class FontFace : NHtmlUnit.Javascript.SimpleScriptable
   {
      static FontFace()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.FontFace o) =>
            new FontFace(o));
      }

      public FontFace(com.gargoylesoftware.htmlunit.javascript.host.FontFace wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.FontFace WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.FontFace)WrappedObject; }
      }

      public FontFace()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.FontFace()) {}

   }


}
