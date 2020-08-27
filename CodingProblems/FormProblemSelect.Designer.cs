namespace CodingProblems
{
    partial class FormProblemSelect
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
            this.listBoxProblems = new System.Windows.Forms.ListBox();
            this.buttonLaunchProblem = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxProblems
            // 
            this.listBoxProblems.FormattingEnabled = true;
            this.listBoxProblems.ItemHeight = 29;
            this.listBoxProblems.Location = new System.Drawing.Point(12, 100);
            this.listBoxProblems.Name = "listBoxProblems";
            this.listBoxProblems.Size = new System.Drawing.Size(331, 526);
            this.listBoxProblems.TabIndex = 0;
            // 
            // buttonLaunchProblem
            // 
            this.buttonLaunchProblem.Location = new System.Drawing.Point(12, 12);
            this.buttonLaunchProblem.Name = "buttonLaunchProblem";
            this.buttonLaunchProblem.Size = new System.Drawing.Size(331, 82);
            this.buttonLaunchProblem.TabIndex = 1;
            this.buttonLaunchProblem.Text = "Launch";
            this.buttonLaunchProblem.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(349, 12);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(725, 618);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "";
            // 
            // FormProblemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 642);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonLaunchProblem);
            this.Controls.Add(this.listBoxProblems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormProblemSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodingProblems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProblems;
        private System.Windows.Forms.Button buttonLaunchProblem;
        private System.Windows.Forms.RichTextBox textBoxDescription;
    }
}

