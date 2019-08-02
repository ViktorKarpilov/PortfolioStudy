using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicImageHandler;
using System.Windows;


using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;

namespace PortfolioAplication.Models
{
    public class PhotoCollection
    {

        Dictionary<string, Image<Rgba32>> Collection = new Dictionary<string, Image<Rgba32>>();

        public PhotoCollection(Dictionary<string, Image<Rgba32>> dict) { Collection = dict; }



        //0 - OK, 1 - conflicting name, 2 - invalid image 
        public int Add(string name, string path)
        {
            Image<Rgba32> img = new Image<Rgba32>(400, 400);

            if (Collection.TryGetValue(name, out img)) { return 1; }

            try
            {
                img = Image.Load(path);
                Collection.Add(name, img);
            }
            catch { return 2; }
            return 0;
        }
        public void Delete(string name)
        {
            Collection.Remove(name);
        }
    }
}
