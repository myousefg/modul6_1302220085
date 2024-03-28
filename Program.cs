using System.Diagnostics;

public class SayaTubeVideo
{
    public int id;
    public string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Title tidak Boleh Kosong!");
        Debug.Assert(title.Length <= 200, "Title tidak boleh melebihi 200 Karakter");
        this.title = title;
        Random randomid = new Random();
        id = randomid.Next(10000, 99999);
        playCount = 0;

       

    }

    public void IncreasePlayCount(int increment)
    {
        playCount += increment;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play Count : " + playCount);
        Console.WriteLine("");
    }   
}

public class SayaTubeUser
{
    public int id;
    List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        this.Username = username;
        uploadedVideos = new List<SayaTubeVideo>();
    }

    public void GetTotalVideoPlayCount()
    {
        int total = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].playCount;
        }
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User : " + Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul : " + uploadedVideos[i].title);
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Kung Fu Panda 4 oleh Yousef");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Breaking Bad oleh Yousef");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Life Of PI oleh Yousef");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film How To Train Your Dragon oleh Yousef");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Iron Man oleh Yousef");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Fast and Furious oleh Yousef");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Deadpool oleh Yousef");
        SayaTubeVideo video8 = new SayaTubeVideo("");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Conjuring oleh Yousef");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Annabelle oleh Yousef");
        SayaTubeVideo video11 = new SayaTubeVideo("Review Film The Reacher oleh Yousef");
        SayaTubeUser User = new SayaTubeUser("Yousef");
        User.AddVideo(video1);
        User.AddVideo(video2);
        User.AddVideo(video3);
        User.AddVideo(video4);
        User.AddVideo(video5);
        User.AddVideo(video6);
        User.AddVideo(video7);
        User.AddVideo(video8);    
        User.AddVideo(video9);
        User.AddVideo(video10);
        User.AddVideo(video11);

        User.PrintAllVideoPlaycount();
    }
}
