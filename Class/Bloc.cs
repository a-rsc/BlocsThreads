using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacBlocs.Class
{
    class Bloc : Panel
    {
        public FrmMain fpare;

        protected List<Panel> llBlocs = new List<Panel>();

        protected int files, columnes, blocs, pixels, msegons;
        protected Timer tmPaint = new Timer();

        protected int cont=0;

        public Bloc(FrmMain fpare)
        {
            int max_xlocation, max_ylocation;

            this.Fpare=fpare;
            this.BackColor=ClConstants.RandomColor();
            this.BorderStyle=BorderStyle.FixedSingle;

            this.Files=ClConstants.Random(1, ClConstants.MAXBLOCS);
            this.Columnes=ClConstants.Random(1, ClConstants.MAXBLOCS);
            this.Blocs=this.Files*this.Columnes;
            this.Pixels=ClConstants.Random(15, 40);

            this.Size=new Size(this.Columnes*this.Pixels, this.Files*this.Pixels);

            max_xlocation=this.Fpare.Size.Width-this.Size.Width;
            max_ylocation=this.Fpare.Size.Height-this.Size.Height;

            this.Location=new Point(ClConstants.Random(0, max_xlocation), ClConstants.Random(0, max_ylocation));

            this.Fpare.Controls.Add(this);
            this.BringToFront();

            for(int i = 0; i<this.Files; i++)
            {
                for(int j = 0; j<this.Columnes; j++)
                {
                    Panel bloc=new Panel();
                    bloc.BackColor=this.BackColor;
                    bloc.Size=new Size(this.Pixels, this.Pixels);
                    bloc.Location=new Point(this.Location.X+this.Pixels*j, this.Location.Y+this.Pixels*i);
                    this.llBlocs.Add(bloc);
                    this.Fpare.Controls.Add(bloc);
                    bloc.BringToFront();
                }
            }
        }

        public FrmMain Fpare { get => fpare; set => fpare=value; }
        public List<Panel> LlBlocs { get => llBlocs; set => llBlocs=value; }
        public int Files { get => files; set => files=value; }
        public int Columnes { get => columnes; set => columnes=value; }
        public int Blocs { get => blocs; set => blocs=value; }
        public int Pixels { get => pixels; set => pixels=value; }
        public int Msegons { get => msegons; set => msegons=value; }
        public Timer TmPaint { get => tmPaint; set => tmPaint=value; }
        public int Cont { get => cont; set => cont=value; }
    }
}
