namespace task5graphics
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.red = new System.Windows.Forms.CheckBox();
            this.blue = new System.Windows.Forms.CheckBox();
            this.black = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sX = new System.Windows.Forms.Label();
            this.sY = new System.Windows.Forms.Label();
            this.sColor = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.sA = new System.Windows.Forms.Label();
            this.sB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sNodes = new System.Windows.Forms.Label();
            this.sArcs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changeA = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // create
            // 
            this.create.AutoSize = true;
            this.create.Location = new System.Drawing.Point(955, 196);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(82, 21);
            this.create.TabIndex = 2;
            this.create.Text = "создать";
            this.create.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(956, 24);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(86, 21);
            this.red.TabIndex = 4;
            this.red.Text = "красный";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(956, 51);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(69, 21);
            this.blue.TabIndex = 5;
            this.blue.Text = "синий";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(956, 78);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(80, 21);
            this.black.TabIndex = 6;
            this.black.Text = "чёрный";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "соеденить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sX
            // 
            this.sX.AutoSize = true;
            this.sX.Location = new System.Drawing.Point(955, 265);
            this.sX.Name = "sX";
            this.sX.Size = new System.Drawing.Size(14, 17);
            this.sX.TabIndex = 8;
            this.sX.Text = "x";
            // 
            // sY
            // 
            this.sY.AutoSize = true;
            this.sY.Location = new System.Drawing.Point(955, 282);
            this.sY.Name = "sY";
            this.sY.Size = new System.Drawing.Size(15, 17);
            this.sY.TabIndex = 9;
            this.sY.Text = "y";
            // 
            // sColor
            // 
            this.sColor.AutoSize = true;
            this.sColor.Location = new System.Drawing.Point(955, 299);
            this.sColor.Name = "sColor";
            this.sColor.Size = new System.Drawing.Size(39, 17);
            this.sColor.TabIndex = 10;
            this.sColor.Text = "color";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(927, 319);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(137, 23);
            this.change.TabIndex = 11;
            this.change.Text = "изменить узел";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // sA
            // 
            this.sA.AutoSize = true;
            this.sA.Location = new System.Drawing.Point(1019, 265);
            this.sA.Name = "sA";
            this.sA.Size = new System.Drawing.Size(17, 17);
            this.sA.TabIndex = 12;
            this.sA.Text = "A";
            // 
            // sB
            // 
            this.sB.AutoSize = true;
            this.sB.Location = new System.Drawing.Point(1020, 282);
            this.sB.Name = "sB";
            this.sB.Size = new System.Drawing.Size(17, 17);
            this.sB.TabIndex = 13;
            this.sB.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "x =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "= IndexA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1045, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "= IndexB";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(927, 348);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(137, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "удалить узел";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "сбросить выбор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sNodes
            // 
            this.sNodes.AutoSize = true;
            this.sNodes.Location = new System.Drawing.Point(943, 418);
            this.sNodes.Name = "sNodes";
            this.sNodes.Size = new System.Drawing.Size(17, 17);
            this.sNodes.TabIndex = 20;
            this.sNodes.Text = "A";
            // 
            // sArcs
            // 
            this.sArcs.AutoSize = true;
            this.sArcs.Location = new System.Drawing.Point(943, 435);
            this.sArcs.Name = "sArcs";
            this.sArcs.Size = new System.Drawing.Size(17, 17);
            this.sArcs.TabIndex = 21;
            this.sArcs.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "nodes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(966, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "arcs";
            // 
            // changeA
            // 
            this.changeA.Location = new System.Drawing.Point(927, 377);
            this.changeA.Name = "changeA";
            this.changeA.Size = new System.Drawing.Size(137, 23);
            this.changeA.TabIndex = 24;
            this.changeA.Text = "изменить дугу";
            this.changeA.UseVisualStyleBackColor = true;
            this.changeA.Click += new System.EventHandler(this.changeA_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1026, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "разъеденить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1144, 574);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.changeA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sArcs);
            this.Controls.Add(this.sNodes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sB);
            this.Controls.Add(this.sA);
            this.Controls.Add(this.change);
            this.Controls.Add(this.sColor);
            this.Controls.Add(this.sY);
            this.Controls.Add(this.sX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.black);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.create);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox create;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox red;
        private System.Windows.Forms.CheckBox blue;
        private System.Windows.Forms.CheckBox black;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sX;
        private System.Windows.Forms.Label sY;
        private System.Windows.Forms.Label sColor;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label sA;
        private System.Windows.Forms.Label sB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sNodes;
        private System.Windows.Forms.Label sArcs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeA;
        private System.Windows.Forms.Button button3;
    }
}

