﻿using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample2
{
    public class MainPost
    {
        public static void Main(string[] args)
        {
            Post p1 = new Post();
            Post p3 = new Post();
            Post p2 = new Post(1, "MY DOGS", "Dominik", true);
            Type a = p1.GetType();
            Type b = p2.GetType();
            
            
            if (a.Equals(b))
            {
                Console.WriteLine("what in the fuck i am confused.");
            }
            
            ImagePost im1 = new ImagePost("www.pornhub.com", "This is my favourite website", "Anta Ziolkowski", true);

            Type im = im1.GetType();

            if (im.IsSubclassOf(p1.GetType()))
            {
                Console.WriteLine("i am a subclass of this types class.");
            }

            Type pp = typeof(Post);
            if (im.IsSubclassOf(pp))
            {
                Console.WriteLine("This is the same thing to get the type of the class.");
            }
            
            
            
            if(Type.Equals(p1, p2))
            {
                Console.WriteLine("this is indeed true");
            }
            
            Console.WriteLine(im1.ToString());
            
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}