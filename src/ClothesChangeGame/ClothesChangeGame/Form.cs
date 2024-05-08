using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesChangeGame.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ClothesChangeGame
{
    public partial class FormMain : Form
    {
        Person _person = new Person();
        Appearance _appearance = new Appearance();
        Surrounding _surrounding = new Surrounding();
        Dictionary<string, dynamic> _ctrlMap = new Dictionary<string, dynamic>()
        {
            { "radioButton_BlueShirt", ClothesChangeGame.Top.blueShirt },
            { "radioButton_LeatherJacket", ClothesChangeGame.Top.leatherJacket },
            { "radioButton_GreenTShirt", ClothesChangeGame.Top.greenTShirt },
            { "radioButton_RedShirt", ClothesChangeGame.Top.redShirt },
            { "radioButton_RedTShirt", ClothesChangeGame.Top.redTShirt },
            { "radioButton1", ClothesChangeGame.Top.redTShirt },
            { "radioButton_BlackShorts", ClothesChangeGame.Bottom.blackPants },
            { "radioButton_BlueShorts", ClothesChangeGame.Bottom.blueShorts },
            { "radioButton_RedBreeches", ClothesChangeGame.Bottom.brownPants },
            { "radioButton_GreenBreeches", ClothesChangeGame.Bottom.greenPants },
            { "radioButton_Jeans", ClothesChangeGame.Bottom.bluePants },
            { "radioButton_NoShoes", ClothesChangeGame.Shoes.none },
            { "radioButton_Crocs", ClothesChangeGame.Shoes.crocs },
            { "radioButton_Gumshoes", ClothesChangeGame.Shoes.gumshoes },
            { "radioButton_Slippers", ClothesChangeGame.Shoes.slippers },
            { "radioButton_Sneakers", ClothesChangeGame.Shoes.sneakers },
        };
        Dictionary<dynamic, Bitmap> _resMap = new Dictionary<dynamic, Bitmap>()
            {
                { ClothesChangeGame.Top.blueShirt, Resources.bluetshirt },
                { ClothesChangeGame.Top.leatherJacket, Resources.darktshirt },
                { ClothesChangeGame.Top.greenTShirt, Resources.greentshirt },
                { ClothesChangeGame.Top.redShirt, Resources.redtshirt },
                { ClothesChangeGame.Top.redTShirt, Resources.redtshirttwo },
                { ClothesChangeGame.Bottom.blackPants, Resources.blackPants },
                { ClothesChangeGame.Bottom.blueShorts, Resources.blueShorts },
                { ClothesChangeGame.Bottom.brownPants, Resources.brownPants },
                { ClothesChangeGame.Bottom.greenPants, Resources.greenPants },
                { ClothesChangeGame.Bottom.bluePants, Resources.bluePants },
                { ClothesChangeGame.Shoes.none, Resources.justLegs },
                { ClothesChangeGame.Shoes.crocs, Resources.crocs },
                { ClothesChangeGame.Shoes.gumshoes, Resources.gumshoes },
                { ClothesChangeGame.Shoes.slippers, Resources.slippers },
                { ClothesChangeGame.Shoes.sneakers, Resources.sneakers },
            };
        string ph = "Placeholder-Text";
        private Control GetFormatControl(object sender, ConvertEventArgs cevent)
        {
            Binding binding = (sender as Binding);
            if (binding == null) return null;

            Control button = binding.Control;

            if (button == null || cevent.DesiredType != typeof(Boolean)) return null;
            return button;
        }
        private Control GetParseControl(object sender, ConvertEventArgs cevent)
        {
            Binding binding = (sender as Binding);
            if (binding == null) return null;

            Control button = binding.Control;
            bool value = (bool)cevent.Value;

            if (button == null || value != true) return null;
            return button;
        }
        private void FormatTop(object sender, ConvertEventArgs cevent)
        {
            Control button = GetFormatControl(sender, cevent);
            if (button == null) return;

            cevent.Value = _appearance.Top == _ctrlMap[button.Name];
            SetTopImage();
        }
        private void ParseTop(object sender, ConvertEventArgs cevent)
        {
            Control button = GetParseControl(sender, cevent);
            if (button == null) return;

            _appearance.Top = _ctrlMap[button.Name];
            SetTopImage();
        }
        private void FormatBottom(object sender, ConvertEventArgs cevent)
        {
            Control button = GetFormatControl(sender, cevent);
            if (button == null) return;

            cevent.Value = _appearance.Bottom == _ctrlMap[button.Name];
            SetBottomImage();
        }
        private void ParseBottom(object sender, ConvertEventArgs cevent)
        {
            Control button = GetParseControl(sender, cevent);
            if (button == null) return;

            _appearance.Bottom = _ctrlMap[button.Name];
            SetBottomImage();
        }
        private void FormatShoes(object sender, ConvertEventArgs cevent)
        {
            Control button = GetFormatControl(sender, cevent);
            if (button == null) return;

            cevent.Value = _appearance.Shoes == _ctrlMap[button.Name];
            SetShoesImage();
        }
        private void ParseShoes(object sender, ConvertEventArgs cevent)
        {
            Control button = GetParseControl(sender, cevent);
            if (button == null) return;

            _appearance.Shoes = _ctrlMap[button.Name];
            SetShoesImage();
        }
        private void RandomizeBottom()
        {
            Random random = new Random();
            Bottom next = _appearance.Bottom;
            do
            {
                next = (Bottom)random.Next(Enum.GetNames(typeof(Bottom)).Length);
            }
            while (_appearance.Bottom == next);
            _appearance.Bottom = next;
        }
        private void RandomizeMood()
        {
            Random random = new Random();
            Mood next = _person.Mood;
            do
            {
                next = (Mood)random.Next(Enum.GetNames(typeof(Mood)).Length);
            }
            while (_person.Mood == next);
            _person.Mood = next;
            HandleHeadChange();
        }
        private void RandomizeTop()
        {
            Random random = new Random();
            Top next = _appearance.Top;
            do
            {
                next = (Top)random.Next(Enum.GetNames(typeof(Top)).Length);
            }
            while (_appearance.Top == next);
            _appearance.Top = next;
        }
        private void RandomizeShoes()
        {
            Random random = new Random();
            Shoes next = _appearance.Shoes;
            do
            {
                next = (Shoes)random.Next(Enum.GetNames(typeof(Shoes)).Length);
            }
            while (_appearance.Shoes == next);
            _appearance.Shoes = next;
        }
        private void SetTopImage()
        {
            pictureBox_Top.Image = _resMap[_appearance.Top];
        }
        private void SetBottomImage()
        {
            pictureBox_Bottom.Image = _resMap[_appearance.Bottom];
        }
        private void SetShoesImage()
        {
            pictureBox_Shoes.Image = _resMap[_appearance.Shoes];
        }
        private void FormatHair(object sender, ConvertEventArgs cevent)
        {
            // MessageBox.Show("Format Hair Color");
        }
        public FormMain()
        {
            InitializeComponent();

            checkBox_Name.Checked = true;
            textBox_Name.DataBindings.Add("Enabled", checkBox_Name, "Checked");

            button_Happiness.Focus();

            label_CharacterName.DataBindings.Add("Text", _person, "Name");
            textBox_Name.DataBindings.Add("Text", _person, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            label_Motto.DataBindings.Add("Text", _person, "Motto");
            textBox_Motto.DataBindings.Add("Text", _person, "Motto", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox_HairColor.DataBindings.Add("Text", _person, "HairColor");

            checkBox_Clouds.DataBindings.Add("Checked", _surrounding, "HasCloudsOn", false, DataSourceUpdateMode.OnPropertyChanged);
            checkBox_Table.DataBindings.Add("Checked", _surrounding, "HasTableOn", false, DataSourceUpdateMode.OnPropertyChanged);

            checkBox_Glasses.DataBindings.Add("Checked", _appearance, "HasGlassesOn", false, DataSourceUpdateMode.OnPropertyChanged);
            checkBox_Hat.DataBindings.Add("Checked", _appearance, "HasHatOn", false, DataSourceUpdateMode.OnPropertyChanged);

            foreach (Control ctrl in groupBox_Top.Controls)
            {
                Binding binding = new Binding("Checked", _appearance, "Top", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatTop);
                binding.Parse += new ConvertEventHandler(ParseTop);
                ctrl.DataBindings.Add(binding);
            }
            foreach (Control ctrl in groupBox_Bottom.Controls)
            {
                Binding binding = new Binding("Checked", _appearance, "Bottom", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatBottom);
                binding.Parse += new ConvertEventHandler(ParseBottom);
                ctrl.DataBindings.Add(binding);
            }
            foreach (Control ctrl in groupBox_Shoes.Controls)
            {
                Binding binding = new Binding("Checked", _appearance, "Shoes", false, DataSourceUpdateMode.OnPropertyChanged);
                binding.Format += new ConvertEventHandler(FormatShoes);
                binding.Parse += new ConvertEventHandler(ParseShoes);
                ctrl.DataBindings.Add(binding);
            }

            RandomizeBottom();
            RandomizeMood();
            RandomizeTop();
            RandomizeShoes();
        }
        private void checkBox_Clouds_CheckedChanged(object sender, EventArgs e)
        {
            HandleCloudsTable();
        }
        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Name.Checked == false)
            {
                textBox_Name.Text = "";
            }
        }
        private void checkBox_Table_CheckedChanged(object sender, EventArgs e)
        {
            HandleCloudsTable();
        }
        private void HandleCloudsTable()
        {
            if (checkBox_Table.Checked) pictureBox_Clouds.Image = Resources.table;
            else if (checkBox_Clouds.Checked) pictureBox_Clouds.Image = Resources.clouds;
            else if (!checkBox_Clouds.Checked && !checkBox_Table.Checked) pictureBox_Clouds.Image = null;
        }
        private void HandleHeadChange()
        {
            string propName = _person.Mood.ToString() + Utils.Capitalize(_person.HairColor.ToString());
            if (_appearance.HasGlassesOn) propName += "Glasses";
            if (_appearance.HasHatOn) propName += "Hat";
            Bitmap resource = (Bitmap)Resources.ResourceManager.GetObject(propName);
            pictureBox_Head.Image = resource;
        }
        private void button_Smile_Click(object sender, EventArgs e)
        {
            _person.Mood = Mood.smile;
            HandleHeadChange();
        }
        private void button_Sadness_Click(object sender, EventArgs e)
        {
            _person.Mood = Mood.sad;
            HandleHeadChange();
        }

        private void button_Happiness_Click(object sender, EventArgs e)
        {
            _person.Mood = Mood.happy;
            HandleHeadChange();
        }

        private void checkBox_Glasses_Click(object sender, EventArgs e)
        {
            _appearance.HasGlassesOn = checkBox_Glasses.Checked;
            HandleHeadChange();
        }
        private void checkBox_Hat_Click(object sender, EventArgs e)
        {
            _appearance.HasHatOn = checkBox_Hat.Checked;
            HandleHeadChange();
        }
        private void textBox_HairColor_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess = Enum.TryParse(textBox_HairColor.Text.ToLower(), out HairColor parsed);
            if (isSuccess)
            {
                _person.HairColor = parsed;
                HandleHeadChange();
            }
        }
        private void checkBox_Gloves_Click(object sender, EventArgs e)
        {
            pictureBox_GloveLeft.Image = pictureBox_GloveRight.Image = checkBox_Gloves.Checked ? Resources.gloves : null;
        }

        private void button_RandomMood_Click(object sender, EventArgs e)
        {
            RandomizeMood();
        }
        private void button_RandomBottom_Click(object sender, EventArgs e)
        {
            RandomizeBottom();
        }
        private void button_RandomTop_Click(object sender, EventArgs e)
        {
            RandomizeTop();
        }
        private void button_RandomShoes_Click(object sender, EventArgs e)
        {
            RandomizeShoes();
        }
        private void button_GreenPreset_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.greenPants;
            _appearance.Top = ClothesChangeGame.Top.greenTShirt;
        }

        private void button_BluePreset_Click(object sender, EventArgs e)
        {
            if (
                _appearance.Bottom == ClothesChangeGame.Bottom.bluePants ||
                _appearance.Bottom == ClothesChangeGame.Bottom.brownPants ||
                _appearance.Bottom == ClothesChangeGame.Bottom.greenPants
                )
            {
                _appearance.Bottom = ClothesChangeGame.Bottom.bluePants;
            }
            else if (
                _appearance.Bottom == ClothesChangeGame.Bottom.blackPants ||
                _appearance.Bottom == ClothesChangeGame.Bottom.blueShorts
                )
            {
                _appearance.Bottom = ClothesChangeGame.Bottom.blueShorts;
            }
            _appearance.Top = ClothesChangeGame.Top.blueShirt;
        }
        private void textBox_HairColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_HairColor.Text != _person.HairColor.ToString())
            {
                MessageBox.Show("Must be any of these values: dark, pink or white");
            }
        }
    }
}
