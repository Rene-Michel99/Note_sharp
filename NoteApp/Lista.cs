using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class Lista
    {
        public int id { set; get; }
        public string title { set; get; }
        public string tasks { set; get; }

        private string date;

        public Lista(int id,string title,string tasks,string date=null)
        {
            this.id = id;
            this.title = title;
            this.tasks = tasks;

            if (date == null)
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
        }
        public string get_date()
        {
            return this.date;
        }
        public void update_date(string date)
        {
            this.date = date;
        }
        public string update_date_and_get()
        {
            string[] dte = DateTime.Now.ToString().Split(' ');

            string[] fp = dte[0].Split('/');

            string data = fp[2] + "-" + fp[1] + "-" + fp[0];

            this.date = data + " " + dte[1];
            return this.date;
        }
    }
}
