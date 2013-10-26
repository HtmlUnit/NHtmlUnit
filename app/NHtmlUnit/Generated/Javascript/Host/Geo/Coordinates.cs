// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Geo
{
   public partial class Coordinates : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Coordinates()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.geo.Coordinates o) =>
            new Coordinates(o));
      }

      public Coordinates(com.gargoylesoftware.htmlunit.javascript.host.geo.Coordinates wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.geo.Coordinates WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.geo.Coordinates)WrappedObject; }
      }

      public Coordinates()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.geo.Coordinates()) {}


      public System.Double Latitude
      {
         get
         {
            return WObj.getLatitude();
         }
      }

      public System.Double Longitude
      {
         get
         {
            return WObj.getLongitude();
         }
      }

      public System.Double Accuracy
      {
         get
         {
            return WObj.getAccuracy();
         }
      }
   }


}
