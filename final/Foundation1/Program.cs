using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("How to get to first base", "Hyrum Tolman", 480);

        Comment video1Comment1 = new Comment("David", "This video is truly inspiring! I love how you taking about how to talking to her.");
        Comment video1Comment2 = new Comment("MrBeast", "Your content always surprises me. I want to fly you out to Florida.");
        Comment video1Comment3 = new Comment("Murmut", "Wonderful! I wish i had that skill.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Pickled herring in my soup", "Jack Dalton", 975);

        Comment video2Comment1 = new Comment("Diego", "Wow what a chef");
        Comment video2Comment2 = new Comment("Bill", "BowTies are cool");
        Comment video2Comment3 = new Comment("Alisha", "I go hard to this song");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Let's country dance", "Miriam Velasquez Soto", 650);

        Comment video3Comment1 = new Comment("Anna", "Wow, you can really dances.");
        Comment video3Comment2 = new Comment("Peter", "How do you do that.");
        Comment video3Comment3 = new Comment("Ralph", "woof woof");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
