using System;
using System.Drawing;

namespace EasyIconCreator
{
    /// <summary>
    /// Manage the Tile icon
    /// </summary>
    public class TileIcon : TileContent
    {
        /// <summary>
        /// Icon Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Icon Folder
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Path File
        /// </summary>
        public string Path {
            get {
                return $"Icons\\{Folder}\\png\\{Size}\\{Name}";
            }
        }


        public TileIcon(
            string name,
            TileSize backgroundSize,
            Color backgroundColor,
            string folder,
            int iconSize,
            TileAlignment alignment,
            TilePosition position,
            int marginHorizontal,
            int marginVertical,
            bool visible)
            {
                Name = name;
                BackgroundSize = backgroundSize;
                BackgroundColor = backgroundColor;
                Folder = folder;
                Size = iconSize;
                Alignment = alignment;
                Position = position;
                MarginHorizontal = marginHorizontal;
                MarginVertical = marginVertical;
                Visible = visible;
        }

        public override int GetX()
        {
            var margin = MarginHorizontal * 5;
            switch (Alignment)
            {
                case TileAlignment.Right:
                    return margin + BackgroundSize.Width - Size;
                case TileAlignment.Center:
                    return margin + BackgroundSize.Width / 2 - Size/2;
                default: //TileAlignment.Left
                    return margin + 0;
            }

        }

        public override int GetY()
        {
            var scapeFromCorner = 5;
            var margin = MarginVertical * 10;
            switch (Position)
            {
                case TilePosition.Top:
                    return margin + 0 + scapeFromCorner;
                case TilePosition.Bottom:
                    return margin + BackgroundSize.Height - Size - scapeFromCorner;
                default: //TilePosition.Middle
                    return margin + BackgroundSize.Height / 2 - Size / 2;
            }
        }
    }
}
