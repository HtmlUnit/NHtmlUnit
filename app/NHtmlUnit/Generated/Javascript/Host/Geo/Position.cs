// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Geo
{
   public partial class Position : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Position()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.geo.Position o) =>
            new Position(o));
      }

      public Position(com.gargoylesoftware.htmlunit.javascript.host.geo.Position wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.geo.Position WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.geo.Position)WrappedObject; }
      }

      public Position()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.geo.Position()) {}


      public NHtmlUnit.Javascript.Host.Geo.Coordinates Coords
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Geo.Coordinates>(
               WObj.getCoords());
         }
      }

   }


}
