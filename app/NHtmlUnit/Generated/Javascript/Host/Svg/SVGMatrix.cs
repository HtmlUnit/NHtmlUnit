// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGMatrix : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGMatrix()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix o) =>
            new SVGMatrix(o));
      }

      public SVGMatrix(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix)WrappedObject; }
      }

      public SVGMatrix(NHtmlUnit.Javascript.Host.Window scope)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix((com.gargoylesoftware.htmlunit.javascript.host.Window)scope.WrappedObject)) {}

      public SVGMatrix()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix()) {}


      public System.Double A
      {
         get
         {
            return WObj.getA();
         }
         set
         {
            WObj.setA(value);
         }

      }

      public System.Double B
      {
         get
         {
            return WObj.getB();
         }
         set
         {
            WObj.setB(value);
         }

      }

      public System.Double C
      {
         get
         {
            return WObj.getC();
         }
         set
         {
            WObj.setC(value);
         }

      }

      public System.Double D
      {
         get
         {
            return WObj.getD();
         }
         set
         {
            WObj.setD(value);
         }

      }

      public System.Double E
      {
         get
         {
            return WObj.getE();
         }
         set
         {
            WObj.setE(value);
         }

      }

      public System.Double F
      {
         get
         {
            return WObj.getF();
         }
         set
         {
            WObj.setF(value);
         }

      }
// Generating method code for flipX
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix FlipX()
      {
         var arg = WObj.flipX();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for flipY
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix FlipY()
      {
         var arg = WObj.flipY();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for inverse
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix Inverse()
      {
         var arg = WObj.inverse();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for multiply
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix Multiply(NHtmlUnit.Javascript.Host.Svg.SVGMatrix by)
      {
         var arg = WObj.multiply((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMatrix)by.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for rotate
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix Rotate(System.Double angle)
      {
         var arg = WObj.rotate(angle);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for rotateFromVector
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix RotateFromVector(System.Double x, System.Double y)
      {
         var arg = WObj.rotateFromVector(x, y);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for scale
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix Scale(System.Double factor)
      {
         var arg = WObj.scale(factor);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for scaleNonUniform
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix ScaleNonUniform(System.Double factorX, System.Double factorY)
      {
         var arg = WObj.scaleNonUniform(factorX, factorY);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for skewX
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix SkewX(System.Double angle)
      {
         var arg = WObj.skewX(angle);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for skewY
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix SkewY(System.Double angle)
      {
         var arg = WObj.skewY(angle);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

// Generating method code for translate
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix Translate(System.Double x, System.Double y)
      {
         var arg = WObj.translate(x, y);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(arg);
      }

   }


}
