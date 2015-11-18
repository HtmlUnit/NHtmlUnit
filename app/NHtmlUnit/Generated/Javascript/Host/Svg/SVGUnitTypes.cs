// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGUnitTypes : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGUnitTypes()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUnitTypes o) =>
            new SVGUnitTypes(o));
      }

      public SVGUnitTypes(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUnitTypes wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUnitTypes WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUnitTypes)WrappedObject; }
      }

      public SVGUnitTypes()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUnitTypes()) {}

   }


}
