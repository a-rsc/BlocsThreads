using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacBlocs.Class
{
    class ClBlocThread : Bloc
    {
        //public delegate void ObjecteDelegat();

        public ClBlocThread(FrmMain fpare) : base(fpare)
        {
            //ObjecteDelegat delegat = new ObjecteDelegat(paint);
        }

        public void paint()
        {
            for(int i = 0; i<this.Blocs; i++)
            {
                llBlocs[i].BackColor=ClConstants.RandomColor();
                //this.llBlocs[i].BorderStyle=BorderStyle.FixedSingle;
                Thread.Sleep(1000);
            }
        }
    }
}
