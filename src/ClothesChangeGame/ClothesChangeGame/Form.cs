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
        Dictionary<Top, Bitmap> _topMap = new Dictionary<Top, Bitmap>()
        {
            { ClothesChangeGame.Top.blueShirt, Resources.bluetshirt },
            { ClothesChangeGame.Top.leatherJacket, Resources.darktshirt },
            { ClothesChangeGame.Top.greenTShirt, Resources.greentshirt },
            { ClothesChangeGame.Top.redShirt, Resources.redtshirt },
            { ClothesChangeGame.Top.redTShirt, Resources.redtshirttwo },
        };
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

            pictureBox_Top.Image = _topMap[_appearance.Top];
            radioButton_RedShirt.Checked = true;

            checkBox_Glasses.DataBindings.Add("Checked", _appearance, "HasGlassesOn", false, DataSourceUpdateMode.OnPropertyChanged);
            checkBox_Hat.DataBindings.Add("Checked", _appearance, "HasHatOn", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void checkBox_Clouds_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Clouds.Image = checkBox_Clouds.Checked ? Resources.clouds : null;
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
            pictureBox_Clouds.Image = checkBox_Table.Checked ? Resources.table : null;
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
        private void setTopImage()
        {
            pictureBox_Top.Image = _topMap[_appearance.Top];
        }
        private void button_RandomTop_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _appearance.Top = (Top)random.Next(Enum.GetNames(typeof(Top)).Length);
            setTopImage();
        }

        private void radioButton_RedTShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.redTShirt;
            setTopImage();
        }

        private void radioButton_GreenTShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.greenTShirt;
            setTopImage();
        }

        private void radioButton_RedShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.redShirt;
            setTopImage();
        }

        private void radioButton_BlueShirt_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.blueShirt;
            setTopImage();
        }

        private void radioButton_LeatherJacket_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.leatherJacket;
            setTopImage();
        }

        private void button_GreenPreset_Click(object sender, EventArgs e)
        {
            _appearance.Top = ClothesChangeGame.Top.greenTShirt;
            setTopImage();
        }
    }
}
