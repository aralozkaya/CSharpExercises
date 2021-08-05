using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    public class Note
    {

        public static BindingList<Note> myNotes = new BindingList<Note> { };
        public string Title { get; set; }
        public string Text { get; set; }

        public Note(string title, string text)
        {
            this.Title = title;
            this.Text = text;
            myNotes.Add(this);
        }
    }
}
