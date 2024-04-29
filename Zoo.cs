﻿using System;
using System.Deployment.Application;
using System.Linq;

namespace HitsZoo
{
    public class Zoo
    {
        public int animalsCount = 0;
        Animal[] animalsArray = new Animal[100];

        public int visitorsCount = 0;
        Person[] visitorsArray = new Person[100];

        public int staffCount = 0;
        Staff[] staffArray = new Staff[100];

        private int currentAnimalId = 0;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;

        public void AddHorse(string voice)
        {
            Horse horse = new Horse(currentAnimalId, voice);
            animalsArray[animalsCount] = horse;
            currentAnimalId++;
            animalsCount++;
        }

        public void AddCapybara(string voice)
        {
            Capybara capybara = new Capybara(currentAnimalId, voice);
            animalsArray[animalsCount] = capybara;
            currentAnimalId++;
            animalsCount++;
        }

        public void AddBars(string voice)
        {
            Bars bars = new Bars(currentAnimalId, voice);
            animalsArray[animalsCount] = bars;
            currentAnimalId++;
            animalsCount++;
        }

        public void RemoveAnimal(Animal animalForRemoving)
        {
            animalsArray = animalsArray.Where(val => val != animalForRemoving).ToArray();
            animalsCount--;
        }

        public void AddVisitor(string name, int age)
        {
            Person visitor = new Person(currentVisitorId, name, age);
            visitorsArray[visitorsCount] = visitor;
            currentVisitorId++;
            visitorsCount++;
        }
        public void RemoveVisitor(Person visitorForRemoving)
        {
            visitorsArray = visitorsArray.Where(val => val != visitorForRemoving).ToArray();
            visitorsCount--;
        }

        public void AddStaff(string name, int age, string occupation)
        {
            Staff staff = new Staff(currentStaffId, name, age, occupation, AssignAnimal());
            staffArray[staffCount] = staff;
            currentStaffId++;
            staffCount++;
        }

        public void RemoveStaff(Staff staffForRemoving)
        {
            staffArray = staffArray.Where(val => val != staffForRemoving).ToArray();
            staffCount--;
        }

        private int AssignAnimal()
        {
            foreach (Animal animal in animalsArray)
            {
                if (animal == null) return -1;
                if (animal.isFree)
                {
                    animal.isFree = false;
                    return animal.id;
                }
            }
            return -1;
        }

        private void UpdateAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                animalsArray[i].Update();

                // Обновление статуса животного, если его закрепили или открепили
                bool found = false;
                for (int j = 0; j < staffCount; j++)
                {
                    if (staffArray[j].wardAnimalId == animalsArray[i].id)
                    {
                        animalsArray[i].isFree = false;
                        found = true;
                    }
                }
                if (!found)
                {
                    animalsArray[i].isFree = true;
                }
            }
        }

        private void UpdateStaff()
        {
            for (int i = 0; i < staffCount; i++)
            {   
                if (staffArray[i].wardAnimalId != -1)
                {
                    staffArray[i].Update(FindAnimalById(staffArray[i].wardAnimalId));
                }
            }
        }

        public void Update()
        {
            UpdateAnimals();
            UpdateStaff();
        }

        public Animal FindAnimalById(int id)
        {
            for (int i = 0; i < animalsCount; i++)
            {
                if (animalsArray[i].id == id) return animalsArray[i];
            }
            return null;
        }

        public Person FindVisitorById(int id)
        {
            for (int i = 0; i < visitorsCount; i++)
            {
                if (visitorsArray[i].id == id) return visitorsArray[i];
            }
            return null;
        }

        public Staff FindStaffById(int id)
        {
            for (int i = 0; i < staffCount; i++)
            {
                if (staffArray[i].id == id) return staffArray[i];
            }
            return null;
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < animalsCount; i++)
            {
                textBox.Text += animalsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < staffCount; i++)
            {
                textBox.Text += staffArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            for (int i = 0; i < visitorsCount; i++)
            {
                textBox.Text += visitorsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons)
        {
            textBoxZoo.Text = $"Животных: {animalsCount}   Работников: {staffCount}   Посетителей: {visitorsCount}   ";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
        }
    }
}
