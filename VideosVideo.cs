using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public partial class VideosVideo
    {
        public void Generate(VideoMaker videoMaker)
        {
            aviManager = new AviFile.AviManager(fileName,false);
            Console.WriteLine("Video ID:" + this.Id + " with name: " + fileName);
            Console.WriteLine("Number of Sequences: " + this.Sequences.Length);
            int sequenceNumber = 1;
            foreach (var sequence in Sequences)
            {
                Console.WriteLine("Processing Video " + sequenceNumber.ToString() + " : " + sequence.Id );
                ++sequenceNumber;
            }
        }
        public void AddFrame(System.Drawing.Bitmap bitmap)
        {
            if (stream == null)
                stream = aviManager.AddVideoStream(true, 30, bitmap);
            else
                stream.AddFrame(bitmap);
        }
        private AviFile.AviManager aviManager;
        private AviFile.VideoStream stream;
        public String fileName;
    }
