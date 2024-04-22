    public class Articles
    {
        public Articles (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void ChangeAuthor(string author)
        {
            Author = author;            
        }
        public void ChangeTitle(string title)
        {

            Title = title;            
        }
        public void Edit(string newContent)
        {
            Content = newContent;           
        }

        public override string ToString()
        {
            return $"{Title}-{Content}: {Author}";
        }

    }
