namespace Task5
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
            listBoxResults = new ListBox();
            btnBubbleSort = new Button();
            btnDescendingSort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(12, 12);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(506, 224);
            listBoxResults.TabIndex = 0;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(12, 248);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(250, 68);
            btnBubbleSort.TabIndex = 1;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnDescendingSort
            // 
            btnDescendingSort.Location = new Point(268, 248);
            btnDescendingSort.Name = "btnDescendingSort";
            btnDescendingSort.Size = new Size(250, 68);
            btnDescendingSort.TabIndex = 2;
            btnDescendingSort.Text = "Descending Sort";
            btnDescendingSort.UseVisualStyleBackColor = true;
            btnDescendingSort.Click += btnDescendingSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDescendingSort);
            Controls.Add(btnBubbleSort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnBubbleSort;
        private Button btnDescendingSort;
    }
}
