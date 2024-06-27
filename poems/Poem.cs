using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_26_06_File_sys
{
    internal class Poem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public short Year { get; set; }
        public string Text { get; set; }
        public string Theme { get; set; }

        public Poem(string title, string author, short year, string text, string theme)
        {
            Title = title;
            Author = author;
            Year = year;
            Text = text;
            Theme = theme;
        }

        public override string ToString()
        {
            return $"Title: {Title}.   Author: {Author}.   Year: {Year}.   Theme: {Theme}." +
                $"\nText:  {Text}\n";
        }

    }
}
