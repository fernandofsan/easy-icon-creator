using System.Drawing;

namespace EasyIconCreator
{
    /// <summary>
    /// Manage the text to be applied at Tile
    /// </summary>
    public class TileText : TileContent
    {
        /// <summary>
        /// Text on Tile
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Text Font
        /// </summary>
        public string Font { get; set; } = "Arial";

        /// <summary>
        /// Font Size
        /// </summary>
        public int FontSize { get; set; } = 28;

        /// <summary>
        /// ForeColor
        /// </summary>
        public Color Color { get; set; } = Color.White;

        public TileText(
                string text,
                int fontSize,
                TileSize backgroundSize,
                Color backgroundColor,
                TileAlignment alignment,
                TilePosition position,
                int marginHorizontal,
                int marginVertical,
                bool visible)
        {
            Text = text;
            FontSize = fontSize;
            BackgroundSize = backgroundSize;
            BackgroundColor = backgroundColor;
            Alignment = alignment;
            Position = position;
            MarginHorizontal = marginHorizontal;
            MarginVertical = marginVertical;
            Visible = visible;
        }

        public ImageMagick.TextAlignment GetAlignmentAsTextAlignment()
        {
            return ((ImageMagick.TextAlignment)Alignment);
        }

        public override int GetY()
        {
            var margin = MarginVertical * 10;
            switch (Position)
            {
                case TilePosition.Top:
                    return margin + (int)FontSize;
                case TilePosition.Bottom:
                    return margin + BackgroundSize.Height - (int)(FontSize * 0.4M);
                default: //TilePosition.Middle
                    return margin + BackgroundSize.Height / 2;
            }
        }

        public override int GetX()
        {
            //Remove the text of the corner
            var moveFromCorner = 10;

            var margin = MarginHorizontal * 10;
            switch (Alignment)
            {
                case TileAlignment.Right:
                    return margin + BackgroundSize.Width - (int)FontSize/2;
                case TileAlignment.Center:
                    //return margin + BackgroundSize.Width - (int)(FontSize * 0.4M);
                    return margin + BackgroundSize.Width / 2;
                default: //TileAlignment.Left
                    return moveFromCorner + margin + 0;
            }
        }

        /// <summary>
        /// Evita erro causado quando se tenta desenhar um Texto vazio
        /// </summary>
        /// <returns></returns>
        public new bool IsVisible()
        {
            if (string.IsNullOrEmpty(Text))
                return false;

            return Visible;
        }
    }

}
