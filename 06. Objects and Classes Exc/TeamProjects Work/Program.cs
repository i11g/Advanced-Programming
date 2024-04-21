namespace TeamProjects_Work
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Teams> teams = new Dictionary<string,Teams>();

            int numberOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] data = Console.ReadLine().Split("-").ToArray();

                string creator = data[0];
                string teamName = data[1];

                Teams currentTeam = new Teams(creator, teamName);
                Console.WriteLine($"Team....)");
                teams.Add(teamName, currentTeam);
            }
            
            string command = Console.ReadLine();

            while (command != "end of assigment")
            {   
                string[] info=command.Split("->").ToArray();
                string member = info[0];
                string teamName = info[1];

                teams[teamName].Members.Add(member);

                command = Console.ReadLine();
            }
           
           foreach(var team in teams.Where(team=>team.Value.Members.Count>0).
                                     OrderByDescending(team=>team.Value.Members.Count).
                                     ThenBy(team => team.Key))
            {

            }
        }

        
    }
}