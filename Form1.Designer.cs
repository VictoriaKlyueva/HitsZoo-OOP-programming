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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.professionLabel = new System.Windows.Forms.Label();
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
            this.capybaraButton.Click += new System.EventHandler(this.capybaraButton_Click);
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
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
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
            this.timeLabel.Location = new System.Drawing.Point(1152, 9);
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
            this.time.Location = new System.Drawing.Point(1189, 44);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 16;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 802);
            this.Controls.Add(this.professionLabel);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label professionLabel;
    }
}

