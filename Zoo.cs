﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HitsZoo
{
    public class Zoo : IAddEnclouser
    {
        private Animal[] animalsArray = new Animal[100];
        private Person[] visitorsArray = new Person[100];
        private Staff[] staffArray = new Staff[100];
        private Enclouser[] enclousersArray = new Enclouser[100];

        public int currentAnimalId = 0;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;
        private int currentEnclouserId = 0;

        public int AnimalsCount { get; set; } = 0;
        public int VisitorsCount { get; set; } = 0;
        public int StaffCount { get; set; } = 0;
        public int EnclousersCount { get; set; } = 0;
             
        private void GenerateAnimals(int enclousersNumber, int animalsNumber)
        {
            Random rnd = new Random();
            for (int i = 0; i < animalsNumber; i++)
            {
                int choice = rnd.Next(0, 2);

                if (choice == 0)
                {
                    AddAnimal(new Horse(currentAnimalId, "Я дефолтная лошадь", 
                              rnd.Next(0, enclousersNumber)), i < enclousersNumber);
                }
                else if (choice == 1)
                {
                    AddAnimal(new Capybara(currentAnimalId, "Я дефолтная капибара", 
                              rnd.Next(0, enclousersNumber)), i < enclousersNumber);
                }
                else
                {
                    AddAnimal(new Bars(currentAnimalId, "Я дефолтный барс", 
                        rnd.Next(0, enclousersNumber)), i < enclousersNumber);
                }
            }
        }

        public void AddEnclouser(Animal animal)
        {
            Enclouser enclouser = new Enclouser(currentEnclouserId, animal);
            enclousersArray[EnclousersCount] = enclouser;
            currentEnclouserId++;
            EnclousersCount++;
        }

        public void AddAnimal(Horse horse, bool newEnclouser)
        {
            animalsArray[AnimalsCount] = horse;
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(horse);
            }
            else
            {
                FindEnclouserById(horse.EnclouserId).AddAnimal(horse);
            }
        }

        public void AddAnimal(Capybara capybara, bool newEnclouser)
        {
            animalsArray[AnimalsCount] = capybara;
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(capybara);
            }
            else
            {
                FindEnclouserById(capybara.EnclouserId).AddAnimal(capybara);
            }
        }

        public void AddAnimal(Bars bars, bool newEnclouser)
        {
            animalsArray[AnimalsCount] = bars;
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(bars);
            }
            else
            {
                FindEnclouserById(bars.EnclouserId).AddAnimal(bars);
            }
        }

        public Enclouser FindEnclouserById(int id)
        {
            for (int i = 0; i < EnclousersCount; i++)
            {
                if (enclousersArray[i].Id == id)
                {
                    return enclousersArray[i];
                }
            }

            return null;
        }

        public void RemoveAnimal(Animal animalForRemoving)
        {
            animalsArray = animalsArray.Where(val => val != animalForRemoving).ToArray();
            AnimalsCount--;
        }

        public void RemoveAnimalFromEnclouser(Animal animal, Enclouser enclouser)
        {
            enclouser.RemoveAnimal(animal);
        }

        public void AddVisitor(string name, int age)
        {
            Visitor visitor = new Visitor(currentVisitorId, name, age);
            visitorsArray[VisitorsCount] = visitor;
            currentVisitorId++;
            VisitorsCount++;
        }
        public void RemoveVisitor(Person visitorForRemoving)
        {
            visitorsArray = visitorsArray.Where(val => val != visitorForRemoving).ToArray();
            VisitorsCount--;
        }

        public void AddStaff(string name, int age, string occupation)
        {
            Staff staff = new Staff(currentStaffId, name, age, occupation, AssignAnimal());
            staffArray[StaffCount] = staff;
            currentStaffId++;
            StaffCount++;
        }

        public void RemoveStaff(Staff staffForRemoving)
        {
            staffArray = staffArray.Where(val => val != staffForRemoving).ToArray();
            StaffCount--;
        }

        private int AssignAnimal()
        {
            foreach (Animal animal in animalsArray)
            {
                if (animal == null) return -1;
                if (animal.IsFree)
                {
                    animal.IsFree = false;
                    return animal.Id;
                }
            }
            return -1;
        }

        private void UpdateAnimals()
        {
            for (int i = 0; i < AnimalsCount; i++)
            {
                animalsArray[i].Update();

                // Обновление статуса животного, если его закрепили или открепили
                bool found = false;
                for (int j = 0; j < StaffCount; j++)
                {
                    if (staffArray[j].wardAnimalId == animalsArray[i].Id)
                    {
                        animalsArray[i].IsFree = false;
                        found = true;
                    }
                }
                if (!found)
                {
                    animalsArray[i].IsFree = true;
                }
            }
        }

        private void UpdateStaff()
        {
            for (int i = 0; i < StaffCount; i++)
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
            for (int i = 0; i < AnimalsCount; i++)
            {
                if (animalsArray[i].Id == id) return animalsArray[i];
            }
            return null;
        }

        public Person FindVisitorById(int id)
        {
            for (int i = 0; i < VisitorsCount; i++)
            {
                if (visitorsArray[i].Id == id) return visitorsArray[i];
            }
            return null;
        }

        public Staff FindStaffById(int id)
        {
            for (int i = 0; i < StaffCount; i++)
            {
                if (staffArray[i].Id == id) return staffArray[i];
            }
            return null;
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < AnimalsCount; i++)
            {
                textBox.Text += animalsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < StaffCount; i++)
            {
                textBox.Text += staffArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            for (int i = 0; i < VisitorsCount; i++)
            {
                textBox.Text += visitorsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintEnclousers(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < EnclousersCount; i++)
            {
                textBox.Text += enclousersArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons,
                          System.Windows.Forms.TextBox textBoxEnclousers)
        {
            textBoxZoo.Text = $"Животных: {AnimalsCount}   Работников: {StaffCount}   Посетителей: {VisitorsCount}   ";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
            PrintEnclousers(textBoxEnclousers);
        }

        public Zoo ()
        {
            GenerateAnimals(3, 15);
        }
    }
}
