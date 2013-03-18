// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Geo
{
   public partial class Geolocation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Geolocation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.geo.Geolocation o) =>
            new Geolocation(o));
      }

      public Geolocation(com.gargoylesoftware.htmlunit.javascript.host.geo.Geolocation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.geo.Geolocation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.geo.Geolocation)WrappedObject; }
      }

      public Geolocation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.geo.Geolocation()) {}

// Generating method code for getCurrentPosition
      public virtual void GetCurrentPosition(net.sourceforge.htmlunit.corejs.javascript.Function successCallback, object errorCallback, object options)
      {
         WObj.getCurrentPosition(successCallback, errorCallback, options);
      }

// Generating method code for watchPosition
      public virtual int WatchPosition(net.sourceforge.htmlunit.corejs.javascript.Function successCallback, object errorCallback, object options)
      {
         return WObj.watchPosition(successCallback, errorCallback, options);
      }

// Generating method code for clearWatch
      public virtual void ClearWatch(int watchId)
      {
         WObj.clearWatch(watchId);
      }

   }


}
