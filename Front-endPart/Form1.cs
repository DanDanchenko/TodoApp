using Back_endPart;
using Back_endPart.Infrastructure;



namespace Front_endPart
{
 
    public partial class MainForm : Form
    {
        TaskRepository Context = new TaskRepository();
        Back_endPart.Infrastructure.TaskContext DContext = new Back_endPart.Infrastructure.TaskContext();



        public MainForm()
        {
            InitializeComponent();
        }

        void AddToHistory(int id)
        {
            DeletedTask deletedTask = new DeletedTask();
            deletedTask.Title = Context.GetTask(id).Title;
            deletedTask.IsCompleted = Context.GetTask(id).IsCompleted;
            deletedTask.DeleteTime = DateTime.Now;
            DContext.Add(deletedTask);
            DContext.Save();
            if (DContext.GetHistoryList().Last().Id > 10)
            {
                DContext.Delete(0);
            }
            DContext.Save();
        }

        public void ShowAllData()
        {

            dgvTasks.Columns.Clear();
            dgvTasks.Rows.Clear();

            dgvTasks.Columns.Add("Col1", "ID");
            dgvTasks.Columns.Add("Col2", "Заголовок");
            dgvTasks.Columns.Add("Col3", "Пріоритет (2-найбільший, 0-найменший)");
            dgvTasks.Columns.Add("Col4", "До коли треба було зробити");
            dgvTasks.Columns.Add("Col5", "Детальний опис завдання");
            dgvTasks.Columns.Add("Col6", "Виконано");
            if (Context != null)
            {
                if (Context.GetTasksList().Count() > 0)
                {
                    dgvTasks.RowCount = Context.GetTasksList().Count();
            
               
                    for (int i = 0; i < dgvTasks.RowCount; i++)
                    {
                        dgvTasks[0, i].Value = Context.GetTask(i).Id;
                        dgvTasks[1, i].Value = Context.GetTask(i).Title;
                        dgvTasks[2, i].Value = Context.GetTask(i).Priority;
                        dgvTasks[3, i].Value = Context.GetTask(i).DeadLineDate;
                        dgvTasks[4, i].Value = Context.GetTask(i).Description;
                        dgvTasks[5, i].Value = Context.GetTask(i).IsCompleted;


                    }
                }
                
            }
            else
            {
                MessageBox.Show("Виникла помилка! Можливо бази даних не існує");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

            ShowAllData();


           



            

           


        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (Context.GetTasksList().Count() > 0)
            {
                ShowAllData();
            }
            else
            {
                MessageBox.Show("База даних наразі порожня.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Context.GetTasksList().Count() > 0)
            {
                if (dgvTasks.CurrentRow != null)
                {
                    AddToHistory(dgvTasks.CurrentRow.Index);
                    Context.Delete(dgvTasks.CurrentRow.Index);
                    Context.Save();
                    ShowAllData();
                }
                else
                    MessageBox.Show("Потрібно вибрати рядок, або клітинку рядка того завдання, яке ви хочете видалити!");
            }
            else
            {
                MessageBox.Show("Видалення неможливе! База даних порожня");
            }
            
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm formadd = new AddForm();
            formadd.ShowDialog();
        }

        

        private void dgvTasks_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Context.GetTasksList().Count() > 0)
            {
                if (dgvTasks.CurrentRow != null)
                {
                    AddForm frmupdate = new AddForm();
                    frmupdate.UpdatedTaskId = dgvTasks.CurrentRow.Index;
                    frmupdate.IsAddOrUpdate = true;
                    frmupdate.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Потрібно вибрати рядок, або клітинку рядка того завдання, яке ви хочете редагувати!");
                }
            }
            else
            {
                MessageBox.Show("Наразі база порожня, редагування неможливе!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (Context.GetTasksList().Count() > 0)
            {
                Context.DeleteAll();
                Context.Save();
                ShowAllData();
            }
            else
            {
                MessageBox.Show("Видалення неможливе, оскільки база порожня");
            }
           
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            dgvTasks.Columns.Clear();
            dgvTasks.Rows.Clear();

            dgvTasks.Columns.Add("Col1", "ID");
            dgvTasks.Columns.Add("Col2", "Заголовок");
            dgvTasks.Columns.Add("Col3", "Виконано");
            dgvTasks.Columns.Add("Col4", "Дата видалення");

            btnAdd.Enabled = false;
            btnShowData.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnCloseHistory.Enabled = true;

            if (DContext.GetCount() > 0)
            {

                dgvTasks.RowCount = DContext.GetCount();

                for (int i = 0; i < dgvTasks.RowCount; i++)
                {
                    dgvTasks[0, i].Value = DContext.GetDeleted(i).Id;
                    dgvTasks[1, i].Value = DContext.GetDeleted(i).Title;
                    dgvTasks[2, i].Value = DContext.GetDeleted(i).IsCompleted;
                    dgvTasks[3, i].Value = DContext.GetDeleted(i).DeleteTime;
                   


                }
            }
            else
            {
                MessageBox.Show("Наразі, ви ще нічого не видаляли, тому історія порожня");
            }

            


        }

        private void btnCloseHistory_Click(object sender, EventArgs e)
        {
            if (Context.GetTasksList().Count() > 0)
            {
                ShowAllData();
            }
            else
            {
                MessageBox.Show("База даних наразі порожня.");
            }

            btnCloseHistory.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnShowData.Enabled = true;
            btnClear.Enabled = true;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ShowAllData();
        }
    }
}