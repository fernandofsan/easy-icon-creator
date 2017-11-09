using System;
using System.Drawing;

namespace EasyIconCreator
{
    public interface ITileContent
    {
        int GetX();
        int GetY();
        bool IsVisible();
    }

    public abstract class TileContent : ITileContent
    {
        /// <summary>
        /// Define the margin X
        /// </summary>
        public int MarginHorizontal { get; set; } = 0;

        /// <summary>
        /// Define the margin Y
        /// </summary>
        public int MarginVertical { get; set; } = 0;

        /// <summary>
        /// Position on X Position
        /// </summary>
        private int X { get; set; }

        /// <summary>
        /// Position on Y
        /// </summary>
        private int Y { get; set; }

        /// <summary>
        /// Set the alignment of the content
        /// </summary>
        public TileAlignment Alignment;

        /// <summary>
        /// Set the content position
        /// </summary>
        public TilePosition Position;

        /// <summary>
        /// Uses Background size as a reference to positioning the element
        /// </summary>
        public TileSize BackgroundSize;

        /// <summary>
        /// Background Color
        /// </summary>
        public Color BackgroundColor = Color.Black;


        /// <summary>
        /// Set if the content must be shown on Tile
        /// </summary>
        public bool Visible { get; set; }


        public abstract int GetX();

        public abstract int GetY();

        public bool IsVisible()
        {
            return Visible;

        }
    }

    /// <summary>
    /// Define the content position relative to X
    /// </summary>
    public enum TileAlignment
    {
        Left = 1,
        Center = 2,
        Right = 3
    }

    /// <summary>
    /// Define the content position relative to Y
    /// </summary>
    public enum TilePosition
    {
        Top = 1,
        Middle = 2,
        Bottom = 3
    }

    /// <summary>
    /// Set Width and Height for an object
    /// </summary>
    public class TileSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public TileSize(int _width, int _height)
        {
            Width = _width;
            Height = _height;
        }

        public override string ToString()
        {
            return $"{Width} x {Height}";
        }
    }



}
