using System;
using System.IO;

class Program
{
    // Number of bytes in .wav header
    const int HEADER_SIZE = 44;

    static void Main(string[] args)
    {
        // Check command-line arguments
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: dotnet run <input.wav> <output.wav> <factor>");
            return;
        }

        // Open files and determine scaling factor
        string inputFilePath = args[0];
        string outputFilePath = args[1];
        float factor = float.Parse(args[2]);

        try
        {
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                // Copy header from input file to output file
                byte[] header = new byte[HEADER_SIZE];
                inputFileStream.Read(header, 0, HEADER_SIZE);
                outputFileStream.Write(header, 0, HEADER_SIZE);

                // Read samples from input file and write updated data to output file
                byte[] buffer = new byte[2];
                while (inputFileStream.Read(buffer, 0, buffer.Length) > 0)
                {
                    // Convert bytes to a sample (16-bit PCM)
                    short sample = BitConverter.ToInt16(buffer, 0);

                    // Update volume of sample
                    sample = (short)(sample * factor);

                    // Convert sample back to bytes
                    buffer = BitConverter.GetBytes(sample);

                    // Write updated sample to new file
                    outputFileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
