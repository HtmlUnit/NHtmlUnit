// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class MediaList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList o) =>
            new MediaList(o));
      }

      public MediaList(com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList)WrappedObject; }
      }

      public MediaList(NHtmlUnit.Javascript.Host.Css.CSSStyleSheet parent, NHtmlUnit.W3C.Dom.Stylesheets.IMediaList wrappedList)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)parent.WrappedObject, (org.w3c.dom.stylesheets.MediaList)wrappedList.WrappedObject)) {}

      public MediaList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.MediaList()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.String MediaText
      {
         get
         {
            return WObj.getMediaText();
         }
      }
// Generating method code for item
      public virtual string Item(int index)
      {
         return WObj.item(index);
      }

   }


}
