// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class FontFaceSet : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static FontFaceSet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.FontFaceSet o) =>
            new FontFaceSet(o));
      }

      public FontFaceSet(com.gargoylesoftware.htmlunit.javascript.host.FontFaceSet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.FontFaceSet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.FontFaceSet)WrappedObject; }
      }

      public FontFaceSet()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.FontFaceSet()) {}

// Generating method code for load
      public virtual NHtmlUnit.Javascript.Host.Promise Load(string font, string text)
      {
         var arg = WObj.load(font, text);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

   }


}
