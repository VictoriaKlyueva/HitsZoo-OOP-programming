using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace HitsZoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Zoo zoo = new Zoo();
        int currentTime = 0;

        // обработчик события Tick таймера
        void timer_Tick(object sender, EventArgs e)
        {
            currentTime += 1;
            time.Text = currentTime.ToString();
            zoo.UpdateAnimals();

            zoo.PrintStatus(textBoxZoo, textBoxAnimals, textBoxPersons);
        }

        // Создание коня
        private void HorseButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Horse horse = new Horse(zoo.animalsCount, voice);
            zoo.AddAnimal(horse);
        }

        // Создание капибары
        private void CapybaraButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Capybara capybara = new Capybara(zoo.animalsCount, voice);
            zoo.AddAnimal(capybara);
        }

        // Создание кыргызского барса
        private void BarsButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Bars bars = new Bars(zoo.animalsCount, voice);
            zoo.AddAnimal(bars);
        }

        // Создание работника
        private void StaffButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;
            string occupation = textBoxOccupation.Text;
            Staff currentPerson;
            if (age != "")
            {
                currentPerson = new Staff(zoo.staffCount, name, Convert.ToInt32(age), occupation);
            }
            else
            {
                currentPerson = new Staff(zoo.staffCount, "артем", Convert.ToInt32(18), occupation);
            }
            zoo.AddStaff(currentPerson);
        }

        // Создание посетителя
        private void VisitorButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;

            Person currentPerson;
            if (age != "")
            {
                // Сделать обработку ввода нечисловых значений
                currentPerson = new Person(zoo.visitorsCount, name, Convert.ToInt32(age));
            }
            else
            {
                currentPerson = new Person(zoo.visitorsCount, name, 18);
            }
            zoo.AddVisitor(currentPerson);
        }

        private void VoiceButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxVoiceSubmit.Text);
            textBoxVoiceResult.Text = zoo.FindAnimalById(id).SubmitVote();
        }

        private void AnimalEditButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdAnimalEdit.Text);
            int criticalHunger = Convert.ToInt32(textBoxCriticalHungerEdit.Text);
            string voice = textBoxVoiceEdit.Text;

            zoo.FindAnimalById(id).Edit(criticalHunger, voice);
        }

        private void StaffEditButton_Click(Object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdStaffEdit.Text);
            string name = textBoxStaffNameEdit.Text;
            int age = Convert.ToInt32(textBoxStaffAgeEdit.Text);
            string occupation = textBoxOccupationEdit.Text;

            zoo.FindStaffById(id).Edit(name, age, occupation);
        }

        private void VisitorEditButton_Click(Object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxPersonIdEdit.Text);
            string name = textBoxPersonNameEdit.Text;
            int age = Convert.ToInt32(textBoxPersonAgeEdit.Text);

            zoo.FindVisitorById(id).Edit(name, age);
        }

        private void AnimalDeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxAnimalDeleteId.Text);
            zoo.RemoveAnimal(zoo.FindAnimalById(id));
            textBoxAnimalDeleteId.Text = "";
        }

        private void VisitorDeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxVisitorDeleteId.Text);
            zoo.RemoveVisitor(zoo.FindVisitorById(id));
            textBoxVisitorDeleteId.Text = "";
        }

        private void StaffDeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxStaffDeleteId.Text);
            zoo.RemoveStaff(zoo.FindStaffById(id));
            textBoxVisitorDeleteId.Text = "";
        }
    }
}
