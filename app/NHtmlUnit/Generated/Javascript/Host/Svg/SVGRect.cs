// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGRect : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGRect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRect o) =>
            new SVGRect(o));
      }

      public SVGRect(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRect)WrappedObject; }
      }

      public SVGRect()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRect()) {}


      public System.Double X
      {
         get
         {
            return WObj.getX();
         }
         set
         {
            WObj.setX(value);
         }

      }

      public System.Double Y
      {
         get
         {
            return WObj.getY();
         }
         set
         {
            WObj.setY(value);
         }

      }

      public System.Double Width
      {
         get
         {
            return WObj.getWidth();
         }
         set
         {
            WObj.setWidth(value);
         }

      }

      public System.Double Height
      {
         get
         {
            return WObj.getHeight();
         }
      }
   }


}
