using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class FormForSetting : Form
    {
        public FormForSetting(Font font)
        {
            InitializeComponent();
            //Добавдение в комбобокс значений
            comboBox_Style.Items.Add("Arial");
            comboBox_Style.Items.Add("Times New Roman");
            comboBox_Style.Items.Add("Georgia");
            comboBox_Style.Items.Add("Verdana");
            comboBox_Style.Items.Add("Microsoft Sans Serif");
            button_clear.Text = "Clear";        //Студия перестала открывать формы  , заменил текст на кнопке здесь
        }
        /// <summary>
        /// Выбор шрифта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FontType = "Segoe";
            switch (comboBox_Style.SelectedIndex)
            {
                case 0:
                    FontType = "Arial";
                    break;
                case 1:
                    FontType = "Times New Roman";
                    break;
                case 2:
                    FontType = "Georgia";
                    break;
                case 3:
                    FontType = "Verdana";
                    break;
                case 4:
                    FontType = "Microsoft Sans Serif";
                    break;
            }
            textBox_example.Font = new Font(FontType, textBox_example.Font.Size, FontStyle.Regular);




        }
        /// <summary>
        /// Увеличение шрифта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GrowSize_Click(object sender, EventArgs e)
        {
            float size = textBox_example.Font.Size + 1;
            if (size < 16) textBox_example.Font = new Font(textBox_example.Font.FontFamily, size, textBox_example.Font.Style);

        }
        /// <summary>
        /// Уменьшений фришта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LowerSize_Click(object sender, EventArgs e)
        {
            float size = textBox_example.Font.Size - 1;
            if (size > 5) textBox_example.Font = new Font(textBox_example.Font.FontFamily, size, textBox_example.Font.Style);
        }
        /// <summary>
        /// Свойство , для передачи параметров
        /// </summary>
        public Font GetFont
        {
            get 
            {
                return textBox_example.Font;
            }
        }
        /// <summary>
        /// Чекбокс для применения стиля Италик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_italic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_italic.Checked) textBox_example.Font = new Font(textBox_example.Font, FontStyle.Italic ^ textBox_example.Font.Style);
            if (!checkBox_italic.Checked) textBox_example.Font = new Font(textBox_example.Font, FontStyle.Italic ^ textBox_example.Font.Style);
        }
        /// <summary>
        /// Чекбокс для применения стиля Жирный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Bold.Checked) textBox_example.Font = new Font(textBox_example.Font, FontStyle.Bold ^ textBox_example.Font.Style);
            if (!checkBox_Bold.Checked)  textBox_example.Font = new Font(textBox_example.Font, FontStyle.Bold ^ textBox_example.Font.Style);
        }
        /// <summary>
        /// Чекбокс для применения стиля Подчеркивание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_UnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnderLine.Checked)
                textBox_example.Font = new Font(textBox_example.Font, FontStyle.Underline^textBox_example.Font.Style);
            if (!checkBox_UnderLine.Checked)  textBox_example.Font = new Font(textBox_example.Font, FontStyle.Underline^textBox_example.Font.Style);
        }
        /// <summary>
        /// Кнопка сброса значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            checkBox_UnderLine.Checked = false;
            checkBox_italic.Checked = false;
            checkBox_Bold.Checked = false;
            textBox_example.Font = new Font("Segoe", 9, FontStyle.Regular); 
        }
        /// <summary>
        /// Кнопка применить значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Apply_Click(object sender, EventArgs e)
        {
            this.DialogResult=System.Windows.Forms.DialogResult.OK;
        }
        /// <summary>
        /// Скрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}