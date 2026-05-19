namespace PlannerAppp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйПроектToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            задачиToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            textBoxTaskName = new TextBox();
            numericUpDownHours = new NumericUpDown();
            buttonAdd = new Button();
            buttonDelete = new Button();
            listBoxTask = new ListBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, задачиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйПроектToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйПроектToolStripMenuItem
            // 
            новыйПроектToolStripMenuItem.Name = "новыйПроектToolStripMenuItem";
            новыйПроектToolStripMenuItem.Size = new Size(180, 22);
            новыйПроектToolStripMenuItem.Text = "Новый проект";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // задачиToolStripMenuItem
            // 
            задачиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem });
            задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            задачиToolStripMenuItem.Size = new Size(58, 20);
            задачиToolStripMenuItem.Text = "Задачи";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(126, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(126, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Название задача:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Часы: ";
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(150, 47);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(200, 23);
            textBoxTaskName.TabIndex = 3;
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.DecimalPlaces = 1;
            numericUpDownHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownHours.Location = new Point(150, 87);
            numericUpDownHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(120, 23);
            numericUpDownHours.TabIndex = 4;
            numericUpDownHours.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightGreen;
            buttonAdd.Location = new Point(370, 70);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить задачу";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.LightCoral;
            buttonDelete.Location = new Point(570, 140);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxTask
            // 
            listBoxTask.FormattingEnabled = true;
            listBoxTask.ItemHeight = 15;
            listBoxTask.Location = new Point(12, 130);
            listBoxTask.Name = "listBoxTask";
            listBoxTask.Size = new Size(550, 289);
            listBoxTask.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(listBoxTask);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownHours);
            Controls.Add(textBoxTaskName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик задач";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйПроектToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBoxTaskName;
        private NumericUpDown numericUpDownHours;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxTask;
    }
}
