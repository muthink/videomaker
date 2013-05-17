using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


    public partial class VideoMaker
    {
        public static VideoMaker LoadFromFile(String file)
        {
            VideoMaker vm;
            using (FileStream xmlStream = new FileStream(file, FileMode.Open))
            {
                using (XmlReader xmlReader = XmlReader.Create(xmlStream))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(VideoMaker));
                    vm = serializer.Deserialize(xmlReader) as VideoMaker;
                }
            }
            return vm;
        }

        public void Run()
        {
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("Number of Videos: " + this.Videos.Length);
            int videoNumber = 1;
            foreach (VideosVideo video in Videos)
            {
                Console.WriteLine("Processing Video " + videoNumber.ToString() + " : " + video.Id );
                video.Generate(this);
                ++videoNumber;
            }
            Console.ReadKey();
        }
    }