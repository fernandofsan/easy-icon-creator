using System.Collections.Generic;

namespace EasyIconCreator
{
    public class TilePositionOld
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public TilePositionOld(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public static class TilePositionSource
    {
        public enum TilePositionEnum
        {
            Top = 1,
            Middle = 2,
            Bottom = 3
        }

        public static TilePositionEnum Parse(this TilePositionOld tilePosition)
        {
            return (TilePositionEnum)tilePosition.Value;
        }

        public static List<TilePositionOld> Get()
        {
            return new List<TilePositionOld>()
            {
                new TilePositionOld("Top", 1),
                new TilePositionOld("Middle", 2),
                new TilePositionOld("Bottom", 3)
            };
        }
    } 
}
