using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NotesStore
    {
        //Dictionary<string, string> data = new Dictionary<string, string>();

        public NotesStore()
        {
            
        }
        List<string> notes = new List<string>();
        public void AddNote(string state,string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name Cannot be empty");
            }
            if(state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"invalid state {state}");
            }
            // data[state] = name;

            notes.Add(state + " " + name);

        }

        public List<string> GetNotes(string state) {

            List<string> result = new List<string>();

            if (state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"invalid state {state}");
            }


            foreach (string note in notes)
            {
                string[] arr = note.Split(' ');
                if (arr[0]==state)
                {
                    result.Add(arr[1]);
                }
            }
            return result;
        }
    }
}
