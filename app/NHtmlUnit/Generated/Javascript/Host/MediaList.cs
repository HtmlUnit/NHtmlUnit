// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MediaList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MediaList o) =>
            new MediaList(o));
      }

      public MediaList(com.gargoylesoftware.htmlunit.javascript.host.MediaList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MediaList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MediaList)WrappedObject; }
      }

      public MediaList(NHtmlUnit.Javascript.Host.Css.CSSStyleSheet parent, NHtmlUnit.W3C.Dom.Stylesheets.IMediaList wrappedList)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MediaList((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)parent.WrappedObject, (org.w3c.dom.stylesheets.MediaList)wrappedList.WrappedObject)) {}


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
