
namespace MarsRoverProblem
{
    partial class MarsRover
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
            this.label_input1 = new System.Windows.Forms.Label();
            this.label_input2 = new System.Windows.Forms.Label();
            this.label_input3 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.buttonTestCase = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_input1
            // 
            this.label_input1.AutoSize = true;
            this.label_input1.Location = new System.Drawing.Point(141, 46);
            this.label_input1.Name = "label_input1";
            this.label_input1.Size = new System.Drawing.Size(66, 15);
            this.label_input1.TabIndex = 0;
            this.label_input1.Text = "Max Points";
            // 
            // label_input2
            // 
            this.label_input2.AutoSize = true;
            this.label_input2.Location = new System.Drawing.Point(330, 46);
            this.label_input2.Name = "label_input2";
            this.label_input2.Size = new System.Drawing.Size(82, 15);
            this.label_input2.TabIndex = 1;
            this.label_input2.Text = "Start Positions";
            // 
            // label_input3
            // 
            this.label_input3.AutoSize = true;
            this.label_input3.Location = new System.Drawing.Point(558, 46);
            this.label_input3.Name = "label_input3";
            this.label_input3.Size = new System.Drawing.Size(42, 15);
            this.label_input3.TabIndex = 2;
            this.label_input3.Text = "Moves";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(121, 79);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(107, 23);
            this.input1.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(321, 79);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(104, 23);
            this.input2.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(530, 79);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(101, 23);
            this.input3.TabIndex = 5;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(202, 309);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(326, 23);
            this.output.TabIndex = 6;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_output.Location = new System.Drawing.Point(330, 272);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(69, 21);
            this.label_output.TabIndex = 7;
            this.label_output.Text = "OUTPUT";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(292, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(151, 47);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "CHECK";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // buttonTestCase
            // 
            this.buttonTestCase.Location = new System.Drawing.Point(12, 12);
            this.buttonTestCase.Name = "buttonTestCase";
            this.buttonTestCase.Size = new System.Drawing.Size(75, 23);
            this.buttonTestCase.TabIndex = 9;
            this.buttonTestCase.Text = "Test Cases";
            this.buttonTestCase.UseVisualStyleBackColor = true;
            this.buttonTestCase.Click += new System.EventHandler(this.buttonTestCase_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Option 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Option 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "LMLMLMLMM";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "1 2 N";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "5 5";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "MMRMMRMRRM";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "3 3 E";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "5 5";
            this.label6.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(663, 79);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(62, 24);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MarsRover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 447);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonTestCase);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label_input3);
            this.Controls.Add(this.label_input2);
            this.Controls.Add(this.label_input1);
            this.Name = "MarsRover";
            this.Text = "MarsRover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_input1;
        private System.Windows.Forms.Label label_input2;
        private System.Windows.Forms.Label label_input3;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox np;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Button buttonTestCase;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClear;
    }
}

