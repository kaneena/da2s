namespace da2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("f1.txt", "first file");
            FileInfo fin1 = new FileInfo("f1.txt");
            File.WriteAllText("f2.txt", "second file");
            FileInfo fin2 = new FileInfo("f2.txt");
            File.WriteAllText("f3.txt", "third file");
            fin1.CopyTo("f4.txt");
            fin2.MoveTo("f5.txt");
             using (StreamWriter streamWriter = fin1.AppendText()) 
             {
                streamWriter.Write(" appended successfully");
             }
        }
    }
}
