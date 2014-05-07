// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Screen : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Screen()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Screen o) =>
            new Screen(o));
      }

      public Screen(com.gargoylesoftware.htmlunit.javascript.host.Screen wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Screen WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Screen)WrappedObject; }
      }

      public Screen()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Screen()) {}


      public System.Int32 AvailHeight
      {
         get
         {
            return WObj.getAvailHeight();
         }
      }

      public System.Int32 AvailWidth
      {
         get
         {
            return WObj.getAvailWidth();
         }
      }

      public System.Int32 BufferDepth
      {
         get
         {
            return WObj.getBufferDepth();
         }
         set
         {
            WObj.setBufferDepth(value);
         }

      }

      public System.Int32 ColorDepth
      {
         get
         {
            return WObj.getColorDepth();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 AvailLeft
      {
         get
         {
            return WObj.getAvailLeft();
         }
      }

      public System.Int32 AvailTop
      {
         get
         {
            return WObj.getAvailTop();
         }
      }

      public System.Int32 DeviceXDPI
      {
         get
         {
            return WObj.getDeviceXDPI();
         }
      }

      public System.Int32 DeviceYDPI
      {
         get
         {
            return WObj.getDeviceYDPI();
         }
      }

      public System.Boolean FontSmoothingEnabled
      {
         get
         {
            return WObj.getFontSmoothingEnabled();
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

      public System.Int32 LogicalXDPI
      {
         get
         {
            return WObj.getLogicalXDPI();
         }
      }

      public System.Int32 LogicalYDPI
      {
         get
         {
            return WObj.getLogicalYDPI();
         }
      }

      public System.Int32 PixelDepth
      {
         get
         {
            return WObj.getPixelDepth();
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

      public System.Int32 UpdateInterval
      {
         get
         {
            return WObj.getUpdateInterval();
         }
         set
         {
            WObj.setUpdateInterval(value);
         }

      }
   }


}
