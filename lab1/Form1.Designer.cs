namespace lab1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.lFloorCount = new System.Windows.Forms.Label();
            this.tbFloorCount = new System.Windows.Forms.TextBox();
            this.tbFloorArea = new System.Windows.Forms.TextBox();
            this.lFloorArea = new System.Windows.Forms.Label();
            this.tbPeopleCount = new System.Windows.Forms.TextBox();
            this.lPeopleCount = new System.Windows.Forms.Label();
            this.tbGardenArea = new System.Windows.Forms.TextBox();
            this.lGardenArea = new System.Windows.Forms.Label();
            this.lTypeOfBuilding = new System.Windows.Forms.Label();
            this.cbTypeOfBuilding = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToResizeColumns = false;
            this.dgView.AllowUserToResizeRows = false;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgView.GridColor = System.Drawing.Color.SteelBlue;
            this.dgView.Location = new System.Drawing.Point(12, 12);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersVisible = false;
            this.dgView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgView.Size = new System.Drawing.Size(468, 298);
            this.dgView.TabIndex = 0;
            // 
            // lFloorCount
            // 
            this.lFloorCount.AutoSize = true;
            this.lFloorCount.Location = new System.Drawing.Point(486, 31);
            this.lFloorCount.Name = "lFloorCount";
            this.lFloorCount.Size = new System.Drawing.Size(106, 13);
            this.lFloorCount.TabIndex = 1;
            this.lFloorCount.Text = "Количество этажей";
            // 
            // tbFloorCount
            // 
            this.tbFloorCount.Location = new System.Drawing.Point(619, 28);
            this.tbFloorCount.Name = "tbFloorCount";
            this.tbFloorCount.Size = new System.Drawing.Size(82, 20);
            this.tbFloorCount.TabIndex = 2;
            // 
            // tbFloorArea
            // 
            this.tbFloorArea.Location = new System.Drawing.Point(619, 54);
            this.tbFloorArea.Name = "tbFloorArea";
            this.tbFloorArea.Size = new System.Drawing.Size(82, 20);
            this.tbFloorArea.TabIndex = 4;
            // 
            // lFloorArea
            // 
            this.lFloorArea.AutoSize = true;
            this.lFloorArea.Location = new System.Drawing.Point(486, 57);
            this.lFloorArea.Name = "lFloorArea";
            this.lFloorArea.Size = new System.Drawing.Size(126, 13);
            this.lFloorArea.TabIndex = 3;
            this.lFloorArea.Text = "Площадь одного этажа";
            // 
            // tbPeopleCount
            // 
            this.tbPeopleCount.Location = new System.Drawing.Point(619, 80);
            this.tbPeopleCount.Name = "tbPeopleCount";
            this.tbPeopleCount.Size = new System.Drawing.Size(82, 20);
            this.tbPeopleCount.TabIndex = 6;
            // 
            // lPeopleCount
            // 
            this.lPeopleCount.AutoSize = true;
            this.lPeopleCount.Location = new System.Drawing.Point(486, 83);
            this.lPeopleCount.Name = "lPeopleCount";
            this.lPeopleCount.Size = new System.Drawing.Size(112, 13);
            this.lPeopleCount.TabIndex = 5;
            this.lPeopleCount.Text = "Количество жителей";
            // 
            // tbGardenArea
            // 
            this.tbGardenArea.Enabled = false;
            this.tbGardenArea.Location = new System.Drawing.Point(619, 106);
            this.tbGardenArea.Name = "tbGardenArea";
            this.tbGardenArea.Size = new System.Drawing.Size(82, 20);
            this.tbGardenArea.TabIndex = 8;
            // 
            // lGardenArea
            // 
            this.lGardenArea.AutoSize = true;
            this.lGardenArea.Enabled = false;
            this.lGardenArea.Location = new System.Drawing.Point(486, 109);
            this.lGardenArea.Name = "lGardenArea";
            this.lGardenArea.Size = new System.Drawing.Size(96, 13);
            this.lGardenArea.TabIndex = 7;
            this.lGardenArea.Text = "Площадь участка";
            // 
            // lTypeOfBuilding
            // 
            this.lTypeOfBuilding.AutoSize = true;
            this.lTypeOfBuilding.Location = new System.Drawing.Point(486, 157);
            this.lTypeOfBuilding.Name = "lTypeOfBuilding";
            this.lTypeOfBuilding.Size = new System.Drawing.Size(82, 13);
            this.lTypeOfBuilding.TabIndex = 9;
            this.lTypeOfBuilding.Text = "Тип постройки";
            // 
            // cbTypeOfBuilding
            // 
            this.cbTypeOfBuilding.FormattingEnabled = true;
            this.cbTypeOfBuilding.Items.AddRange(new object[] {
            "Коттедж",
            "Сад",
            "Гараж"});
            this.cbTypeOfBuilding.Location = new System.Drawing.Point(619, 154);
            this.cbTypeOfBuilding.Name = "cbTypeOfBuilding";
            this.cbTypeOfBuilding.Size = new System.Drawing.Size(82, 21);
            this.cbTypeOfBuilding.TabIndex = 10;
            this.cbTypeOfBuilding.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfBuilding_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Location = new System.Drawing.Point(567, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(489, 276);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(88, 23);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.cbSort.Location = new System.Drawing.Point(583, 278);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(126, 21);
            this.cbSort.TabIndex = 13;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Сортировка по общей площади";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTypeOfBuilding);
            this.Controls.Add(this.lTypeOfBuilding);
            this.Controls.Add(this.tbGardenArea);
            this.Controls.Add(this.lGardenArea);
            this.Controls.Add(this.tbPeopleCount);
            this.Controls.Add(this.lPeopleCount);
            this.Controls.Add(this.tbFloorArea);
            this.Controls.Add(this.lFloorArea);
            this.Controls.Add(this.tbFloorCount);
            this.Controls.Add(this.lFloorCount);
            this.Controls.Add(this.dgView);
            this.Name = "Form1";
            this.Text = "Строительство";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Label lFloorCount;
        private System.Windows.Forms.TextBox tbFloorCount;
        private System.Windows.Forms.TextBox tbFloorArea;
        private System.Windows.Forms.Label lFloorArea;
        private System.Windows.Forms.TextBox tbPeopleCount;
        private System.Windows.Forms.Label lPeopleCount;
        private System.Windows.Forms.TextBox tbGardenArea;
        private System.Windows.Forms.Label lGardenArea;
        private System.Windows.Forms.Label lTypeOfBuilding;
        private System.Windows.Forms.ComboBox cbTypeOfBuilding;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label1;
    }
}

