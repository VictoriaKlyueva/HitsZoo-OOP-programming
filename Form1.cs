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

        public int currentAnimalId = 15;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;
        private int currentEnclouserId = 2;

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
            Guid enclouserId = new Guid(textBoxEnclouserId.Text);

            if (((Enclouser)zoo.FindEntityById(enclouserId)).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            Horse horse = new Horse(voice, enclouserId);

            // Новый вольер
            if (enclouserCheckBox.Checked)
            {
                zoo.AddEntity(new Enclouser(horse));
            }
            // Существующий вольер
            else
            {
                ((Enclouser)zoo.FindEntityById(enclouserId)).AddAnimal(horse);
            }

            zoo.AddEntity(horse);
        }

        // Создание капибары
        private void CapybaraButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Guid enclouserId = new Guid(textBoxEnclouserId.Text);

            if (((Enclouser)zoo.FindEntityById(enclouserId)).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            Capybara capybara = new Capybara(voice, enclouserId);

            // Новый вольер
            if (enclouserCheckBox.Checked)
            {
                zoo.AddEntity(new Enclouser(capybara));
            }
            // Существующий вольер
            else
            {
                ((Enclouser)zoo.FindEntityById(enclouserId)).AddAnimal(capybara);
            }

            zoo.AddEntity(capybara);
        }

        // Создание кыргызского барса
        private void BarsButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Guid enclouserId = new Guid(textBoxEnclouserId.Text);

            if (((Enclouser)zoo.FindEntityById(enclouserId)).IsFull())
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            Bars bars = new Bars(voice, enclouserId);

            // Новый вольер
            if (enclouserCheckBox.Checked)
            {
                zoo.AddEntity(new Enclouser(bars));
            }
            // Существующий вольер
            else
            {
                ((Enclouser)zoo.FindEntityById(enclouserId)).AddAnimal(bars);
            }

            zoo.AddEntity(bars);
        }

        // Создание работника
        private void StaffButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string occupation = textBoxOccupation.Text;
                Guid enclouserGuid = zoo.GetEmptyEnclouserId();
                zoo.AddEntity(new Staff(name, age, occupation, enclouserGuid));
                currentStaffId++;
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
                zoo.AddEntity(new Visitor(name, age));
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
                Guid id = new Guid(textBoxVoiceSubmit.Text);
                textBoxVoiceResult.Text = ((Animal)zoo.FindEntityById(id)).SubmitVote();
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
                Guid id = new Guid(textBoxIdAnimalEdit.Text);
                int criticalHunger = Convert.ToInt32(textBoxCriticalHungerEdit.Text);
                string voice = textBoxVoiceEdit.Text;

                ((Animal)zoo.FindEntityById(id)).Edit(criticalHunger, voice);
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
                Guid id = new Guid(textBoxIdStaffEdit.Text);
                string name = textBoxStaffNameEdit.Text;
                int age = Convert.ToInt32(textBoxStaffAgeEdit.Text);
                string occupation = textBoxOccupationEdit.Text;
                Guid wardAnimalId = new Guid(textBoxStaffEditWardEnclouser.Text);

                ((Staff)zoo.FindEntityById(id)).Edit(name, age, occupation, wardAnimalId);
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
                Guid id = new Guid(textBoxPersonIdEdit.Text);
                string name = textBoxPersonNameEdit.Text;
                int age = Convert.ToInt32(textBoxPersonAgeEdit.Text);

                ((Visitor)zoo.FindEntityById(id)).Edit(name, age);
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
                Guid id = new Guid(textBoxAnimalDeleteId.Text);
                Animal currentAnimal = ((Animal)zoo.FindEntityById(id));
                zoo.RemoveEntity(currentAnimal.Id);
                zoo.RemoveAnimalFromEnclouser(currentAnimal, (Enclouser)zoo.FindEntityById(currentAnimal.EnclouserId));
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
                Guid id = new Guid(textBoxVisitorDeleteId.Text);
                zoo.RemoveEntity(zoo.FindEntityById(id).Id);
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
                Guid id = new Guid(textBoxStaffDeleteId.Text);
                zoo.RemoveEntity(zoo.FindEntityById(id).Id);
                textBoxStaffDeleteId.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }
    }
}
