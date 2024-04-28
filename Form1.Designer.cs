using System;

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
            this.time = new System.Windows.Forms.Label();
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
            this.editAnimalLabel = new System.Windows.Forms.Label();
            this.idAnimalEditLabel = new System.Windows.Forms.Label();
            this.textBoxIdAnimalEdit = new System.Windows.Forms.TextBox();
            this.criticalHungerLabel = new System.Windows.Forms.Label();
            this.textBoxCriticalHungerEdit = new System.Windows.Forms.TextBox();
            this.voiceLabel = new System.Windows.Forms.Label();
            this.textBoxVoiceEdit = new System.Windows.Forms.TextBox();
            this.staffLabel = new System.Windows.Forms.Label();
            this.idStaffEditLabel = new System.Windows.Forms.Label();
            this.textBoxIdStaffEdit = new System.Windows.Forms.TextBox();
            this.staffNameEditLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxStaffAgeEdit = new System.Windows.Forms.TextBox();
            this.staffAgeEditLabel = new System.Windows.Forms.Label();
            this.textBoxOccupationEdit = new System.Windows.Forms.TextBox();
            this.occupationEditLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personIdEditLabel = new System.Windows.Forms.Label();
            this.textBoxPersonIdEdit = new System.Windows.Forms.TextBox();
            this.personNameEditLabel = new System.Windows.Forms.Label();
            this.textBoxPersonNameEdit = new System.Windows.Forms.TextBox();
            this.textBoxPersonAgeEdit = new System.Windows.Forms.TextBox();
            this.personAgeEditLabel = new System.Windows.Forms.Label();
            this.deleteAnimalLabel = new System.Windows.Forms.Label();
            this.animalDeleteIdLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deletePersonLabel = new System.Windows.Forms.Label();
            this.deletePersonIdLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxAnimals = new System.Windows.Forms.TextBox();
            this.textBoxPersons = new System.Windows.Forms.TextBox();
            this.PersonsLabel = new System.Windows.Forms.Label();
            this.animalsLabel = new System.Windows.Forms.Label();
            this.zooLabel = new System.Windows.Forms.Label();
            this.textBoxZoo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // horseButton
            // 
            this.horseButton.Location = new System.Drawing.Point(13, 45);
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
            this.capybaraButton.Location = new System.Drawing.Point(323, 45);
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
            this.barsButton.Location = new System.Drawing.Point(168, 45);
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
            this.staffButton.Location = new System.Drawing.Point(478, 45);
            this.staffButton.Margin = new System.Windows.Forms.Padding(4);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(202, 36);
            this.staffButton.TabIndex = 3;
            this.staffButton.Text = "Сотрудник";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // visitorButton
            // 
            this.visitorButton.Location = new System.Drawing.Point(688, 44);
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
            this.addEntity.Location = new System.Drawing.Point(13, 9);
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
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeLabel.Location = new System.Drawing.Point(1794, 9);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(97, 29);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Время:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.time.Location = new System.Drawing.Point(1832, 43);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(27, 29);
            this.time.TabIndex = 7;
            this.time.Text = "0";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(571, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(571, 116);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(264, 22);
            this.textBoxAge.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(484, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Имя";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(484, 122);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 16);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Возраст";
            // 
            // textBoxVoice
            // 
            this.textBoxVoice.Location = new System.Drawing.Point(76, 88);
            this.textBoxVoice.Name = "textBoxVoice";
            this.textBoxVoice.Size = new System.Drawing.Size(394, 22);
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
            this.textBoxOccupation.Location = new System.Drawing.Point(571, 142);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(109, 22);
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
            this.professionLabel.Location = new System.Drawing.Point(484, 150);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(81, 16);
            this.professionLabel.TabIndex = 18;
            this.professionLabel.Text = "Профессия";
            // 
            // editAnimalLabel
            // 
            this.editAnimalLabel.AutoSize = true;
            this.editAnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editAnimalLabel.Location = new System.Drawing.Point(13, 193);
            this.editAnimalLabel.Name = "editAnimalLabel";
            this.editAnimalLabel.Size = new System.Drawing.Size(309, 29);
            this.editAnimalLabel.TabIndex = 20;
            this.editAnimalLabel.Text = "Редактировать животное";
            // 
            // idAnimalEditLabel
            // 
            this.idAnimalEditLabel.AutoSize = true;
            this.idAnimalEditLabel.Location = new System.Drawing.Point(15, 232);
            this.idAnimalEditLabel.Name = "idAnimalEditLabel";
            this.idAnimalEditLabel.Size = new System.Drawing.Size(21, 16);
            this.idAnimalEditLabel.TabIndex = 21;
            this.idAnimalEditLabel.Text = "Id:";
            // 
            // textBoxIdAnimalEdit
            // 
            this.textBoxIdAnimalEdit.Location = new System.Drawing.Point(42, 229);
            this.textBoxIdAnimalEdit.Name = "textBoxIdAnimalEdit";
            this.textBoxIdAnimalEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdAnimalEdit.TabIndex = 22;
            // 
            // criticalHungerLabel
            // 
            this.criticalHungerLabel.AutoSize = true;
            this.criticalHungerLabel.Location = new System.Drawing.Point(156, 232);
            this.criticalHungerLabel.Name = "criticalHungerLabel";
            this.criticalHungerLabel.Size = new System.Drawing.Size(136, 16);
            this.criticalHungerLabel.TabIndex = 23;
            this.criticalHungerLabel.Text = "Критический голод:";
            // 
            // textBoxCriticalHungerEdit
            // 
            this.textBoxCriticalHungerEdit.Location = new System.Drawing.Point(298, 229);
            this.textBoxCriticalHungerEdit.Name = "textBoxCriticalHungerEdit";
            this.textBoxCriticalHungerEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxCriticalHungerEdit.TabIndex = 24;
            // 
            // voiceLabel
            // 
            this.voiceLabel.AutoSize = true;
            this.voiceLabel.Location = new System.Drawing.Point(517, 232);
            this.voiceLabel.Name = "voiceLabel";
            this.voiceLabel.Size = new System.Drawing.Size(48, 16);
            this.voiceLabel.TabIndex = 25;
            this.voiceLabel.Text = "Голос:";
            // 
            // textBoxVoiceEdit
            // 
            this.textBoxVoiceEdit.Location = new System.Drawing.Point(571, 229);
            this.textBoxVoiceEdit.Name = "textBoxVoiceEdit";
            this.textBoxVoiceEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxVoiceEdit.TabIndex = 26;
            // 
            // staffLabel
            // 
            this.staffLabel.AutoSize = true;
            this.staffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffLabel.Location = new System.Drawing.Point(13, 305);
            this.staffLabel.Name = "staffLabel";
            this.staffLabel.Size = new System.Drawing.Size(332, 29);
            this.staffLabel.TabIndex = 27;
            this.staffLabel.Text = "Редактировать сотрудника";
            // 
            // idStaffEditLabel
            // 
            this.idStaffEditLabel.AutoSize = true;
            this.idStaffEditLabel.Location = new System.Drawing.Point(15, 346);
            this.idStaffEditLabel.Name = "idStaffEditLabel";
            this.idStaffEditLabel.Size = new System.Drawing.Size(21, 16);
            this.idStaffEditLabel.TabIndex = 28;
            this.idStaffEditLabel.Text = "Id:";
            // 
            // textBoxIdStaffEdit
            // 
            this.textBoxIdStaffEdit.Location = new System.Drawing.Point(42, 343);
            this.textBoxIdStaffEdit.Name = "textBoxIdStaffEdit";
            this.textBoxIdStaffEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdStaffEdit.TabIndex = 29;
            // 
            // staffNameEditLabel
            // 
            this.staffNameEditLabel.AutoSize = true;
            this.staffNameEditLabel.Location = new System.Drawing.Point(256, 346);
            this.staffNameEditLabel.Name = "staffNameEditLabel";
            this.staffNameEditLabel.Size = new System.Drawing.Size(36, 16);
            this.staffNameEditLabel.TabIndex = 30;
            this.staffNameEditLabel.Text = "Имя:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 31;
            // 
            // textBoxStaffAgeEdit
            // 
            this.textBoxStaffAgeEdit.Location = new System.Drawing.Point(571, 343);
            this.textBoxStaffAgeEdit.Name = "textBoxStaffAgeEdit";
            this.textBoxStaffAgeEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxStaffAgeEdit.TabIndex = 32;
            // 
            // staffAgeEditLabel
            // 
            this.staffAgeEditLabel.AutoSize = true;
            this.staffAgeEditLabel.Location = new System.Drawing.Point(500, 346);
            this.staffAgeEditLabel.Name = "staffAgeEditLabel";
            this.staffAgeEditLabel.Size = new System.Drawing.Size(65, 16);
            this.staffAgeEditLabel.TabIndex = 33;
            this.staffAgeEditLabel.Text = "Возраст:";
            // 
            // textBoxOccupationEdit
            // 
            this.textBoxOccupationEdit.Location = new System.Drawing.Point(298, 379);
            this.textBoxOccupationEdit.Name = "textBoxOccupationEdit";
            this.textBoxOccupationEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxOccupationEdit.TabIndex = 34;
            // 
            // occupationEditLabel
            // 
            this.occupationEditLabel.AutoSize = true;
            this.occupationEditLabel.Location = new System.Drawing.Point(208, 379);
            this.occupationEditLabel.Name = "occupationEditLabel";
            this.occupationEditLabel.Size = new System.Drawing.Size(84, 16);
            this.occupationEditLabel.TabIndex = 35;
            this.occupationEditLabel.Text = "Профессия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(13, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Редактировать посетителя";
            // 
            // personIdEditLabel
            // 
            this.personIdEditLabel.AutoSize = true;
            this.personIdEditLabel.Location = new System.Drawing.Point(15, 447);
            this.personIdEditLabel.Name = "personIdEditLabel";
            this.personIdEditLabel.Size = new System.Drawing.Size(21, 16);
            this.personIdEditLabel.TabIndex = 37;
            this.personIdEditLabel.Text = "Id:";
            // 
            // textBoxPersonIdEdit
            // 
            this.textBoxPersonIdEdit.Location = new System.Drawing.Point(42, 444);
            this.textBoxPersonIdEdit.Name = "textBoxPersonIdEdit";
            this.textBoxPersonIdEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonIdEdit.TabIndex = 38;
            // 
            // personNameEditLabel
            // 
            this.personNameEditLabel.AutoSize = true;
            this.personNameEditLabel.Location = new System.Drawing.Point(256, 447);
            this.personNameEditLabel.Name = "personNameEditLabel";
            this.personNameEditLabel.Size = new System.Drawing.Size(36, 16);
            this.personNameEditLabel.TabIndex = 39;
            this.personNameEditLabel.Text = "Имя:";
            // 
            // textBoxPersonNameEdit
            // 
            this.textBoxPersonNameEdit.Location = new System.Drawing.Point(298, 441);
            this.textBoxPersonNameEdit.Name = "textBoxPersonNameEdit";
            this.textBoxPersonNameEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonNameEdit.TabIndex = 40;
            // 
            // textBoxPersonAgeEdit
            // 
            this.textBoxPersonAgeEdit.Location = new System.Drawing.Point(571, 441);
            this.textBoxPersonAgeEdit.Name = "textBoxPersonAgeEdit";
            this.textBoxPersonAgeEdit.Size = new System.Drawing.Size(100, 22);
            this.textBoxPersonAgeEdit.TabIndex = 41;
            // 
            // personAgeEditLabel
            // 
            this.personAgeEditLabel.AutoSize = true;
            this.personAgeEditLabel.Location = new System.Drawing.Point(500, 444);
            this.personAgeEditLabel.Name = "personAgeEditLabel";
            this.personAgeEditLabel.Size = new System.Drawing.Size(65, 16);
            this.personAgeEditLabel.TabIndex = 42;
            this.personAgeEditLabel.Text = "Возраст:";
            // 
            // deleteAnimalLabel
            // 
            this.deleteAnimalLabel.AutoSize = true;
            this.deleteAnimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deleteAnimalLabel.Location = new System.Drawing.Point(13, 495);
            this.deleteAnimalLabel.Name = "deleteAnimalLabel";
            this.deleteAnimalLabel.Size = new System.Drawing.Size(229, 29);
            this.deleteAnimalLabel.TabIndex = 43;
            this.deleteAnimalLabel.Text = "Удалить животное";
            // 
            // animalDeleteIdLabel
            // 
            this.animalDeleteIdLabel.AutoSize = true;
            this.animalDeleteIdLabel.Location = new System.Drawing.Point(15, 535);
            this.animalDeleteIdLabel.Name = "animalDeleteIdLabel";
            this.animalDeleteIdLabel.Size = new System.Drawing.Size(21, 16);
            this.animalDeleteIdLabel.TabIndex = 44;
            this.animalDeleteIdLabel.Text = "Id:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 532);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 45;
            // 
            // deletePersonLabel
            // 
            this.deletePersonLabel.AutoSize = true;
            this.deletePersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deletePersonLabel.Location = new System.Drawing.Point(254, 495);
            this.deletePersonLabel.Name = "deletePersonLabel";
            this.deletePersonLabel.Size = new System.Drawing.Size(226, 29);
            this.deletePersonLabel.TabIndex = 46;
            this.deletePersonLabel.Text = "Удалить человека";
            // 
            // deletePersonIdLabel
            // 
            this.deletePersonIdLabel.AutoSize = true;
            this.deletePersonIdLabel.Location = new System.Drawing.Point(271, 535);
            this.deletePersonIdLabel.Name = "deletePersonIdLabel";
            this.deletePersonIdLabel.Size = new System.Drawing.Size(21, 16);
            this.deletePersonIdLabel.TabIndex = 47;
            this.deletePersonIdLabel.Text = "Id:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(298, 532);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 48;
            // 
            // textBoxAnimals
            // 
            this.textBoxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAnimals.Location = new System.Drawing.Point(901, 232);
            this.textBoxAnimals.Multiline = true;
            this.textBoxAnimals.Name = "textBoxAnimals";
            this.textBoxAnimals.Size = new System.Drawing.Size(499, 603);
            this.textBoxAnimals.TabIndex = 49;
            // 
            // textBoxPersons
            // 
            this.textBoxPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPersons.Location = new System.Drawing.Point(1427, 232);
            this.textBoxPersons.Multiline = true;
            this.textBoxPersons.Name = "textBoxPersons";
            this.textBoxPersons.Size = new System.Drawing.Size(464, 603);
            this.textBoxPersons.TabIndex = 50;
            // 
            // PersonsLabel
            // 
            this.PersonsLabel.AutoSize = true;
            this.PersonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PersonsLabel.Location = new System.Drawing.Point(1420, 193);
            this.PersonsLabel.Name = "PersonsLabel";
            this.PersonsLabel.Size = new System.Drawing.Size(105, 39);
            this.PersonsLabel.TabIndex = 51;
            this.PersonsLabel.Text = "Люди";
            // 
            // animalsLabel
            // 
            this.animalsLabel.AutoSize = true;
            this.animalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.animalsLabel.Location = new System.Drawing.Point(894, 190);
            this.animalsLabel.Name = "animalsLabel";
            this.animalsLabel.Size = new System.Drawing.Size(182, 39);
            this.animalsLabel.TabIndex = 52;
            this.animalsLabel.Text = "Животные";
            // 
            // zooLabel
            // 
            this.zooLabel.AutoSize = true;
            this.zooLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.zooLabel.Location = new System.Drawing.Point(894, 45);
            this.zooLabel.Name = "zooLabel";
            this.zooLabel.Size = new System.Drawing.Size(151, 39);
            this.zooLabel.TabIndex = 53;
            this.zooLabel.Text = "Зоопарк";
            // 
            // textBoxZoo
            // 
            this.textBoxZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZoo.Location = new System.Drawing.Point(901, 116);
            this.textBoxZoo.Name = "textBoxZoo";
            this.textBoxZoo.Size = new System.Drawing.Size(762, 36);
            this.textBoxZoo.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 847);
            this.Controls.Add(this.textBoxZoo);
            this.Controls.Add(this.zooLabel);
            this.Controls.Add(this.animalsLabel);
            this.Controls.Add(this.PersonsLabel);
            this.Controls.Add(this.textBoxPersons);
            this.Controls.Add(this.textBoxAnimals);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.deletePersonIdLabel);
            this.Controls.Add(this.deletePersonLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.animalDeleteIdLabel);
            this.Controls.Add(this.deleteAnimalLabel);
            this.Controls.Add(this.personAgeEditLabel);
            this.Controls.Add(this.textBoxPersonAgeEdit);
            this.Controls.Add(this.textBoxPersonNameEdit);
            this.Controls.Add(this.personNameEditLabel);
            this.Controls.Add(this.textBoxPersonIdEdit);
            this.Controls.Add(this.personIdEditLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.occupationEditLabel);
            this.Controls.Add(this.textBoxOccupationEdit);
            this.Controls.Add(this.staffAgeEditLabel);
            this.Controls.Add(this.textBoxStaffAgeEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.staffNameEditLabel);
            this.Controls.Add(this.textBoxIdStaffEdit);
            this.Controls.Add(this.idStaffEditLabel);
            this.Controls.Add(this.staffLabel);
            this.Controls.Add(this.textBoxVoiceEdit);
            this.Controls.Add(this.voiceLabel);
            this.Controls.Add(this.textBoxCriticalHungerEdit);
            this.Controls.Add(this.criticalHungerLabel);
            this.Controls.Add(this.textBoxIdAnimalEdit);
            this.Controls.Add(this.idAnimalEditLabel);
            this.Controls.Add(this.editAnimalLabel);
            this.Controls.Add(this.professionLabel);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVoice);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.time);
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
        private System.Windows.Forms.Label time;
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
        private System.Windows.Forms.Label editAnimalLabel;
        private System.Windows.Forms.Label idAnimalEditLabel;
        private System.Windows.Forms.TextBox textBoxIdAnimalEdit;
        private System.Windows.Forms.Label criticalHungerLabel;
        private System.Windows.Forms.TextBox textBoxCriticalHungerEdit;
        private System.Windows.Forms.Label voiceLabel;
        private System.Windows.Forms.TextBox textBoxVoiceEdit;
        private System.Windows.Forms.Label staffLabel;
        private System.Windows.Forms.Label idStaffEditLabel;
        private System.Windows.Forms.TextBox textBoxIdStaffEdit;
        private System.Windows.Forms.Label staffNameEditLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxStaffAgeEdit;
        private System.Windows.Forms.Label staffAgeEditLabel;
        private System.Windows.Forms.TextBox textBoxOccupationEdit;
        private System.Windows.Forms.Label occupationEditLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label personIdEditLabel;
        private System.Windows.Forms.TextBox textBoxPersonIdEdit;
        private System.Windows.Forms.Label personNameEditLabel;
        private System.Windows.Forms.TextBox textBoxPersonNameEdit;
        private System.Windows.Forms.TextBox textBoxPersonAgeEdit;
        private System.Windows.Forms.Label personAgeEditLabel;
        private System.Windows.Forms.Label deleteAnimalLabel;
        private System.Windows.Forms.Label animalDeleteIdLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label deletePersonLabel;
        private System.Windows.Forms.Label deletePersonIdLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxAnimals;
        private System.Windows.Forms.TextBox textBoxPersons;
        private System.Windows.Forms.Label PersonsLabel;
        private System.Windows.Forms.Label animalsLabel;
        private System.Windows.Forms.Label zooLabel;
        private System.Windows.Forms.TextBox textBoxZoo;
    }
}

