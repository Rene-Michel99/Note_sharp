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
            this.Show_lists_btn = new MetroFramework.Controls.MetroButton();
            this.Show_notes_btn = new MetroFramework.Controls.MetroButton();
            this.New_list_btn = new MetroFramework.Controls.MetroTile();
            this.Search_box = new MetroFramework.Controls.MetroTextBox();
            this.New_note_btn = new MetroFramework.Controls.MetroTile();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Holder_panel = new System.Windows.Forms.Panel();
            this.Notes_list_panel = new System.Windows.Forms.Panel();
            this.Count_notes_lb = new MetroFramework.Controls.MetroLabel();
            this.Top_lb = new MetroFramework.Controls.MetroLabel();
            this.Note_cr_pn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title_note_box = new MetroFramework.Controls.MetroTextBox();
            this.Save_btn = new MetroFramework.Controls.MetroTile();
            this.Erase_btn = new MetroFramework.Controls.MetroTile();
            this.Text_note_rtb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Italic_btn = new MetroFramework.Controls.MetroButton();
            this.Color_btn = new MetroFramework.Controls.MetroButton();
            this.Font_size_box = new System.Windows.Forms.NumericUpDown();
            this.Strikeout_btn = new MetroFramework.Controls.MetroButton();
            this.Bold_btn = new MetroFramework.Controls.MetroButton();
            this.Sub_btn = new MetroFramework.Controls.MetroButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Holder_panel.SuspendLayout();
            this.Note_cr_pn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Font_size_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_panel
            // 
            this.Control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Control_panel.Controls.Add(this.Show_lists_btn);
            this.Control_panel.Controls.Add(this.Show_notes_btn);
            this.Control_panel.Controls.Add(this.New_list_btn);
            this.Control_panel.Controls.Add(this.Search_box);
            this.Control_panel.Controls.Add(this.New_note_btn);
            this.Control_panel.Location = new System.Drawing.Point(24, 29);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(186, 478);
            this.Control_panel.TabIndex = 0;
            // 
            // Show_lists_btn
            // 
            this.Show_lists_btn.Location = new System.Drawing.Point(11, 113);
            this.Show_lists_btn.Name = "Show_lists_btn";
            this.Show_lists_btn.Size = new System.Drawing.Size(163, 53);
            this.Show_lists_btn.TabIndex = 4;
            this.Show_lists_btn.Text = "Listas";
            this.Show_lists_btn.Click += new System.EventHandler(this.Show_lists_btn_Click);
            // 
            // Show_notes_btn
            // 
            this.Show_notes_btn.Location = new System.Drawing.Point(11, 54);
            this.Show_notes_btn.Name = "Show_notes_btn";
            this.Show_notes_btn.Size = new System.Drawing.Size(163, 53);
            this.Show_notes_btn.TabIndex = 3;
            this.Show_notes_btn.Text = "Notas";
            this.Show_notes_btn.Click += new System.EventHandler(this.Show_notes_btn_Click);
            // 
            // New_list_btn
            // 
            this.New_list_btn.Location = new System.Drawing.Point(11, 225);
            this.New_list_btn.Name = "New_list_btn";
            this.New_list_btn.Size = new System.Drawing.Size(163, 52);
            this.New_list_btn.TabIndex = 2;
            this.New_list_btn.Text = "+ Nova Lista";
            this.New_list_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_list_btn.Click += new System.EventHandler(this.New_list_btn_Click);
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
            this.New_note_btn.Location = new System.Drawing.Point(11, 172);
            this.New_note_btn.Name = "New_note_btn";
            this.New_note_btn.Size = new System.Drawing.Size(163, 47);
            this.New_note_btn.Style = MetroFramework.MetroColorStyle.Purple;
            this.New_note_btn.TabIndex = 0;
            this.New_note_btn.Text = "+ Nova Nota";
            this.New_note_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_note_btn.Click += new System.EventHandler(this.New_note_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Location = new System.Drawing.Point(217, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.splitContainer1.Panel1.Controls.Add(this.Holder_panel);
            this.splitContainer1.Panel1.Controls.Add(this.Count_notes_lb);
            this.splitContainer1.Panel1.Controls.Add(this.Top_lb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.Note_cr_pn);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(714, 478);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // Holder_panel
            // 
            this.Holder_panel.Controls.Add(this.Notes_list_panel);
            this.Holder_panel.Location = new System.Drawing.Point(4, 98);
            this.Holder_panel.Name = "Holder_panel";
            this.Holder_panel.Size = new System.Drawing.Size(223, 374);
            this.Holder_panel.TabIndex = 5;
            // 
            // Notes_list_panel
            // 
            this.Notes_list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_list_panel.AutoScroll = true;
            this.Notes_list_panel.Location = new System.Drawing.Point(3, 3);
            this.Notes_list_panel.Name = "Notes_list_panel";
            this.Notes_list_panel.Size = new System.Drawing.Size(217, 368);
            this.Notes_list_panel.TabIndex = 3;
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
            // Top_lb
            // 
            this.Top_lb.AutoSize = true;
            this.Top_lb.CustomBackground = true;
            this.Top_lb.CustomForeColor = true;
            this.Top_lb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Top_lb.Location = new System.Drawing.Point(4, 22);
            this.Top_lb.Name = "Top_lb";
            this.Top_lb.Size = new System.Drawing.Size(124, 25);
            this.Top_lb.Style = MetroFramework.MetroColorStyle.Black;
            this.Top_lb.TabIndex = 2;
            this.Top_lb.Text = "Todas as Notas";
            this.Top_lb.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Note_cr_pn
            // 
            this.Note_cr_pn.Controls.Add(this.panel2);
            this.Note_cr_pn.Controls.Add(this.Text_note_rtb);
            this.Note_cr_pn.Controls.Add(this.panel1);
            this.Note_cr_pn.Location = new System.Drawing.Point(6, 3);
            this.Note_cr_pn.Name = "Note_cr_pn";
            this.Note_cr_pn.Size = new System.Drawing.Size(467, 472);
            this.Note_cr_pn.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Title_note_box);
            this.panel2.Controls.Add(this.Save_btn);
            this.panel2.Controls.Add(this.Erase_btn);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 41);
            this.panel2.TabIndex = 7;
            // 
            // Title_note_box
            // 
            this.Title_note_box.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Title_note_box.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Title_note_box.Location = new System.Drawing.Point(3, 5);
            this.Title_note_box.Multiline = true;
            this.Title_note_box.Name = "Title_note_box";
            this.Title_note_box.Size = new System.Drawing.Size(257, 33);
            this.Title_note_box.TabIndex = 6;
            this.Title_note_box.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(267, 5);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(83, 33);
            this.Save_btn.Style = MetroFramework.MetroColorStyle.Green;
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Salvar";
            this.Save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Erase_btn
            // 
            this.Erase_btn.Location = new System.Drawing.Point(356, 5);
            this.Erase_btn.Name = "Erase_btn";
            this.Erase_btn.Size = new System.Drawing.Size(85, 33);
            this.Erase_btn.Style = MetroFramework.MetroColorStyle.Red;
            this.Erase_btn.TabIndex = 5;
            this.Erase_btn.Text = "Apagar";
            this.Erase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Erase_btn.Click += new System.EventHandler(this.Erase_btn_Click);
            // 
            // Text_note_rtb
            // 
            this.Text_note_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_note_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text_note_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_note_rtb.ForeColor = System.Drawing.SystemColors.Info;
            this.Text_note_rtb.Location = new System.Drawing.Point(5, 95);
            this.Text_note_rtb.Name = "Text_note_rtb";
            this.Text_note_rtb.Size = new System.Drawing.Size(459, 374);
            this.Text_note_rtb.TabIndex = 0;
            this.Text_note_rtb.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Italic_btn);
            this.panel1.Controls.Add(this.Color_btn);
            this.panel1.Controls.Add(this.Font_size_box);
            this.panel1.Controls.Add(this.Strikeout_btn);
            this.panel1.Controls.Add(this.Bold_btn);
            this.panel1.Controls.Add(this.Sub_btn);
            this.panel1.Location = new System.Drawing.Point(5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 32);
            this.panel1.TabIndex = 6;
            // 
            // Italic_btn
            // 
            this.Italic_btn.Location = new System.Drawing.Point(327, 6);
            this.Italic_btn.Name = "Italic_btn";
            this.Italic_btn.Size = new System.Drawing.Size(75, 23);
            this.Italic_btn.TabIndex = 6;
            this.Italic_btn.Text = "Itálico";
            this.Italic_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Italic_btn.Click += new System.EventHandler(this.Italic_btn_Click);
            // 
            // Color_btn
            // 
            this.Color_btn.Location = new System.Drawing.Point(246, 6);
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(75, 23);
            this.Color_btn.TabIndex = 5;
            this.Color_btn.Text = "Cor";
            this.Color_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // Font_size_box
            // 
            this.Font_size_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Font_size_box.ForeColor = System.Drawing.Color.White;
            this.Font_size_box.Location = new System.Drawing.Point(404, 6);
            this.Font_size_box.Name = "Font_size_box";
            this.Font_size_box.Size = new System.Drawing.Size(38, 20);
            this.Font_size_box.TabIndex = 4;
            this.Font_size_box.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Font_size_box.ValueChanged += new System.EventHandler(this.Font_size_box_ValueChanged);
            // 
            // Strikeout_btn
            // 
            this.Strikeout_btn.Location = new System.Drawing.Point(165, 6);
            this.Strikeout_btn.Name = "Strikeout_btn";
            this.Strikeout_btn.Size = new System.Drawing.Size(75, 23);
            this.Strikeout_btn.TabIndex = 3;
            this.Strikeout_btn.Text = "Tachado";
            this.Strikeout_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Strikeout_btn.Click += new System.EventHandler(this.Strikeout_btn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 530);
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
            this.Holder_panel.ResumeLayout(false);
            this.Note_cr_pn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Font_size_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_panel;
        private MetroFramework.Controls.MetroTile New_note_btn;
        private MetroFramework.Controls.MetroTextBox Search_box;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel Top_lb;
        private System.Windows.Forms.Panel Notes_list_panel;
        private MetroFramework.Controls.MetroLabel Count_notes_lb;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroTile New_list_btn;
        private MetroFramework.Controls.MetroButton Show_lists_btn;
        private MetroFramework.Controls.MetroButton Show_notes_btn;
        private System.Windows.Forms.Panel Note_cr_pn;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile Save_btn;
        private MetroFramework.Controls.MetroTile Erase_btn;
        private System.Windows.Forms.RichTextBox Text_note_rtb;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton Italic_btn;
        private MetroFramework.Controls.MetroButton Color_btn;
        private System.Windows.Forms.NumericUpDown Font_size_box;
        private MetroFramework.Controls.MetroButton Strikeout_btn;
        private MetroFramework.Controls.MetroButton Bold_btn;
        private MetroFramework.Controls.MetroButton Sub_btn;
        private MetroFramework.Controls.MetroTextBox Title_note_box;
        private System.Windows.Forms.Panel Holder_panel;
    }
}

