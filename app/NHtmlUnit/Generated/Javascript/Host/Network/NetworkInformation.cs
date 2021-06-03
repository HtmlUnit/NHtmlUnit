// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Network
{
   public partial class NetworkInformation : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static NetworkInformation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.network.NetworkInformation o) =>
            new NetworkInformation(o));
      }

      public NetworkInformation(com.gargoylesoftware.htmlunit.javascript.host.network.NetworkInformation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.network.NetworkInformation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.network.NetworkInformation)WrappedObject; }
      }

      public NetworkInformation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.network.NetworkInformation()) {}


      public System.Double Downlink
      {
         get
         {
            return WObj.getDownlink();
         }
      }

      public System.String EffectiveType
      {
         get
         {
            return WObj.getEffectiveType();
         }
      }

      public System.Int32 Rtt
      {
         get
         {
            return WObj.getRtt();
         }
      }
   }


}
