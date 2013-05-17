using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviFile;

public partial class SequencesSequence
{
    public void Generate(VideosVideo video)
    {       
        Console.WriteLine("Number of Tracks: " + this.Tracks.Length);
        int sequenceNumber = 1;
        foreach (var track in Tracks)
        {
            Console.WriteLine("Processing Video " + sequenceNumber.ToString() + " : " + track.Id);
            ++sequenceNumber;
        }
    }
    public void addFrame()
    {
    }
}
