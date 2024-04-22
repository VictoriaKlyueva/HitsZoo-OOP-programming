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
            Person currentPerson = new Person(name, Convert.ToInt32(age));
            zoo.addPerson(currentPerson);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Zoo
    {
        int animalsCount = 0;
        Animal[] animalsArray = new Animal[100];
        int personsCount = 0;
        Person[] personsArray = new Person[100];

        public void addAnimal(Animal animal)
        {
            animalsArray[animalsCount] = animal;
            animalsCount++;
        }

        public void addPerson(Person human)
        {
            personsArray[personsCount] = human;
            personsCount++;
        }

        public void updateAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                animalsArray[i].currentHunger += 1;
                animalsArray[i].update();
            }
        }

        public void printAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                Console.WriteLine($"Номер: {i}");
                animalsArray[i].print();
            }
        }

        public void printPersons()
        {
            for (int i = 0; i < personsCount; i++)
            {
                Console.WriteLine($"Номер: {i}");
                personsArray[i].print();
            }
        }
    }

    public class Animal
    {
        int criticalHunger = new Random().Next(10, 20);
        public int currentHunger = 0;
        public bool isHungry = false;
        string voice = "meow";

        public void update()
        {
            if (currentHunger > criticalHunger)
            {
                isHungry = true;
            }
        }

        public void feed()
        {
            currentHunger = 0;
            isHungry = false;
        }

        public void submitVote()
        {
            Console.WriteLine(voice);
        }

        public void print()
        {
            Console.WriteLine($"Численный голод: {currentHunger}  " +
                              $" Голод: {isHungry}");
        }

        public Animal(string voice) 
        {
            this.voice = voice;
        }
    }

    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void print()
        {
            Console.WriteLine(name + " " + age);
        }
    }
}
