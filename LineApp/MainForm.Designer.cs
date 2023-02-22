
namespace LineApp
{
    partial class MainForm
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
            this.lineGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.onlyPositive = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lineGridView
            // 
            this.lineGridView.AllowUserToAddRows = false;
            this.lineGridView.AllowUserToDeleteRows = false;
            this.lineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineGridView.Location = new System.Drawing.Point(12, 12);
            this.lineGridView.Name = "lineGridView";
            this.lineGridView.ReadOnly = true;
            this.lineGridView.RowTemplate.Height = 25;
            this.lineGridView.Size = new System.Drawing.Size(776, 257);
            this.lineGridView.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Возрастание",
            "Убывание"});
            this.comboBox1.Location = new System.Drawing.Point(12, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // onlyPositive
            // 
            this.onlyPositive.Location = new System.Drawing.Point(12, 333);
            this.onlyPositive.Name = "onlyPositive";
            this.onlyPositive.Size = new System.Drawing.Size(89, 23);
            this.onlyPositive.TabIndex = 2;
            this.onlyPositive.Text = "Вывод \"+\"";
            this.toolTip1.SetToolTip(this.onlyPositive, "Отображает только отрезки с положительными кординатами");
            this.onlyPositive.UseVisualStyleBackColor = true;
            this.onlyPositive.Click += new System.EventHandler(this.onlyPositive_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 362);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(89, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Сброс";
            this.toolTip1.SetToolTip(this.resetButton, "Сбрасывает список в изначальное состояние");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 391);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(89, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Сортировка";
            this.toolTip1.SetToolTip(this.sortButton, "Сортирует отрезки по возрастанию координат, сначала по X1, потом X2, Y1, Y2");
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 275);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 23);
            this.searchBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.onlyPositive);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lineGridView);
            this.Name = "MainForm";
            this.Text = "LineApp";
            ((System.ComponentModel.ISupportInitialize)(this.lineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lineGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button onlyPositive;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown searchBox;
    }
}

