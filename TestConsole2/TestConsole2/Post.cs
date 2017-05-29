using System;
namespace TestConsole2
{
    partial class Program
    {
        public class Post
        {
            public string Title { get; private set; }
            public string Description { get; private set; }
            public DateTime CreatedTime { get; private set; }
            public DateTime ModifiedTIme { get; private set; }
            public int UpVote { get; private set; }
            public int DownVote { get; private set; }

            public Post(string title, string Description)
            {
                this.Title = title;
                this.Description = title;
                this.CreatedTime = DateTime.Now;
                this.ModifiedTIme = DateTime.Now;
            }

            public void Vote(bool flag)
            {
                if (flag)
                    UpVote += 1;
                else
                    DownVote += 1; 
            }
            
        }
    }
}
