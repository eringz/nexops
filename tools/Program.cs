using System;
using System.IO;

class Program 
{
    static void Main ()
    {
        string docsFolder = @"C:\Users\ASTA\Projects\NexOps\docs";

        foreach (var file in Directory.GetFiles(docsFolder, "*.md"))
        {
            string content = File.ReadAllText(file);
            string updatedContent = content.Replace("{{DATE}}", DateTime.Now.ToString("MMMM dd, yyyy"));
            File.WriteAllText(file, updatedContent);
            Console.WriteLine($"Updated: {Path.GetFileName(file)}");
        }
    }
}