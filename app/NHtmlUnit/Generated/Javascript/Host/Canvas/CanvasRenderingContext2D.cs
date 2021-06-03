// Generated class v2.50.0.0, don't modify

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

      public CanvasRenderingContext2D(NHtmlUnit.Javascript.Host.Html.HTMLCanvasElement canvas)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasRenderingContext2D((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement)canvas.WrappedObject)) {}


      public System.Double GlobalAlpha
      {
         get
         {
            return WObj.getGlobalAlpha();
         }
         set
         {
            WObj.setGlobalAlpha(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.HTMLCanvasElement Canvas
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCanvasElement>(
               WObj.getCanvas());
         }
      }

// Generating method code for arc
      public virtual void Arc(System.Double x, System.Double y, System.Double radius, System.Double startAngle, System.Double endAngle, bool anticlockwise)
      {
         WObj.arc(x, y, radius, startAngle, endAngle, anticlockwise);
      }

// Generating method code for arcTo
      public virtual void ArcTo(System.Double x1, System.Double y1, System.Double x2, System.Double y2, System.Double radius)
      {
         WObj.arcTo(x1, y1, x2, y2, radius);
      }

// Generating method code for beginPath
      public virtual void BeginPath()
      {
         WObj.beginPath();
      }

// Generating method code for bezierCurveTo
      public virtual void BezierCurveTo(System.Double cp1x, System.Double cp1y, System.Double cp2x, System.Double cp2y, System.Double x, System.Double y)
      {
         WObj.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y);
      }

// Generating method code for clearRect
      public virtual void ClearRect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.clearRect(x, y, w, h);
      }

// Generating method code for closePath
      public virtual void ClosePath()
      {
         WObj.closePath();
      }

// Generating method code for createLinearGradient
      public virtual NHtmlUnit.Javascript.Host.Canvas.CanvasGradient CreateLinearGradient(System.Double x0, System.Double y0, System.Double r0, System.Double x1, object y1, object r1)
      {
         var arg = WObj.createLinearGradient(x0, y0, r0, x1, y1, r1);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Canvas.CanvasGradient>(arg);
      }

// Generating method code for createPattern
      public virtual void CreatePattern()
      {
         WObj.createPattern();
      }

// Generating method code for createRadialGradient
      public virtual NHtmlUnit.Javascript.Host.Canvas.CanvasGradient CreateRadialGradient(System.Double x0, System.Double y0, System.Double r0, System.Double x1, System.Double y1, System.Double r1)
      {
         var arg = WObj.createRadialGradient(x0, y0, r0, x1, y1, r1);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Canvas.CanvasGradient>(arg);
      }

// Generating method code for drawImage
      public virtual void DrawImage(object image, int sx, int sy, object sWidth, object sHeight, object dx, object dy, object dWidth, object dHeight)
      {
         WObj.drawImage(image, sx, sy, sWidth, sHeight, dx, dy, dWidth, dHeight);
      }

// Generating method code for toDataURL
      public virtual string ToDataURL(string type)
      {
         return WObj.toDataURL(type);
      }

// Generating method code for ellipse
      public virtual void Ellipse(System.Double x, System.Double y, System.Double radiusX, System.Double radiusY, System.Double rotation, System.Double startAngle, System.Double endAngle, bool anticlockwise)
      {
         WObj.ellipse(x, y, radiusX, radiusY, rotation, startAngle, endAngle, anticlockwise);
      }

// Generating method code for fill
      public virtual void Fill()
      {
         WObj.fill();
      }

// Generating method code for fillRect
      public virtual void FillRect(int x, int y, int w, int h)
      {
         WObj.fillRect(x, y, w, h);
      }

// Generating method code for fillText
      public virtual void FillText(string text, System.Double x, System.Double y)
      {
         WObj.fillText(text, x, y);
      }

// Generating method code for getImageData
      public virtual NHtmlUnit.Javascript.Host.Canvas.ImageData GetImageData(int sx, int sy, int sw, int sh)
      {
         var arg = WObj.getImageData(sx, sy, sw, sh);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Canvas.ImageData>(arg);
      }

// Generating method code for getLineDash
      public virtual void GetLineDash()
      {
         WObj.getLineDash();
      }

// Generating method code for getLineData
      public virtual void GetLineData()
      {
         WObj.getLineData();
      }

// Generating method code for isPointInPath
      public virtual void IsPointInPath()
      {
         WObj.isPointInPath();
      }

// Generating method code for lineTo
      public virtual void LineTo(System.Double x, System.Double y)
      {
         WObj.lineTo(x, y);
      }

// Generating method code for measureText
      public virtual NHtmlUnit.Javascript.Host.Canvas.TextMetrics MeasureText(object text)
      {
         var arg = WObj.measureText(text);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Canvas.TextMetrics>(arg);
      }

// Generating method code for moveTo
      public virtual void MoveTo(System.Double x, System.Double y)
      {
         WObj.moveTo(x, y);
      }

// Generating method code for putImageData
      public virtual void PutImageData(NHtmlUnit.Javascript.Host.Canvas.ImageData imageData, int dx, int dy, object dirtyX, object dirtyY, object dirtyWidth, object dirtyHeight)
      {
         WObj.putImageData((com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData)imageData.WrappedObject, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
      }

// Generating method code for quadraticCurveTo
      public virtual void QuadraticCurveTo(System.Double controlPointX, System.Double controlPointY, System.Double endPointX, System.Double endPointY)
      {
         WObj.quadraticCurveTo(controlPointX, controlPointY, endPointX, endPointY);
      }

// Generating method code for rect
      public virtual void Rect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.rect(x, y, w, h);
      }

// Generating method code for restore
      public virtual void Restore()
      {
         WObj.restore();
      }

// Generating method code for rotate
      public virtual void Rotate(System.Double angle)
      {
         WObj.rotate(angle);
      }

// Generating method code for save
      public virtual void Save()
      {
         WObj.save();
      }

// Generating method code for scale
      public virtual void Scale(object x, object y)
      {
         WObj.scale(x, y);
      }

// Generating method code for setLineDash
      public virtual void SetLineDash()
      {
         WObj.setLineDash();
      }

// Generating method code for setTransform
      public virtual void SetTransform(System.Double m11, System.Double m12, System.Double m21, System.Double m22, System.Double dx, System.Double dy)
      {
         WObj.setTransform(m11, m12, m21, m22, dx, dy);
      }

// Generating method code for stroke
      public virtual void Stroke()
      {
         WObj.stroke();
      }

// Generating method code for strokeRect
      public virtual void StrokeRect(int x, int y, int w, int h)
      {
         WObj.strokeRect(x, y, w, h);
      }

// Generating method code for strokeText
      public virtual void StrokeText()
      {
         WObj.strokeText();
      }

// Generating method code for transform
      public virtual void Transform(System.Double m11, System.Double m12, System.Double m21, System.Double m22, System.Double dx, System.Double dy)
      {
         WObj.transform(m11, m12, m21, m22, dx, dy);
      }

// Generating method code for translate
      public virtual void Translate(int x, int y)
      {
         WObj.translate(x, y);
      }

// Generating method code for getFillStyle
      public virtual object GetFillStyle()
      {
         var arg = WObj.getFillStyle();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setFillStyle
      public virtual void SetFillStyle(string fillStyle)
      {
         WObj.setFillStyle(fillStyle);
      }

// Generating method code for getStrokeStyle
      public virtual object GetStrokeStyle()
      {
         var arg = WObj.getStrokeStyle();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setStrokeStyle
      public virtual void SetStrokeStyle(string strokeStyle)
      {
         WObj.setStrokeStyle(strokeStyle);
      }

// Generating method code for getLineWidth
      public virtual System.Double GetLineWidth()
      {
         return WObj.getLineWidth();
      }

// Generating method code for setLineWidth
      public virtual void SetLineWidth(object lineWidth)
      {
         WObj.setLineWidth(lineWidth);
      }

   }


}
