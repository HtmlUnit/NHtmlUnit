// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGPathSegList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegList o) =>
            new SVGPathSegList(o));
      }

      public SVGPathSegList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegList)WrappedObject; }
      }

      public SVGPathSegList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegList()) {}

   }


}
