// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ClientRect : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ClientRect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ClientRect o) =>
            new ClientRect(o));
      }

      public ClientRect(com.gargoylesoftware.htmlunit.javascript.host.ClientRect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ClientRect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ClientRect)WrappedObject; }
      }

      public ClientRect()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ClientRect()) {}

      public ClientRect(int bottom, int left, int right, int top)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ClientRect(bottom, left, right, top)) {}


      public System.Int32 Right
      {
         get
         {
            return WObj.getRight();
         }
         set
         {
            WObj.setRight(value);
         }

      }

      public System.Int32 Left
      {
         get
         {
            return WObj.getLeft();
         }
         set
         {
            WObj.setLeft(value);
         }

      }

      public System.Int32 Bottom
      {
         get
         {
            return WObj.getBottom();
         }
         set
         {
            WObj.setBottom(value);
         }

      }

      public System.Int32 Top
      {
         get
         {
            return WObj.getTop();
         }
         set
         {
            WObj.setTop(value);
         }

      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }
   }


}
