using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace NoteApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private List<Note> notes_saved;
        private Manager_list manager_list = new Manager_list();
        private DataController db_controller;
        Panel List_cr_pn = new Panel();
        Panel List_lists = new Panel();

        private CurrentNote current_note;

        public Form1()
        {
            InitializeComponent();
        }
        private int init_conn_db()
        {
            List_lists.Size = new Size(217, 368);
            this.db_controller = new DataController();
            try
            {

                DataTable dtreader = this.db_controller.get_all_notes();

                int y = 0;
                if(dtreader.Rows.Count > 0)
                {
                    foreach(DataRow item in dtreader.Rows)
                    {
                        Note note = new Note(item["created_at"].ToString());
                        note.title = item["title"].ToString();
                        note.text = item["content"].ToString();
                        note.id = Convert.ToInt32(item["id"]);

                        this.notes_saved.Add(note);

                        MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                        btn.Text = note.title;
                        btn.AutoSize = true;
                        btn.Anchor = AnchorStyles.Right & AnchorStyles.Left;
                        btn.Theme = MetroFramework.MetroThemeStyle.Dark;
                        btn.Click += this.Select_note;

                        Notes_list_panel.Controls.Add(btn);
                        btn.SetBounds(0, y, 210, 45);
                        y += 50;
                    }
                }
                /*Count_notes_lb.Text = Notes_list_panel.Controls.Count.ToString()+" notas";
                dtreader.Close();

                cmd.CommandText = "SELECT * FROM lists";

                MySqlDataReader dtreader2 = cmd.ExecuteReader();

                y = 0;

                while (dtreader2.Read())
                {
                    Lista lista = new Lista(Convert.ToInt32(dtreader2["id"].ToString()), dtreader2["title"].ToString(), dtreader2["tasks"].ToString(), dtreader2["date_"].ToString());

                    this.manager_list.add_lista(lista);

                    MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Text = lista.title;
                    btn.AutoSize = true;
                    btn.Anchor = AnchorStyles.Right & AnchorStyles.Left;
                    btn.Theme = MetroFramework.MetroThemeStyle.Dark;
                    btn.Click += this.Show_list;

                    List_lists.Controls.Add(btn);
                    btn.SetBounds(0, y, 210, 45);
                    y += 50;
                }*/
                return 0;
            }
            catch(Exception e)
            {
                MessageBox.Show("Houve um erro ao se conectar ao Banco de Dados!");
                throw e;
            }
        }
        private void create_panel_list()
        {
            List_cr_pn.Size = new Size(467, 472);
            List_cr_pn.AutoScroll = true;

            Panel list_pn = new Panel();
            list_pn.AutoScroll = true;
            list_pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
            card.color = Color.Purple;
            card.BackColor = Color.FromArgb(64, 64, 64);

            Panel layout = new Panel();

            MetroFramework.Controls.MetroCheckBox check = new MetroFramework.Controls.MetroCheckBox();
            check.Style = MetroFramework.MetroColorStyle.Green;
            check.Theme = MetroFramework.MetroThemeStyle.Dark;

            MetroFramework.Controls.MetroTextBox title_task = new MetroFramework.Controls.MetroTextBox();
            title_task.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            title_task.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            title_task.Theme = MetroFramework.MetroThemeStyle.Dark;
            title_task.Multiline = true;

            layout.Controls.Add(check);
            check.SetBounds(4, 20, 30, 15);
            layout.Controls.Add(title_task);
            title_task.SetBounds(40, 12, 275, 31);

            card.Controls.Add(layout);
            layout.SetBounds(3, 3, 413, 61);

            list_pn.Controls.Add(card);
            card.SetBounds(3, 3, 421, 67);

            List_cr_pn.Controls.Add(list_pn);
            list_pn.SetBounds(4, 4, 460, 357);

            MetroFramework.Controls.MetroTile add_task = new MetroFramework.Controls.MetroTile();
            add_task.Text = "+ Adicionar Nova Tarefa";
            add_task.TextAlign = ContentAlignment.MiddleCenter;
            add_task.Click += this.New_task_btn_click;

            MetroFramework.Controls.MetroTile save_list = new MetroFramework.Controls.MetroTile();
            save_list.Text = "Salvar";
            save_list.TextAlign = ContentAlignment.MiddleCenter;
            save_list.Style = MetroFramework.MetroColorStyle.Green;
            save_list.Click += this.Save_list_btn_click;

            MetroFramework.Controls.MetroTextBox title_list = new MetroFramework.Controls.MetroTextBox();
            title_list.Theme = MetroFramework.MetroThemeStyle.Dark;
            title_list.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            title_list.Multiline = true;
            title_list.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;

            List_cr_pn.Controls.Add(add_task);
            add_task.SetBounds(3, 367, 170, 46);
            List_cr_pn.Controls.Add(save_list);
            save_list.SetBounds(181, 423, 170, 46);
            List_cr_pn.Controls.Add(title_list);
            title_list.SetBounds(6, 423, 169, 35);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = MetroFramework.MetroColorStyle.Purple;

            this.notes_saved = new List<Note>();

            this.create_panel_list();
            this.current_note = new CurrentNote();
            if (this.init_conn_db() != 0)
                System.Windows.Forms.Application.Exit();

        }
        private void New_note_btn_Click(object sender, EventArgs e)
        {
            if(splitContainer1.Panel2.Enabled == false)
                splitContainer1.Panel2.Enabled = true;

            clear_panel_2();
        }
        private void remove_note_saved(Note note)
        {
            for(int i=0; i<Notes_list_panel.Controls.Count; i++)
            {
                if(Notes_list_panel.Controls[i].Text == note.title)
                {
                    Notes_list_panel.Controls.Remove(Notes_list_panel.Controls[i]);
                    break;
                }
            }
            notes_saved.Remove(note);

            Notes_list_panel.Controls.Clear();

            int y = 0;
            foreach(Note note1 in notes_saved)
            {
                MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Text = note1.title;
                btn.AutoSize = true;
                btn.Anchor = AnchorStyles.Right & AnchorStyles.Left;
                btn.Theme = MetroFramework.MetroThemeStyle.Dark;
                btn.Click += this.Select_note;

                Notes_list_panel.Controls.Add(btn);
                btn.SetBounds(0, y, 210, 45);
                y += 50;
            }
            Notes_list_panel.Refresh();
        }
        private void insert_new_note_in_panel(string title)
        {
            MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = title;
            btn.AutoSize = true;
            btn.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            btn.Click += this.Select_note;
            btn.Theme = MetroFramework.MetroThemeStyle.Dark;

            int y = 0;
            if (Notes_list_panel.Controls.Count > 0)
                y = Notes_list_panel.Controls[Notes_list_panel.Controls.Count - 1].Bounds.Y + 50;

            Notes_list_panel.Controls.Add(btn);
            btn.SetBounds(0, y, 210, 45);

            Notes_list_panel.Refresh();
        }
        private void update_notes_saved(Note note=null)
        {
            if(note != null)
            {
                this.notes_saved.Add(note);

                this.insert_new_note_in_panel(note.title);

                int status = this.db_controller.insert_in_notes(note);

                if (status == 0)
                {
                    MessageBox.Show("Nota salva com sucesso!");
                }
                else
                    MessageBox.Show("Não foi possível salvar a nota, tente novamente mais tarde!");
            }
            else
            {
                // UPDATE
                note = this.get_note_by_id(this.current_note.note_id);
                note.title = Title_note_box.Text;
                note.text = Text_note_rtb.Rtf;
                note.set_new_date();

                this.change_title_note_box(note.title);

                int status = this.db_controller.update_note(note);

                if (status == 0)
                {
                    MessageBox.Show("Nota salva com sucesso!");
                }
                else
                    MessageBox.Show("Não foi possível salvar a nota, tente novamente mais tarde!");
            }
            
        }
        private void change_title_note_box(string new_title)
        {
            Notes_list_panel.Controls[this.current_note.note_btn_id].Text = new_title;
        }
        private int exist_in(string title)
        {
            int id = -1;
            foreach(Note note in this.notes_saved)
            {
                if (note.title == title)
                    id = note.id;
            }
            return id; 
        }
        private bool exist_in_by_id(int id)
        {
            bool output = false;
            foreach (Note note in this.notes_saved)
            {
                if (note.id == id)
                    output = true;
            }
            return output;
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Title_note_box.Text != "" && Text_note_rtb.Text != "")
            {
                if (this.current_note.note_id == -1)
                {
                    Note note = new Note();

                    note.title = Title_note_box.Text;
                    note.text = Text_note_rtb.Rtf;

                    if (notes_saved.Count > 0)
                    {
                        int maior = 0;
                        foreach (Note nt in notes_saved)
                        {
                            if (nt.id > maior)
                                maior = nt.id;
                        }
                        note.id = maior + 1;
                    }
                    else
                        note.id = 1;

                    this.update_notes_saved(note);
                }
                else
                {
                    this.update_notes_saved();
                }
            }
            else
                MessageBox.Show("Impossível salvar uma nota vazia!");
        }
        private Note get_note(string text)
        {
            foreach(Note note in this.notes_saved)
            {
                if (note.title == text)
                    return note;
            }
            return null;
        }
        private Note get_note_by_id(int id)
        {
            foreach(Note note in this.notes_saved)
            {
                if (note.id == id)
                    return note;
            }
            return null;
        }
        private void load_note(string text,int index)
        {
            Note note = get_note(text);

            Title_note_box.Text = note.title;
            Text_note_rtb.Rtf = note.text;

            this.current_note.note_id = note.id;
            this.current_note.note_btn_id = index;
        }
        private void load_list(Lista list)
        {
            string[] tasks = list.tasks.Split(';');

            Panel list_pn = (Panel)List_cr_pn.Controls[0];
            list_pn.Controls.Clear();

            MetroFramework.Controls.MetroTextBox title_list = (MetroFramework.Controls.MetroTextBox)List_cr_pn.Controls[3];
            title_list.Text = list.title;

            int y = 3;

            for (int i=0; i<tasks.Length; i++)
            {
                string text = tasks[i].Split('@')[0];
                if (text == "")
                    break;
                bool is_checked = false;
                if (tasks[i].Split('@')[1] == "True")
                    is_checked = true;

                Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
                card.color = Color.Purple;
                card.BackColor = Color.FromArgb(64, 64, 64);

                Panel layout = new Panel();

                MetroFramework.Controls.MetroCheckBox check = new MetroFramework.Controls.MetroCheckBox();
                check.Style = MetroFramework.MetroColorStyle.Green;
                check.Theme = MetroFramework.MetroThemeStyle.Dark;
                check.Checked = is_checked;

                MetroFramework.Controls.MetroTextBox title_task = new MetroFramework.Controls.MetroTextBox();
                title_task.FontSize = MetroFramework.MetroTextBoxSize.Tall;
                title_task.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
                title_task.Theme = MetroFramework.MetroThemeStyle.Dark;
                title_task.Multiline = true;
                title_task.Text = text;

                layout.Controls.Add(check);
                check.SetBounds(4, 20, 30, 15);
                layout.Controls.Add(title_task);
                title_task.SetBounds(40, 12, 275, 31);

                card.Controls.Add(layout);
                layout.SetBounds(3, 3, 413, 61);

                list_pn.Controls.Add(card);
                card.SetBounds(3, y, 421, 67);
                y += 73;
            }
            
        }
        private void clear_panel_2()
        {
            Title_note_box.Text = "Nota " + (notes_saved.Count + 1).ToString();
            Text_note_rtb.Text = "";
        }
        private void Select_note(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Enabled == false)
                splitContainer1.Panel2.Enabled = true;

            Italic_btn.Highlight = false;
            Sub_btn.Highlight = false;
            Bold_btn.Highlight = false;
            Strikeout_btn.Highlight = false;

            int id = exist_in(Title_note_box.Text);

            bool pass = true;
            if(id == -1 && Title_note_box.Text != "")
            {
                if (MessageBox.Show("Está nota não foi salva, deseja continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    pass = true;
            }

            if(pass)
            {
                int idx = Notes_list_panel.Controls.GetChildIndex((MetroFramework.Controls.MetroButton)sender);

                string[] list = sender.ToString().Split(':');
                string text = list[1].Trim();
                this.load_note(text,idx);
            }
        }
        private void create_new_task(int x, int y,Panel pn)
        {
            Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
            card.color = Color.Purple;
            card.BackColor = Color.FromArgb(64, 64, 64);

            Panel layout = new Panel();

            MetroFramework.Controls.MetroCheckBox check = new MetroFramework.Controls.MetroCheckBox();
            check.Style = MetroFramework.MetroColorStyle.Green;
            check.Theme = MetroFramework.MetroThemeStyle.Dark;

            MetroFramework.Controls.MetroTextBox title_task = new MetroFramework.Controls.MetroTextBox();
            title_task.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            title_task.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            title_task.Theme = MetroFramework.MetroThemeStyle.Dark;
            title_task.Multiline = true;

            layout.Controls.Add(check);
            check.SetBounds(4, 20, 30, 15);
            layout.Controls.Add(title_task);
            title_task.SetBounds(40, 12, 275, 31);

            card.Controls.Add(layout);
            layout.SetBounds(3, 3, 413, 61);

            pn.Controls.Add(card);
            card.SetBounds(x, y, 421, 67);
        }
        private void Italic_btn_Click(object sender, EventArgs e)
        {
            if(!Text_note_rtb.SelectionFont.Italic)
            {
                Italic_btn.Highlight = true;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;
                FontStyle style = Text_note_rtb.SelectionFont.Style;
                style |= FontStyle.Italic;
                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
            else
            {
                Italic_btn.Highlight = false;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;

                FontStyle style = FontStyle.Regular;

                if (Text_note_rtb.SelectionFont.Strikeout)
                    style |= FontStyle.Strikeout;
                if (Text_note_rtb.SelectionFont.Bold)
                    style |= FontStyle.Bold;
                if (Text_note_rtb.SelectionFont.Underline)
                    style |= FontStyle.Underline;

                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
        }
        private void Sub_btn_Click_1(object sender, EventArgs e)
        {
            if (!Text_note_rtb.SelectionFont.Underline)
            {
                Sub_btn.Highlight = true;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;
                FontStyle style = Text_note_rtb.SelectionFont.Style;
                style |= FontStyle.Underline;
                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
            else
            {
                Sub_btn.Highlight = false;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;

                FontStyle style = FontStyle.Regular;

                if (Text_note_rtb.SelectionFont.Strikeout)
                    style |= FontStyle.Strikeout;
                if (Text_note_rtb.SelectionFont.Bold)
                    style |= FontStyle.Bold;
                if (Text_note_rtb.SelectionFont.Italic)
                    style |= FontStyle.Italic;

                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
        }
        private void Strikeout_btn_Click(object sender, EventArgs e)
        {
            if (!Text_note_rtb.SelectionFont.Strikeout)
            {
                Strikeout_btn.Highlight = true;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;
                FontStyle style = Text_note_rtb.SelectionFont.Style;
                style |= FontStyle.Strikeout;
                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
            else
            {
                Strikeout_btn.Highlight = false;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;

                FontStyle style = FontStyle.Regular;

                if (Text_note_rtb.SelectionFont.Bold)
                    style |= FontStyle.Bold;
                if (Text_note_rtb.SelectionFont.Underline)
                    style |= FontStyle.Underline;
                if (Text_note_rtb.SelectionFont.Italic)
                    style |= FontStyle.Italic;

                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
        }
        private void Bold_btn_Click(object sender, EventArgs e)
        {
            if (!Text_note_rtb.SelectionFont.Bold)
            {
                Bold_btn.Highlight = true;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;
                FontStyle style = Text_note_rtb.SelectionFont.Style;
                style |= FontStyle.Bold;
                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
            else
            {
                Bold_btn.Highlight = false;
                FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
                float size = Text_note_rtb.SelectionFont.Size;

                FontStyle style = FontStyle.Regular;

                if (Text_note_rtb.SelectionFont.Strikeout)
                    style |= FontStyle.Strikeout;
                if (Text_note_rtb.SelectionFont.Underline)
                    style |= FontStyle.Underline;
                if (Text_note_rtb.SelectionFont.Italic)
                    style |= FontStyle.Italic;

                Text_note_rtb.SelectionFont = new Font(family, size, style);
            }
        }
        private void Color_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Text_note_rtb.SelectionColor = colorDialog1.Color;
        }
        private void Font_size_box_ValueChanged(object sender, EventArgs e)
        {
            FontFamily family = Text_note_rtb.SelectionFont.FontFamily;
            float size = (float)Font_size_box.Value;
            FontStyle style = Text_note_rtb.SelectionFont.Style;
            Text_note_rtb.SelectionFont = new Font(family, size, style);
        }
        private void Erase_btn_Click(object sender, EventArgs e)
        {
            Note note = get_note(Title_note_box.Text);

            /*if(note != null)
            {
                string message = "Tem certeza que deseja deletar " + note.title + "?";
                if (MessageBox.Show(message, "Apagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = this.connection.CreateCommand();
                    cmd.CommandText = "DELETE from notes where id=@id";
                    cmd.Parameters.AddWithValue("@id", note.id);

                    cmd.ExecuteNonQuery();

                    remove_note_saved(note);

                    clear_panel_2();
                }
            }*/

        }
        private void Show_notes_btn_Click(object sender, EventArgs e)
        {
            Top_lb.Text = "Todas as notas";
            Count_notes_lb.Text = notes_saved.Count.ToString() + " Notas";

            Holder_panel.Controls.Clear();
            Holder_panel.Controls.Add(Notes_list_panel);
            Notes_list_panel.SetBounds(3, 3, 217, 368);

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Note_cr_pn);
        }
        private void Show_lists_btn_Click(object sender, EventArgs e)
        {
            Top_lb.Text = "Todas as listas";
            Count_notes_lb.Text = List_lists.Controls.Count.ToString() + " listas";

            Holder_panel.Controls.Clear();
            Holder_panel.Controls.Add(List_lists);
            List_lists.SetBounds(3, 3, 217, 368);

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(List_cr_pn);
        }
        private void New_task_btn_click(object sender, EventArgs e)
        {
            Panel list = (Panel)List_cr_pn.Controls[0];
            Bunifu.Framework.UI.BunifuCards tile = (Bunifu.Framework.UI.BunifuCards)list.Controls[list.Controls.Count-1];
            int x = tile.Bounds.X;
            int y = tile.Bounds.Y;

            Console.WriteLine(List_cr_pn.Controls[0].GetType());

            create_new_task(x, y + 73,list);
        }
        private void update_list_pn(string title)
        {
            int y = 3;
            if(List_lists.Controls.Count > 0)
            {
                MetroFramework.Controls.MetroButton btn = (MetroFramework.Controls.MetroButton)List_lists.Controls[List_lists.Controls.Count - 1];
                y = btn.Bounds.Y + 50;
            }

            MetroFramework.Controls.MetroButton new_btn = new MetroFramework.Controls.MetroButton();
            new_btn.TextAlign = ContentAlignment.MiddleCenter;
            new_btn.Text = title;
            new_btn.AutoSize = true;
            new_btn.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            //new_btn.Click += this.Show_list;
            new_btn.Theme = MetroFramework.MetroThemeStyle.Dark;

            List_lists.Controls.Add(new_btn);
            new_btn.SetBounds(0, y, 210, 45);

            List_lists.Refresh();
        }
        private void Save_list_btn_click(object sender, EventArgs e)
        {
            /*MetroFramework.Controls.MetroTextBox title = (MetroFramework.Controls.MetroTextBox)List_cr_pn.Controls[3];
            if (title.Text != "")
            {
                string tasks = "";
                Panel list = (Panel)List_cr_pn.Controls[0];
                foreach(Bunifu.Framework.UI.BunifuCards card in list.Controls)
                {
                    MetroFramework.Controls.MetroTextBox title_task = (MetroFramework.Controls.MetroTextBox)card.Controls[4].Controls[1];
                    if(title_task.Text != "")
                    {
                        MetroFramework.Controls.MetroCheckBox check = (MetroFramework.Controls.MetroCheckBox)card.Controls[4].Controls[0];
                        tasks += title_task.Text + "@" + check.Checked+";";
                        Console.WriteLine(tasks);
                    }
                }
                
                if (!manager_list.exist_in(title.Text))
                {
                    int id = manager_list.get_new_id(title.Text);
                    Lista lis = new Lista(id, title.Text, tasks);
                    MySqlCommand cmd = this.connection.CreateCommand();

                    cmd.CommandText = "INSERT INTO lists(id,title,tasks,date_) values(@id,@title,@tasks,@date_)";
                    cmd.Parameters.AddWithValue("@id", lis.id);
                    cmd.Parameters.AddWithValue("@title", lis.title);
                    cmd.Parameters.AddWithValue("@tasks", lis.tasks);
                    cmd.Parameters.AddWithValue("@date_", lis.get_date());

                    int status = cmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        manager_list.add_lista(lis);
                        MessageBox.Show("Lista salva com sucesso!");
                        this.update_list_pn(lis.title);
                    }
                    else
                        MessageBox.Show("Não foi possível salvar a lista.");
                }
                else
                {
                    Lista lis = manager_list.get_list(title.Text);
                    lis.tasks = tasks;
                    MySqlCommand cmd = this.connection.CreateCommand();

                    cmd.CommandText = "UPDATE lists SET tasks=@tasks,date_=@date where id=@id";
                    cmd.Parameters.AddWithValue("@tasks", lis.tasks);
                    cmd.Parameters.AddWithValue("@date", lis.update_date_and_get());
                    cmd.Parameters.AddWithValue("@id", lis.id);

                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        manager_list.update_list(lis);
                        MessageBox.Show("Nota salva com sucesso!");
                    }
                    else
                        MessageBox.Show("Não foi possível salvar a nota.");
                }
                
            }*/
        }
        private void Show_list(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;

            MetroFramework.Controls.MetroButton btn = (MetroFramework.Controls.MetroButton)sender;
            Lista list = manager_list.get_list(btn.Text);

            load_list(list);
        }
        private void New_list_btn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;

            Top_lb.Text = "Todas as listas";
            Count_notes_lb.Text = List_lists.Controls.Count.ToString() + " listas";

            Holder_panel.Controls.Clear();
            Holder_panel.Controls.Add(List_lists);

            Panel list_pn = (Panel)List_cr_pn.Controls[0];
            list_pn.Controls.Clear();

            MetroFramework.Controls.MetroTextBox title_list = (MetroFramework.Controls.MetroTextBox)List_cr_pn.Controls[3];
            title_list.Text = "";

            Bunifu.Framework.UI.BunifuCards card = new Bunifu.Framework.UI.BunifuCards();
            card.color = Color.Purple;
            card.BackColor = Color.FromArgb(64, 64, 64);

            Panel layout = new Panel();

            MetroFramework.Controls.MetroCheckBox check = new MetroFramework.Controls.MetroCheckBox();
            check.Style = MetroFramework.MetroColorStyle.Green;
            check.Theme = MetroFramework.MetroThemeStyle.Dark;

            MetroFramework.Controls.MetroTextBox title_task = new MetroFramework.Controls.MetroTextBox();
            title_task.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            title_task.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            title_task.Theme = MetroFramework.MetroThemeStyle.Dark;
            title_task.Multiline = true;

            layout.Controls.Add(check);
            check.SetBounds(4, 20, 30, 15);
            layout.Controls.Add(title_task);
            title_task.SetBounds(40, 12, 275, 31);

            card.Controls.Add(layout);
            layout.SetBounds(3, 3, 413, 61);

            list_pn.Controls.Add(card);
            card.SetBounds(3, 3, 421, 67);

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(List_cr_pn);
        }
    }
}
