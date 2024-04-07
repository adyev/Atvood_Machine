using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Tao.OpenGl;
using Tao.FreeGlut;
using Atwood.Prog;


namespace Atwood
{

   public partial class Form1 : Form
   {

      Camera cam = new Camera();

      private void InitGL()
      {

         Glut.glutInit();
         float r = 188.0f / 255;
         float g = 210.0f / 255;
         float b = 238.0f / 255;
         Gl.glClearColor(r, g, b, 0.0f);
         Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
         Gl.glViewport(0, 0, AnT.Width, AnT.Height);
         Gl.glMatrixMode(Gl.GL_PROJECTION);
         Gl.glLoadIdentity();
         Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
         cam.Position_Camera(-2.7f, 8.64f, 15.1f, 0, 3, 0, 0, 1, 0);
         Gl.glMatrixMode(Gl.GL_MODELVIEW); Gl.glLoadIdentity();
         Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
         Gl.glEnable(Gl.GL_DEPTH_TEST);
         Gl.glEnable(Gl.GL_LIGHTING);
         Gl.glEnable(Gl.GL_LIGHT0);
         Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
         Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
         Gl.glEnable(Gl.GL_BLEND);
         Gl.glEnable(Gl.GL_LINE_SMOOTH);
         Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, new float[] { 0.5f, 0.5f, 0.5f, 1.0f });


         // Вот тут в инициализации 
         // укажем начальную позицию камеры, взгляда и вертикального вектора.
      }
      float[] MatrixColorOX = { 1, 0, 0, 1 };
      float[] MatrixColorOY = { 0, 1, 0, 1 };
      float[] MatrixColorOZ = { 0, 1, 0, 1 };
      float[] MatrixOXOYColor = { 1, 1, 1, 1 };
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
      private void DrawGrid(int x)
      {

         // x - количество или длина сетки, quad_size - размер клетки 
         Gl.glPushMatrix(); // Рисуем оси координат, цвет объявлен в самом начале


         Gl.glPopMatrix();
         Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
         LoadTexture(new Bitmap("table.bmp"), true);

         Gl.glEnable(Gl.GL_TEXTURE_2D);

         Gl.glColor3f(1, 1, 1);
         Gl.glBegin(Gl.GL_QUADS);
         Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixOXOYColor);


         Gl.glTexCoord3f(-x, 0, -x); Gl.glVertex3f(-x, 0, -x);
         Gl.glTexCoord3f(x, 0, -x); Gl.glVertex3f(x, 0, -x);
         Gl.glTexCoord3f(x, 0, x); Gl.glVertex3f(x, 0, x);
         Gl.glTexCoord3f(-x, 0, x); Gl.glVertex3f(-x, 0, x);

         Gl.glEnd();

      }

      float[] color = { 1, 0, 1, 1 }, shininess = { 30 };

      Atwood_machine Atwood_machine;
      float Mainheight = 8, Leftheight = 4, Rightheight = 4, angle = 0;
      private void Draw()
      {

         Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
         Gl.glLoadIdentity();

         // установка порта вывода в соответствии с размерами элемента anT 
         Gl.glViewport(0, 0, AnT.Width, AnT.Height);
         // настройка проекции 
         Gl.glMatrixMode(Gl.GL_PROJECTION);
         Gl.glLoadIdentity();
         Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
         cam.Look();
         DrawGrid(10);

         Gl.glMatrixMode(Gl.GL_MODELVIEW);
         Gl.glLoadIdentity();
         // настройка параметров OpenGL для визуализации 

         Gl.glPushMatrix();
         Gl.glTranslated(0, 0, -1);
         Gl.glRotated(0, 0, 0, 0);
         // рисуем цилиндр с помощью библиотеки FreeGLUT
         Atwood_machine.instalation.Height = Mainheight;
         Atwood_machine.Left_rope.Height = Leftheight;
         Atwood_machine.Right_rope.Height = Rightheight;
         Atwood_machine.disk.Angle = angle;

         Gl.glColor3d(1, 1, 255);
         Atwood_machine.Draw();

         Gl.glPopMatrix();
         Gl.glFlush();
         AnT.Invalidate();

      }
      public Form1()
      {
         InitializeComponent();
         AnT.InitializeContexts();
         timer1.Enabled = true;
		 chart1.ChartAreas[0].AxisX.Interval = 0.1;
		 chart1.ChartAreas[0].AxisX.Minimum = 0;
		 chart2.ChartAreas[0].AxisX.Interval = 0.1;
		 chart2.ChartAreas[0].AxisX.Minimum = 0;
		 chart2.ChartAreas[0].AxisY.Minimum = 0;
		 //chart1.ChartAreas[0].AxisY.Minimum = 0;
		 chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
		 chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
		 chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
		 chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
		 chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
		 chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
		 chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
		 chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
		 chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
		 chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
		 chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
		 chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
		 chart2.ChartAreas[0].CursorY.IsUserEnabled = true;
		 chart2.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
		 chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
		 chart2.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

		}

		float t = 0.1f;
		bool b = false;
		bool kostyl;
		private void Massbody1_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Massbody1.Text.Length != 8)
         {
            if (Massbody1.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }
         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               Massbody2.Focus();
         }
         e.Handled = true;
      }

      private void Massbody2_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Massbody2.Text.Length != 8)
         {
            if (Massbody2.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }

         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               Disk_mass.Focus();
         }
         e.Handled = true;
      }

      private void Disk_mass_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = false;
         if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            return;
         if (e.KeyChar == '.')
            e.KeyChar = ',';
         if (e.KeyChar == ',' && Disk_mass.Text.Length != 8)
         {
            if (Disk_mass.Text.IndexOf(',') != -1)
               e.Handled = true;
            return;
         }
         if (Char.IsControl(e.KeyChar))
         {
            if (e.KeyChar == (char)Keys.Back)
            {
               e.Handled = false;
               return;
            };
            if (e.KeyChar == (char)Keys.Enter)
               StartBottom.Focus();
         }
         e.Handled = true;
      }

      private void AnT_Load(object sender, EventArgs e)
      {
         InitGL();
         Atwood_machine = new Atwood_machine(1, 2, 5, (float)Main_Height.Value / 10);
         Draw();
      }

      private void Form1_SizeChanged(object sender, EventArgs e)
      {
         Control control = (Control)sender;
         control.Size = new Size(control.Size.Width, control.Size.Height);
         Draw();

      }
      bool mouseRotate, mouseScale, mouseMove = false;
      int myMouseYcoord, myMouseXcoord, myMouseXcoordVar, myMouseYcoordVar;
      float rot_cam_X;

      private void AnT_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
            mouseRotate = true;
         // Если нажата левая кнопка мыши
         if (e.Button == MouseButtons.Middle)
            mouseMove = true;
         if (e.Button == MouseButtons.Right)
            mouseScale = true;
         // Если нажата средняя кнопка мыши 
         myMouseYcoord = e.X;
         // Передаем в нашу глобальную переменную позицию мыши по Х 
         myMouseXcoord = e.Y;
      }

      private void AnT_MouseUp(object sender, MouseEventArgs e)
      {
         mouseRotate = false;
         mouseMove = false;
         mouseScale = false;
      }


	  float[] DtDf = new float[2];

	  private void Form1_Load(object sender, EventArgs e)
	  {
		label9.Text = (Mainheight - Rightheight - 1).ToString();
		label10.Text = (Mainheight - Leftheight - 1).ToString();
		AnT.Visible = true;
		chart2.Visible = false;
		chart1.Visible = false;	
	  }

	  Stopwatch stopWatch = new Stopwatch();

	  private void vTToolStripMenuItem_Click(object sender, EventArgs e)
	  {
	  	AnT.Visible = false;
	  	chart2.Visible = false;
	  	chart1.Visible = true;
	  	eTToolStripMenuItem.Enabled = true;
	  	сценаToolStripMenuItem.Enabled = true;
	  	vTToolStripMenuItem.Enabled = false;
	  	TimerLabel.Visible = false;
	  }

	   private void eTToolStripMenuItem_Click(object sender, EventArgs e)
	   {
	   	AnT.Visible = false;
	   	chart2.Visible = true;
	   	chart1.Visible = false;
	   	eTToolStripMenuItem.Enabled = false;
	   	сценаToolStripMenuItem.Enabled = true;
	   	vTToolStripMenuItem.Enabled = true;
	   	TimerLabel.Visible = false;
	   }
	   
	   private void сценаToolStripMenuItem_Click(object sender, EventArgs e)
	   {
	   	AnT.Visible = true;
	   	chart2.Visible = false;
	   	chart1.Visible = false;
	   	eTToolStripMenuItem.Enabled = true;
	   	сценаToolStripMenuItem.Enabled = false;
	   	vTToolStripMenuItem.Enabled = true;
	   	TimerLabel.Visible = true;
	   }
	   
	   Stopwatch stopWatch2 = new Stopwatch();




      float Gacc = 9.8f;



      private void label11_Click(object sender, EventArgs e)
      {

      }



		Stopwatch FrameTime = new Stopwatch();
	   
	   private void StartBottom_Click(object sender, EventArgs e)
      {
         if (Massbody1.Text == "" || Massbody2.Text == "" || Disk_mass.Text == "")
         {
            MessageBox.Show("Введите все необходимые данные."
                        , "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
            StartBottom.Enabled = true;
            PauseBottom.Enabled = false;
         }
         else
         {

            StartBottom.Enabled = false;
            PauseBottom.Enabled = true;
            TimerLabel.Visible = true;
            kostyl = false;
            Atwood_machine.Right_body.Mass = float.Parse(Massbody1.Text);
            Atwood_machine.Leftt_body.Mass = float.Parse(Massbody2.Text);
            Atwood_machine.disk.Mass = float.Parse(Disk_mass.Text);
            string[] s = comboBox1.Text.ToString().Split(' ');
            if (s.Length == 3)
            { 
               Gacc = float.Parse(s[2]);
            }
            else Gacc = float.Parse(comboBox1.Text);
            DtDf = AtwoodCalc.Compute(Atwood_machine.Right_body.Mass,
												Atwood_machine.Leftt_body.Mass, Gacc,
                                    Atwood_machine.disk.Mass, 0,
												true);
				chart1.Series[0].Points.AddXY(0, -AtwoodCalc.v);
				chart1.Series[1].Points.AddXY(0, AtwoodCalc.v);
				chart2.Series[0].Points.AddXY(0, Atwood_machine.Right_body.Mass * AtwoodCalc.v * AtwoodCalc.v / 2);
				chart2.Series[1].Points.AddXY(0, Atwood_machine.Leftt_body.Mass * AtwoodCalc.v * AtwoodCalc.v / 2);
				chart2.Series[2].Points.AddXY(0, (Mainheight - Rightheight - 1) * Atwood_machine.Right_body.Mass * 9.8f);
				chart2.Series[3].Points.AddXY(0, (Mainheight - Leftheight - 1) * Atwood_machine.Leftt_body.Mass * 9.8f);
				b = true;
				if (Leftheight >= Atwood_machine.instalation.Height - 1.1)
				{
					Leftheight = Atwood_machine.instalation.Height - 1.1005f;
					Rightheight = Atwood_machine.instalation.Height - Leftheight;
				}
				else
				{
					if (Rightheight >= Atwood_machine.instalation.Height - 1.1)
					{
						Rightheight = Atwood_machine.instalation.Height - 1.1005f;
						Leftheight = Atwood_machine.instalation.Height - Rightheight;

					}
				}
				stopWatch.Start();
				stopWatch2.Start();
				FrameTime.Start();
			}
		}
		float t1 = 0;
		private void ResetBottom_Click(object sender, EventArgs e)
		{
			StartBottom.Enabled = true;
			PauseBottom.Enabled = false;
			TimerLabel.Visible = false;
			TimerLabel.Text = "0";
			PauseBottom.Text = "Пауза";
			isPaused = false;
			Main_Height.Enabled = true;
			Rightheight = Atwood_machine.instalation.Height / 2;
			Leftheight = Atwood_machine.instalation.Height / 2;
			angle = 0;
			stopWatch.Stop();
			stopWatch.Reset();
			stopWatch2.Stop();
			stopWatch2.Reset();
			b = false;
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart2.Series[0].Points.Clear();
			chart2.Series[1].Points.Clear();
			chart2.Series[2].Points.Clear();
			chart2.Series[3].Points.Clear();
			chart1.ChartAreas[0].AxisX.Interval = 0.1;
			chart2.ChartAreas[0].AxisX.Interval = 0.1;
			t = 0.1f;
			t1 = 0;
			label9.Text = (Mainheight - Rightheight - 1).ToString();
			label10.Text = (Mainheight - Leftheight - 1).ToString();
		}
      bool isPaused = false;
      private void PauseBottom_Click(object sender, EventArgs e)
      {
			if (!isPaused)
			{
				stopWatch.Stop();
				stopWatch2.Stop();
				b = false;
				PauseBottom.Text = "Продолжить";
				isPaused = true;

			}
			else
			{
				b = true;
				PauseBottom.Text = "Пауза";
				isPaused = false;
				stopWatch.Start();
				stopWatch2.Start();
			}
		}
		
      private void timer1_Tick_1(object sender, EventArgs e)
      {
			
			//FrameTime.Stop();
			float s = FrameTime.Elapsed.Milliseconds;
			mouse_Events();
			cam.update();
			float t2 = 0;
			FrameTime.Restart();
			label9.Text = Math.Round((Leftheight - 1), 2).ToString();
			label10.Text = Math.Round((Rightheight - 1), 2).ToString();


			if (b)
			{

				
				
				Main_Height.Enabled = false;


				if (Rightheight < Atwood_machine.instalation.Height - 1 && Leftheight < Atwood_machine.instalation.Height - 1)
				{ 
					
					DtDf = AtwoodCalc.Compute(Atwood_machine.Right_body.Mass,
													Atwood_machine.Leftt_body.Mass, Gacc,
                                       Atwood_machine.disk.Mass, s * 0.001f,
													false);
					
					

					Leftheight = Leftheight - DtDf[0];
					Rightheight = Rightheight + DtDf[0];


					if (Leftheight < 1)
					{
						Leftheight = 1;
						Rightheight = Mainheight - Leftheight;
					} 
					 if (Rightheight < 1)
					{
						Rightheight = 1;
						Leftheight= Mainheight - Rightheight;
					}

					angle += DtDf[1];
					if (angle >= 360)
						angle -= 360;

					TimerLabel.Text = stopWatch.Elapsed.Seconds.ToString() + "." + stopWatch.Elapsed.Milliseconds.ToString();
					t1 += s * 0.001f;
					chart1.Series[0].Points.AddXY(t1, -AtwoodCalc.v) ;
					chart1.Series[1].Points.AddXY(t1, AtwoodCalc.v);
					
					chart2.Series[0].Points.AddXY(t1, Atwood_machine.Right_body.Mass * AtwoodCalc.v * AtwoodCalc.v / 2);
					chart2.Series[1].Points.AddXY(t1, Atwood_machine.Leftt_body.Mass* AtwoodCalc.v * AtwoodCalc.v / 2);
					chart2.Series[2].Points.AddXY(t1, (Mainheight - Rightheight - 1) * Atwood_machine.Right_body.Mass * 9.8f);
					chart2.Series[3].Points.AddXY(t1, (Mainheight - Leftheight - 1) * Atwood_machine.Leftt_body.Mass * 9.8f);

					t2 = t1;
					if (t1 > 20 * t)
					{
						t = t * 10;
						chart1.ChartAreas[0].AxisX.Interval = t;
						chart2.ChartAreas[0].AxisX.Interval = t;
					}

					//label9.Text = Math.Round((Leftheight-1),2).ToString();
					//label10.Text = Math.Round((Rightheight-1),2).ToString();

					
					
					

					
					
				}
				else
				{
					/*if (Atwood_machine.Right_body.Mass > Atwood_machine.Leftt_body.Mass)
					{
						Rightheight = Mainheight - 1;
						Leftheight = 1;
					}
					else
					{
						Rightheight = 1;
						Leftheight = Mainheight - 1;
					}
					label9.Text = Math.Round((Leftheight - 1), 1).ToString();
					label10.Text = Math.Round((Rightheight - 1), 1).ToString();*/
					
					
					stopWatch.Stop();
					stopWatch2.Stop();
					b = false;
					kostyl = true;
				}
			}
			else
			{
				if (Mainheight != (float)Main_Height.Value / 10)
				{
					Mainheight = (float)Main_Height.Value / 10;
					Rightheight = Mainheight / 2;
					Leftheight = Mainheight / 2;
					label4.Text = "Нынешняя высота: " + Mainheight;
				}
				if (kostyl != b)
				{
					if (Atwood_machine.Right_body.Mass > Atwood_machine.Leftt_body.Mass)
					{
						Rightheight = Mainheight - 1;
						Leftheight = 1;
					}
					else
					{
						Rightheight = 1;
						Leftheight = Mainheight - 1;
					}
					label9.Text = Math.Round((Leftheight - 1), 1).ToString();
					label10.Text = Math.Round((Rightheight - 1), 1).ToString();
					
					TimerLabel.Text = stopWatch.Elapsed.Seconds.ToString() + "." + stopWatch.Elapsed.Milliseconds.ToString();
					kostyl = false;
					PauseBottom.Enabled = false;
				}
			}
			Draw();
		}


      private void AnT_MouseMove(object sender, MouseEventArgs e)
      {
         myMouseXcoordVar = e.Y;
         myMouseYcoordVar = e.X;
      }

      private void mouse_Events()
      {
         if (mouseRotate == true) // Если нажата левая кнопка мыши 
         {
            AnT.Cursor = System.Windows.Forms.Cursors.SizeAll;
            //меняем указатель 
            cam.Rotate_Position((float)(myMouseYcoordVar - myMouseYcoord), 0, 1, 0);
            // крутим камеру, в моем случае вид у нее от третьего лица 
            rot_cam_X = rot_cam_X + (myMouseXcoordVar - myMouseXcoord);
            if ((rot_cam_X > -40) && (rot_cam_X < 40))
               cam.upDown(((float)(myMouseXcoordVar - myMouseXcoord)) / 10);
            else rot_cam_X = rot_cam_X - (myMouseXcoordVar - myMouseXcoord);
            myMouseYcoord = myMouseYcoordVar;
            myMouseXcoord = myMouseXcoordVar;
         }
         else if (mouseMove == true)
         {
            AnT.Cursor = Cursors.SizeAll;
            cam.Strafe(-((float)(myMouseXcoordVar - myMouseXcoord)) / 50);
            myMouseXcoord = myMouseXcoordVar;
         }
         else if (mouseScale == true)
         {
            AnT.Cursor = Cursors.SizeAll;
            cam.Scale(((float)(myMouseXcoordVar - myMouseXcoord)) / 50);
            myMouseXcoord = myMouseXcoordVar;
         }
         else AnT.Cursor = Cursors.Default; // возвращаем курсор 
      }
   }
}
