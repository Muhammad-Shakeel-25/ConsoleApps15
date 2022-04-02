using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class SocialNetwork
    {

        string[] post = new string[99] ;
        string[] author = new string[99];
        int[] like = new int[99];
        int id = 0;

        public void Run()
        {
            string[] choices =
            {
                " Post Message",
                " Post Photo",
                " Remove Post",
                " Display All Posts",
                " Display Posts by Author",
                " Add Comment to Post",
                " Like a Post",
                " Unlike a Post",
                " Quit"
            };
            int choice = ConsoleHelper.SelectChoice(choices);
            if (choice == 1)
            {
                PostMessage();
            }
            else if (choice == 3)
            {
                RemovePost();
            }
            else if(choice == 4)
            {
                DisplayAllPosts();
            }
            else if (choice == 7)
            {
                LikePost();
            }
            else if (choice == 8)
            {
                UnLikePost();
            }
        }

        private void UnLikePost()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            if (like[postid]>0)
            {
            like[postid] = like[postid] - 1;
            Console.WriteLine(" Post UnLiked with ID " + postid);
            }
            else
            {
                Console.WriteLine(" Post already unliked ");
            }
            Run();


        }

        private void LikePost()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            like[postid] = like[postid]+1;
            Console.WriteLine(" Post Liked with ID " + postid);
            Run();
        }

        private void RemovePost()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            post[postid] = "";
            Console.WriteLine(" Post Removed with ID " + postid);
            Run();
        }

        private void DisplayAllPosts()
        {
            for(int i=0;i<id;i++)
            {
                if(post[i]!="")
                { 
                Console.WriteLine(" Post ID " + i +" | Post Author " + author[i]);
                Console.WriteLine(" "+post[i]);
                Console.WriteLine(" Likes "+like[i]);
                }
            }

            Run();
        }

        private void PostMessage()
        {
            Console.WriteLine(" Please enter author Name:");
            author[id] = Console.ReadLine();
            Console.WriteLine(" Please enter post message:");
            post[id] = Console.ReadLine();
            like[id] = 0;
            id++;

            Run();

        }
    }
}
