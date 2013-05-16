using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace videomaker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                VideoMaker  videoMaker = new VideoMaker();

                videoMaker = VideoMaker.LoadFromFile(args[0]);
                videoMaker.Run();
            }
        }
    }
}
