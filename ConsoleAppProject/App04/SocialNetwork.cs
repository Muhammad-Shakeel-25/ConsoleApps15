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
        string[] comment = new string[99];
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
            else if (choice == 2)
            {
                PostPhoto();
            }
            else if (choice == 3)
            {
                RemovePost();
            }
            else if(choice == 4)
            {
                DisplayAllPosts();
            }
            else if (choice == 5)
            {
                DisplayPostsByAuthor();
            }
            else if (choice == 6)
            {
                AddComment();
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

        private void PostMessage()
        {
            Console.WriteLine(" Please enter author Name:");
            author[id] = Console.ReadLine();
            Console.WriteLine(" Please enter post message:");
            post[id] = Console.ReadLine();
            like[id] = 0;
            id++;
            Console.WriteLine(" Post added");
            ReRun();

        }

        private void PostPhoto()
        {
            Console.WriteLine(" Please enter author Name:");
            author[id] = Console.ReadLine();
            Console.WriteLine(" Please enter post photo url:");
            post[id] = Console.ReadLine();
            like[id] = 0;
            id++;
            Console.WriteLine(" Post added");
            ReRun();
        }

        private void AddComment()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please Enter Your Comment>");
            comment[postid] = " Comment for Post id "+postid+") "+Console.ReadLine();
            Console.WriteLine(" Comment added to post id " + postid);
            ReRun();
        }

        private void showComments(int postID)
        {
            for(int i=0;i<comment.Length;i++)
            {
                if(comment[i]!=null)
                { 
                    if(comment[i].Contains(postID+")"))
                Console.WriteLine(" " + comment[i]);
                }
            }
        }

        private void DisplayPostsByAuthor()
        {
            Console.WriteLine(" Please enter the name of author>");
            String authorName = Console.ReadLine();
            for (int i = 0; i < id; i++)
            {
                if (post[i] != "" && author[i]==authorName)
                {
                    Console.WriteLine(" Post ID " + i + " | Post Author " + author[i]);
                    Console.WriteLine(" " + post[i]);
                    Console.WriteLine(" Likes " + like[i]);
                    showComments(i);
                }
            }


            ReRun();

        }

        private void ReRun()
        {
            Console.WriteLine(" Want to show ALL OPTIONS AGAIN? y/n");
            if (Console.ReadLine() == "y")
                Run();
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
            ReRun();


        }

        private void LikePost()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            like[postid] = like[postid]+1;
            Console.WriteLine(" Post Liked with ID " + postid);
            ReRun();
        }

        private void RemovePost()
        {
            Console.WriteLine(" Please Enter Post ID>");
            int postid = Convert.ToInt32(Console.ReadLine());
            post[postid] = "";
            Console.WriteLine(" Post Removed with ID " + postid);
            ReRun();
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
                    showComments(i);
                }
            }

            ReRun();
        }

       
    }
}
