           
            string[] text=Console.ReadLine().Split(", ").ToArray();

            string title = text[0];
            string content = text[1];
            string author = text[2];

            Articles currentArticle = new Articles(title, content, author);
            

            int number =int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string command = commands[0];
                string info = commands[1];
                if (command=="Edit")
                {
                    currentArticle.Edit (info);
                }
                else if(command=="ChangeAuthor")
                {
                    currentArticle.ChangeAuthor (info);
                }
                else if (command == "Rename")
                {
                    currentArticle.ChangeTitle (info);
                }
            }

            Console.WriteLine($"{currentArticle.Title}-{currentArticle.Content}: {currentArticle.Author}");
            
