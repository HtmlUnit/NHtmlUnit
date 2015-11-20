// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGStringList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGStringList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStringList o) =>
            new SVGStringList(o));
      }

      public SVGStringList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStringList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStringList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStringList)WrappedObject; }
      }

      public SVGStringList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStringList()) {}

   }


}
