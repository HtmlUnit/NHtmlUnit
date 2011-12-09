// Generated class v4, don't modify

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

// Generating method code for jsxGet_availHeight
      public virtual int JsxGet_availHeight()
      {
         return WObj.jsxGet_availHeight();
      }

// Generating method code for jsxGet_availWidth
      public virtual int JsxGet_availWidth()
      {
         return WObj.jsxGet_availWidth();
      }

// Generating method code for jsxGet_bufferDepth
      public virtual int JsxGet_bufferDepth()
      {
         return WObj.jsxGet_bufferDepth();
      }

// Generating method code for jsxGet_colorDepth
      public virtual int JsxGet_colorDepth()
      {
         return WObj.jsxGet_colorDepth();
      }

// Generating method code for jsxGet_height
      public virtual int JsxGet_height()
      {
         return WObj.jsxGet_height();
      }

// Generating method code for jsxGet_width
      public virtual int JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxGet_availLeft
      public virtual int JsxGet_availLeft()
      {
         return WObj.jsxGet_availLeft();
      }

// Generating method code for jsxGet_availTop
      public virtual int JsxGet_availTop()
      {
         return WObj.jsxGet_availTop();
      }

// Generating method code for jsxSet_bufferDepth
      public virtual void JsxSet_bufferDepth(int bufferDepth)
      {
         WObj.jsxSet_bufferDepth(bufferDepth);
      }

// Generating method code for jsxGet_deviceXDPI
      public virtual int JsxGet_deviceXDPI()
      {
         return WObj.jsxGet_deviceXDPI();
      }

// Generating method code for jsxGet_deviceYDPI
      public virtual int JsxGet_deviceYDPI()
      {
         return WObj.jsxGet_deviceYDPI();
      }

// Generating method code for jsxGet_fontSmoothingEnabled
      public virtual bool JsxGet_fontSmoothingEnabled()
      {
         return WObj.jsxGet_fontSmoothingEnabled();
      }

// Generating method code for jsxGet_left
      public virtual int JsxGet_left()
      {
         return WObj.jsxGet_left();
      }

// Generating method code for jsxSet_left
      public virtual void JsxSet_left(int left)
      {
         WObj.jsxSet_left(left);
      }

// Generating method code for jsxGet_logicalXDPI
      public virtual int JsxGet_logicalXDPI()
      {
         return WObj.jsxGet_logicalXDPI();
      }

// Generating method code for jsxGet_logicalYDPI
      public virtual int JsxGet_logicalYDPI()
      {
         return WObj.jsxGet_logicalYDPI();
      }

// Generating method code for jsxGet_pixelDepth
      public virtual int JsxGet_pixelDepth()
      {
         return WObj.jsxGet_pixelDepth();
      }

// Generating method code for jsxGet_top
      public virtual int JsxGet_top()
      {
         return WObj.jsxGet_top();
      }

// Generating method code for jsxSet_top
      public virtual void JsxSet_top(int top)
      {
         WObj.jsxSet_top(top);
      }

// Generating method code for jsxGet_updateInterval
      public virtual int JsxGet_updateInterval()
      {
         return WObj.jsxGet_updateInterval();
      }

// Generating method code for jsxSet_updateInterval
      public virtual void JsxSet_updateInterval(int updateInterval)
      {
         WObj.jsxSet_updateInterval(updateInterval);
      }

   }


}
