namespace TDC_Office
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрОстатковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ордерНаДоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеНоменклатурыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.филиалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брянскToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калугаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тверьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для начала работы выберите сверху режим или филиал";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимToolStripMenuItem,
            this.филиалToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрОстатковToolStripMenuItem,
            this.ордерНаДоставкуToolStripMenuItem,
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem,
            this.редактированиеНоменклатурыТоваровToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // просмотрОстатковToolStripMenuItem
            // 
            this.просмотрОстатковToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.просмотрОстатковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("просмотрОстатковToolStripMenuItem.Image")));
            this.просмотрОстатковToolStripMenuItem.Name = "просмотрОстатковToolStripMenuItem";
            this.просмотрОстатковToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.просмотрОстатковToolStripMenuItem.Text = "Просмотр остатков";
            this.просмотрОстатковToolStripMenuItem.Click += new System.EventHandler(this.просмотрОстатковToolStripMenuItem_Click_1);
            // 
            // ордерНаДоставкуToolStripMenuItem
            // 
            this.ордерНаДоставкуToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ордерНаДоставкуToolStripMenuItem.Name = "ордерНаДоставкуToolStripMenuItem";
            this.ордерНаДоставкуToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.ордерНаДоставкуToolStripMenuItem.Text = "Ордер на доставку";
            this.ордерНаДоставкуToolStripMenuItem.Click += new System.EventHandler(this.ордерНаДоставкуToolStripMenuItem_Click_1);
            // 
            // добавлениеНовойТоварнойПозицииToolStripMenuItem
            // 
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавлениеНовойТоварнойПозицииToolStripMenuItem.Image")));
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.Name = "добавлениеНовойТоварнойПозицииToolStripMenuItem";
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.Text = "Добавление новой товарной позиции";
            this.добавлениеНовойТоварнойПозицииToolStripMenuItem.Click += new System.EventHandler(this.добавлениеНовойТоварнойПозицииToolStripMenuItem_Click_1);
            // 
            // редактированиеНоменклатурыТоваровToolStripMenuItem
            // 
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("редактированиеНоменклатурыТоваровToolStripMenuItem.Image")));
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.Name = "редактированиеНоменклатурыТоваровToolStripMenuItem";
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.Text = "Редактирование номенклатуры товаров";
            this.редактированиеНоменклатурыТоваровToolStripMenuItem.Click += new System.EventHandler(this.редактированиеНоменклатурыТоваровToolStripMenuItem_Click_1);
            // 
            // филиалToolStripMenuItem
            // 
            this.филиалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.брянскToolStripMenuItem,
            this.калугаToolStripMenuItem,
            this.тверьToolStripMenuItem});
            this.филиалToolStripMenuItem.Name = "филиалToolStripMenuItem";
            this.филиалToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.филиалToolStripMenuItem.Text = "Филиал";
            // 
            // брянскToolStripMenuItem
            // 
            this.брянскToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.брянскToolStripMenuItem.Name = "брянскToolStripMenuItem";
            this.брянскToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.брянскToolStripMenuItem.Text = "1-Брянск";
            this.брянскToolStripMenuItem.Click += new System.EventHandler(this.брянскToolStripMenuItem_Click_1);
            // 
            // калугаToolStripMenuItem
            // 
            this.калугаToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.калугаToolStripMenuItem.Name = "калугаToolStripMenuItem";
            this.калугаToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.калугаToolStripMenuItem.Text = "2-Калуга";
            this.калугаToolStripMenuItem.Click += new System.EventHandler(this.калугаToolStripMenuItem_Click);
            // 
            // тверьToolStripMenuItem
            // 
            this.тверьToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.тверьToolStripMenuItem.Name = "тверьToolStripMenuItem";
            this.тверьToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.тверьToolStripMenuItem.Text = "3-Тверь";
            this.тверьToolStripMenuItem.Click += new System.EventHandler(this.тверьToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доставкаToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // доставкаToolStripMenuItem
            // 
            this.доставкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.доставкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПапкуToolStripMenuItem,
            this.удалитьВсеToolStripMenuItem});
            this.доставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("доставкаToolStripMenuItem.Image")));
            this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
            this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.доставкаToolStripMenuItem.Text = "Доставка";
            // 
            // открытьПапкуToolStripMenuItem
            // 
            this.открытьПапкуToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.открытьПапкуToolStripMenuItem.Name = "открытьПапкуToolStripMenuItem";
            this.открытьПапкуToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.открытьПапкуToolStripMenuItem.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem_Click);
            // 
            // удалитьВсеToolStripMenuItem
            // 
            this.удалитьВсеToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.удалитьВсеToolStripMenuItem.Name = "удалитьВсеToolStripMenuItem";
            this.удалитьВсеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.удалитьВсеToolStripMenuItem.Text = "Удалить все";
            this.удалитьВсеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПапкуToolStripMenuItem1,
            this.удалитьВсеToolStripMenuItem1});
            this.отчетыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отчетыToolStripMenuItem.Image")));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // открытьПапкуToolStripMenuItem1
            // 
            this.открытьПапкуToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.открытьПапкуToolStripMenuItem1.Name = "открытьПапкуToolStripMenuItem1";
            this.открытьПапкуToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.открытьПапкуToolStripMenuItem1.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem1.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem1_Click);
            // 
            // удалитьВсеToolStripMenuItem1
            // 
            this.удалитьВсеToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.удалитьВсеToolStripMenuItem1.Name = "удалитьВсеToolStripMenuItem1";
            this.удалитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.удалитьВсеToolStripMenuItem1.Text = "Удалить все";
            this.удалитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.удалитьВсеToolStripMenuItem1_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.настройкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиToolStripMenuItem.Image")));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(36, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Загрузить данные о новых остатках";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 246);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDC-Office";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрОстатковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ордерНаДоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеНовойТоварнойПозицииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеНоменклатурыТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem филиалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem брянскToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калугаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тверьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

