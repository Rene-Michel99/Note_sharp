using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace NoteApp
{
    class DataController
    {
        private static SQLiteConnection db_connection;
        
        public DataController()
        {
            this.create_database();

            this.create_tables();
        }
        private static SQLiteConnection define_connection()
        {
            string db_dir = "Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\Data\\bd.sqlite; Version=3;";
            db_connection = new SQLiteConnection(db_dir);
            db_connection.Open();
            return db_connection;
        }
        private void create_database()
        {
            try
            {
                string current_dir = System.IO.Directory.GetCurrentDirectory();
                if (System.IO.Directory.Exists(current_dir + "\\Data"))
                {
                    if(!System.IO.File.Exists(current_dir + "\\Data\\bd.sqlite"))
                    {
                        SQLiteConnection.CreateFile(current_dir + "\\Data\\bd.sqlite");
                    }
                }
                else
                {
                    System.IO.Directory.CreateDirectory(current_dir + "\\Data");
                    SQLiteConnection.CreateFile(current_dir + "\\Data\\bd.sqlite");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private void create_tables()
        {
            try
            {
                string[] array = { "Notes(id integer PRIMARY KEY, title varchar(256), content text, created_at date);" };
                using(var cmd = define_connection().CreateCommand())
                {
                    for(int i=0; i<array.Length; i++)
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + array[i];
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable get_all_notes()
        {
            SQLiteDataAdapter adapter = null;
            DataTable table = new DataTable();
            try
            {
                using (var cmd = define_connection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Notes";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, db_connection);
                    adapter.Fill(table);

                    return table;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public int insert_in_notes(Note note)
        {
            try
            {
                using(var cmd = define_connection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Notes (id,title,content,created_at) values(@id,@title,@content,@created_at);";
                    cmd.Parameters.AddWithValue("@id", note.id);
                    cmd.Parameters.AddWithValue("@title", note.title);
                    cmd.Parameters.AddWithValue("@content", note.text);
                    cmd.Parameters.AddWithValue("@created_at",note.get_date());
                    cmd.ExecuteNonQuery();
                }
                return 0;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public int update_note(Note note)
        {
            try
            {
                using (var cmd = define_connection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Notes SET title=@title,content=@content,created_at=@created_at WHERE id=@id;";
                    cmd.Parameters.AddWithValue("@id", note.id);
                    cmd.Parameters.AddWithValue("@title", note.title);
                    cmd.Parameters.AddWithValue("@content", note.text);
                    cmd.Parameters.AddWithValue("@created_at", note.get_date());
                    cmd.ExecuteNonQuery();
                }
                return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
