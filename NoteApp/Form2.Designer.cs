namespace NoteApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Done_cb = new MetroFramework.Controls.MetroCheckBox();
            this.Title_task = new MetroFramework.Controls.MetroTextBox();
            this.Add_task = new MetroFramework.Controls.MetroTile();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTextBox1);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Add_task);
            this.panel1.Location = new System.Drawing.Point(167, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 472);
            this.panel1.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(181, 423);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(145, 46);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Salvar";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bunifuCards1);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 357);
            this.panel3.TabIndex = 4;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Purple;
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(421, 67);
            this.bunifuCards1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Done_cb);
            this.panel2.Controls.Add(this.Title_task);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 61);
            this.panel2.TabIndex = 0;
            // 
            // Done_cb
            // 
            this.Done_cb.AutoSize = true;
            this.Done_cb.ForeColor = System.Drawing.Color.Red;
            this.Done_cb.Location = new System.Drawing.Point(4, 20);
            this.Done_cb.Name = "Done_cb";
            this.Done_cb.Size = new System.Drawing.Size(30, 15);
            this.Done_cb.Style = MetroFramework.MetroColorStyle.Green;
            this.Done_cb.TabIndex = 1;
            this.Done_cb.Text = "V";
            this.Done_cb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Done_cb.UseVisualStyleBackColor = true;
            // 
            // Title_task
            // 
            this.Title_task.CustomBackground = true;
            this.Title_task.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Title_task.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Title_task.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Title_task.Location = new System.Drawing.Point(40, 12);
            this.Title_task.Multiline = true;
            this.Title_task.Name = "Title_task";
            this.Title_task.PromptText = "Tarefa...";
            this.Title_task.Size = new System.Drawing.Size(275, 31);
            this.Title_task.TabIndex = 0;
            this.Title_task.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Title_task.Click += new System.EventHandler(this.Title_task_Click);
            // 
            // Add_task
            // 
            this.Add_task.Location = new System.Drawing.Point(3, 367);
            this.Add_task.Name = "Add_task";
            this.Add_task.Size = new System.Drawing.Size(170, 46);
            this.Add_task.TabIndex = 3;
            this.Add_task.Text = "Adionar Nova Tarefa";
            this.Add_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.Location = new System.Drawing.Point(6, 423);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(169, 35);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox Title_task;
        private MetroFramework.Controls.MetroCheckBox Done_cb;
        private MetroFramework.Controls.MetroTile Add_task;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}