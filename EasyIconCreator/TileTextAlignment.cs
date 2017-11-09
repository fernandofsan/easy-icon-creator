using ImageMagick;
using System.Collections.Generic;

namespace EasyIconCreator
{
    public class TileTextAlignment
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public TileTextAlignment(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public static class TileTextAlignmentSource
    {

        public static TextAlignment Parse(this TileTextAlignment tileTextAlignment)
        {
            return (TextAlignment)tileTextAlignment.Value;
        }

        public static List<TileTextAlignment> Get()
        {
            return new List<TileTextAlignment>()
            {
                new TileTextAlignment("Left", 1),
                new TileTextAlignment("Center", 2),
                new TileTextAlignment("Right", 3)
            };
        }
    } 
}
