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

        // Создание капибары
        private void capybaraButton_Click(object sender, EventArgs e)
        {   
            string voice = textBoxVoice.Text;
            Animal currentAnimal = new Animal(voice);
            zoo.addAnimal(currentAnimal);
        }

        // Создание работника
        private void staffButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;
            Person currentPerson;
            try
            {
                currentPerson = new Person(name, Convert.ToInt32(age));
            }
            catch
            {
                currentPerson = new Person("Вика Клюева", Convert.ToInt32(18));
            }
            zoo.addPerson(currentPerson);
        }
    }
}
