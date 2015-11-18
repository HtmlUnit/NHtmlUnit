// Generated class v2.19.0.0, don't modify

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


      public System.Object StrokeStyle
      {
         get
         {
            return WObj.getStrokeStyle();
         }
         set
         {
            WObj.setStrokeStyle(value);
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

// Generating method code for clip
      public virtual void Clip()
      {
         WObj.clip();
      }

// Generating method code for closePath
      public virtual void ClosePath()
      {
         WObj.closePath();
      }

// Generating method code for createImageData
      public virtual void CreateImageData()
      {
         WObj.createImageData();
      }

// Generating method code for createLinearGradient
      public virtual void CreateLinearGradient(System.Double x0, System.Double y0, System.Double r0, System.Double x1, object y1, object r1)
      {
         WObj.createLinearGradient(x0, y0, r0, x1, y1, r1);
      }

// Generating method code for createPattern
      public virtual void CreatePattern()
      {
         WObj.createPattern();
      }

// Generating method code for createRadialGradient
      public virtual void CreateRadialGradient()
      {
         WObj.createRadialGradient();
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
      public virtual void FillText()
      {
         WObj.fillText();
      }

// Generating method code for getImageData
      public virtual NHtmlUnit.Javascript.Host.Canvas.ImageData GetImageData(int sx, int sy, int sw, int sh)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Canvas.ImageData>(WObj.getImageData(sx, sy, sw, sh));
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
      public virtual void MeasureText()
      {
         WObj.measureText();
      }

// Generating method code for moveTo
      public virtual void MoveTo(System.Double x, System.Double y)
      {
         WObj.moveTo(x, y);
      }

// Generating method code for putImageData
      public virtual void PutImageData()
      {
         WObj.putImageData();
      }

// Generating method code for quadraticCurveTo
      public virtual void QuadraticCurveTo(System.Double controlPointX, System.Double controlPointY, System.Double endPointX, System.Double endPointY)
      {
         WObj.quadraticCurveTo(controlPointX, controlPointY, endPointX, endPointY);
      }

// Generating method code for rect
      public virtual void Rect()
      {
         WObj.rect();
      }

// Generating method code for restore
      public virtual void Restore()
      {
         WObj.restore();
      }

// Generating method code for rotate
      public virtual void Rotate()
      {
         WObj.rotate();
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
      public virtual void SetTransform()
      {
         WObj.setTransform();
      }

// Generating method code for stroke
      public virtual void Stroke()
      {
         WObj.stroke();
      }

// Generating method code for strokeRect
      public virtual void StrokeRect(System.Double x, System.Double y, System.Double w, System.Double h)
      {
         WObj.strokeRect(x, y, w, h);
      }

// Generating method code for strokeText
      public virtual void StrokeText()
      {
         WObj.strokeText();
      }

// Generating method code for transform
      public virtual void Transform()
      {
         WObj.transform();
      }

// Generating method code for translate
      public virtual void Translate(object x, object y)
      {
         WObj.translate(x, y);
      }

// Generating method code for getFillStyle
      public virtual object GetFillStyle()
      {
         return WObj.getFillStyle();
      }

// Generating method code for setFillStyle
      public virtual void SetFillStyle(string fillStyle)
      {
         WObj.setFillStyle(fillStyle);
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

// Generating method code for getGlobalAlpha
      public virtual System.Double GetGlobalAlpha()
      {
         return WObj.getGlobalAlpha();
      }

// Generating method code for setGlobalAlpha
      public virtual void SetGlobalAlpha(object globalAlpha)
      {
         WObj.setGlobalAlpha(globalAlpha);
      }

   }


}
