// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class Keyboard : ObjectWrapper
   {
      static Keyboard()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.Keyboard o) =>
            new Keyboard(o));
      }

      public Keyboard(com.gargoylesoftware.htmlunit.html.Keyboard wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.Keyboard WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.Keyboard)WrappedObject; }
      }

      public Keyboard()
         : this(new com.gargoylesoftware.htmlunit.html.Keyboard()) {}

// Generating method code for type
      public virtual void Type(System.Char ch)
      {
         WObj.type(ch);
      }

// Generating method code for press
      public virtual void Press(int keyCode)
      {
         WObj.press(keyCode);
      }

// Generating method code for release
      public virtual void Release(int keyCode)
      {
         WObj.release(keyCode);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

   }


}
