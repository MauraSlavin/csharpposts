using System;
using post.Posts;

namespace post
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's the title of your post?");
            var enteredTitle = Console.ReadLine();
            Console.WriteLine("Type your post:");
            var enteredDescription = Console.ReadLine();

            var thisPost = new APost();
            thisPost.SetNewPost(enteredTitle, enteredDescription);

            var thisPostVotes = new int[2]{0, 0};
            var result = "";

            var entry = "";
            while (entry != "end")
            {
                Console.WriteLine("Type 'Up' for an up vote;  'Down' for a down vote;  'Show' to display the votes; or 'End' to stop the app.");
                entry = Console.ReadLine();
                entry = entry.ToLower().Replace(" ", String.Empty);
                if (entry == "up")
                {
                    result = thisPost.AddVote("Up");

                    if (result == "")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Up vote incremented.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(result);
                    }
                }

                else if (entry == "down")
                {
                    result = thisPost.AddVote("Down");
                    if (result == "")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Down vote incremented.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(result);
                    }
                }

                else if (entry == "show")
                {
                    thisPostVotes = thisPost.GetVotes();
                    Console.WriteLine();
                    Console.WriteLine("For post titled: " + thisPost.title);
                    Console.WriteLine(thisPost.description);
                    Console.WriteLine("Up votes: " + thisPostVotes[0]);
                    Console.WriteLine("Down votes: " + thisPostVotes[1]);
                }

                else if (entry != "end")
                {
                    Console.WriteLine();
                    Console.WriteLine("'" + entry + "' is invalid.  Please enter up, down, show or end.");
                }

            }
        }
    }
}
