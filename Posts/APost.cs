using System;

namespace post.Posts
{
    public class APost
    {
        public string title;
        public string description;
        public DateTime timestamp;
        public int[] votes = new int[2]{0, 0};

        public void SetNewPost(string newTitle, string newDescription)
        {
            title = newTitle;
            description = newDescription;
            timestamp = DateTime.Now;
        }

        public string AddVote(string UpDown)
        {
            var result = "";  
            if (UpDown == "Up")
            {
                votes[0]++;
            }
            else if (UpDown == "Down")
            {
                votes[1]++;
            }
            else
            {
                result = "UpDown parameter must be 'Up' or 'Down'.";
            }
            return result;
        }

        public int[] GetVotes()
        {
            return votes;
        }

    }
}