using ComboxExtended;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static EasyIconCreator.TilePositionSource;
using Newtonsoft.Json;
using EasyIconCreator.Extensions;

namespace EasyIconCreator
{
    public partial class Form1 : Form
    {
        private string OutputDirectory { get; set; } = @"Output\";
        private string DefaultImage { get { return OutputDirectory + "DefaultImage.png"; } }

        public TileText _TileText;
        public TileIcon _TileIcon;

        public Form1()
        {
            InitializeComponent();

            cbIconImage.DataBindings.Add("Visible", TileConfiguration.Instance, "hasIconPath");

            
            cbTextAlignment.DataSource = new string[] { "Left", "Center", "Right" };
            cbTextAlignment.SelectedIndex = 0;

            cbIconAlignment.DataSource = new string[] { "Left", "Center", "Right" };
            cbIconAlignment.SelectedIndex = 2;

            cbTextPosition.DataSource = new string[] { "Top", "Middle", "Bottom" };
            cbTextPosition.SelectedIndex = 2;

            cbIconSize.DataSource = new int[] { 16, 22, 24, 32, 48, 64, 128, 256 };
            cbIconSize.SelectedIndex = 3;

            colorBackgound.Color = btBackgroundColor.BackColor = Color.BlueViolet;            
            colorText.Color = btTextColor.BackColor = Color.White;            

            cbImageSize.DataSource = TileConfiguration.Instance.TileSizes;
            cbImageSize.SelectedIndex = 0;

            cbIconColor.SelectedIndex = 0;


            cbIconSize.SelectedIndex = 3;


            cbIconPosition.DataSource = new string[] { "Top", "Middle", "Bottom" };
            cbIconPosition.SelectedIndex = 0;

            foreach (var fileName in Directory.GetFiles($"Icons\\black\\png\\32"))
            {
                cbIconImage.Items.Add(new ComboBoxItem(Path.GetFileName(fileName), getImageByName(fileName)));
            }
            cbIconImage.SelectedIndex = 0;

            UpdateImage();
            GetAllControls(this);

        }

        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndexChanged += UpdateImage;
                } else if(c is TextBox)
                {
                    (c as TextBox).TextChanged += UpdateImage;
                }
                else if (c is NumericUpDown)
                {
                    (c as NumericUpDown).ValueChanged += UpdateImage;
                }
                else if (c is TrackBar)
                {
                    (c as TrackBar).ValueChanged += UpdateImage;
                }
                else if (c is CheckBox)
                {
                    (c as CheckBox).CheckedChanged += UpdateImage;
                }
            }
        }

        public Image getImageByName(string name)
        {
            return Image.FromFile(System.IO.Path.Combine(Application.StartupPath, name));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            colorBackgound.ShowDialog();
            btBackgroundColor.BackColor = colorBackgound.Color;
            UpdateImage();
        }

        void PrepareImage()
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            if (pictureBox1.InitialImage != null)
                pictureBox1.InitialImage.Dispose();
            pictureBox1.InitialImage = null;
            pictureBox1.Update();
            pictureBox1.Refresh();
        }

        private void UpdateImage()
        {
            PrepareImage();

            if (cbImageSize.SelectedItem == null)
                return;

            //backgorund image
            var background = ((TileSize)cbImageSize.SelectedItem);

            //text information
            var textBackgroundColor = btTextColor.BackColor;
            var textAlignment = (TileAlignment)Enum.Parse(typeof(TileAlignment), cbTextAlignment.SelectedValue.ToString());
            var textPosition = (TilePosition)Enum.Parse(typeof(TilePosition), cbTextPosition.SelectedValue.ToString());
            var textMarginHorizontal = trackTextHorizontal.Value;
            var textMarginVertical = trackTextVertical.Value;
            var textVisible = checkTextEnabled.Checked;
            var textFontSize = (int)TextSize.Value;
            var textText = txtTexto.Text;

            _TileText = new TileText(
                textText,
                textFontSize,
                background,
                textBackgroundColor,
                textAlignment,
                textPosition,
                textMarginHorizontal,
                textMarginVertical,
                textVisible);

            var iconBackgroundColor = colorBackgound.Color;
            var iconSize = (int)cbIconSize.SelectedItem;
            var iconColor = cbIconColor.SelectedItem.ToString();
            var iconAlignment = (TileAlignment)Enum.Parse(typeof(TileAlignment), cbIconAlignment.SelectedValue.ToString());
            var iconPosition = (TilePosition)Enum.Parse(typeof(TilePosition), cbIconPosition.SelectedValue.ToString());
            var iconMarginHorizontal = trackIconHorizontal.Value;
            var iconMarginVertical = trackIconVertical.Value;
            var iconName = cbIconImage.SelectedItem.ToString();


            _TileIcon = new TileIcon(
                iconName,
                background,
                iconBackgroundColor,
                iconColor,
                iconSize,
                iconAlignment,
                iconPosition,
                iconMarginHorizontal,
                iconMarginVertical,
                true);

            MagickReadSettings settings = new MagickReadSettings();
            settings.Width = pictureBox1.Width = background.Width;
            settings.Height = pictureBox1.Height = background.Height;

            using (MemoryStream memStream = new MemoryStream())
            {
                using (MagickImage image = new MagickImage($"xc: rgb({_TileIcon.BackgroundColor.R},{_TileIcon.BackgroundColor.G},{_TileIcon.BackgroundColor.B})", settings))
                {
                    image.Format = MagickFormat.Png;
                    image.Composite(new MagickImage(_TileIcon.Path), _TileIcon.GetX(), _TileIcon.GetY(), CompositeOperator.Blend);

                    //draw Text
                    if (_TileText.IsVisible())
                    {
                        new Drawables()
                          .FontPointSize(_TileText.FontSize)
                          .Font(_TileText.Font)
                          .StrokeColor(_TileText.Color)
                          .FillColor(_TileText.BackgroundColor)
                          .TextAlignment(_TileText.GetAlignmentAsTextAlignment())
                          .Text(_TileText.GetX(), _TileText.GetY(), _TileText.Text)
                          .Draw(image);
                    }

                    image.Write(DefaultImage);
                }
            }

            using (Image myImage = Image.FromFile(DefaultImage))
            {
                pictureBox1.Image = (Image)myImage.Clone();
                pictureBox1.Update();
            }
        }

        private void UpdateImage(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void btTextColor_Click(object sender, EventArgs e)
        {
            colorText.ShowDialog();
            btTextColor.BackColor = colorText.Color;
            UpdateImage();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = $"{_TileText.Text.ToSlug()}-{_TileIcon.BackgroundSize.Width}x{_TileIcon.BackgroundSize.Height}-{_TileIcon.Size}x{_TileIcon.Size}.png"; 

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(DefaultImage, sf.FileName, true);
                    MessageBox.Show("Imagem criada com sucesso!");

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderIconsPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                TileConfiguration.Instance.IconsPath = folderIconsPath.SelectedPath;
                TileConfiguration.Instance.Save();
            }
        }
    }


}
