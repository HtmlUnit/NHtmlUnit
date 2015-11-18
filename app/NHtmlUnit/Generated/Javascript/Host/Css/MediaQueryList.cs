// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class MediaQueryList : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaQueryList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList o) =>
            new MediaQueryList(o));
      }

      public MediaQueryList(com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList)WrappedObject; }
      }

      public MediaQueryList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList()) {}

      public MediaQueryList(string mediaQueryString)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.MediaQueryList(mediaQueryString)) {}


      public System.String Media
      {
         get
         {
            return WObj.getMedia();
         }
      }

      public System.Boolean Matches
      {
         get
         {
            return WObj.getMatches();
         }
      }
// Generating method code for addListener
      public virtual void AddListener(object listener)
      {
         WObj.addListener(listener);
      }

// Generating method code for removeListener
      public virtual void RemoveListener(object listener)
      {
         WObj.removeListener(listener);
      }

   }


}
