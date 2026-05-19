namespace PlannerAppp
{
    public partial class Form1 : Form
    {
        private string[] taskNames;
        private double[] taskHours;
        private int[] taskCount;
        public Form1()
        {
            InitializeComponent();

            taskNames = new string[100];
            taskHours = new double[100];
            taskCount = 0;
        }

        private void UpdateListBox()
        {
            listBoxTask.Items.Clear();

            for (int i = 0; i < taskCount; i++)
            {
                string displayText = $"{taskNames[i]} - {taskHours[i]} ч ";
                listBoxTask.Items.Add(displayText);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTaskName.Text))
            {
                MessageBox.Show("Введите название задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (taskCount >= 100)
            {
                MessageBox.Show("Достигнут лимит задач (100)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            taskNames[taskCount] = textBoxTaskName.Text;
            taskHours[taskCount] = (double)numericUpDownHours.Value;

            taskCount++;

            UpdateListBox();

            textBoxTaskName.Text = "";
            numericUpDownHours.Value = 1;

            textBoxTaskName.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indexToDelete = listBoxTask.SelectedIndex;

            for (int i =  indexToDelete; i < taskCount - 1; i++)
            {
                taskNames[i] = taskNames[i + 1];
                taskHours[i] = taskHours[i + 1];
            }

            taskNames[taskCount - 1] = null;
            taskHours[taskCount - 1] = 0;

            taskCount--;

            UpdateListBox();
        }
    }
}
