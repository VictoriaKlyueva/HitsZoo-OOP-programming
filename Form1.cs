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
            zoo.updateAnimals();

            zoo.printAnimals();
            zoo.printPersons();
        }

        // Создание коня
        private void HorseButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Horse horse = new Horse(voice);
            zoo.addAnimal(horse);
        }

        // Создание капибары
        private void CapybaraButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Capybara capybara = new Capybara(voice);
            zoo.addAnimal(capybara);
        }

        // Создание кыргызского барса
        private void BarsButton_Click(object sender, EventArgs e)
        {
            string voice = textBoxVoice.Text;
            Bars bars = new Bars(voice);
            zoo.addAnimal(bars);
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
                currentPerson = new Staff(name, Convert.ToInt32(age), occupation);
            }
            else
            {
                currentPerson = new Staff(name, Convert.ToInt32(18), occupation);
            }
            zoo.addPerson(currentPerson);
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
                currentPerson = new Person(name, Convert.ToInt32(age));
            }
            else
            {
                currentPerson = new Person(name, 18);
            }
            zoo.addPerson(currentPerson);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
