namespace Part_7_Assignment
{
    partial class Part7Lists
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
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblNumberRemove = new System.Windows.Forms.Label();
            this.lblHeroAdd = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHeroRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnHeroAdd = new System.Windows.Forms.Button();
            this.btnHeroRemove = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(12, 48);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(111, 52);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(143, 48);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(111, 52);
            this.btnSortNumbers.TabIndex = 1;
            this.btnSortNumbers.Text = "Ascending sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHeroes.Location = new System.Drawing.Point(458, 48);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(111, 52);
            this.btnNewHeroes.TabIndex = 2;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.Location = new System.Drawing.Point(599, 48);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(111, 52);
            this.btnSortHeroes.TabIndex = 3;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(12, 9);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(98, 25);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(453, 9);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(81, 25);
            this.lblHeroes.TabIndex = 5;
            this.lblHeroes.Text = "Heroes";
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(12, 97);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(242, 173);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(458, 97);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(252, 173);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblNumberRemove
            // 
            this.lblNumberRemove.AutoSize = true;
            this.lblNumberRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRemove.Location = new System.Drawing.Point(15, 285);
            this.lblNumberRemove.Name = "lblNumberRemove";
            this.lblNumberRemove.Size = new System.Drawing.Size(269, 25);
            this.lblNumberRemove.TabIndex = 8;
            this.lblNumberRemove.Text = "Select a number to remove";
            // 
            // lblHeroAdd
            // 
            this.lblHeroAdd.AutoSize = true;
            this.lblHeroAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroAdd.Location = new System.Drawing.Point(456, 285);
            this.lblHeroAdd.Name = "lblHeroAdd";
            this.lblHeroAdd.Size = new System.Drawing.Size(255, 25);
            this.lblHeroAdd.TabIndex = 9;
            this.lblHeroAdd.Text = "Enter a hero name to add";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 404);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroRemove.Location = new System.Drawing.Point(453, 382);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(290, 25);
            this.lblHeroRemove.TabIndex = 11;
            this.lblHeroRemove.Text = "Enter a hero name to remove";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(20, 332);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 47);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(179, 332);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(147, 47);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnHeroAdd
            // 
            this.btnHeroAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeroAdd.Location = new System.Drawing.Point(668, 332);
            this.btnHeroAdd.Name = "btnHeroAdd";
            this.btnHeroAdd.Size = new System.Drawing.Size(120, 35);
            this.btnHeroAdd.TabIndex = 14;
            this.btnHeroAdd.Text = "Add";
            this.btnHeroAdd.UseVisualStyleBackColor = true;
            this.btnHeroAdd.Click += new System.EventHandler(this.btnHeroAdd_Click);
            // 
            // btnHeroRemove
            // 
            this.btnHeroRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeroRemove.Location = new System.Drawing.Point(668, 410);
            this.btnHeroRemove.Name = "btnHeroRemove";
            this.btnHeroRemove.Size = new System.Drawing.Size(120, 37);
            this.btnHeroRemove.TabIndex = 15;
            this.btnHeroRemove.Text = "Remove";
            this.btnHeroRemove.UseVisualStyleBackColor = true;
            this.btnHeroRemove.Click += new System.EventHandler(this.btnHeroRemove_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(534, 332);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(108, 20);
            this.txtAdd.TabIndex = 16;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(534, 410);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(108, 20);
            this.txtRemove.TabIndex = 17;
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDescending.Location = new System.Drawing.Point(143, -4);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(111, 52);
            this.btnSortDescending.TabIndex = 18;
            this.btnSortDescending.Text = "Descending sort";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Location = new System.Drawing.Point(540, 9);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(91, 23);
            this.btnLowerCase.TabIndex = 19;
            this.btnLowerCase.Text = "Lower case list";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.Location = new System.Drawing.Point(652, 9);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(91, 23);
            this.btnUpperCase.TabIndex = 20;
            this.btnUpperCase.Text = "Upper cas list";
            this.btnUpperCase.UseVisualStyleBackColor = true;
            this.btnUpperCase.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // Part7Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpperCase);
            this.Controls.Add(this.btnLowerCase);
            this.Controls.Add(this.btnSortDescending);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnHeroRemove);
            this.Controls.Add(this.btnHeroAdd);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblHeroRemove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHeroAdd);
            this.Controls.Add(this.lblNumberRemove);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Name = "Part7Lists";
            this.Text = "Part 7 Lists";
            this.Load += new System.EventHandler(this.Part7Lists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblNumberRemove;
        private System.Windows.Forms.Label lblHeroAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHeroRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnHeroAdd;
        private System.Windows.Forms.Button btnHeroRemove;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Button btnUpperCase;
    }
}

