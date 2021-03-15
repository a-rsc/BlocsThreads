using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PacBlocs.Class
{
    class ClConstants
    {
        public static Color RandomColor()
        {
            Random r = new Random();

            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)); ;
        }

        public static List<SoundPlayer> initSounds()
        {
            List<SoundPlayer> llSounds = new List<SoundPlayer>
            {
                //new SoundPlayer(Application.StartupPath + @"\..\..\applause.wav"),
                //new SoundPlayer(Application.StartupPath + @"\..\..\boo.wav")
            };

            return llSounds;
        }

        public static int Random(int min, int max)
        {
            Random r = new Random();

            System.Threading.Thread.Sleep(2);
            return r.Next(min, max + 1);
        }

    }
}
