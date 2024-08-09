namespace Mood_Food_Project
{
    partial class Rating_Suggestion_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating_Suggestion_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewFoods = new System.Windows.Forms.DataGridView();
            this.textBoxPortionSize = new System.Windows.Forms.TextBox();
            this.comboBoxTiming = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAfterRating = new System.Windows.Forms.ComboBox();
            this.comboBoxBeforeRating = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSelectFood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAllergy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfFood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recommendationLabel = new System.Windows.Forms.Label();
            this.comboBoxCurrentMood = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Mood_Food_Project.Properties.Resources.Tab_Control_Background_1;
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridViewFoods);
            this.tabPage1.Controls.Add(this.textBoxPortionSize);
            this.tabPage1.Controls.Add(this.comboBoxTiming);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBoxAfterRating);
            this.tabPage1.Controls.Add(this.comboBoxBeforeRating);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxSelectFood);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxAllergy);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxTypeOfFood);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rating";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(255, 363);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(208, 45);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add the food";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(93, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "(Plate)";
            // 
            // dataGridViewFoods
            // 
            this.dataGridViewFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoods.Location = new System.Drawing.Point(505, 12);
            this.dataGridViewFoods.Name = "dataGridViewFoods";
            this.dataGridViewFoods.RowHeadersWidth = 51;
            this.dataGridViewFoods.RowTemplate.Height = 24;
            this.dataGridViewFoods.Size = new System.Drawing.Size(520, 205);
            this.dataGridViewFoods.TabIndex = 17;
            // 
            // textBoxPortionSize
            // 
            this.textBoxPortionSize.Enabled = false;
            this.textBoxPortionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPortionSize.Location = new System.Drawing.Point(255, 159);
            this.textBoxPortionSize.Name = "textBoxPortionSize";
            this.textBoxPortionSize.Size = new System.Drawing.Size(208, 30);
            this.textBoxPortionSize.TabIndex = 7;
            // 
            // comboBoxTiming
            // 
            this.comboBoxTiming.Enabled = false;
            this.comboBoxTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTiming.FormattingEnabled = true;
            this.comboBoxTiming.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening",
            "Night"});
            this.comboBoxTiming.Location = new System.Drawing.Point(255, 212);
            this.comboBoxTiming.Name = "comboBoxTiming";
            this.comboBoxTiming.Size = new System.Drawing.Size(208, 33);
            this.comboBoxTiming.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Timing";
            // 
            // comboBoxAfterRating
            // 
            this.comboBoxAfterRating.Enabled = false;
            this.comboBoxAfterRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAfterRating.FormattingEnabled = true;
            this.comboBoxAfterRating.Items.AddRange(new object[] {
            "😫 - 1",
            "😣 - 2",
            "☹ - 3",
            "😞 - 4",
            "😒 - 5",
            "🙂 - 6",
            "😊 - 7",
            "😎 - 8",
            "😃 - 9",
            "😆 - 10"});
            this.comboBoxAfterRating.Location = new System.Drawing.Point(255, 313);
            this.comboBoxAfterRating.Name = "comboBoxAfterRating";
            this.comboBoxAfterRating.Size = new System.Drawing.Size(208, 33);
            this.comboBoxAfterRating.TabIndex = 13;
            // 
            // comboBoxBeforeRating
            // 
            this.comboBoxBeforeRating.Enabled = false;
            this.comboBoxBeforeRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBeforeRating.FormattingEnabled = true;
            this.comboBoxBeforeRating.Items.AddRange(new object[] {
            "😫 - 1",
            "😣 - 2",
            "☹ - 3",
            "😞 - 4",
            "😒 - 5",
            "🙂 - 6",
            "😊 - 7",
            "😎 - 8",
            "😃 - 9 ",
            "😆 -10"});
            this.comboBoxBeforeRating.Location = new System.Drawing.Point(255, 264);
            this.comboBoxBeforeRating.Name = "comboBoxBeforeRating";
            this.comboBoxBeforeRating.Size = new System.Drawing.Size(208, 33);
            this.comboBoxBeforeRating.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rate the food (After)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rate the food (Before)";
            // 
            // comboBoxSelectFood
            // 
            this.comboBoxSelectFood.Enabled = false;
            this.comboBoxSelectFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectFood.FormattingEnabled = true;
            this.comboBoxSelectFood.Location = new System.Drawing.Point(255, 115);
            this.comboBoxSelectFood.Name = "comboBoxSelectFood";
            this.comboBoxSelectFood.Size = new System.Drawing.Size(208, 33);
            this.comboBoxSelectFood.TabIndex = 5;
            this.comboBoxSelectFood.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFood_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Food";
            // 
            // comboBoxAllergy
            // 
            this.comboBoxAllergy.Enabled = false;
            this.comboBoxAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAllergy.FormattingEnabled = true;
            this.comboBoxAllergy.Location = new System.Drawing.Point(255, 62);
            this.comboBoxAllergy.Name = "comboBoxAllergy";
            this.comboBoxAllergy.Size = new System.Drawing.Size(208, 33);
            this.comboBoxAllergy.TabIndex = 3;
            this.comboBoxAllergy.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllergy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Allergy";
            // 
            // comboBoxTypeOfFood
            // 
            this.comboBoxTypeOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeOfFood.FormattingEnabled = true;
            this.comboBoxTypeOfFood.Items.AddRange(new object[] {
            "Indian",
            "Mexican",
            "American"});
            this.comboBoxTypeOfFood.Location = new System.Drawing.Point(255, 12);
            this.comboBoxTypeOfFood.Name = "comboBoxTypeOfFood";
            this.comboBoxTypeOfFood.Size = new System.Drawing.Size(208, 33);
            this.comboBoxTypeOfFood.TabIndex = 1;
            this.comboBoxTypeOfFood.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfFood_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Food";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(91, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Portion Size";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.recommendationLabel);
            this.tabPage2.Controls.Add(this.comboBoxCurrentMood);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suggestion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 57);
            this.button1.TabIndex = 17;
            this.button1.Text = "Suggestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSuggestion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(433, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 418);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // recommendationLabel
            // 
            this.recommendationLabel.AutoSize = true;
            this.recommendationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationLabel.Location = new System.Drawing.Point(41, 203);
            this.recommendationLabel.Name = "recommendationLabel";
            this.recommendationLabel.Size = new System.Drawing.Size(111, 25);
            this.recommendationLabel.TabIndex = 18;
            this.recommendationLabel.Text = "Suggestion";
            // 
            // comboBoxCurrentMood
            // 
            this.comboBoxCurrentMood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentMood.FormattingEnabled = true;
            this.comboBoxCurrentMood.Items.AddRange(new object[] {
            "😫 - 1",
            "😣 - 2",
            "☹ - 3",
            "😞 - 4",
            "😒 - 5",
            "🙂 - 6",
            "😊 - 7",
            "😎 - 8",
            "😃 - 9 ",
            "😆 -10"});
            this.comboBoxCurrentMood.Location = new System.Drawing.Point(213, 41);
            this.comboBoxCurrentMood.Name = "comboBoxCurrentMood";
            this.comboBoxCurrentMood.Size = new System.Drawing.Size(208, 33);
            this.comboBoxCurrentMood.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Current Mood";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(855, 486);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 45);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Rating_Suggestion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mood_Food_Project.Properties.Resources.Background_Image;
            this.ClientSize = new System.Drawing.Size(1130, 543);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rating_Suggestion_Form";
            this.Text = "Rating Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeOfFood;
        private System.Windows.Forms.ComboBox comboBoxAllergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAfterRating;
        private System.Windows.Forms.ComboBox comboBoxBeforeRating;
        private System.Windows.Forms.ComboBox comboBoxTiming;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPortionSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewFoods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCurrentMood;
        private System.Windows.Forms.Label recommendationLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

