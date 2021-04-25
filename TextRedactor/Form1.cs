using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextRedactor
{
    public partial class RedactorForm : Form
    {
        public RedactorForm()
        {
            InitializeComponent();
            Save_button.Enabled = false;    //Кнопка "сохранить" заблокирована , пока не открыт/ загружен файл
        }
        Font font;
        /// <summary>
        /// Кнопка открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;   //Если файл не выбран вернуться
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText); //Запись в richTextBox текста 
                using (StreamWriter stream = new StreamWriter("LinOlastFile.txt")) //Запись в файл в программе  пути , откуда был 
                {                                                                 //открыт/сохранения
                    stream.WriteLine(openFileDialog.FileName);                    
                };
                Save_button.Enabled = true;                                     //Активизция кнопки "сохранить"
            }
            catch
            {
                MessageBox.Show("Не удалось октрыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Кнопка активизации сохранения файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_button_Click(object sender, EventArgs e)
        {
            try 
            {
                richTextBox.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);  //Сохранение текста в тот же файл
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        /// <summary>
        /// Кнопка активизации формы для сохранить файла по выбранному пути
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAs_Button_Click(object sender, EventArgs e)
        {     
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                richTextBox.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.RichText); //Сохранения файла
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Кнопка активизации  поиска 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_button_Click(object sender, EventArgs e)
        {
            FormForSearch FFS = new FormForSearch();        //Создание формы поиска
            
            DialogResult result=FFS.ShowDialog();          //Открытие формы
            if (result == System.Windows.Forms.DialogResult.OK)     //Если результат диалога форм "ОК" , то осуществить поиск
            {
                Seacrh(FFS.GetWord);            //Поиск по свойству формы поиска
            }
        }
        ///Поиск по строке      
        private void Seacrh(string t)
        {
            try
            {
                if (t.Length > richTextBox.Text.Length) return;                  //Если искомаемая строка больше , вернуться 
                for (int i = 0; i < richTextBox.Text.Length - t.Length + 1; i++)         //Перебор символов по оригинаальной строке - строку поиска
                {
                    if (richTextBox.Text[i] == t[0])
                    {
                        if (t.Length == 1) SelectSearchWord(i, 1);
                        for (int k = 1, l = i + 1; k < t.Length; k++, l++)
                        {
                            if (t[k] != richTextBox.Text[l]) break;

                            if (t[k] == richTextBox.Text[l])
                                if (k == t.Length - 1)
                                    SelectSearchWord(l - k, t.Length);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Поиск отменен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///Кнопка выделения слов поиска
        /// </summary>
        /// <param name="i"></param>
        /// <param name="k"></param>
        private void SelectSearchWord(int i , int k)
         {            
            richTextBox.Select(i,k);
            richTextBox.SelectionBackColor = Color.Yellow;          
        }
        /// <summary>
        /// Кнопка активизации замены слов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Replace_Button_Click(object sender, EventArgs e)
        {
            FormForReplace FFR = new FormForReplace();      //Создание формы для ввода заменяемого слова
            FFR.ShowDialog();                               //Переход на форму
            if ( FFR.DialogResult==DialogResult.OK)         //Если результат "ОК" , осуществить замену
            {
               richTextBox.Text= richTextBox.Text.Replace(FFR.ThisWord,FFR.ThatWord);
            }
        }
        /// <summary>
        /// Кнопка активизации кодирования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coding_Button_Click(object sender, EventArgs e)
        {
            FormForCoding FFC = new FormForCoding();            //Создание формы
            FFC.ShowDialog();                                   //Открытие формы
            if (FFC.DialogResult == DialogResult.OK)            //При результате "ОК" , осуществить кодирование
            {
                string CodeText = "";                               //Переписывание зашифрованного текста
                for(int i = 0; i < richTextBox.Text.Length; i++)
                {
                    CodeText += (char)(richTextBox.Text[i] ^ FFC.GetNum);
                }
                richTextBox.Text = CodeText;
            }
        }
        /// <summary>
        /// Кнопка активизации декодинга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decoding_Button_Click(object sender, EventArgs e)
        {
            FormForCoding FFC = new FormForCoding();                          //Создание формы
            FFC.ShowDialog();                                                 //Открытие формы
            if (FFC.DialogResult == DialogResult.OK)                          //При результате "ОК" , осуществить декодирование
            {
                string CodeText = "";                                             //Переписывание зашифрованного текста
                for (int i = 0; i < richTextBox.Text.Length; i++)
                {
                    CodeText += (char)(richTextBox.Text[i] ^ FFC.GetNum);
                }
                richTextBox.Text = CodeText;
            }
        }
        /// <summary>
        /// Кнопка активизации для сохранения пути файла , с которым работали в последний раз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Archive_Button_Click(object sender, EventArgs e)
        { 
            using (StreamReader stream = new StreamReader("LinOLastFile.txt"))          //чтение с файла пути
            {
                string txt = stream.ReadLine();
                richTextBox.LoadFile(txt, RichTextBoxStreamType.RichText);          //загрузка файла
            }
            Save_button.Enabled = true;
        }
        /// <summary>
        /// Кнопка активизации формы настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Setting_button_Click(object sender, EventArgs e)
        {
            FormForSetting FFS = new FormForSetting(richTextBox.Font);
            FFS.ShowDialog();
            if (FFS.DialogResult == DialogResult.OK)
            { 
                richTextBox.Font = FFS.GetFont;                     //Передача параметров через свойтсво формы FFS
            }
           
         }
        /// <summary>
        /// Кнопка закрытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();               //Закрыть прогрмму
        }
    }
}
