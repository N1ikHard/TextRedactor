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
    public partial class FormForReplace : Form
    {
        public FormForReplace()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Свойства слов , которое надо заменить  и на которое заменять
        /// </summary>
        public string ThisWord
        {
            get { return ThisTextBox.Text; }
        }
        public string ThatWord
        {
            get { return ThatTextBox.Text; }
        }
        /// <summary>
        /// Кнопка активизация замены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Replace_Click(object sender, EventArgs e)
        {
            if (ThisTextBox.Text == "") this.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        /// <summary>
        /// Скрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
