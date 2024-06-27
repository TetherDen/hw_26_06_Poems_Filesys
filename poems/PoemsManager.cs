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

        }


    }
}
