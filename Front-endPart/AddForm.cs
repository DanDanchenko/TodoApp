using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_endPart;
using Back_endPart.Infrastructure;

namespace Front_endPart
{
    public partial class AddForm : Form
    {

         TaskRepository Context = new TaskRepository();
        public int UpdatedTaskId = 0;
        public bool IsAddOrUpdate = false;
        Back_endPart.Infrastructure.TaskContext deletedContext = new Back_endPart.Infrastructure.TaskContext();
        public AddForm()
        {
            InitializeComponent();
        }

        void AddToHistory()
        {
            DeletedTask deletedTask = new DeletedTask();
            deletedTask.Title = Context.GetTask(UpdatedTaskId).Title;
            deletedTask.IsCompleted = Context.GetTask(UpdatedTaskId).IsCompleted;
            deletedTask.DeleteTime = DateTime.Now;
            deletedContext.Add(deletedTask);
            deletedContext.Save();
            if (deletedContext.GetHistoryList().Last().Id > 10)
            {
                deletedContext.Delete(0);
            }
            deletedContext.Save();
        }

        void AddTask()
        {
            Back_endPart.Task NewTask = new Back_endPart.Task();
            DateTime deadline = DateTime.Now;
            bool IsCorrect1 = false;
            bool IsCorrect2 = false;
            bool IsCorrect3 = false;
            bool IsCorrect4 = false;




            if (tbTitle.Text != "")
            {
                NewTask.Title = tbTitle.Text;
                IsCorrect1 = true;
            }
            else
            {
                MessageBox.Show("Помилка! Поле для заголовку не має бути порожнім!");
            }

            switch (cbPriority.SelectedIndex)
            {
                case 0:
                    NewTask.Priority = Priorities.Low;
                    break;
                case 1:
                    NewTask.Priority = Priorities.Medium;
                    break;
                case 2:
                    NewTask.Priority = Priorities.Heigh;
                    break;

            }
            IsCorrect2 = true;

            while (!DateTime.TryParse(tbDeadLine.Text, out deadline))
            {
                MessageBox.Show("Помилка! Поле кінцевого часу виконання не повинно бути порожнім, та значення має бути введено у правильному фориаті!");
                tbDeadLine.Text = DateTime.Now.ToString();

            }

            NewTask.DeadLineDate = deadline;

            IsCorrect3 = true;


            if (tbDescription.Text != "")
            {
                NewTask.Description = tbDescription.Text;
                IsCorrect4 = true;
            }
            else
            {
                MessageBox.Show("Помилка! Поле для опису не має бути порожнім!");
            }

            NewTask.IsCompleted = false;


            if (IsCorrect1 && IsCorrect2 && IsCorrect3 && IsCorrect4)
            {
                Context.Add(NewTask);
                Context.Save();
                MessageBox.Show("Завдання успішно додано!");
                Close();
            }
        }

        void UpdateTask()
        {
            if (!chbIsCompleted.Checked)
            {
                DateTime deadline = DateTime.Now;
                Priorities priority = Priorities.Low;

                bool IsCorrect1 = false;
                bool IsCorrect2 = false;
                bool IsCorrect3 = false;
                bool IsCorrect4 = false;

                if (tbTitle.Text != "")
                {

                    IsCorrect1 = true;
                }
                else
                {
                    MessageBox.Show("Помилка! Поле для заголовку не має бути порожнім!");
                }

                switch (cbPriority.SelectedIndex)
                {
                    case 0:
                        priority = Priorities.Low;
                        break;
                    case 1:
                        priority = Priorities.Medium;
                        break;
                    case 2:
                        priority = Priorities.Heigh;
                        break;

                }
                IsCorrect2 = true;

                while (!DateTime.TryParse(tbDeadLine.Text, out deadline))
                {
                    MessageBox.Show("Помилка! Поле кінцевого часу виконання не повинно бути порожнім, та значення має бути введено у правильному фориаті!");
                    tbDeadLine.Text = DateTime.Now.ToString();

                }


                IsCorrect3 = true;

                if (tbDescription.Text != "")
                {

                    IsCorrect4 = true;
                }
                else
                {
                    MessageBox.Show("Помилка! Поле для опису не має бути порожнім!");
                }



                if (IsCorrect1 && IsCorrect2 && IsCorrect3 && IsCorrect4)
                {
                    Context.Update(UpdatedTaskId, tbTitle.Text, priority, deadline, tbDescription.Text, chbIsCompleted.Checked);
                    Context.Save();
                    MessageBox.Show("Редагування пройшло успішно! Щоб побачити новий стан бази, потрібно перезапустити програму");
                    Close();
                }
            }
            else
            {
                Context.GetTask(UpdatedTaskId).IsCompleted = true;
                AddToHistory();
                Context.Delete(UpdatedTaskId);
                Context.Save();
                MessageBox.Show("Завдання успішно позначене, як виконане, та додано в історію.");
                Close();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if (!IsAddOrUpdate)
            {
                AddTask();
            }
            else
            {
                UpdateTask();
            }

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (!IsAddOrUpdate)
            {
                cbPriority.SelectedIndex = 0;
            }
            else
            {
                Text = "Редагувати існуюче завдання";
                btnOK.Text = "Застосувати зміни";
                chbIsCompleted.Enabled = true;
                tbTitle.Text = Context.GetTask(UpdatedTaskId).Title;
                switch (Context.GetTask(UpdatedTaskId).Priority)
                {
                    case Priorities.Low:
                        cbPriority.SelectedIndex = 0;
                        break;
                    case Priorities.Medium:
                        cbPriority.SelectedIndex = 1;
                        break;
                    case Priorities.Heigh:
                        cbPriority.SelectedIndex = 2;
                        break;
                }
                tbDeadLine.Text = Context.GetTask(UpdatedTaskId).DeadLineDate.ToString();
                tbDescription.Text = Context.GetTask(UpdatedTaskId).Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbIsCompleted_Click(object sender, EventArgs e)
        {
            if (chbIsCompleted.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Позначити це завдання, як виконане? Якщо так, редагування та всі зміни, внесені вами вище будуть скасовані, після натиску кнопки Застосувати, воно буде видалене з бази, та додано в історію останніх 10 виконаних чи видалених завдань.", "Підтвердіть дію", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    chbIsCompleted.Checked = true;
                    tbTitle.Enabled = false;
                    tbDeadLine.Enabled = false;
                    cbPriority.Enabled = false;
                    tbDescription.Enabled = false;
                }

                else
                    chbIsCompleted.Checked = false;

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Скасувати? Якщо так, після натиску кнопки Застосувати, завдання просто буде відредаговане згідно введених вище значень у відповідні поля.", "Підтвердіть дію", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    chbIsCompleted.Checked = false;
                    tbTitle.Enabled = true;
                    tbDeadLine.Enabled = true;
                    cbPriority.Enabled = true;
                    tbDescription.Enabled = true;
                }
                else
                    chbIsCompleted.Checked = true;
            }
        }
    }
}
