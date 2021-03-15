using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PacBlocs.Class;

namespace PacBlocs
{
    public partial class FrmMain : Form
    {
        List<ClBloc> llBloc = new List<ClBloc>();
        List<ClBlocThread> llBlocThread = new List<ClBlocThread>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNewBlock_Click(object sender, EventArgs e)
        {
            llBloc.Add(new ClBloc(this));
            llBloc[llBloc.Count-1].jatà+=new EventHandler(fiBloc);

        }

        private void btnNewBlockThread_Click(object sender, EventArgs e)
        {
            llBlocThread.Add(new ClBlocThread(this));
            llBlocThread[llBlocThread.Count-1].jatà+=new EventHandler(fiBloc);
        }

        private void fiBloc(object sender, EventArgs e)
        {
            // Debug.WriteLine(sender.GetType());
            if(sender is ClBloc)
            {
                // Allibero memòria...
                // Debug.WriteLine("ClBloc");               
                // this.Controls.Remove((ClBloc)sender); -> només es borra el panel base no la resta de panels fills
                llBloc.Remove((ClBloc)sender);
            }
            else if(sender is ClBlocThread)
            {
                // Allibero memòria...
                // Debug.WriteLine("ClBlocThread");
                // this.Controls.Remove((ClBlocThread)sender); -> només es borra el panel base no la resta de panels fills
                llBlocThread.Remove((ClBlocThread)sender);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // tanquem ordenadament els threads
            foreach(ClBlocThread th in llBlocThread)
            {
                // ???
            }
        }
    }
}
