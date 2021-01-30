using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class Note
    {
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }

        private string date;

        public Note(string date=null)
        {
            if(date == null)
            {
                string[] dte = DateTime.Now.ToString().Split(' ');

                string[] fp = dte[0].Split('/');

                string data = fp[2] + "-" + fp[1] + "-" + fp[0];

                this.date = data + " " + dte[1];
            }
            else
            {
                this.date = date;
            }
            //"30/01/2021 04:31:23" utcnow()
            //"YYYY-MM-DD hh:mm:ss" mysql
            //2021-01-30 15:06:23
        }
        public void set_new_date()
        {
            this.date = string.Empty;

            string[] dte = DateTime.Now.ToString().Split(' ');

            string[] fp = dte[0].Split('/');

            string data = fp[2] + "-" + fp[1] + "-" + fp[0];

            this.date = data + " " + dte[1];
        }
        public string get_date()
        {
            return this.date;
        }
    }
}
