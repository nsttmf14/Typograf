
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
            this.buttonsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typograflabel = new System.Windows.Forms.Label();
            this.propertiespage = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.label7pravil = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6pravil = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label5pravil = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label4pravil = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3pravil = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2pravil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1918, 999);
            this.tabControl1.TabIndex = 0;
            // 
            // typografpage
            // 
            this.typografpage.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.typografpage.Controls.Add(this.buttonsave);
            this.typografpage.Controls.Add(this.button1);
            this.typografpage.Controls.Add(this.textBox1);
            this.typografpage.Controls.Add(this.typograflabel);
            this.typografpage.Location = new System.Drawing.Point(4, 29);
            this.typografpage.Name = "typografpage";
            this.typografpage.Padding = new System.Windows.Forms.Padding(3);
            this.typografpage.Size = new System.Drawing.Size(1910, 966);
            this.typografpage.TabIndex = 0;
            this.typografpage.Text = "Типограф";
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(1032, 841);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(304, 61);
            this.buttonsave.TabIndex = 3;
            this.buttonsave.Text = "Сохранить ";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 841);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отипогрфировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1752, 654);
            this.textBox1.TabIndex = 1;
            // 
            // typograflabel
            // 
            this.typograflabel.AutoSize = true;
            this.typograflabel.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typograflabel.Location = new System.Drawing.Point(648, 36);
            this.typograflabel.Name = "typograflabel";
            this.typograflabel.Size = new System.Drawing.Size(480, 56);
            this.typograflabel.TabIndex = 0;
            this.typograflabel.Text = "Типограф";
            this.typograflabel.Click += new System.EventHandler(this.typograflabel_Click);
            // 
            // propertiespage
            // 
            this.propertiespage.BackgroundImage = global::Typograf.Properties.Resources._1613395175_156_p_bezhevii_fon_odnotonnii_estetika_174;
            this.propertiespage.Controls.Add(this.button9);
            this.propertiespage.Controls.Add(this.label7pravil);
            this.propertiespage.Controls.Add(this.button6);
            this.propertiespage.Controls.Add(this.label6pravil);
            this.propertiespage.Controls.Add(this.button7);
            this.propertiespage.Controls.Add(this.label5pravil);
            this.propertiespage.Controls.Add(this.button8);
            this.propertiespage.Controls.Add(this.label4pravil);
            this.propertiespage.Controls.Add(this.button5);
            this.propertiespage.Controls.Add(this.label3pravil);
            this.propertiespage.Controls.Add(this.button4);
            this.propertiespage.Controls.Add(this.label2pravil);
            this.propertiespage.Controls.Add(this.label3);
            this.propertiespage.Controls.Add(this.button3);
            this.propertiespage.Controls.Add(this.label1pravil);
            this.propertiespage.Location = new System.Drawing.Point(4, 29);
            this.propertiespage.Name = "propertiespage";
            this.propertiespage.Padding = new System.Windows.Forms.Padding(3);
            this.propertiespage.Size = new System.Drawing.Size(1910, 966);
            this.propertiespage.TabIndex = 1;
            this.propertiespage.Text = "Настройки";
            this.propertiespage.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(36, 614);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 47);
            this.button9.TabIndex = 14;
            this.button9.Text = "\", ...\"";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label7pravil
            // 
            this.label7pravil.AutoSize = true;
            this.label7pravil.Location = new System.Drawing.Point(224, 627);
            this.label7pravil.Name = "label7pravil";
            this.label7pravil.Size = new System.Drawing.Size(223, 20);
            this.label7pravil.TabIndex = 13;
            this.label7pravil.Text = "правило знаков препинания";
            this.label7pravil.Click += new System.EventHandler(this.label7pravil_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(36, 526);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 47);
            this.button6.TabIndex = 12;
            this.button6.Text = "\", ...\"";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6pravil
            // 
            this.label6pravil.AutoSize = true;
            this.label6pravil.Location = new System.Drawing.Point(224, 539);
            this.label6pravil.Name = "label6pravil";
            this.label6pravil.Size = new System.Drawing.Size(223, 20);
            this.label6pravil.TabIndex = 11;
            this.label6pravil.Text = "правило знаков препинания";
            this.label6pravil.Click += new System.EventHandler(this.label6pravil_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(36, 433);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 47);
            this.button7.TabIndex = 10;
            this.button7.Text = "\", ...\"";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5pravil
            // 
            this.label5pravil.AutoSize = true;
            this.label5pravil.Location = new System.Drawing.Point(224, 446);
            this.label5pravil.Name = "label5pravil";
            this.label5pravil.Size = new System.Drawing.Size(223, 20);
            this.label5pravil.TabIndex = 9;
            this.label5pravil.Text = "правило знаков препинания";
            this.label5pravil.Click += new System.EventHandler(this.label5pravil_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(36, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "\", ...\"";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label4pravil
            // 
            this.label4pravil.AutoSize = true;
            this.label4pravil.Location = new System.Drawing.Point(224, 352);
            this.label4pravil.Name = "label4pravil";
            this.label4pravil.Size = new System.Drawing.Size(223, 20);
            this.label4pravil.TabIndex = 7;
            this.label4pravil.Text = "правило знаков препинания";
            this.label4pravil.Click += new System.EventHandler(this.label4pravil_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "\", ...\"";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3pravil
            // 
            this.label3pravil.AutoSize = true;
            this.label3pravil.Location = new System.Drawing.Point(224, 256);
            this.label3pravil.Name = "label3pravil";
            this.label3pravil.Size = new System.Drawing.Size(223, 20);
            this.label3pravil.TabIndex = 5;
            this.label3pravil.Text = "правило знаков препинания";
            this.label3pravil.Click += new System.EventHandler(this.label3pravil_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "\", ...\"";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2pravil
            // 
            this.label2pravil.AutoSize = true;
            this.label2pravil.Location = new System.Drawing.Point(224, 163);
            this.label2pravil.Name = "label2pravil";
            this.label2pravil.Size = new System.Drawing.Size(223, 20);
            this.label2pravil.TabIndex = 3;
            this.label2pravil.Text = "правило знаков препинания";
            this.label2pravil.Click += new System.EventHandler(this.label2pravil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Свойства настроек:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 47);
            this.button3.TabIndex = 1;
            this.button3.Text = "\", ...\"";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1pravil
            // 
            this.label1pravil.AutoSize = true;
            this.label1pravil.Location = new System.Drawing.Point(224, 69);
            this.label1pravil.Name = "label1pravil";
            this.label1pravil.Size = new System.Drawing.Size(223, 20);
            this.label1pravil.TabIndex = 0;
            this.label1pravil.Text = "правило знаков препинания";
            this.label1pravil.Click += new System.EventHandler(this.label1pravil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7pravil;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6pravil;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5pravil;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4pravil;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3pravil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2pravil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1pravil;
    }
}

