// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class CanvasRenderingContext2D : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CanvasRenderingContext2D()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D o) =>
            new CanvasRenderingContext2D(o));
      }

      public CanvasRenderingContext2D(com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D)WrappedObject; }
      }

      public CanvasRenderingContext2D()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D()) {}

// Generating method code for jsxGet_fillStyle
      public virtual object JsxGet_fillStyle()
      {
         return WObj.jsxGet_fillStyle();
      }

// Generating method code for jsxFunction_translate
      public virtual void JsxFunction_translate(object x, object y)
      {
         WObj.jsxFunction_translate(x, y);
      }

// Generating method code for jsxFunction_scale
      public virtual void JsxFunction_scale(object x, object y)
      {
         WObj.jsxFunction_scale(x, y);
      }

// Generating method code for jsxSet_fillStyle
      public virtual void JsxSet_fillStyle(object fillStyle)
      {
         WObj.jsxSet_fillStyle(fillStyle);
      }

// Generating method code for jsxGet_strokeStyle
      public virtual object JsxGet_strokeStyle()
      {
         return WObj.jsxGet_strokeStyle();
      }

// Generating method code for jsxSet_strokeStyle
      public virtual void JsxSet_strokeStyle(object strokeStyle)
      {
         WObj.jsxSet_strokeStyle(strokeStyle);
      }

// Generating method code for jsxGet_lineWidth
      public virtual System.Double JsxGet_lineWidth()
      {
         return WObj.jsxGet_lineWidth();
      }

// Generating method code for jsxSet_lineWidth
      public virtual void JsxSet_lineWidth(object lineWidth)
      {
         WObj.jsxSet_lineWidth(lineWidth);
      }

// Generating method code for jsxGet_globalAlpha
      public virtual System.Double JsxGet_globalAlpha()
      {
         return WObj.jsxGet_globalAlpha();
      }

// Generating method code for jsxSet_globalAlpha
      public virtual void JsxSet_globalAlpha(object globalAlpha)
      {
         WObj.jsxSet_globalAlpha(globalAlpha);
      }

// Generating method code for jsxFunction_clearRect
      public virtual void JsxFunction_clearRect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.jsxFunction_clearRect(x, y, w, h);
      }

// Generating method code for jsxFunction_fillRect
      public virtual void JsxFunction_fillRect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.jsxFunction_fillRect(x, y, w, h);
      }

// Generating method code for jsxFunction_strokeRect
      public virtual void JsxFunction_strokeRect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.jsxFunction_strokeRect(x, y, w, h);
      }

// Generating method code for jsxFunction_beginPath
      public virtual void JsxFunction_beginPath()
      {
         WObj.jsxFunction_beginPath();
      }

// Generating method code for jsxFunction_closePath
      public virtual void JsxFunction_closePath()
      {
         WObj.jsxFunction_closePath();
      }

// Generating method code for jsxFunction_moveTo
      public virtual void JsxFunction_moveTo(System.Double x, System.Double y)
      {
         WObj.jsxFunction_moveTo(x, y);
      }

// Generating method code for jsxFunction_lineTo
      public virtual void JsxFunction_lineTo(System.Double x, System.Double y)
      {
         WObj.jsxFunction_lineTo(x, y);
      }

// Generating method code for jsxFunction_save
      public virtual void JsxFunction_save()
      {
         WObj.jsxFunction_save();
      }

// Generating method code for jsxFunction_restore
      public virtual void JsxFunction_restore()
      {
         WObj.jsxFunction_restore();
      }

// Generating method code for jsxFunction_createLinearGradient
      public virtual void JsxFunction_createLinearGradient(System.Double x0, System.Double y0, System.Double r0, System.Double x1, object y1, object r1)
      {
         WObj.jsxFunction_createLinearGradient(x0, y0, r0, x1, y1, r1);
      }

// Generating method code for jsxFunction_arc
      public virtual void JsxFunction_arc(System.Double x, System.Double y, System.Double radius, System.Double startAngle, System.Double endAngle, bool anticlockwise)
      {
         WObj.jsxFunction_arc(x, y, radius, startAngle, endAngle, anticlockwise);
      }

// Generating method code for jsxFunction_arcTo
      public virtual void JsxFunction_arcTo(System.Double x1, System.Double y1, System.Double x2, System.Double y2, System.Double radius)
      {
         WObj.jsxFunction_arcTo(x1, y1, x2, y2, radius);
      }

// Generating method code for jsxFunction_bezierCurveTo
      public virtual void JsxFunction_bezierCurveTo(System.Double cp1x, System.Double cp1y, System.Double cp2x, System.Double cp2y, System.Double x, System.Double y)
      {
         WObj.jsxFunction_bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y);
      }

// Generating method code for jsxFunction_fill
      public virtual void JsxFunction_fill()
      {
         WObj.jsxFunction_fill();
      }

// Generating method code for jsxFunction_stroke
      public virtual void JsxFunction_stroke()
      {
         WObj.jsxFunction_stroke();
      }

// Generating method code for jsxFunction_clip
      public virtual void JsxFunction_clip()
      {
         WObj.jsxFunction_clip();
      }

   }


}
