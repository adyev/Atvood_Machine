using System.Drawing;
namespace Atwood
{


	public interface Drawing
	{
		void LoadTexture(Bitmap textureImage, bool flip);

	}

	class Atwood_machine
    {
        public Instalation instalation;
        public Disk disk;
        public Rope Left_rope;
        public Rope Right_rope;
        public Body Right_body;
        public Body Leftt_body;

        public void Draw()
        {
            instalation.Draw();
            disk.Draw(instalation);
            Left_rope.Draw(instalation.Height);
            Right_rope.Draw(instalation.Height);
            Right_body.Draw(instalation.Height, Right_rope.Height);
            Leftt_body.Draw(instalation.Height, Left_rope.Height);
        }
        public Atwood_machine(float m1, float m2, float md, float inst_height)
        {
            instalation = new Instalation(inst_height);
            disk = new Disk(md);
            Left_rope = new Rope(instalation.Height, false);
            Right_rope = new Rope(instalation.Height, true);
            Right_body = new Body(m1, true);
            Leftt_body = new Body(m2, false);
        }

    }
}
