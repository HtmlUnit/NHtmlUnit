// Generated class v2.19.0.0, don't modify

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


      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
         set
         {
            WObj.setWidth(value);
         }

      }

      public System.Int32 DeviceXDPI
      {
         get
         {
            return WObj.getDeviceXDPI();
         }
         set
         {
            WObj.setDeviceXDPI(value);
         }

      }

      public System.Int32 AvailHeight
      {
         get
         {
            return WObj.getAvailHeight();
         }
         set
         {
            WObj.setAvailHeight(value);
         }

      }

      public System.Int32 AvailWidth
      {
         get
         {
            return WObj.getAvailWidth();
         }
         set
         {
            WObj.setAvailWidth(value);
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
         set
         {
            WObj.setColorDepth(value);
         }

      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
         set
         {
            WObj.setHeight(value);
         }

      }

      public System.Int32 AvailLeft
      {
         get
         {
            return WObj.getAvailLeft();
         }
         set
         {
            WObj.setAvailLeft(value);
         }

      }

      public System.Int32 AvailTop
      {
         get
         {
            return WObj.getAvailTop();
         }
         set
         {
            WObj.setAvailTop(value);
         }

      }

      public System.Int32 DeviceYDPI
      {
         get
         {
            return WObj.getDeviceYDPI();
         }
         set
         {
            WObj.setDeviceYDPI(value);
         }

      }

      public System.Boolean FontSmoothingEnabled
      {
         get
         {
            return WObj.getFontSmoothingEnabled();
         }
         set
         {
            WObj.setFontSmoothingEnabled(value);
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
         set
         {
            WObj.setLogicalXDPI(value);
         }

      }

      public System.Int32 LogicalYDPI
      {
         get
         {
            return WObj.getLogicalYDPI();
         }
         set
         {
            WObj.setLogicalYDPI(value);
         }

      }

      public System.Int32 PixelDepth
      {
         get
         {
            return WObj.getPixelDepth();
         }
         set
         {
            WObj.setPixelDepth(value);
         }

      }

      public System.Int32 SystemXDPI
      {
         get
         {
            return WObj.getSystemXDPI();
         }
         set
         {
            WObj.setSystemXDPI(value);
         }

      }

      public System.Int32 SystemYDPI
      {
         get
         {
            return WObj.getSystemYDPI();
         }
         set
         {
            WObj.setSystemYDPI(value);
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
      }
   }


}
