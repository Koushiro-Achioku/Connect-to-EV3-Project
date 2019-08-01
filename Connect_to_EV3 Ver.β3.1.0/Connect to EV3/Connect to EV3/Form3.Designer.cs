namespace Connect_to_EV3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_up = new System.Windows.Forms.Button();
            this.button_center = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port A + Port D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Power :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(233, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 19);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // button_up
            // 
            this.button_up.Image = global::Connect_to_EV3.Properties.Resources.up;
            this.button_up.Location = new System.Drawing.Point(68, 13);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(50, 50);
            this.button_up.TabIndex = 0;
            this.button_up.UseVisualStyleBackColor = true;
            // 
            // button_center
            // 
            this.button_center.Image = global::Connect_to_EV3.Properties.Resources.center;
            this.button_center.Location = new System.Drawing.Point(68, 69);
            this.button_center.Name = "button_center";
            this.button_center.Size = new System.Drawing.Size(50, 50);
            this.button_center.TabIndex = 1;
            this.button_center.UseVisualStyleBackColor = true;
            // 
            // button_left
            // 
            this.button_left.Image = global::Connect_to_EV3.Properties.Resources.left;
            this.button_left.Location = new System.Drawing.Point(12, 69);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(50, 50);
            this.button_left.TabIndex = 2;
            this.button_left.UseVisualStyleBackColor = true;
            // 
            // button_down
            // 
            this.button_down.Image = global::Connect_to_EV3.Properties.Resources.down;
            this.button_down.Location = new System.Drawing.Point(68, 125);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(50, 50);
            this.button_down.TabIndex = 3;
            this.button_down.UseVisualStyleBackColor = true;
            // 
            // button_right
            // 
            this.button_right.Image = global::Connect_to_EV3.Properties.Resources.right;
            this.button_right.Location = new System.Drawing.Point(124, 69);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(50, 50);
            this.button_right.TabIndex = 4;
            this.button_right.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 189);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_center);
            this.Controls.Add(this.button_up);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Radio Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form3_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_center;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_right;
    }
}