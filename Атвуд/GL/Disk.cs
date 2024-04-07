using System.Drawing;
using System.Drawing.Imaging;
using Tao.OpenGl;

namespace Atwood
{
    public class Disk : Drawing
    {
        public float Mass { get; set; }
        public float Angle { get; set; }
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

        public void Draw(Instalation inst)
        {
            LoadTexture(new Bitmap("block.bmp"), true);
			
			Gl.glPushMatrix();
            Gl.glLoadIdentity();
			
            //float[] MatrixOXOYColor = { 0, 0, 1, 1 };
            //Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixOXOYColor);
            //Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, new float [1]{ 127 });
            Glu.GLUquadric quadr = Glu.gluNewQuadric();

            Glu.gluQuadricTexture(quadr, Gl.GL_TRUE);
            Gl.glEnable(Gl.GL_TEXTURE_2D);

            Gl.glTranslated(0, inst.Height, 0.15);
            Gl.glRotated(Angle, 0, 0, 1);
            Gl.glColor3f(1, 0, 0);
            Glu.gluCylinder(quadr, 1, 1, 0.1, 50, 50);
            Glu.gluDisk(quadr, 0.0f, 1, 60, 1);
            Gl.glTranslatef(0.0f, 0.0f, 0.1f);
            Glu.gluDisk(quadr, 0.0f, 1, 60, 1);
            //Gl.glRotated(90, 1, 0, 0);
            //float[] MatrixMarkColor = { 0, 0, 0, 1 };
            //Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixMarkColor);
            //Glut.glutSolidCylinder(0.1, 0.9, 50, 50);
            float[] MatrixMainColor = { 0.5f, 0.5f, 0.5f, 1 };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixMainColor);

            Gl.glPopMatrix();
        }
        public Disk(float mass)
        {
            Mass = mass;
            Angle = 0;
        }
    }
}