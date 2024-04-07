using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows; 


namespace Atwood.Prog
{
   class AtwoodCalc
   {

      public static float v = 0;
      static float v_angle = 0;

      public static float[] Compute(float m1, float m2, float g, float md, float t, bool reset)
      {
         float []data= new float[2];
         float acc = (m1 - m2) * g / (m1 + m2 + md / (2));
         data[0] = v * t + acc  * t*t; //изменение коорд. за один фрейм
         data[1] = float.Parse("" + (v_angle * t + acc * t*t) * 180 / Math.PI);//изменение угла за фрейм
         if (reset)
         {
            v = 0;
            v_angle = 0;
         }
         else
         {
            v += acc * t;
            v_angle += acc * t;
         }

		 //data[0] *= 100;
         return data;
      }   
   }
}

    
