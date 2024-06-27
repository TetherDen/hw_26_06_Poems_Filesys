using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_26_06_File_sys
{
    internal static class PoemsManager
    {
        private static List<Poem> poemList = new List<Poem>();

        public static void Add(Poem poem)
        {
            poemList.Add(poem);
        }

        public static void Remove(Poem poem)
        {
            poemList.Remove(poem);
        }
        public static void Remove(string title)
        {
            foreach (Poem poem in poemList)
            {
                if (poem.Title == title)
                {
                    poemList.Remove(poem);
                    break;
                }    
            }
        }
        public static void Clear()
        {
            poemList.Clear();
        }
        public static void Show()
        {
            foreach (Poem poem in poemList)
            {
                Console.WriteLine(poem.ToString());
            }
        }

        public static Poem SearchByTitle(string title)
        {
            return poemList.Find(el => el.Title == title);
        }
        public static Poem SearchByAuthor(string author)
        {
            return poemList.Find(el => el.Author == author);
        }
        public static Poem SearchByText(string text)
        {
            return poemList.Find(el => el.Text == text);
        }

        public static void ChangeTitle(Poem poem, string title)
        {
            poem.Title = title;
        }
        public static void ChangeAuthor(Poem poem, string author)
        {
            poem.Author = author;
        }
        public static void ChangeText(Poem poem, string text)
        {
            poem.Text = text;
        }

        public static void Save(string path)
        {
            using(StreamWriter sw = new StreamWriter(path,true))
            {
                foreach(Poem poem in poemList)
                {
                    sw.WriteLine(poem.Title);
                    sw.WriteLine(poem.Author);
                    sw.WriteLine(poem.Year);
                    sw.WriteLine(poem.Text);
                    sw.WriteLine(poem.Theme);
                    sw.WriteLine("//======//");
                }
            }
        }
        public static void Load(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string title = sr.ReadLine();
                        string author = sr.ReadLine();
                        short year = Convert.ToInt16(sr.ReadLine());
                        string text = sr.ReadLine();
                        string theme = sr.ReadLine();
                        sr.ReadLine();

                        poemList.Add(new Poem(title, author, year, text, theme));
                    }
                }
            }
        }
    }
}
