using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacBlocs.Class
{
    class ClBloc : Bloc
    {
        public event EventHandler jatà;

        public ClBloc(FrmMain fpare) : base(fpare)
        {
            tmPaint.Interval=ClConstants.Random(2, 50)*10;
            tmPaint.Tick+=new EventHandler(tmPaint_Tick);
            tmPaint.Start();
        }

        private void tmPaint_Tick(object sender, EventArgs e)
        {
            if (this.cont < this.Blocs)
            {
                this.llBlocs[this.cont].BackColor=ClConstants.RandomColor();
                //this.llBlocs[this.cont].BorderStyle=BorderStyle.FixedSingle;

                this.cont++;
            }
            else
            {
                tmPaint.Stop();
                // Llenço l'event per alliberar memòria...
                jatà(this, EventArgs.Empty);
            }
        }
    }
}
