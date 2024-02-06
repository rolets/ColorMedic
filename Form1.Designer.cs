namespace med
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectSlider1 = new med.SelectionRangeSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.selectSlider2 = new med.SelectionRangeSlider();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.diapazonMin = new System.Windows.Forms.Label();
            this.diapazonMax = new System.Windows.Forms.Label();
            this.diapazonMin2 = new System.Windows.Forms.Label();
            this.diapazonMax2 = new System.Windows.Forms.Label();
            this.selectSliderV = new med.SelectionRangeSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.selectSliderS = new med.SelectionRangeSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxInv = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пакетнаяОбработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неОбработанныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.imageBox1.Location = new System.Drawing.Point(289, 24);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1115, 547);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // selectSlider1
            // 
            this.selectSlider1.BackColor = System.Drawing.SystemColors.Control;
            this.selectSlider1.BackgroundImage = global::med.Properties.Resources.medResult1;
            this.selectSlider1.ColorSheme = 1;
            this.selectSlider1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectSlider1.Location = new System.Drawing.Point(4, 18);
            this.selectSlider1.Max = 180;
            this.selectSlider1.Min = 0;
            this.selectSlider1.Name = "selectSlider1";
            this.selectSlider1.SelectedMax = 27;
            this.selectSlider1.SelectedMin = 0;
            this.selectSlider1.Size = new System.Drawing.Size(252, 27);
            this.selectSlider1.TabIndex = 8;
            this.selectSlider1.SelectionChanged += new System.EventHandler(this.selectionRangeSlider1_SelectionChanged);
            this.selectSlider1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectionRangeSlider1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "% площади";
            // 
            // selectSlider2
            // 
            this.selectSlider2.BackColor = System.Drawing.SystemColors.Control;
            this.selectSlider2.BackgroundImage = global::med.Properties.Resources.medResult1;
            this.selectSlider2.ColorSheme = 1;
            this.selectSlider2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectSlider2.Location = new System.Drawing.Point(5, 93);
            this.selectSlider2.Max = 180;
            this.selectSlider2.Min = 0;
            this.selectSlider2.Name = "selectSlider2";
            this.selectSlider2.SelectedMax = 180;
            this.selectSlider2.SelectedMin = 150;
            this.selectSlider2.Size = new System.Drawing.Size(251, 27);
            this.selectSlider2.TabIndex = 10;
            this.selectSlider2.SelectionChanged += new System.EventHandler(this.selectionRangeSlider2_SelectionChanged);
            this.selectSlider2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectionRangeSlider1_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 25);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "второй диапазон";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // diapazonMin
            // 
            this.diapazonMin.AutoSize = true;
            this.diapazonMin.Location = new System.Drawing.Point(4, 48);
            this.diapazonMin.Name = "diapazonMin";
            this.diapazonMin.Size = new System.Drawing.Size(37, 21);
            this.diapazonMin.TabIndex = 12;
            this.diapazonMin.Text = "min";
            // 
            // diapazonMax
            // 
            this.diapazonMax.AutoSize = true;
            this.diapazonMax.Location = new System.Drawing.Point(217, 48);
            this.diapazonMax.Name = "diapazonMax";
            this.diapazonMax.Size = new System.Drawing.Size(39, 21);
            this.diapazonMax.TabIndex = 13;
            this.diapazonMax.Text = "max";
            // 
            // diapazonMin2
            // 
            this.diapazonMin2.AutoSize = true;
            this.diapazonMin2.Location = new System.Drawing.Point(7, 123);
            this.diapazonMin2.Name = "diapazonMin2";
            this.diapazonMin2.Size = new System.Drawing.Size(37, 21);
            this.diapazonMin2.TabIndex = 14;
            this.diapazonMin2.Text = "min";
            // 
            // diapazonMax2
            // 
            this.diapazonMax2.AutoSize = true;
            this.diapazonMax2.Location = new System.Drawing.Point(217, 123);
            this.diapazonMax2.Name = "diapazonMax2";
            this.diapazonMax2.Size = new System.Drawing.Size(39, 21);
            this.diapazonMax2.TabIndex = 15;
            this.diapazonMax2.Text = "max";
            this.diapazonMax2.Click += new System.EventHandler(this.diapazonMax2_Click);
            // 
            // selectSliderV
            // 
            this.selectSliderV.BackColor = System.Drawing.SystemColors.Control;
            this.selectSliderV.BackgroundImage = global::med.Properties.Resources.medResult1;
            this.selectSliderV.ColorSheme = 0;
            this.selectSliderV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectSliderV.Location = new System.Drawing.Point(7, 161);
            this.selectSliderV.Max = 255;
            this.selectSliderV.Min = 0;
            this.selectSliderV.Name = "selectSliderV";
            this.selectSliderV.SelectedMax = 255;
            this.selectSliderV.SelectedMin = 0;
            this.selectSliderV.Size = new System.Drawing.Size(249, 27);
            this.selectSliderV.TabIndex = 16;
            this.selectSliderV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectionRangeSlider1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Яркость";
            // 
            // selectSliderS
            // 
            this.selectSliderS.BackColor = System.Drawing.SystemColors.Control;
            this.selectSliderS.BackgroundImage = global::med.Properties.Resources.medResult1;
            this.selectSliderS.ColorSheme = 0;
            this.selectSliderS.Location = new System.Drawing.Point(5, 226);
            this.selectSliderS.Margin = new System.Windows.Forms.Padding(4);
            this.selectSliderS.Max = 255;
            this.selectSliderS.Min = 0;
            this.selectSliderS.Name = "selectSliderS";
            this.selectSliderS.SelectedMax = 255;
            this.selectSliderS.SelectedMin = 0;
            this.selectSliderS.Size = new System.Drawing.Size(251, 27);
            this.selectSliderS.TabIndex = 18;
            this.selectSliderS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectionRangeSlider1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Насыщенность";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxInv);
            this.panel1.Controls.Add(this.selectSlider1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.selectSliderS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.diapazonMin);
            this.panel1.Controls.Add(this.diapazonMax);
            this.panel1.Controls.Add(this.selectSlider2);
            this.panel1.Controls.Add(this.diapazonMin2);
            this.panel1.Controls.Add(this.selectSliderV);
            this.panel1.Controls.Add(this.diapazonMax2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 304);
            this.panel1.TabIndex = 20;
            // 
            // checkBoxInv
            // 
            this.checkBoxInv.AutoSize = true;
            this.checkBoxInv.Location = new System.Drawing.Point(94, 274);
            this.checkBoxInv.Name = "checkBoxInv";
            this.checkBoxInv.Size = new System.Drawing.Size(99, 25);
            this.checkBoxInv.TabIndex = 21;
            this.checkBoxInv.Text = "Инверсия";
            this.checkBoxInv.UseVisualStyleBackColor = true;
            this.checkBoxInv.CheckedChanged += new System.EventHandler(this.checkBoxInv_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "количество объектов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1404, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.пакетнаяОбработкаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            this.открытьToolStripMenuItem.MouseLeave += new System.EventHandler(this.сохранитьToolStripMenuItem_MouseLeave);
            this.открытьToolStripMenuItem.MouseHover += new System.EventHandler(this.открытьToolStripMenuItem_MouseHover);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            this.сохранитьToolStripMenuItem.MouseLeave += new System.EventHandler(this.сохранитьToolStripMenuItem_MouseLeave);
            this.сохранитьToolStripMenuItem.MouseHover += new System.EventHandler(this.сохранитьToolStripMenuItem_MouseHover);
            // 
            // пакетнаяОбработкаToolStripMenuItem
            // 
            this.пакетнаяОбработкаToolStripMenuItem.Name = "пакетнаяОбработкаToolStripMenuItem";
            this.пакетнаяОбработкаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.пакетнаяОбработкаToolStripMenuItem.Text = "Пакетная обработка";
            this.пакетнаяОбработкаToolStripMenuItem.Click += new System.EventHandler(this.пакетнаяОбработкаToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНастройкиToolStripMenuItem,
            this.неОбработанныйToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // сохранитьНастройкиToolStripMenuItem
            // 
            this.сохранитьНастройкиToolStripMenuItem.Name = "сохранитьНастройкиToolStripMenuItem";
            this.сохранитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сохранитьНастройкиToolStripMenuItem.Text = "Сохранить настройки";
            this.сохранитьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНастройкиToolStripMenuItem_Click);
            // 
            // неОбработанныйToolStripMenuItem
            // 
            this.неОбработанныйToolStripMenuItem.Name = "неОбработанныйToolStripMenuItem";
            this.неОбработанныйToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.неОбработанныйToolStripMenuItem.Text = "Не обработанный";
            this.неОбработанныйToolStripMenuItem.Click += new System.EventHandler(this.неОбработанныйToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1404, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Обработка изображений";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Label label1;
        private SelectionRangeSlider selectSlider1;
        private Label label2;
        private SelectionRangeSlider selectSlider2;
        private CheckBox checkBox1;
        private Label diapazonMin;
        private Label diapazonMax;
        private Label diapazonMin2;
        private Label diapazonMax2;
        private SelectionRangeSlider selectSliderV;
        private Label label3;
        private SelectionRangeSlider selectSliderS;
        private Label label4;
        private Panel panel1;
        private CheckBox checkBoxInv;
        private Label label5;
        private Label label6;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem пакетнаяОбработкаToolStripMenuItem;
        private ToolStripMenuItem сервисToolStripMenuItem;
        private ToolStripMenuItem сохранитьНастройкиToolStripMenuItem;
        private ToolStripMenuItem неОбработанныйToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}