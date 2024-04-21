using System.Xml.Linq;

namespace Songs1
{  

    public class Song
    {
        public string TypeList { get; set; } 
        public string Name { get; set; } 
        public string Time { get; set; } 

    }
        
    public class Program
    {
        static void Main(string[] args)
        {
           int numberOfSongs=int.Parse(Console.ReadLine());
            List<Song> allsongs = new List<Song>();

            for (int i = 0; i<numberOfSongs; i++)
            {
                string[] songs = Console.ReadLine().Split("_").ToArray();
                string type = songs[0];
                string name = songs[1];
                string time = songs[2]; 

                Song currentsong = new Song()
                {
                    TypeList= type,
                    Name= name,
                    Time= time
                }; 

                allsongs.Add(currentsong);
            }

            string command = Console.ReadLine();

            if (command != "all")
            {
                List<Song> filteredSongs = allsongs.Where(song => song.TypeList == command).ToList();
                foreach (Song song in allsongs)
                {
                    Console.WriteLine(song.Name);

                }
            }
            else
            {
                foreach (Song song1 in allsongs)
                {
                    Console.WriteLine(song1.Name);
                }
            }
        }
    }
}
