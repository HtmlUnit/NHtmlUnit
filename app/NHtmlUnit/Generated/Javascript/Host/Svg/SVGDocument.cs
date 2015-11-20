// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGDocument : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDocument o) =>
            new SVGDocument(o));
      }

      public SVGDocument(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDocument)WrappedObject; }
      }

      public SVGDocument()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDocument()) {}

   }


}
