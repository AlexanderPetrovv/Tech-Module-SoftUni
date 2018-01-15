using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class SocialMediaPosts
    {
        static Dictionary<string, int> postLikes;
        static Dictionary<string, int> postDislikes;
        static Dictionary<string, Dictionary<string, string>> postComments;

        static void Main(string[] args)
        {
            postLikes = new Dictionary<string, int>();
            postDislikes = new Dictionary<string, int>();
            postComments = new Dictionary<string, Dictionary<string, string>>();

            string line = Console.ReadLine();

            while (line != "drop the media")
            {
                string[] input = line.Split(' ');
                string command = input[0];
                string postName = input[1];

                switch (command)
                {
                    case "post":
                        CreatePost(postName);
                        break;
                    case "like":
                        LikePost(postName);
                        break;
                    case "dislike":
                        DislikePost(postName);
                        break;
                    case "comment":
                        string commentator = input[2];
                        string comment = string.Join(" ", input.Skip(3));
                        CommentPost(postName, commentator, comment);
                        break;
                }

                line = Console.ReadLine();
            }

            PrintResult();
        }

        static void PrintResult()
        {
            foreach (var postComment in postComments)
            {
                string postName = postComment.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Dictionary<string, string> comments = postComment.Value;

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");

                Console.WriteLine("Comments:");
                if (comments.Count <= 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var comment in comments)
                {
                    string commentator = comment.Key;
                    string commentContent = comment.Value;
                    Console.WriteLine($"*  {commentator}: {commentContent}");
                }
            }
        }

        static void CommentPost(string postName, string commentator, string comment)
        {
            postComments[postName].Add(commentator, comment);
        }

        static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }

        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }

        static void CreatePost(string postName)
        {
            postLikes[postName] = 0;
            postDislikes[postName] = 0;
            postComments[postName] = new Dictionary<string, string>();
        }
    }
}
