using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private List<Note> notes_saved;

        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }
        private void init_conn_db()
        {
            string connetionString = "server=localhost;database=notesdb;uid=root;pwd=c66209f7e8;";
            this.connection = new MySqlConnection(connetionString);

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM notes";

                MySqlDataReader dtreader = cmd.ExecuteReader();

                int y = 0;

                while (dtreader.Read())
                {
                    Note note = new Note(dtreader["date_"].ToString());
                    note.title = dtreader["title"].ToString();
                    note.text = dtreader["text_"].ToString();
                    note.id = Convert.ToInt32(dtreader["id"].ToString());

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
                Count_notes_lb.Text = Notes_list_panel.Controls.Count.ToString()+" notas";
                dtreader.Close();
            }
            catch
            {
                MessageBox.Show("Houve um erro ao se conectar ao Banco de Dados!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = MetroFramework.MetroColorStyle.Purple;

            this.notes_saved = new List<Note>();

            this.init_conn_db();

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
        private void update_notes_saved(Note note)
        {
            if(!notes_saved.Contains(note))
            {
                this.notes_saved.Add(note);

                MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Text = note.title;
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
            else
            {
                foreach(Note nt in notes_saved)
                {
                    if(note.id == nt.id)
                    {
                        string val = note.get_date() + "*" + nt.get_date();
                        Console.WriteLine(val);
                    }
                }
            }
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
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Title_note_box.Text != "" && Text_note_rtb.Text != "")
            {
                int id = exist_in(Title_note_box.Text);

                if (id == -1)
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

                    MySqlCommand cmd = this.connection.CreateCommand();

                    cmd.CommandText = "INSERT INTO notes(id,title,text_,date_) values(@id,@title,@text_,@date_)";
                    cmd.Parameters.AddWithValue("@id", note.id);
                    cmd.Parameters.AddWithValue("@title", note.title);
                    cmd.Parameters.AddWithValue("@text_", note.text);
                    cmd.Parameters.AddWithValue("@date_", note.get_date());

                    int status = cmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        this.update_notes_saved(note);
                        MessageBox.Show("Nota salva com sucesso!");
                    }
                    else
                        MessageBox.Show("Não foi possível salvar a nota.");
                }
                else
                {
                    Note note = get_note(Title_note_box.Text);
                    note.text = Text_note_rtb.Rtf;
                    note.set_new_date();

                    Console.WriteLine(note.get_date());

                    MySqlCommand cmd = this.connection.CreateCommand();

                    cmd.CommandText = "UPDATE notes SET text_=@text,date_=@date where id=@id";
                    cmd.Parameters.AddWithValue("@text", note.text);
                    cmd.Parameters.AddWithValue("@date", note.get_date());
                    cmd.Parameters.AddWithValue("@id", id);

                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        this.update_notes_saved(note);
                        MessageBox.Show("Nota salva com sucesso!");
                    }
                    else
                        MessageBox.Show("Não foi possível salvar a nota.");
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
        private void load_note(string text)
        {
            Note note = get_note(text);

            Title_note_box.Text = note.title;
            Text_note_rtb.Rtf = note.text;
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
                string[] list = sender.ToString().Split(':');
                string text = list[1].Trim();
                this.load_note(text);
            }
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

            if(note != null)
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
            }

        }
    }
}
