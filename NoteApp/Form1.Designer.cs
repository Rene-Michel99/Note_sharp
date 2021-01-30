namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Control_panel = new System.Windows.Forms.Panel();
            this.Search_box = new MetroFramework.Controls.MetroTextBox();
            this.New_note_btn = new MetroFramework.Controls.MetroTile();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Count_notes_lb = new MetroFramework.Controls.MetroLabel();
            this.Notes_list_panel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Erase_btn = new MetroFramework.Controls.MetroTile();
            this.Save_btn = new MetroFramework.Controls.MetroTile();
            this.Title_note_box = new MetroFramework.Controls.MetroTextBox();
            this.Text_note_rtb = new System.Windows.Forms.RichTextBox();
            this.Sub_btn = new MetroFramework.Controls.MetroButton();
            this.Bold_btn = new MetroFramework.Controls.MetroButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_btn = new MetroFramework.Controls.MetroButton();
            this.Font_size_box = new System.Windows.Forms.NumericUpDown();
            this.Control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Font_size_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_panel
            // 
            this.Control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Control_panel.Controls.Add(this.Search_box);
            this.Control_panel.Controls.Add(this.New_note_btn);
            this.Control_panel.Location = new System.Drawing.Point(24, 29);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(186, 478);
            this.Control_panel.TabIndex = 0;
            // 
            // Search_box
            // 
            this.Search_box.CustomBackground = true;
            this.Search_box.CustomForeColor = true;
            this.Search_box.Location = new System.Drawing.Point(11, 24);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(163, 23);
            this.Search_box.Style = MetroFramework.MetroColorStyle.Black;
            this.Search_box.TabIndex = 1;
            this.Search_box.Text = "Pesquisar";
            this.Search_box.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // New_note_btn
            // 
            this.New_note_btn.ForeColor = System.Drawing.Color.Lavender;
            this.New_note_btn.Location = new System.Drawing.Point(22, 60);
            this.New_note_btn.Name = "New_note_btn";
            this.New_note_btn.Size = new System.Drawing.Size(139, 47);
            this.New_note_btn.Style = MetroFramework.MetroColorStyle.Purple;
            this.New_note_btn.TabIndex = 0;
            this.New_note_btn.Text = "+ Nova Nota";
            this.New_note_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_note_btn.Click += new System.EventHandler(this.New_note_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Location = new System.Drawing.Point(217, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.splitContainer1.Panel1.Controls.Add(this.Count_notes_lb);
            this.splitContainer1.Panel1.Controls.Add(this.Notes_list_panel);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.Erase_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Save_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Title_note_box);
            this.splitContainer1.Panel2.Controls.Add(this.Text_note_rtb);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(644, 478);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // Count_notes_lb
            // 
            this.Count_notes_lb.AutoSize = true;
            this.Count_notes_lb.CustomBackground = true;
            this.Count_notes_lb.CustomForeColor = true;
            this.Count_notes_lb.Location = new System.Drawing.Point(16, 47);
            this.Count_notes_lb.Name = "Count_notes_lb";
            this.Count_notes_lb.Size = new System.Drawing.Size(51, 19);
            this.Count_notes_lb.Style = MetroFramework.MetroColorStyle.Black;
            this.Count_notes_lb.TabIndex = 4;
            this.Count_notes_lb.Text = "0 notas";
            this.Count_notes_lb.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Notes_list_panel
            // 
            this.Notes_list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_list_panel.AutoScroll = true;
            this.Notes_list_panel.Location = new System.Drawing.Point(4, 98);
            this.Notes_list_panel.Name = "Notes_list_panel";
            this.Notes_list_panel.Size = new System.Drawing.Size(207, 377);
            this.Notes_list_panel.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(4, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Todas as Notas";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Font_size_box);
            this.panel1.Controls.Add(this.Color_btn);
            this.panel1.Controls.Add(this.Bold_btn);
            this.panel1.Controls.Add(this.Sub_btn);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 32);
            this.panel1.TabIndex = 6;
            // 
            // Erase_btn
            // 
            this.Erase_btn.Location = new System.Drawing.Point(348, 21);
            this.Erase_btn.Name = "Erase_btn";
            this.Erase_btn.Size = new System.Drawing.Size(75, 33);
            this.Erase_btn.Style = MetroFramework.MetroColorStyle.Red;
            this.Erase_btn.TabIndex = 5;
            this.Erase_btn.Text = "Apagar";
            this.Erase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Erase_btn.Click += new System.EventHandler(this.Erase_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(267, 21);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 33);
            this.Save_btn.Style = MetroFramework.MetroColorStyle.Green;
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Salvar";
            this.Save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Title_note_box
            // 
            this.Title_note_box.CustomBackground = true;
            this.Title_note_box.CustomForeColor = true;
            this.Title_note_box.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Title_note_box.Location = new System.Drawing.Point(3, 21);
            this.Title_note_box.Name = "Title_note_box";
            this.Title_note_box.Size = new System.Drawing.Size(258, 33);
            this.Title_note_box.Style = MetroFramework.MetroColorStyle.Black;
            this.Title_note_box.TabIndex = 3;
            this.Title_note_box.Text = "Nota sem nome";
            this.Title_note_box.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Text_note_rtb
            // 
            this.Text_note_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Text_note_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text_note_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_note_rtb.ForeColor = System.Drawing.SystemColors.Info;
            this.Text_note_rtb.Location = new System.Drawing.Point(3, 98);
            this.Text_note_rtb.Name = "Text_note_rtb";
            this.Text_note_rtb.Size = new System.Drawing.Size(420, 377);
            this.Text_note_rtb.TabIndex = 0;
            this.Text_note_rtb.Text = "";
            // 
            // Sub_btn
            // 
            this.Sub_btn.Location = new System.Drawing.Point(3, 6);
            this.Sub_btn.Name = "Sub_btn";
            this.Sub_btn.Size = new System.Drawing.Size(75, 23);
            this.Sub_btn.TabIndex = 1;
            this.Sub_btn.Text = "Sublinhado";
            this.Sub_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Sub_btn.Click += new System.EventHandler(this.Sub_btn_Click_1);
            // 
            // Bold_btn
            // 
            this.Bold_btn.Location = new System.Drawing.Point(84, 6);
            this.Bold_btn.Name = "Bold_btn";
            this.Bold_btn.Size = new System.Drawing.Size(75, 23);
            this.Bold_btn.TabIndex = 2;
            this.Bold_btn.Text = "Negrito";
            this.Bold_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Bold_btn.Click += new System.EventHandler(this.Bold_btn_Click);
            // 
            // Color_btn
            // 
            this.Color_btn.Location = new System.Drawing.Point(165, 6);
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(75, 23);
            this.Color_btn.TabIndex = 3;
            this.Color_btn.Text = "Cor";
            this.Color_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // Font_size_box
            // 
            this.Font_size_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Font_size_box.ForeColor = System.Drawing.Color.White;
            this.Font_size_box.Location = new System.Drawing.Point(247, 6);
            this.Font_size_box.Name = "Font_size_box";
            this.Font_size_box.Size = new System.Drawing.Size(33, 20);
            this.Font_size_box.TabIndex = 4;
            this.Font_size_box.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Font_size_box.ValueChanged += new System.EventHandler(this.Font_size_box_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Control_panel);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control_panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Font_size_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_panel;
        private MetroFramework.Controls.MetroTile New_note_btn;
        private MetroFramework.Controls.MetroTextBox Search_box;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox Text_note_rtb;
        private MetroFramework.Controls.MetroTextBox Title_note_box;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile Erase_btn;
        private MetroFramework.Controls.MetroTile Save_btn;
        private System.Windows.Forms.Panel Notes_list_panel;
        private MetroFramework.Controls.MetroLabel Count_notes_lb;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton Sub_btn;
        private MetroFramework.Controls.MetroButton Bold_btn;
        private MetroFramework.Controls.MetroButton Color_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown Font_size_box;
    }
}

