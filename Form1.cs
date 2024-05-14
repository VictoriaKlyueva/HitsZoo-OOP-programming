using System;
using System.Windows.Forms;

namespace HitsZoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private readonly Zoo zoo = new Zoo();

        private int currentTime = 0;
        private bool pause = false;

        private readonly string[] pauseButtonTexts = { "Пауза", "Продолжить" };

        // Обработчик события Tick таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                currentTime += 1;
                timeShowLabel.Text = currentTime.ToString();
                zoo.Update();
            }

            zoo.PrintStatus(textBoxZoo, textBoxAnimals, textBoxPersons, textBoxEnclousersStatus);
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            pause = !pause;
            pauseButton.Text = pauseButtonTexts[Convert.ToInt32(pause)];
        }

        // Создание коня
        private void HorseButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            int enclouserId = textBoxEnclouserId.Text is null ? 0 : Convert.ToInt32(textBoxEnclouserId.Text);
            if (zoo.FindEnclouserById(enclouserId).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            zoo.AddAnimal(new Horse(zoo.currentAnimalId, voice, enclouserId), enclouserCheckBox.Checked);
        }

        // Создание капибары
        private void CapybaraButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            int enclouserId = textBoxEnclouserId.Text is null ? 0 : Convert.ToInt32(textBoxEnclouserId.Text);
            if (zoo.FindEnclouserById(enclouserId).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            zoo.AddAnimal(new Capybara(zoo.currentAnimalId, voice, enclouserId), enclouserCheckBox.Checked);
        }

        // Создание кыргызского барса
        private void BarsButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            int enclouserId = textBoxEnclouserId.Text is null ? 0 : Convert.ToInt32(textBoxEnclouserId.Text);
            if (zoo.FindEnclouserById(enclouserId).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            zoo.AddAnimal(new Bars(zoo.currentAnimalId, voice, enclouserId), enclouserCheckBox.Checked);
        }

        // Создание работника
        private void StaffButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string occupation = textBoxOccupation.Text;
                zoo.AddStaff(name, age, occupation);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Создание посетителя
        private void VisitorButton_Click(object sender, EventArgs e)
        {   
            try
            {
                string name = textBoxName.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                zoo.AddVisitor(name, age);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Подача голоса
        private void VoiceButton_Click(object sender, EventArgs e)
        {   
            try
            {
                int id = Convert.ToInt32(textBoxVoiceSubmit.Text);
                textBoxVoiceResult.Text = zoo.FindAnimalById(id).SubmitVote();
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Редактирование животного
        private void AnimalEditButton_Click(object sender, EventArgs e)
        {
            try {
                int id = Convert.ToInt32(textBoxIdAnimalEdit.Text);
                int criticalHunger = Convert.ToInt32(textBoxCriticalHungerEdit.Text);
                string voice = textBoxVoiceEdit.Text;

                zoo.FindAnimalById(id).Edit(criticalHunger, voice);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Редактирование сотрудника
        private void StaffEditButton_Click(Object sender, EventArgs e)
        {   
            try {
                int id = Convert.ToInt32(textBoxIdStaffEdit.Text);
                string name = textBoxStaffNameEdit.Text;
                int age = Convert.ToInt32(textBoxStaffAgeEdit.Text);
                string occupation = textBoxOccupationEdit.Text;
                int wardAnimalId = Convert.ToInt32(textBoxStaffEditWardEnclouser.Text);

                zoo.FindStaffById(id).Edit(name, age, occupation, wardAnimalId);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Редактирование посетителя
        private void VisitorEditButton_Click(Object sender, EventArgs e)
        {   
            try {
                int id = Convert.ToInt32(textBoxPersonIdEdit.Text);
                string name = textBoxPersonNameEdit.Text;
                int age = Convert.ToInt32(textBoxPersonAgeEdit.Text);

                zoo.FindVisitorById(id).Edit(name, age);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Удаление животного
        private void AnimalDeleteButton_Click(object sender, EventArgs e)
        {
            try {
                int id = Convert.ToInt32(textBoxAnimalDeleteId.Text);
                Animal currentAnimal = zoo.FindAnimalById(id);
                zoo.RemoveAnimal(currentAnimal);
                zoo.RemoveAnimalFromEnclouser(currentAnimal, zoo.FindEnclouserById(currentAnimal.EnclouserId));
                textBoxAnimalDeleteId.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Удаление посетителя
        private void VisitorDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxVisitorDeleteId.Text);
                zoo.RemoveVisitor(zoo.FindVisitorById(id));
                textBoxVisitorDeleteId.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        // Удаление сотрудника
        private void StaffDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxStaffDeleteId.Text);
                zoo.RemoveStaff(zoo.FindStaffById(id));
                textBoxStaffDeleteId.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }
    }
}
