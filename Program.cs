namespace hw_26_06_File_sys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 1:
            //Створіть додаток для роботи з колекцією віршів, який
            //зберігатиме таку інформацію:
            // назва вірша;
            // П.І.Б.автора;
            // рік написання;
            // текст вірша;
            // тема вірша.
            //Додаток має давати можливість:
            // додавати вірші;
            // видаляти вірші;
            // змінювати інформацію про вірші;
            // шукати вірш за різними характеристиками;
            // зберігати колекцію віршів у файл;
            // завантажувати колекцію віршів з файлу.

            Poem poem1= new Poem("PoemTitle", "PoemAuthor", 1555, "Lorem ipsum dolor sit amet", "Poem theme");
            Poem poem2= new Poem("Poem22", "PoemAuthor22", 222, "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "222 theme");
            Poem poem3= new Poem("Title333", "Author333", 1733, "Ut enim ad minim veniam", "NewTheme");

            //Console.WriteLine(poem1);

            PoemsManager.Add(poem1);
            PoemsManager.Add(poem2);
            PoemsManager.Add(poem3);
            PoemsManager.Show();
            Console.WriteLine(PoemsManager.SearchByTitle("Poem22"));
            Console.WriteLine(PoemsManager.SearchByAuthor("PoemAuthor22"));




        }
    }
}
