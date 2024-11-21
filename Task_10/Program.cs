class Program
{
    static void Main(string[] args)
    {
        List<string> lines = ["x\tsin(x)"];
        for (double i = 0; i < 1; i+=0.1)
        {
            lines.Add($"{i:F1}\t{Math.Sin(i):F10}");
        }

        // Set a variable to the Documents path.
        string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        {
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
}
