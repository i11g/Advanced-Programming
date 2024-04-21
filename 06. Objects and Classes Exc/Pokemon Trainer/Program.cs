namespace Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lines=Console.ReadLine();
            
            Dictionary<string,Trainer> trainers=new Dictionary<string,Trainer>();

          while (lines!="Tournament")
            {
                string[] info = lines.Split(' ').ToArray();
                string trainerName = info[0];
                string pokemonName = info[1];
                string element = info[2];
                int health = int.Parse(info[3]);
                int numberOfBadges = 0;

                if(!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }


                Trainer currentTrainer = trainers[trainerName];
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                currentTrainer.AddPokemon(Pokemon pokemon);

                lines = Console.ReadLine();
            }
        }
    }
}