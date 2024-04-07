using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atwood
{

   public partial class SplashScreen : Form
   {

      public SplashScreen()
      {
         InitializeComponent();
         this.Width = 920; 
         this.Height = 530; 
      }



      int t = 0;
      private void timer1_Tick(object sender, EventArgs e)
      {

         t++;
         // After fadeIn and fadeOut complete, stop the timer and close this splash.
         if (t == 5)
         {
            timer1.Stop();
            this.Close();
         }
      }

      private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
      {
         timer1.Stop();
         this.Close();
      }

		private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
		{
			timer1.Stop();
			this.Close();
		}

		private void SplashScreen_Deactivate(object sender, EventArgs e)
		{
			timer1.Stop();
			this.Close();
		}
	}
}

