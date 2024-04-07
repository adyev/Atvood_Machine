using System.Drawing;
using System.Drawing.Imaging;
using Tao.OpenGl;

namespace Atwood
{
    public class Instalation : Drawing
    {
        public float Height { get; set; }
        //public float X { get; set; }
        //public float Y { get; set; }
        //public float Z { get; set; }
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
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, (int)Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, (int)Gl.GL_REPEAT);
            if (bitmapData != null)
            {
                textureImage.UnlockBits(bitmapData);
            }
        }
        public void Draw()
        {
			Gl.glPushMatrix();
            Gl.glLoadIdentity();
         //float[] MatrixOXOYColor = { 0, 0, 1, 1 };
         //Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixOXOYColor);
         Gl.glRotated(-90, 1, 0, 0);

         Glu.GLUquadric quadr1 = Glu.gluNewQuadric();
			LoadTexture(new Bitmap("stand.bmp"), true);
			//Gl.glTranslatef(0.0f, 0.0f, 0.1f);
			
			//Gl.glTranslatef(0.0f, 0.0f, -0.1f);
			Gl.glTranslated(0, 0.0f, 0);

			Glu.gluQuadricTexture(quadr1, Gl.GL_TRUE);
			Gl.glEnable(Gl.GL_TEXTURE_2D);
			Gl.glColor3f(1, 0, 0);
			Gl.glTranslatef(0.0f, 0.0f, 0.1f);
			Glu.gluDisk(quadr1, 0, 2, 50, 50);
			Gl.glTranslatef(0.0f, 0.0f, -0.1f);
			Glu.gluCylinder(quadr1, 2, 2, 0.1f, 50, 10);
			Gl.glTranslatef(0.0f, 0.0f, 0.1f);
			LoadTexture(new Bitmap("body.bmp"), true);
            Glu.GLUquadric quadr = Glu.gluNewQuadric();

			Glu.gluQuadricTexture(quadr, Gl.GL_TRUE);
			Gl.glEnable(Gl.GL_TEXTURE_2D);
			Gl.glColor3f(1, 0, 0);
			Glu.gluCylinder(quadr, 0.15, 0.15, Height, 50, 10);
			Gl.glTranslated(0, 0, Height);
			Glu.gluDisk(quadr, 0.0f, 0.2, 10, 1);
			//Glu.gluCylinder(quadr, 0.15, 0.15, Height, 50, 10);
			//Glut.glutSolidCylinder(0.2, Height, 50, 50);
			//Gl.glColor3f(0, 0, 0);

		}
        public Instalation(float height)
        {
            Height = height;
        }

    }
}