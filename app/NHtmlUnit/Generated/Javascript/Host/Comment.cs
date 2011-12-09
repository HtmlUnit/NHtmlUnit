// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Comment : NHtmlUnit.Javascript.Host.CharacterDataImpl
   {
      static Comment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Comment o) =>
            new Comment(o));
      }

      public Comment(com.gargoylesoftware.htmlunit.javascript.host.Comment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Comment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Comment)WrappedObject; }
      }

      public Comment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Comment()) {}

   }


}
