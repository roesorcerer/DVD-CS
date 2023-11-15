using System;
using System.IO;

namespace Module04Lab1
{
    class DVDCollection
    {
        static void Main(string[] args)
        {
            DVD[] dvdArray = new DVD[50];//Creating a DVD collection that is able to hold 50 DVDs
            Console.WriteLine("Welcome to DVD Collections Database");//welcome message
            string FilePath = @"C:\CSharpFiles\dvd.txt";
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            string header = "DVD Name,DVD Genre,DVD Year,DVD Rating\r";
            sw.Write(header);

            int choice;//variables
            string Name = "", Genre, Year;
            int Rating;
            string attribute;
            int j = 0;

            do
            {

                Console.WriteLine("1.Open DVD information");//menu selection
                Console.WriteLine("2.New DVD entry");
                Console.WriteLine("3.Modify DVD entry");
                Console.WriteLine("4.Close Program");
                Int32.TryParse(Console.ReadLine(), out choice);

                switch (choice)//action will be preformed depending on choice
                {
                    case 1:
                        {
                            Console.WriteLine("Enter DVD Name to open");//dvd name 
                            Name = Console.ReadLine();

                            for (int i = 0; dvdArray[i] != null; i++)
                            {
                                if (dvdArray[i].Name.Equals(Name))//will search array for name and pull up results. 
                                    Console.WriteLine(dvdArray[i].ToString());
                            }
                            break;
                        }

                    case 2://selection to enter new DVD into
                        {
                            Console.WriteLine("Enter New DVD Name");
                            Name = Console.ReadLine();
                            Console.WriteLine("Enter New DVD Genre");
                            Genre = Console.ReadLine();
                            Console.WriteLine("Enter New DVD Year");
                            Year = Console.ReadLine();
                            Console.WriteLine("Enter New DVD Rating");
                            Int32.TryParse(Console.ReadLine(), out Rating);

                            sw.Write(dvdArray[j] = new DVD(//user input will be added to array. 
                                Name,
                                Genre,
                                Year,
                                Rating
                            ));
                            j++;
                            break;
                        }

                    case 3://change or modify DVD
                        {
                            Console.WriteLine("Enter DVD Name to modify");
                            Name = Console.ReadLine();
                            for (int i = 0; dvdArray[i] != null; i++)
                            {
                                if (dvdArray[i].Name.Equals(Name))//will search array for DVD name from entries
                                {
                                    Console.WriteLine("Enter attribute to modify");
                                    attribute = Console.ReadLine();//attribute will pull up different option to change
                                    if (attribute.Equals("Name") || attribute.Equals("name"))
                                    {
                                        Console.WriteLine("Enter New DVD Name");
                                        Name = Console.ReadLine();
                                        dvdArray[i].Name = Name;
                                    }
                                    else if (attribute.Equals("Genre") || attribute.Equals("genre"))
                                    {
                                        Console.WriteLine("Enter New DVD Genre");
                                        Genre = Console.ReadLine();
                                        dvdArray[i].Genre = Genre;
                                    }
                                    else if (attribute.Equals("Year") || attribute.Equals("year"))
                                    {
                                        Console.WriteLine("Enter New DVD Year");
                                        Year = Console.ReadLine();
                                        dvdArray[i].Year = Year;
                                    }
                                    else if (attribute.Equals("Rating") || attribute.Equals("rating"))
                                    {
                                        Console.WriteLine("Enter New DVD Rating");
                                        Int32.TryParse(Console.ReadLine(), out Rating);
                                        dvdArray[i].Rating = Rating;
                                    }
                                }
                                Console.WriteLine("Changed DVD");
                                Console.WriteLine(dvdArray[i].ToString());
                            }
                            break;
                        }
                }
            }
            while (choice != 4);//program end if user selects 4
            Console.WriteLine("GoodBye");
            sw.Close();
        }
    }
    class DVD//public class for variables
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public int Rating { get; set; }
        public DVD(string Name, string Genre, string Year, int Rating)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Year = Year;
            this.Rating = Rating;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Genre: " + Genre + " Year: " + Year + " Rating: " + Rating;
        }
    }
}
