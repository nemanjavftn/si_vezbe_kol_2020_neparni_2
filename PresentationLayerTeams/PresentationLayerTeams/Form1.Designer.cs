
namespace PresentationLayerTeams
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCOACH = new System.Windows.Forms.TextBox();
            this.textBoxpOINTS = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.Location = new System.Drawing.Point(13, 177);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(251, 199);
            this.listBoxIspis.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(31, 58);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(38, 13);
            this.labelCoach.TabIndex = 3;
            this.labelCoach.Text = "Coach";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(31, 88);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(58, 13);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "labelPoints";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCOACH
            // 
            this.textBoxCOACH.Location = new System.Drawing.Point(134, 58);
            this.textBoxCOACH.Name = "textBoxCOACH";
            this.textBoxCOACH.Size = new System.Drawing.Size(100, 20);
            this.textBoxCOACH.TabIndex = 6;
            // 
            // textBoxpOINTS
            // 
            this.textBoxpOINTS.Location = new System.Drawing.Point(134, 88);
            this.textBoxpOINTS.Name = "textBoxpOINTS";
            this.textBoxpOINTS.Size = new System.Drawing.Size(100, 20);
            this.textBoxpOINTS.TabIndex = 7;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(134, 126);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxpOINTS);
            this.Controls.Add(this.textBoxCOACH);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelCoach);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIspis;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCOACH;
        private System.Windows.Forms.TextBox textBoxpOINTS;
        private System.Windows.Forms.Button buttonDodaj;
    }
}

