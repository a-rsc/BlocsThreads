
namespace PacBlocs
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewBlock = new System.Windows.Forms.Button();
            this.btnNewBlockThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBlock
            // 
            this.btnNewBlock.Location = new System.Drawing.Point(13, 13);
            this.btnNewBlock.Name = "btnNewBlock";
            this.btnNewBlock.Size = new System.Drawing.Size(150, 23);
            this.btnNewBlock.TabIndex = 0;
            this.btnNewBlock.Text = "ClBloc (sequencial)";
            this.btnNewBlock.UseVisualStyleBackColor = true;
            this.btnNewBlock.Click += new System.EventHandler(this.btnNewBlock_Click);
            // 
            // btnNewBlockThread
            // 
            this.btnNewBlockThread.Location = new System.Drawing.Point(13, 42);
            this.btnNewBlockThread.Name = "btnNewBlockThread";
            this.btnNewBlockThread.Size = new System.Drawing.Size(150, 23);
            this.btnNewBlockThread.TabIndex = 1;
            this.btnNewBlockThread.Text = "ClBloc (thread)";
            this.btnNewBlockThread.UseVisualStyleBackColor = true;
            this.btnNewBlockThread.Click += new System.EventHandler(this.btnNewBlockThread_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnNewBlockThread);
            this.Controls.Add(this.btnNewBlock);
            this.Name = "FrmMain";
            this.Text = "Practica Blocs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewBlock;
        private System.Windows.Forms.Button btnNewBlockThread;
    }
}

