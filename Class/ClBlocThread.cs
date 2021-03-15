using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacBlocs.Class
{
    class ClBlocThread : Panel
    {
        private readonly int MAXBLOCS = 10;
        private FrmMain fpare;

        private List<Panel> llBlocs = new List<Panel>();

        private int files, columnes, msegons, pixels;
        private Timer tmPaint = new Timer();

        private int contF = 0, contC = 0;

        public event EventHandler jatà;

        private delegate void delegat();

        public ClBlocThread(FrmMain fpare)
        {
            int max_xlocation, max_ylocation;

            this.Fpare=fpare;
            this.BackColor=ClConstants.RandomColor();
            this.BorderStyle=BorderStyle.FixedSingle;

            this.Files=ClConstants.Random(1, this.MAXBLOCS);
            this.Columnes=ClConstants.Random(1, this.MAXBLOCS);
            this.Pixels=ClConstants.Random(15, 40);

            this.Size=new Size(this.Columnes*this.Pixels, this.Files*this.Pixels);

            max_xlocation=this.Fpare.Size.Width-this.Size.Width;
            max_ylocation=this.Fpare.Size.Height-this.Size.Height;

            this.Location=new Point(ClConstants.Random(0, max_xlocation), ClConstants.Random(0, max_ylocation));

            this.Fpare.Invoke(new delegat(iniBloc));
        }

        private void iniBloc()
        {
            this.Fpare.Controls.Add(this);
            this.BringToFront();

            tmPaint.Interval=ClConstants.Random(2, 50)*10;
            tmPaint.Tick+=new EventHandler(tmPaint_Tick);
            tmPaint.Start();
        }

        private void tmPaint_Tick(object sender, EventArgs e)
        {
            Panel bloc = new Panel();

            bloc.BackColor=ClConstants.RandomColor();
            bloc.BorderStyle=BorderStyle.FixedSingle;
            bloc.Size=new Size(this.Pixels, this.Pixels);
            bloc.Location=new Point(this.Location.X+this.Pixels*this.ContC, this.Location.Y+this.Pixels*this.ContF);
            this.llBlocs.Add(bloc);
            this.Fpare.Controls.Add(bloc);
            bloc.BringToFront();

            if(this.ContC<this.Columnes-1)
            {
                this.ContC++;
            }
            else if(this.ContF<this.Files-1)
            {
                this.ContC=0;
                this.ContF++;
            }
            else
            {
                tmPaint.Stop();
                // Llenço l'event per alliberar memòria...
                jatà(this, EventArgs.Empty);
            }
        }

        public FrmMain Fpare { get => fpare; set => fpare=value; }
        public List<Panel> LlBlocs { get => llBlocs; set => llBlocs=value; }
        public int Files { get => files; set => files=value; }
        public int Columnes { get => columnes; set => columnes=value; }
        public int Msegons { get => msegons; set => msegons=value; }
        public int Pixels { get => pixels; set => pixels=value; }
        public Timer TmPaint { get => tmPaint; set => tmPaint=value; }
        public int ContF { get => contF; set => contF=value; }
        public int ContC { get => contC; set => contC=value; }
    }
}
