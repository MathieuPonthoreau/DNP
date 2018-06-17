namespace WindowsFormsTempConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.buttonFtoC = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelText_2 = new System.Windows.Forms.Label();
            this.labelText_3 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(66, 131);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(75, 23);
            this.buttonCtoF.TabIndex = 0;
            this.buttonCtoF.Text = "Here";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new System.Drawing.Point(253, 131);
            this.buttonFtoC.Name = "buttonFtoC";
            this.buttonFtoC.Size = new System.Drawing.Size(75, 23);
            this.buttonFtoC.TabIndex = 1;
            this.buttonFtoC.Text = "Here";
            this.buttonFtoC.UseVisualStyleBackColor = true;
            this.buttonFtoC.Click += new System.EventHandler(this.buttonFtoC_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(137, 172);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 2;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(66, 72);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemp.TabIndex = 3;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(66, 53);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(96, 13);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Input temperature :";
            // 
            // labelText_2
            // 
            this.labelText_2.AutoSize = true;
            this.labelText_2.Location = new System.Drawing.Point(66, 112);
            this.labelText_2.Name = "labelText_2";
            this.labelText_2.Size = new System.Drawing.Size(105, 13);
            this.labelText_2.TabIndex = 5;
            this.labelText_2.Text = "Celsius to Fahrenheit";
            // 
            // labelText_3
            // 
            this.labelText_3.AutoSize = true;
            this.labelText_3.Location = new System.Drawing.Point(253, 111);
            this.labelText_3.Name = "labelText_3";
            this.labelText_3.Size = new System.Drawing.Size(105, 13);
            this.labelText_3.TabIndex = 6;
            this.labelText_3.Text = "Farhenheit to Celsius";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(159, 222);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(120, 95);
            this.listBoxResult.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.labelText_3);
            this.Controls.Add(this.labelText_2);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Button buttonFtoC;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText_2;
        private System.Windows.Forms.Label labelText_3;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

