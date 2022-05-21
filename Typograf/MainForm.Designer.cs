
namespace Typograf
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.typografpage = new System.Windows.Forms.TabPage();
            this.shriftbutton = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typograflabel = new System.Windows.Forms.Label();
            this.propertiespage = new System.Windows.Forms.TabPage();
            this.checkboxpravil7 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil6 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil5 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil4 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil3 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil2 = new System.Windows.Forms.CheckBox();
            this.checkboxpravil1 = new System.Windows.Forms.CheckBox();
            this.label7pravil = new System.Windows.Forms.Label();
            this.label6pravil = new System.Windows.Forms.Label();
            this.label5pravil = new System.Windows.Forms.Label();
            this.label4pravil = new System.Windows.Forms.Label();
            this.label3pravil = new System.Windows.Forms.Label();
            this.label2pravil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1pravil = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.typografpage.SuspendLayout();
            this.propertiespage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.typografpage);
            this.tabControl1.Controls.Add(this.propertiespage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // typografpage
            // 
            this.typografpage.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.typografpage.Controls.Add(this.shriftbutton);
            this.typografpage.Controls.Add(this.buttonsave);
            this.typografpage.Controls.Add(this.button1);
            this.typografpage.Controls.Add(this.textBox1);
            this.typografpage.Controls.Add(this.typograflabel);
            this.typografpage.Location = new System.Drawing.Point(4, 22);
            this.typografpage.Margin = new System.Windows.Forms.Padding(2);
            this.typografpage.Name = "typografpage";
            this.typografpage.Padding = new System.Windows.Forms.Padding(2);
            this.typografpage.Size = new System.Drawing.Size(1271, 623);
            this.typografpage.TabIndex = 0;
            this.typografpage.Text = "Типограф";
            // 
            // shriftbutton
            // 
            this.shriftbutton.Location = new System.Drawing.Point(911, 547);
            this.shriftbutton.Margin = new System.Windows.Forms.Padding(2);
            this.shriftbutton.Name = "shriftbutton";
            this.shriftbutton.Size = new System.Drawing.Size(203, 40);
            this.shriftbutton.TabIndex = 4;
            this.shriftbutton.Text = "Поменять шрифт";
            this.shriftbutton.UseVisualStyleBackColor = true;
            this.shriftbutton.Click += new System.EventHandler(this.shriftbutton_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(522, 547);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(203, 40);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Сохранить ";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отипогрфировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1169, 426);
            this.textBox1.TabIndex = 1;
            // 
            // typograflabel
            // 
            this.typograflabel.AutoSize = true;
            this.typograflabel.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typograflabel.Location = new System.Drawing.Point(432, 31);
            this.typograflabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typograflabel.Name = "typograflabel";
            this.typograflabel.Size = new System.Drawing.Size(329, 38);
            this.typograflabel.TabIndex = 0;
            this.typograflabel.Text = "Типограф";
            this.typograflabel.Click += new System.EventHandler(this.typograflabel_Click);
            // 
            // propertiespage
            // 
            this.propertiespage.BackgroundImage = global::Typograf.Properties.Resources._1613395175_156_p_bezhevii_fon_odnotonnii_estetika_174;
            this.propertiespage.Controls.Add(this.checkboxpravil7);
            this.propertiespage.Controls.Add(this.checkboxpravil6);
            this.propertiespage.Controls.Add(this.checkboxpravil5);
            this.propertiespage.Controls.Add(this.checkboxpravil4);
            this.propertiespage.Controls.Add(this.checkboxpravil3);
            this.propertiespage.Controls.Add(this.checkboxpravil2);
            this.propertiespage.Controls.Add(this.checkboxpravil1);
            this.propertiespage.Controls.Add(this.label7pravil);
            this.propertiespage.Controls.Add(this.label6pravil);
            this.propertiespage.Controls.Add(this.label5pravil);
            this.propertiespage.Controls.Add(this.label4pravil);
            this.propertiespage.Controls.Add(this.label3pravil);
            this.propertiespage.Controls.Add(this.label2pravil);
            this.propertiespage.Controls.Add(this.label3);
            this.propertiespage.Controls.Add(this.label1pravil);
            this.propertiespage.Location = new System.Drawing.Point(4, 22);
            this.propertiespage.Margin = new System.Windows.Forms.Padding(2);
            this.propertiespage.Name = "propertiespage";
            this.propertiespage.Padding = new System.Windows.Forms.Padding(2);
            this.propertiespage.Size = new System.Drawing.Size(1271, 623);
            this.propertiespage.TabIndex = 1;
            this.propertiespage.Text = "Настройки";
            this.propertiespage.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil7
            // 
            this.checkboxpravil7.AutoSize = true;
            this.checkboxpravil7.Location = new System.Drawing.Point(24, 408);
            this.checkboxpravil7.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil7.Name = "checkboxpravil7";
            this.checkboxpravil7.Size = new System.Drawing.Size(73, 17);
            this.checkboxpravil7.TabIndex = 20;
            this.checkboxpravil7.Text = "опсурдик";
            this.checkboxpravil7.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil6
            // 
            this.checkboxpravil6.AutoSize = true;
            this.checkboxpravil6.Location = new System.Drawing.Point(24, 350);
            this.checkboxpravil6.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil6.Name = "checkboxpravil6";
            this.checkboxpravil6.Size = new System.Drawing.Size(76, 17);
            this.checkboxpravil6.TabIndex = 19;
            this.checkboxpravil6.Text = "русская с";
            this.checkboxpravil6.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil5
            // 
            this.checkboxpravil5.AutoSize = true;
            this.checkboxpravil5.Location = new System.Drawing.Point(24, 290);
            this.checkboxpravil5.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil5.Name = "checkboxpravil5";
            this.checkboxpravil5.Size = new System.Drawing.Size(32, 17);
            this.checkboxpravil5.TabIndex = 18;
            this.checkboxpravil5.Text = "¿";
            this.checkboxpravil5.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil4
            // 
            this.checkboxpravil4.AutoSize = true;
            this.checkboxpravil4.Location = new System.Drawing.Point(24, 229);
            this.checkboxpravil4.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil4.Name = "checkboxpravil4";
            this.checkboxpravil4.Size = new System.Drawing.Size(29, 17);
            this.checkboxpravil4.TabIndex = 17;
            this.checkboxpravil4.Text = "-";
            this.checkboxpravil4.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil3
            // 
            this.checkboxpravil3.AutoSize = true;
            this.checkboxpravil3.Location = new System.Drawing.Point(24, 166);
            this.checkboxpravil3.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil3.Name = "checkboxpravil3";
            this.checkboxpravil3.Size = new System.Drawing.Size(32, 17);
            this.checkboxpravil3.TabIndex = 16;
            this.checkboxpravil3.Text = "—";
            this.checkboxpravil3.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil2
            // 
            this.checkboxpravil2.AutoSize = true;
            this.checkboxpravil2.Location = new System.Drawing.Point(24, 105);
            this.checkboxpravil2.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil2.Name = "checkboxpravil2";
            this.checkboxpravil2.Size = new System.Drawing.Size(32, 17);
            this.checkboxpravil2.TabIndex = 15;
            this.checkboxpravil2.Text = "−";
            this.checkboxpravil2.UseVisualStyleBackColor = true;
            // 
            // checkboxpravil1
            // 
            this.checkboxpravil1.AutoSize = true;
            this.checkboxpravil1.Location = new System.Drawing.Point(24, 45);
            this.checkboxpravil1.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxpravil1.Name = "checkboxpravil1";
            this.checkboxpravil1.Size = new System.Drawing.Size(50, 17);
            this.checkboxpravil1.TabIndex = 14;
            this.checkboxpravil1.Text = "..., ...";
            this.checkboxpravil1.UseVisualStyleBackColor = true;
            // 
            // label7pravil
            // 
            this.label7pravil.AutoSize = true;
            this.label7pravil.Location = new System.Drawing.Point(149, 408);
            this.label7pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7pravil.Name = "label7pravil";
            this.label7pravil.Size = new System.Drawing.Size(171, 13);
            this.label7pravil.TabIndex = 13;
            this.label7pravil.Text = "идут соревнования по фантазии";
            this.label7pravil.Click += new System.EventHandler(this.label7pravil_Click);
            // 
            // label6pravil
            // 
            this.label6pravil.AutoSize = true;
            this.label6pravil.Location = new System.Drawing.Point(149, 350);
            this.label6pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6pravil.Name = "label6pravil";
            this.label6pravil.Size = new System.Drawing.Size(102, 13);
            this.label6pravil.TabIndex = 11;
            this.label6pravil.Text = "правило русской с";
            this.label6pravil.Click += new System.EventHandler(this.label6pravil_Click);
            // 
            // label5pravil
            // 
            this.label5pravil.AutoSize = true;
            this.label5pravil.Location = new System.Drawing.Point(149, 290);
            this.label5pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5pravil.Name = "label5pravil";
            this.label5pravil.Size = new System.Drawing.Size(173, 13);
            this.label5pravil.TabIndex = 9;
            this.label5pravil.Text = "правило вопросительного знака";
            this.label5pravil.Click += new System.EventHandler(this.label5pravil_Click);
            // 
            // label4pravil
            // 
            this.label4pravil.AutoSize = true;
            this.label4pravil.Location = new System.Drawing.Point(149, 229);
            this.label4pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4pravil.Name = "label4pravil";
            this.label4pravil.Size = new System.Drawing.Size(90, 13);
            this.label4pravil.TabIndex = 7;
            this.label4pravil.Text = "правило дефиса";
            this.label4pravil.Click += new System.EventHandler(this.label4pravil_Click);
            // 
            // label3pravil
            // 
            this.label3pravil.AutoSize = true;
            this.label3pravil.Location = new System.Drawing.Point(149, 166);
            this.label3pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3pravil.Name = "label3pravil";
            this.label3pravil.Size = new System.Drawing.Size(75, 13);
            this.label3pravil.TabIndex = 5;
            this.label3pravil.Text = "правило тире";
            this.label3pravil.Click += new System.EventHandler(this.label3pravil_Click);
            // 
            // label2pravil
            // 
            this.label2pravil.AutoSize = true;
            this.label2pravil.Location = new System.Drawing.Point(149, 106);
            this.label2pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2pravil.Name = "label2pravil";
            this.label2pravil.Size = new System.Drawing.Size(89, 13);
            this.label2pravil.TabIndex = 3;
            this.label2pravil.Text = "правило минуса";
            this.label2pravil.Click += new System.EventHandler(this.label2pravil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Свойства настроек:";
            // 
            // label1pravil
            // 
            this.label1pravil.AutoSize = true;
            this.label1pravil.Location = new System.Drawing.Point(149, 45);
            this.label1pravil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1pravil.Name = "label1pravil";
            this.label1pravil.Size = new System.Drawing.Size(151, 13);
            this.label1pravil.TabIndex = 0;
            this.label1pravil.Text = "правило знаков препинания";
            this.label1pravil.Click += new System.EventHandler(this.label1pravil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Типограф";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.typografpage.ResumeLayout(false);
            this.typografpage.PerformLayout();
            this.propertiespage.ResumeLayout(false);
            this.propertiespage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage typografpage;
        private System.Windows.Forms.TabPage propertiespage;
        private System.Windows.Forms.Label typograflabel;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7pravil;
        private System.Windows.Forms.Label label6pravil;
        private System.Windows.Forms.Label label5pravil;
        private System.Windows.Forms.Label label4pravil;
        private System.Windows.Forms.Label label3pravil;
        private System.Windows.Forms.Label label2pravil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1pravil;
        private System.Windows.Forms.CheckBox checkboxpravil7;
        private System.Windows.Forms.CheckBox checkboxpravil6;
        private System.Windows.Forms.CheckBox checkboxpravil5;
        private System.Windows.Forms.CheckBox checkboxpravil4;
        private System.Windows.Forms.CheckBox checkboxpravil3;
        private System.Windows.Forms.CheckBox checkboxpravil2;
        private System.Windows.Forms.CheckBox checkboxpravil1;
        private System.Windows.Forms.Button shriftbutton;
    }
}

