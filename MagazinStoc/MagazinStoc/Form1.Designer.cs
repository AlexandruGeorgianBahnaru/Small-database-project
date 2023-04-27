namespace MagazinStoc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDistribuitor = new System.Windows.Forms.TextBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.toolTipSterge = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(890, 519);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(237, 64);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(13, 526);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(168, 57);
            this.buttonAdauga.TabIndex = 1;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Denumire:";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(105, 16);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(146, 22);
            this.textBoxDenumire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantitate:";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(105, 52);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(146, 22);
            this.textBoxCantitate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pret:";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(105, 88);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(146, 22);
            this.textBoxPret.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distribuitor:";
            // 
            // textBoxDistribuitor
            // 
            this.textBoxDistribuitor.Location = new System.Drawing.Point(105, 124);
            this.textBoxDistribuitor.Name = "textBoxDistribuitor";
            this.textBoxDistribuitor.Size = new System.Drawing.Size(146, 22);
            this.textBoxDistribuitor.TabIndex = 9;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(189, 526);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(168, 57);
            this.buttonSterge.TabIndex = 10;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            this.buttonSterge.MouseHover += new System.EventHandler(this.buttonSterge_MouseHover);
            // 
            // toolTipSterge
            // 
            this.toolTipSterge.AutoPopDelay = 5000;
            this.toolTipSterge.InitialDelay = 100;
            this.toolTipSterge.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.textBoxDistribuitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDistribuitor;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.ToolTip toolTipSterge;
    }
}

