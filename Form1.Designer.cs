﻿using System;

namespace HitsZoo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.horseButton = new System.Windows.Forms.Button();
            this.capybaraButton = new System.Windows.Forms.Button();
            this.barsButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.visitorButton = new System.Windows.Forms.Button();
            this.addEntity = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeShowLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.textBoxVoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.professionLabel = new System.Windows.Forms.Label();
            this.idAnimalEditLabel = new System.Windows.Forms.Label();
            this.textBoxIdAnimalEdit = new System.Windows.Forms.TextBox();
            this.criticalHungerLabel = new System.Windows.Forms.Label();
            this.textBoxCriticalHungerEdit = new System.Windows.Forms.TextBox();
            this.voiceLabel = new System.Windows.Forms.Label();
            this.textBoxVoiceEdit = new System.Windows.Forms.TextBox();
            this.idStaffEditLabel = new System.Windows.Forms.Label();
            this.textBoxIdStaffEdit = new System.Windows.Forms.TextBox();
            this.staffNameEditLabel = new System.Windows.Forms.Label();
            this.textBoxStaffNameEdit = new System.Windows.Forms.TextBox();
            this.textBoxStaffAgeEdit = new System.Windows.Forms.TextBox();
            this.staffAgeEditLabel = new System.Windows.Forms.Label();
            this.textBoxOccupationEdit = new System.Windows.Forms.TextBox();
            this.occupationEditLabel = new System.Windows.Forms.Label();
            this.personIdEditLabel = new System.Windows.Forms.Label();
            this.textBoxPersonIdEdit = new System.Windows.Forms.TextBox();
            this.personNameEditLabel = new System.Windows.Forms.Label();
            this.textBoxPersonNameEdit = new System.Windows.Forms.TextBox();
            this.textBoxPersonAgeEdit = new System.Windows.Forms.TextBox();
            this.personAgeEditLabel = new System.Windows.Forms.Label();
            this.animalDeleteIdLabel = new System.Windows.Forms.Label();
            this.textBoxAnimalDeleteId = new System.Windows.Forms.TextBox();
            this.deletePersonIdLabel = new System.Windows.Forms.Label();
            this.textBoxVisitorDeleteId = new System.Windows.Forms.TextBox();
            this.textBoxAnimals = new System.Windows.Forms.TextBox();
            this.textBoxPersons = new System.Windows.Forms.TextBox();
            this.personsLabel = new System.Windows.Forms.Label();
            this.animalsLabel = new System.Windows.Forms.Label();
            this.zooLabel = new System.Windows.Forms.Label();
            this.textBoxZoo = new System.Windows.Forms.TextBox();
            this.animalEditButton = new System.Windows.Forms.Button();
            this.staffEditButton = new System.Windows.Forms.Button();
            this.visitorEditButton = new System.Windows.Forms.Button();
            this.animalDeleteButton = new System.Windows.Forms.Button();
            this.visitorDeleteButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.voiceSubmitLabel = new System.Windows.Forms.Label();
            this.textBoxVoiceSubmit = new System.Windows.Forms.TextBox();
            this.textBoxVoiceResult = new System.Windows.Forms.TextBox();
            this.staffDeleteButton = new System.Windows.Forms.Button();
            this.staffDeleteIdLabel = new System.Windows.Forms.Label();
            this.textBoxStaffDeleteId = new System.Windows.Forms.TextBox();
            this.textBoxStaffEditWardEnclouser = new System.Windows.Forms.TextBox();
            this.staffEditWardEnclouserLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.enclouserCheckBox = new System.Windows.Forms.CheckBox();
            this.EnclousersStatusLabel = new System.Windows.Forms.Label();
            this.textBoxEnclousersStatus = new System.Windows.Forms.TextBox();
            this.textBoxEnclouserId = new System.Windows.Forms.TextBox();
            this.EnclouserForAddingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horseButton
            // 
            this.horseButton.Location = new System.Drawing.Point(13, 46);
            this.horseButton.Margin = new System.Windows.Forms.Padding(4);
            this.horseButton.Name = "horseButton";
            this.horseButton.Size = new System.Drawing.Size(147, 36);
            this.horseButton.TabIndex = 0;
            this.horseButton.Text = "Казахский конь";
            this.horseButton.UseVisualStyleBackColor = true;
            this.horseButton.Click += new System.EventHandler(this.HorseButton_Click);
            // 
            // capybaraButton
            // 
            this.capybaraButton.Location = new System.Drawing.Point(323, 46);
            this.capybaraButton.Margin = new System.Windows.Forms.Padding(4);
            this.capybaraButton.Name = "capybaraButton";
            this.capybaraButton.Size = new System.Drawing.Size(147, 36);
            this.capybaraButton.TabIndex = 1;
            this.capybaraButton.Text = "Капибара";
            this.capybaraButton.UseVisualStyleBackColor = true;
            this.capybaraButton.Click += new System.EventHandler(this.CapybaraButton_Click);
            // 
            // barsButton
            // 
            this.barsButton.Location = new System.Drawing.Point(168, 46);
            this.barsButton.Margin = new System.Windows.Forms.Padding(4);
            this.barsButton.Name = "barsButton";
            this.barsButton.Size = new System.Drawing.Size(147, 36);
            this.barsButton.TabIndex = 2;
            this.barsButton.Text = "Кыргызский барс";
            this.barsButton.UseVisualStyleBackColor = true;
            this.barsButton.Click += new System.EventHandler(this.BarsButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(13, 122);
            this.staffButton.Margin = new System.Windows.Forms.Padding(4);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(203, 36);
            this.staffButton.TabIndex = 3;
            this.staffButton.Text = "Сотрудник";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // visitorButton
            // 
            this.visitorButton.Location = new System.Drawing.Point(224, 120);
            this.visitorButton.Margin = new System.Windows.Forms.Padding(4);
            this.visitorButton.Name = "visitorButton";
            this.visitorButton.Size = new System.Drawing.Size(147, 36);
            this.visitorButton.TabIndex = 4;
            this.visitorButton.Text = "Посетитель";
            this.visitorButton.UseVisualStyleBackColor = true;
            this.visitorButton.Click += new System.EventHandler(this.VisitorButton_Click);
            // 
            // addEntity
            // 
            this.addEntity.AutoSize = true;
            this.addEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addEntity.Location = new System.Drawing.Point(8, 9);
            this.addEntity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addEntity.Name = "addEntity";
            this.addEntity.Size = new System.Drawing.Size(251, 29);
            this.addEntity.TabIndex = 5;
            this.addEntity.Text = "Добавить сущность:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeLabel.Location = new System.Drawing.Point(1723, 9);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(97, 29);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Время:";
            // 
            // timeShowLabel
            // 
            this.timeShowLabel.AutoSize = true;
            this.timeShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeShowLabel.Location = new System.Drawing.Point(1814, 9);
            this.timeShowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeShowLabel.Name = "timeShowLabel";
            this.timeShowLabel.Size = new System.Drawing.Size(27, 29);
            this.timeShowLabel.TabIndex = 7;
            this.timeShowLabel.Text = "0";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 165);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(107, 192);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(264, 22);
            this.textBoxAge.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 168);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Имя";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(15, 196);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 16);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Возраст";
            // 
            // textBoxVoice
            // 
            this.textBoxVoice.Location = new System.Drawing.Point(76, 89);
            this.textBoxVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVoice.Name = "textBoxVoice";
            this.textBoxVoice.Size = new System.Drawing.Size(239, 22);
            this.textBoxVoice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Голос";
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Location = new System.Drawing.Point(107, 218);
            this.textBoxOccupation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(264, 22);
            this.textBoxOccupation.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Location = new System.Drawing.Point(15, 224);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(81, 16);
            this.professionLabel.TabIndex = 18;
            this.professionLabel.Text = "Профессия";
            // 
            // idAnimalEditLabel
            // 
            this.idAnimalEditLabel.AutoSize = true;
            this.idAnimalEditLabel.Location = new System.Drawing.Point(14, 328);
            this.idAnimalEditLabel.Name = "idAnimalEditLabel";
            this.idAnimalEditLabel.Size = new System.Drawing.Size(21, 16);
            this.idAnimalEditLabel.TabIndex = 21;
            this.idAnimalEditLabel.Text = "Id:";
            // 
            // textBoxIdAnimalEdit
            // 
            this.textBoxIdAnimalEdit.Location = new System.Drawing.Point(42, 326);
            this.textBoxIdAnimalEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdAnimalEdit.Name = "textBoxIdAnimalEdit";
            this.textBoxIdAnimalEdit.Size = new System.Drawing.Size(64, 22);
            this.textBoxIdAnimalEdit.TabIndex = 22;
            // 
            // criticalHungerLabel
            // 
            this.criticalHungerLabel.AutoSize = true;
            this.criticalHungerLabel.Location = new System.Drawing.Point(131, 330);
            this.criticalHungerLabel.Name = "criticalHungerLabel";
            this.criticalHungerLabel.Size = new System.Drawing.Size(136, 16);
            this.criticalHungerLabel.TabIndex = 23;
            this.criticalHungerLabel.Text = "Критический голод:";
            // 
            // textBoxCriticalHungerEdit
            // 
            this.textBoxCriticalHungerEdit.Location = new System.Drawing.Point(298, 326);
            this.textBoxCriticalHungerEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCriticalHungerEdit.Name = "textBoxCriticalHungerEdit";
            this.textBoxCriticalHungerEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxCriticalHungerEdit.TabIndex = 24;
            // 
            // voiceLabel
            // 
            this.voiceLabel.AutoSize = true;
            this.voiceLabel.Location = new System.Drawing.Point(516, 328);
            this.voiceLabel.Name = "voiceLabel";
            this.voiceLabel.Size = new System.Drawing.Size(48, 16);
            this.voiceLabel.TabIndex = 25;
            this.voiceLabel.Text = "Голос:";
            // 
            // textBoxVoiceEdit
            // 
            this.textBoxVoiceEdit.Location = new System.Drawing.Point(570, 326);
            this.textBoxVoiceEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVoiceEdit.Name = "textBoxVoiceEdit";
            this.textBoxVoiceEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxVoiceEdit.TabIndex = 26;
            // 
            // idStaffEditLabel
            // 
            this.idStaffEditLabel.AutoSize = true;
            this.idStaffEditLabel.Location = new System.Drawing.Point(14, 443);
            this.idStaffEditLabel.Name = "idStaffEditLabel";
            this.idStaffEditLabel.Size = new System.Drawing.Size(21, 16);
            this.idStaffEditLabel.TabIndex = 28;
            this.idStaffEditLabel.Text = "Id:";
            // 
            // textBoxIdStaffEdit
            // 
            this.textBoxIdStaffEdit.Location = new System.Drawing.Point(42, 440);
            this.textBoxIdStaffEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdStaffEdit.Name = "textBoxIdStaffEdit";
            this.textBoxIdStaffEdit.Size = new System.Drawing.Size(64, 22);
            this.textBoxIdStaffEdit.TabIndex = 29;
            // 
            // staffNameEditLabel
            // 
            this.staffNameEditLabel.AutoSize = true;
            this.staffNameEditLabel.Location = new System.Drawing.Point(255, 443);
            this.staffNameEditLabel.Name = "staffNameEditLabel";
            this.staffNameEditLabel.Size = new System.Drawing.Size(36, 16);
            this.staffNameEditLabel.TabIndex = 30;
            this.staffNameEditLabel.Text = "Имя:";
            // 
            // textBoxStaffNameEdit
            // 
            this.textBoxStaffNameEdit.Location = new System.Drawing.Point(298, 440);
            this.textBoxStaffNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStaffNameEdit.Name = "textBoxStaffNameEdit";
            this.textBoxStaffNameEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxStaffNameEdit.TabIndex = 31;
            // 
            // textBoxStaffAgeEdit
            // 
            this.textBoxStaffAgeEdit.Location = new System.Drawing.Point(570, 440);
            this.textBoxStaffAgeEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStaffAgeEdit.Name = "textBoxStaffAgeEdit";
            this.textBoxStaffAgeEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxStaffAgeEdit.TabIndex = 32;
            // 
            // staffAgeEditLabel
            // 
            this.staffAgeEditLabel.AutoSize = true;
            this.staffAgeEditLabel.Location = new System.Drawing.Point(499, 443);
            this.staffAgeEditLabel.Name = "staffAgeEditLabel";
            this.staffAgeEditLabel.Size = new System.Drawing.Size(65, 16);
            this.staffAgeEditLabel.TabIndex = 33;
            this.staffAgeEditLabel.Text = "Возраст:";
            // 
            // textBoxOccupationEdit
            // 
            this.textBoxOccupationEdit.Location = new System.Drawing.Point(298, 476);
            this.textBoxOccupationEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOccupationEdit.Name = "textBoxOccupationEdit";
            this.textBoxOccupationEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxOccupationEdit.TabIndex = 34;
            // 
            // occupationEditLabel
            // 
            this.occupationEditLabel.AutoSize = true;
            this.occupationEditLabel.Location = new System.Drawing.Point(207, 476);
            this.occupationEditLabel.Name = "occupationEditLabel";
            this.occupationEditLabel.Size = new System.Drawing.Size(84, 16);
            this.occupationEditLabel.TabIndex = 35;
            this.occupationEditLabel.Text = "Профессия:";
            // 
            // personIdEditLabel
            // 
            this.personIdEditLabel.AutoSize = true;
            this.personIdEditLabel.Location = new System.Drawing.Point(14, 559);
            this.personIdEditLabel.Name = "personIdEditLabel";
            this.personIdEditLabel.Size = new System.Drawing.Size(21, 16);
            this.personIdEditLabel.TabIndex = 37;
            this.personIdEditLabel.Text = "Id:";
            // 
            // textBoxPersonIdEdit
            // 
            this.textBoxPersonIdEdit.Location = new System.Drawing.Point(42, 555);
            this.textBoxPersonIdEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonIdEdit.Name = "textBoxPersonIdEdit";
            this.textBoxPersonIdEdit.Size = new System.Drawing.Size(64, 22);
            this.textBoxPersonIdEdit.TabIndex = 38;
            // 
            // personNameEditLabel
            // 
            this.personNameEditLabel.AutoSize = true;
            this.personNameEditLabel.Location = new System.Drawing.Point(255, 559);
            this.personNameEditLabel.Name = "personNameEditLabel";
            this.personNameEditLabel.Size = new System.Drawing.Size(36, 16);
            this.personNameEditLabel.TabIndex = 39;
            this.personNameEditLabel.Text = "Имя:";
            // 
            // textBoxPersonNameEdit
            // 
            this.textBoxPersonNameEdit.Location = new System.Drawing.Point(298, 555);
            this.textBoxPersonNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonNameEdit.Name = "textBoxPersonNameEdit";
            this.textBoxPersonNameEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonNameEdit.TabIndex = 40;
            // 
            // textBoxPersonAgeEdit
            // 
            this.textBoxPersonAgeEdit.Location = new System.Drawing.Point(570, 555);
            this.textBoxPersonAgeEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonAgeEdit.Name = "textBoxPersonAgeEdit";
            this.textBoxPersonAgeEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonAgeEdit.TabIndex = 41;
            // 
            // personAgeEditLabel
            // 
            this.personAgeEditLabel.AutoSize = true;
            this.personAgeEditLabel.Location = new System.Drawing.Point(499, 559);
            this.personAgeEditLabel.Name = "personAgeEditLabel";
            this.personAgeEditLabel.Size = new System.Drawing.Size(65, 16);
            this.personAgeEditLabel.TabIndex = 42;
            this.personAgeEditLabel.Text = "Возраст:";
            // 
            // animalDeleteIdLabel
            // 
            this.animalDeleteIdLabel.AutoSize = true;
            this.animalDeleteIdLabel.Location = new System.Drawing.Point(13, 707);
            this.animalDeleteIdLabel.Name = "animalDeleteIdLabel";
            this.animalDeleteIdLabel.Size = new System.Drawing.Size(21, 16);
            this.animalDeleteIdLabel.TabIndex = 44;
            this.animalDeleteIdLabel.Text = "Id:";
            // 
            // textBoxAnimalDeleteId
            // 
            this.textBoxAnimalDeleteId.Location = new System.Drawing.Point(41, 704);
            this.textBoxAnimalDeleteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnimalDeleteId.Name = "textBoxAnimalDeleteId";
            this.textBoxAnimalDeleteId.Size = new System.Drawing.Size(189, 22);
            this.textBoxAnimalDeleteId.TabIndex = 45;
            // 
            // deletePersonIdLabel
            // 
            this.deletePersonIdLabel.AutoSize = true;
            this.deletePersonIdLabel.Location = new System.Drawing.Point(236, 707);
            this.deletePersonIdLabel.Name = "deletePersonIdLabel";
            this.deletePersonIdLabel.Size = new System.Drawing.Size(21, 16);
            this.deletePersonIdLabel.TabIndex = 47;
            this.deletePersonIdLabel.Text = "Id:";
            // 
            // textBoxVisitorDeleteId
            // 
            this.textBoxVisitorDeleteId.Location = new System.Drawing.Point(263, 704);
            this.textBoxVisitorDeleteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVisitorDeleteId.Name = "textBoxVisitorDeleteId";
            this.textBoxVisitorDeleteId.Size = new System.Drawing.Size(190, 22);
            this.textBoxVisitorDeleteId.TabIndex = 48;
            // 
            // textBoxAnimals
            // 
            this.textBoxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAnimals.Location = new System.Drawing.Point(716, 122);
            this.textBoxAnimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnimals.Multiline = true;
            this.textBoxAnimals.Name = "textBoxAnimals";
            this.textBoxAnimals.ReadOnly = true;
            this.textBoxAnimals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnimals.Size = new System.Drawing.Size(632, 732);
            this.textBoxAnimals.TabIndex = 49;
            // 
            // textBoxPersons
            // 
            this.textBoxPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPersons.Location = new System.Drawing.Point(1358, 126);
            this.textBoxPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersons.Multiline = true;
            this.textBoxPersons.Name = "textBoxPersons";
            this.textBoxPersons.ReadOnly = true;
            this.textBoxPersons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPersons.Size = new System.Drawing.Size(669, 803);
            this.textBoxPersons.TabIndex = 50;
            // 
            // personsLabel
            // 
            this.personsLabel.AutoSize = true;
            this.personsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.personsLabel.Location = new System.Drawing.Point(1353, 81);
            this.personsLabel.Name = "personsLabel";
            this.personsLabel.Size = new System.Drawing.Size(79, 29);
            this.personsLabel.TabIndex = 51;
            this.personsLabel.Text = "Люди";
            // 
            // animalsLabel
            // 
            this.animalsLabel.AutoSize = true;
            this.animalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.animalsLabel.Location = new System.Drawing.Point(715, 80);
            this.animalsLabel.Name = "animalsLabel";
            this.animalsLabel.Size = new System.Drawing.Size(134, 29);
            this.animalsLabel.TabIndex = 52;
            this.animalsLabel.Text = "Животные";
            // 
            // zooLabel
            // 
            this.zooLabel.AutoSize = true;
            this.zooLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.zooLabel.Location = new System.Drawing.Point(711, 15);
            this.zooLabel.Name = "zooLabel";
            this.zooLabel.Size = new System.Drawing.Size(112, 29);
            this.zooLabel.TabIndex = 53;
            this.zooLabel.Text = "Зоопарк";
            // 
            // textBoxZoo
            // 
            this.textBoxZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxZoo.Location = new System.Drawing.Point(716, 46);
            this.textBoxZoo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxZoo.Name = "textBoxZoo";
            this.textBoxZoo.ReadOnly = true;
            this.textBoxZoo.Size = new System.Drawing.Size(632, 24);
            this.textBoxZoo.TabIndex = 54;
            // 
            // animalEditButton
            // 
            this.animalEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.animalEditButton.Location = new System.Drawing.Point(18, 282);
            this.animalEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animalEditButton.Name = "animalEditButton";
            this.animalEditButton.Size = new System.Drawing.Size(460, 39);
            this.animalEditButton.TabIndex = 55;
            this.animalEditButton.Text = "Редактировать животное";
            this.animalEditButton.UseVisualStyleBackColor = true;
            this.animalEditButton.Click += new System.EventHandler(this.AnimalEditButton_Click);
            // 
            // staffEditButton
            // 
            this.staffEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffEditButton.Location = new System.Drawing.Point(18, 395);
            this.staffEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffEditButton.Name = "staffEditButton";
            this.staffEditButton.Size = new System.Drawing.Size(460, 39);
            this.staffEditButton.TabIndex = 56;
            this.staffEditButton.Text = "Редактировать сотрудника";
            this.staffEditButton.UseVisualStyleBackColor = true;
            this.staffEditButton.Click += new System.EventHandler(this.StaffEditButton_Click);
            // 
            // visitorEditButton
            // 
            this.visitorEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.visitorEditButton.ForeColor = System.Drawing.Color.Black;
            this.visitorEditButton.Location = new System.Drawing.Point(18, 511);
            this.visitorEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitorEditButton.Name = "visitorEditButton";
            this.visitorEditButton.Size = new System.Drawing.Size(451, 39);
            this.visitorEditButton.TabIndex = 57;
            this.visitorEditButton.Text = "Редактировать посетителя";
            this.visitorEditButton.UseVisualStyleBackColor = true;
            this.visitorEditButton.Click += new System.EventHandler(this.VisitorEditButton_Click);
            // 
            // animalDeleteButton
            // 
            this.animalDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.animalDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.animalDeleteButton.Location = new System.Drawing.Point(17, 598);
            this.animalDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animalDeleteButton.Name = "animalDeleteButton";
            this.animalDeleteButton.Size = new System.Drawing.Size(215, 98);
            this.animalDeleteButton.TabIndex = 58;
            this.animalDeleteButton.Text = "Удалить животное";
            this.animalDeleteButton.UseVisualStyleBackColor = true;
            this.animalDeleteButton.Click += new System.EventHandler(this.AnimalDeleteButton_Click);
            // 
            // visitorDeleteButton
            // 
            this.visitorDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.visitorDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.visitorDeleteButton.Location = new System.Drawing.Point(238, 598);
            this.visitorDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitorDeleteButton.Name = "visitorDeleteButton";
            this.visitorDeleteButton.Size = new System.Drawing.Size(215, 98);
            this.visitorDeleteButton.TabIndex = 59;
            this.visitorDeleteButton.Text = "Удалить посетителя";
            this.visitorDeleteButton.UseVisualStyleBackColor = true;
            this.visitorDeleteButton.Click += new System.EventHandler(this.VisitorDeleteButton_Click);
            // 
            // voiceButton
            // 
            this.voiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.voiceButton.ForeColor = System.Drawing.Color.Black;
            this.voiceButton.Location = new System.Drawing.Point(716, 858);
            this.voiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voiceButton.Name = "voiceButton";
            this.voiceButton.Size = new System.Drawing.Size(636, 39);
            this.voiceButton.TabIndex = 60;
            this.voiceButton.Text = "Голос";
            this.voiceButton.UseVisualStyleBackColor = true;
            this.voiceButton.Click += new System.EventHandler(this.VoiceButton_Click);
            // 
            // voiceSubmitLabel
            // 
            this.voiceSubmitLabel.AutoSize = true;
            this.voiceSubmitLabel.Location = new System.Drawing.Point(717, 904);
            this.voiceSubmitLabel.Name = "voiceSubmitLabel";
            this.voiceSubmitLabel.Size = new System.Drawing.Size(21, 16);
            this.voiceSubmitLabel.TabIndex = 61;
            this.voiceSubmitLabel.Text = "Id:";
            // 
            // textBoxVoiceSubmit
            // 
            this.textBoxVoiceSubmit.Location = new System.Drawing.Point(744, 901);
            this.textBoxVoiceSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVoiceSubmit.Name = "textBoxVoiceSubmit";
            this.textBoxVoiceSubmit.Size = new System.Drawing.Size(64, 22);
            this.textBoxVoiceSubmit.TabIndex = 62;
            // 
            // textBoxVoiceResult
            // 
            this.textBoxVoiceResult.Location = new System.Drawing.Point(814, 901);
            this.textBoxVoiceResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVoiceResult.Name = "textBoxVoiceResult";
            this.textBoxVoiceResult.ReadOnly = true;
            this.textBoxVoiceResult.Size = new System.Drawing.Size(538, 22);
            this.textBoxVoiceResult.TabIndex = 63;
            // 
            // staffDeleteButton
            // 
            this.staffDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.staffDeleteButton.Location = new System.Drawing.Point(459, 596);
            this.staffDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffDeleteButton.Name = "staffDeleteButton";
            this.staffDeleteButton.Size = new System.Drawing.Size(215, 98);
            this.staffDeleteButton.TabIndex = 64;
            this.staffDeleteButton.Text = "Удалить сотрудника";
            this.staffDeleteButton.UseVisualStyleBackColor = true;
            this.staffDeleteButton.Click += new System.EventHandler(this.StaffDeleteButton_Click);
            // 
            // staffDeleteIdLabel
            // 
            this.staffDeleteIdLabel.AutoSize = true;
            this.staffDeleteIdLabel.Location = new System.Drawing.Point(458, 707);
            this.staffDeleteIdLabel.Name = "staffDeleteIdLabel";
            this.staffDeleteIdLabel.Size = new System.Drawing.Size(21, 16);
            this.staffDeleteIdLabel.TabIndex = 65;
            this.staffDeleteIdLabel.Text = "Id:";
            // 
            // textBoxStaffDeleteId
            // 
            this.textBoxStaffDeleteId.Location = new System.Drawing.Point(485, 704);
            this.textBoxStaffDeleteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStaffDeleteId.Name = "textBoxStaffDeleteId";
            this.textBoxStaffDeleteId.Size = new System.Drawing.Size(189, 22);
            this.textBoxStaffDeleteId.TabIndex = 66;
            // 
            // textBoxStaffEditWardEnclouser
            // 
            this.textBoxStaffEditWardEnclouser.Location = new System.Drawing.Point(570, 476);
            this.textBoxStaffEditWardEnclouser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStaffEditWardEnclouser.Name = "textBoxStaffEditWardEnclouser";
            this.textBoxStaffEditWardEnclouser.Size = new System.Drawing.Size(100, 22);
            this.textBoxStaffEditWardEnclouser.TabIndex = 67;
            // 
            // staffEditWardEnclouserLabel
            // 
            this.staffEditWardEnclouserLabel.AutoSize = true;
            this.staffEditWardEnclouserLabel.Location = new System.Drawing.Point(470, 479);
            this.staffEditWardEnclouserLabel.Name = "staffEditWardEnclouserLabel";
            this.staffEditWardEnclouserLabel.Size = new System.Drawing.Size(79, 16);
            this.staffEditWardEnclouserLabel.TabIndex = 68;
            this.staffEditWardEnclouserLabel.Text = "Id вольера:";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1728, 46);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(113, 38);
            this.pauseButton.TabIndex = 69;
            this.pauseButton.Text = "Пауза";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // enclouserCheckBox
            // 
            this.enclouserCheckBox.AutoSize = true;
            this.enclouserCheckBox.Location = new System.Drawing.Point(477, 62);
            this.enclouserCheckBox.Name = "enclouserCheckBox";
            this.enclouserCheckBox.Size = new System.Drawing.Size(134, 20);
            this.enclouserCheckBox.TabIndex = 70;
            this.enclouserCheckBox.Text = "Создать вольер";
            this.enclouserCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnclousersStatusLabel
            // 
            this.EnclousersStatusLabel.AutoSize = true;
            this.EnclousersStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EnclousersStatusLabel.Location = new System.Drawing.Point(711, 938);
            this.EnclousersStatusLabel.Name = "EnclousersStatusLabel";
            this.EnclousersStatusLabel.Size = new System.Drawing.Size(117, 29);
            this.EnclousersStatusLabel.TabIndex = 71;
            this.EnclousersStatusLabel.Text = "Вольеры";
            // 
            // textBoxEnclousersStatus
            // 
            this.textBoxEnclousersStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxEnclousersStatus.Location = new System.Drawing.Point(716, 969);
            this.textBoxEnclousersStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnclousersStatus.Multiline = true;
            this.textBoxEnclousersStatus.Name = "textBoxEnclousersStatus";
            this.textBoxEnclousersStatus.ReadOnly = true;
            this.textBoxEnclousersStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnclousersStatus.Size = new System.Drawing.Size(1316, 158);
            this.textBoxEnclousersStatus.TabIndex = 72;
            // 
            // textBoxEnclouserId
            // 
            this.textBoxEnclouserId.Location = new System.Drawing.Point(404, 89);
            this.textBoxEnclouserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnclouserId.Name = "textBoxEnclouserId";
            this.textBoxEnclouserId.Size = new System.Drawing.Size(66, 22);
            this.textBoxEnclouserId.TabIndex = 73;
            // 
            // EnclouserForAddingLabel
            // 
            this.EnclouserForAddingLabel.AutoSize = true;
            this.EnclouserForAddingLabel.Location = new System.Drawing.Point(322, 92);
            this.EnclouserForAddingLabel.Name = "EnclouserForAddingLabel";
            this.EnclouserForAddingLabel.Size = new System.Drawing.Size(76, 16);
            this.EnclouserForAddingLabel.TabIndex = 75;
            this.EnclouserForAddingLabel.Text = "Id вольера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1138);
            this.Controls.Add(this.EnclouserForAddingLabel);
            this.Controls.Add(this.textBoxEnclouserId);
            this.Controls.Add(this.textBoxEnclousersStatus);
            this.Controls.Add(this.EnclousersStatusLabel);
            this.Controls.Add(this.enclouserCheckBox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.staffEditWardEnclouserLabel);
            this.Controls.Add(this.textBoxStaffEditWardEnclouser);
            this.Controls.Add(this.textBoxStaffDeleteId);
            this.Controls.Add(this.staffDeleteIdLabel);
            this.Controls.Add(this.staffDeleteButton);
            this.Controls.Add(this.textBoxVoiceResult);
            this.Controls.Add(this.textBoxVoiceSubmit);
            this.Controls.Add(this.voiceSubmitLabel);
            this.Controls.Add(this.voiceButton);
            this.Controls.Add(this.visitorDeleteButton);
            this.Controls.Add(this.animalDeleteButton);
            this.Controls.Add(this.visitorEditButton);
            this.Controls.Add(this.staffEditButton);
            this.Controls.Add(this.animalEditButton);
            this.Controls.Add(this.textBoxZoo);
            this.Controls.Add(this.zooLabel);
            this.Controls.Add(this.animalsLabel);
            this.Controls.Add(this.personsLabel);
            this.Controls.Add(this.textBoxPersons);
            this.Controls.Add(this.textBoxAnimals);
            this.Controls.Add(this.textBoxVisitorDeleteId);
            this.Controls.Add(this.deletePersonIdLabel);
            this.Controls.Add(this.textBoxAnimalDeleteId);
            this.Controls.Add(this.animalDeleteIdLabel);
            this.Controls.Add(this.personAgeEditLabel);
            this.Controls.Add(this.textBoxPersonAgeEdit);
            this.Controls.Add(this.textBoxPersonNameEdit);
            this.Controls.Add(this.personNameEditLabel);
            this.Controls.Add(this.textBoxPersonIdEdit);
            this.Controls.Add(this.personIdEditLabel);
            this.Controls.Add(this.occupationEditLabel);
            this.Controls.Add(this.textBoxOccupationEdit);
            this.Controls.Add(this.staffAgeEditLabel);
            this.Controls.Add(this.textBoxStaffAgeEdit);
            this.Controls.Add(this.textBoxStaffNameEdit);
            this.Controls.Add(this.staffNameEditLabel);
            this.Controls.Add(this.textBoxIdStaffEdit);
            this.Controls.Add(this.idStaffEditLabel);
            this.Controls.Add(this.textBoxVoiceEdit);
            this.Controls.Add(this.voiceLabel);
            this.Controls.Add(this.textBoxCriticalHungerEdit);
            this.Controls.Add(this.criticalHungerLabel);
            this.Controls.Add(this.textBoxIdAnimalEdit);
            this.Controls.Add(this.idAnimalEditLabel);
            this.Controls.Add(this.professionLabel);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVoice);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.timeShowLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.addEntity);
            this.Controls.Add(this.visitorButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.barsButton);
            this.Controls.Add(this.capybaraButton);
            this.Controls.Add(this.horseButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HITS Zoo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button horseButton;
        private System.Windows.Forms.Button capybaraButton;
        private System.Windows.Forms.Button barsButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button visitorButton;
        private System.Windows.Forms.Label addEntity;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeShowLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox textBoxVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.Label idAnimalEditLabel;
        private System.Windows.Forms.TextBox textBoxIdAnimalEdit;
        private System.Windows.Forms.Label criticalHungerLabel;
        private System.Windows.Forms.TextBox textBoxCriticalHungerEdit;
        private System.Windows.Forms.Label voiceLabel;
        private System.Windows.Forms.TextBox textBoxVoiceEdit;
        private System.Windows.Forms.Label idStaffEditLabel;
        private System.Windows.Forms.TextBox textBoxIdStaffEdit;
        private System.Windows.Forms.Label staffNameEditLabel;
        private System.Windows.Forms.TextBox textBoxStaffNameEdit;
        private System.Windows.Forms.TextBox textBoxStaffAgeEdit;
        private System.Windows.Forms.Label staffAgeEditLabel;
        private System.Windows.Forms.TextBox textBoxOccupationEdit;
        private System.Windows.Forms.Label occupationEditLabel;
        private System.Windows.Forms.Label personIdEditLabel;
        private System.Windows.Forms.TextBox textBoxPersonIdEdit;
        private System.Windows.Forms.Label personNameEditLabel;
        private System.Windows.Forms.TextBox textBoxPersonNameEdit;
        private System.Windows.Forms.TextBox textBoxPersonAgeEdit;
        private System.Windows.Forms.Label personAgeEditLabel;
        private System.Windows.Forms.Label animalDeleteIdLabel;
        private System.Windows.Forms.TextBox textBoxAnimalDeleteId;
        private System.Windows.Forms.Label deletePersonIdLabel;
        private System.Windows.Forms.TextBox textBoxVisitorDeleteId;
        private System.Windows.Forms.TextBox textBoxAnimals;
        private System.Windows.Forms.TextBox textBoxPersons;
        private System.Windows.Forms.Label personsLabel;
        private System.Windows.Forms.Label animalsLabel;
        private System.Windows.Forms.Label zooLabel;
        private System.Windows.Forms.TextBox textBoxZoo;
        private System.Windows.Forms.Button animalEditButton;
        private System.Windows.Forms.Button staffEditButton;
        private System.Windows.Forms.Button visitorEditButton;
        private System.Windows.Forms.Button animalDeleteButton;
        private System.Windows.Forms.Button visitorDeleteButton;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.Label voiceSubmitLabel;
        private System.Windows.Forms.TextBox textBoxVoiceSubmit;
        private System.Windows.Forms.TextBox textBoxVoiceResult;
        private System.Windows.Forms.Button staffDeleteButton;
        private System.Windows.Forms.Label staffDeleteIdLabel;
        private System.Windows.Forms.TextBox textBoxStaffDeleteId;
        private System.Windows.Forms.TextBox textBoxStaffEditWardEnclouser;
        private System.Windows.Forms.Label staffEditWardEnclouserLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.CheckBox enclouserCheckBox;
        private System.Windows.Forms.Label EnclousersStatusLabel;
        private System.Windows.Forms.TextBox textBoxEnclousersStatus;
        private System.Windows.Forms.TextBox textBoxEnclouserId;
        private System.Windows.Forms.Label EnclouserForAddingLabel;
    }
}

