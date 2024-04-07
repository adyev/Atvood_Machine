﻿using Tao.OpenGl;
using System.Drawing;
using System.Drawing.Imaging;

namespace Atwood
{
    public class Rope : Drawing
    {
        public bool IsRight { get; set; }
        public float Height { get; set; }
      public void LoadTexture(Bitmap textureImage, bool flip)
      {
         if (flip)
         {
            textureImage.RotateFlip(RotateFlipType.Rotate180FlipX);
         }
         Rectangle rectangle = new Rectangle(0, 0, textureImage.Width, textureImage.Height);
         BitmapData bitmapData = textureImage.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
         Gl.glBindTexture(Gl.GL_TEXTURE_2D, 1);
         Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)Gl.GL_RGB8, textureImage.Width, textureImage.Height, 0, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapData.Scan0);
         Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, (int)Gl.GL_LINEAR);
         Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, (int)Gl.GL_LINEAR);
         if (bitmapData != null)
         {
            textureImage.UnlockBits(bitmapData);
         }
      }
      public void Draw(float inst_Height)
        {
            float x;
         LoadTexture(new Bitmap("rope.bmp"), true);
			Gl.glTranslated(0, 0.0, 0);
			Gl.glPushMatrix();
            Gl.glLoadIdentity();
			Gl.glTranslated(0, 0, -0.225f);
			if (IsRight)
                x = -0.9f;
            else
                x = 0.9f;
            Gl.glTranslated(x, inst_Height, 0.43);
            Gl.glRotated(90, 1, 0, 0);
            Glu.GLUquadric quadr = Glu.gluNewQuadric();

            Glu.gluQuadricTexture(quadr, Gl.GL_TRUE);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Glu.gluCylinder(quadr, 0.03, 0.03, Height, 10, 10);
            Gl.glRotatef(180, 1, 0, 0);
            Gl.glTranslatef(0.0f, 0.0f, -1);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 1);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPopMatrix();
        }
        public Rope(float height, bool isRight)
        {
            IsRight = isRight;
            Height = height;
        }
    }
}