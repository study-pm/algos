using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesChangeGame.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothesChangeGame
{
    public partial class FormMain : Form
    {
        Person _person = new Person();
        Appearance _appearance = new Appearance();
        Surrounding _surrounding = new Surrounding();
        Dictionary<Top, (RadioButton control, Bitmap image)> _topMap;
        Dictionary<Bottom, (RadioButton control, Bitmap image)> _bottomMap;
        Dictionary<Shoes, (RadioButton control, Bitmap image)> _shoesMap;
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

            _topMap = new Dictionary<Top, (RadioButton, Bitmap)>()
            {
                { ClothesChangeGame.Top.blueShirt, ( radioButton_BlueShirt, Resources.bluetshirt )},
                { ClothesChangeGame.Top.leatherJacket, (radioButton_LeatherJacket , Resources.darktshirt ) },
                { ClothesChangeGame.Top.greenTShirt, (radioButton_GreenTShirt, Resources.greentshirt ) },
                { ClothesChangeGame.Top.redShirt, (radioButton_RedShirt, Resources.redtshirt ) },
                { ClothesChangeGame.Top.redTShirt, (radioButton_RedTShirt, Resources.redtshirttwo ) },
            };
            SetTop();

            _bottomMap = new Dictionary<Bottom, (RadioButton, Bitmap)>()
            {
                { ClothesChangeGame.Bottom.blackPants, ( radioButton_BlackShorts, Resources.blackPants )},
                { ClothesChangeGame.Bottom.blueShorts, ( radioButton_BlueShorts, Resources.blueShorts )},
                { ClothesChangeGame.Bottom.brownPants, ( radioButton_RedBreeches, Resources.brownPants )},
                { ClothesChangeGame.Bottom.greenPants, ( radioButton_GreenBreeches, Resources.greenPants )},
                { ClothesChangeGame.Bottom.bluePants, ( radioButton_Jeans, Resources.bluePants )},
            };
            SetBottom();

            _shoesMap = new Dictionary<Shoes, (RadioButton, Bitmap)>()
            {
                { ClothesChangeGame.Shoes.crocs, ( radioButton_Crocs, Resources.crocs )},
                { ClothesChangeGame.Shoes.gumshoes, ( radioButton_Gumshoes, Resources.gumshoes )},
                { ClothesChangeGame.Shoes.slippers, ( radioButton_Slippers, Resources.slippers )},
                { ClothesChangeGame.Shoes.sneakers, ( radioButton_Sneakers, Resources.sneakers )},
                { ClothesChangeGame.Shoes.none, ( radioButton_Sneakers, Resources.justLegs )},
            };
            SetShoes();
        }

        private void checkBox_Clouds_CheckedChanged(object sender, EventArgs e)
        {
            HandleCloudsTable();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            // label_CharacterName.Text = textBox_Name.Text;
            // Implemented as binding in constructor call
        }

        private void textBox_Motto_TextChanged(object sender, EventArgs e)
        {
            // label_Motto.Text = textBox_Motto.Text;
            // Implemented as binding in constructor call
        }

        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {
            // textBox_Name.Enabled = checkBox_Name.Checked;
            // Implemented as binding in constructor call
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
            Random random = new Random();
            _person.Mood = (Mood)random.Next(Enum.GetNames(typeof(Mood)).Length);
            HandleHeadChange();
        }
        private void SetTop()
        {
            SetTopControl();
            SetTopImage();
        }
        private void SetTopControl()
        {
            _topMap[_appearance.Top].control.Checked = true;
        }
        private void SetTopImage()
        {
            pictureBox_Top.Image = _topMap[_appearance.Top].image;
        }
        private void SetBottom()
        {
            SetBottomControl();
            SetBottomImage();
        }
        private void SetBottomControl()
        {
            _bottomMap[_appearance.Bottom].control.Checked = true;
        }
        private void SetBottomImage()
        {
            pictureBox_Bottom.Image = _bottomMap[_appearance.Bottom].image;
        }
        private void SetShoes()
        {
            SetShoesControl();
            SetShoesImage();
        }
        private void SetShoesControl()
        {
            _shoesMap[_appearance.Shoes].control.Checked = true;
        }
        private void SetShoesImage()
        {
            pictureBox_Shoes.Image = _shoesMap[_appearance.Shoes].image;
        }
        private void button_RandomBottom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _appearance.Bottom = (Bottom)random.Next(Enum.GetNames(typeof(Bottom)).Length);
            SetBottom();
        }
        private void button_RandomTop_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _appearance.Top = (Top)random.Next(Enum.GetNames(typeof(Top)).Length);
            SetTop();
        }

        private void radioButton_RedTShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.redTShirt;
            SetTopImage();
        }

        private void radioButton_GreenTShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.greenTShirt;
            SetTopImage();
        }

        private void radioButton_RedShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.redShirt;
            SetTopImage();
        }

        private void radioButton_BlueShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.blueShirt;
            SetTopImage();
        }

        private void radioButton_LeatherJacket_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.leatherJacket;
            SetTopImage();
        }

        private void button_GreenPreset_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.greenPants;
            _appearance.Top = ClothesChangeGame.Top.greenTShirt;
            SetBottom();
            SetTop();
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
            SetBottom();
            SetTop();
        }

        private void radioButton_BlackShorts_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.blackPants;
            SetBottomImage();
        }

        private void radioButton_BlueShorts_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.blueShorts;
            SetBottomImage();
        }
        private void radioButton_RedBreeches_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.brownPants;
            SetBottomImage();
        }
        private void radioButton_GreenBreeches_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.greenPants;
            SetBottomImage();
        }
        private void radioButton_Jeans_Click(object sender, EventArgs e)
        {
            _appearance.Bottom = ClothesChangeGame.Bottom.bluePants;
            SetBottomImage();
        }

        private void radioButton_Crocs_Click(object sender, EventArgs e)
        {
            _appearance.Shoes = ClothesChangeGame.Shoes.crocs;
            SetShoesImage();
        }

        private void radioButton_Slippers_Click(object sender, EventArgs e)
        {
            _appearance.Shoes = ClothesChangeGame.Shoes.slippers;
            SetShoesImage();
        }

        private void radioButton_Gumshoes_CheckedChanged(object sender, EventArgs e)
        {
            _appearance.Shoes = ClothesChangeGame.Shoes.gumshoes;
            SetShoesImage();
        }

        private void radioButton_Sneakers_Click(object sender, EventArgs e)
        {
            _appearance.Shoes = ClothesChangeGame.Shoes.sneakers;
            SetShoesImage();
        }

        private void radioButton_NoShoes_Click(object sender, EventArgs e)
        {
            _appearance.Shoes = ClothesChangeGame.Shoes.none;
            SetShoesImage();
        }
    }
}
