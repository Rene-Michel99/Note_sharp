using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class Manager_list
    {
        private List<Lista> lists_saved;
        public Manager_list()
        {
            lists_saved = new List<Lista>();
        }
        public void add_lista(Lista lista)
        {
            this.lists_saved.Add(lista);
        }
        public Lista get_list(string title)
        {
            foreach(Lista list in lists_saved)
            {
                if (list.title == title)
                    return list;
            }
            return null;
        }
        public void update_list(Lista new_lis)
        {
            foreach(Lista list in lists_saved)
            {
                if(list.id == new_lis.id)
                {
                    list.tasks = new_lis.tasks;
                    list.update_date(new_lis.get_date());
                }
            }
        }
        public bool exist_in(string title)
        {
            foreach(Lista lista in lists_saved)
            {
                if (lista.title == title)
                    return true;
            }
            return false;
        }
        public int get_new_id(string title)
        {
            if (lists_saved.Count == 0)
                return 1;
            else
            {
                int id = -1;
                foreach (Lista lista in lists_saved)
                {
                    if (lista.id > id)
                        id = lista.id;
                }
                return id + 1;
            }
        }
    }
}
