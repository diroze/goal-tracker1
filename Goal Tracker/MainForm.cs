using System;
using Goal_Tracker;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GoalTrackerApp
{
    public partial class MainForm : Form
    {
        private GoalManager _goalManager;

        public MainForm()
        {
            InitializeComponent();
            _goalManager = new GoalManager();
        }

        // Завантажити цілі з файлу при старті програми
        private void MainForm_Load(object sender, EventArgs e)
        {
            var goals = StorageService.LoadGoals();
            foreach (var goal in goals)
            {
                listBoxGoals.Items.Add(goal);
            }
        }

        // Додати нову мету
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var goal = new Goal(
                textBoxTitle.Text,
                dateTimePickerDueDate.Value);

            _goalManager.AddGoal(goal);
            listBoxGoals.Items.Add(goal);


            ClearInputFields();
        }

        // Редагувати вибрану мету
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is Goal selectedGoal)
            {
                selectedGoal.Title = textBoxTitle.Text;
                selectedGoal.DueDate = dateTimePickerDueDate.Value;

                _goalManager.EditGoal(listBoxGoals.SelectedIndex, selectedGoal);
                listBoxGoals.Items[listBoxGoals.SelectedIndex] = selectedGoal;


                ClearInputFields();
            }
        }

        // Видалити вибрану мету
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is Goal selectedGoal)
            {
                _goalManager.RemoveGoal(listBoxGoals.SelectedIndex);
                listBoxGoals.Items.Remove(selectedGoal);


                ClearInputFields();
            }
        }

        // Зберегти список цілей у файл
        private void buttonSave_Click(object sender, EventArgs e)
        {
            StorageService.SaveGoals(_goalManager.Goals);
        }

        // Завантажити список цілей з файлу
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var goals = StorageService.LoadGoals();
            listBoxGoals.Items.Clear();
            foreach (var goal in goals)
            {
                listBoxGoals.Items.Add(goal);
            }
        }

        // Очищення полів вводу після дії
        private void ClearInputFields()
        {
            textBoxTitle.Clear();
            dateTimePickerDueDate.Value = DateTime.Now;
        }

        // Обробка вибору цілі в списку
        private void listBoxGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGoals.SelectedItem is Goal selectedGoal)
            {
                textBoxTitle.Text = selectedGoal.Title;
                dateTimePickerDueDate.Value = selectedGoal.DueDate;
            }
        }
    }
}