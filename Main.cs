namespace FileIO;
using System.IO;

public class Io
{
    public static void Main()
    {


        String path = "Numbers.txt";
        if (!File.Exists(path))
        {
            return;
        }
        
        StreamWriter evenWriter = new StreamWriter("Even.txt");
        StreamWriter oddWriter = new StreamWriter("Odd.txt");
        
        using (StreamReader stream = File.OpenText(path))
        {
            string? next;
            while ((next = stream.ReadLine()) != null)
            {
                if (int.Parse(next) % 2 == 0)
                {
                    evenWriter.WriteLine(next);
                }
                else
                {
                    oddWriter.WriteLine(next);
                }
            }
        }
        evenWriter.Close();
        oddWriter.Close();

    }
    
}