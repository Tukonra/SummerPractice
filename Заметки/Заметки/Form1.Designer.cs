namespace Заметки
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notes_list = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_txt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notes_list)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 257);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Что хотите записать?";
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выполнил Мельков Тимофей";
            // 
            // notes_list
            // 
            this.notes_list.AllowUserToAddRows = false;
            this.notes_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notes_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.notes_list.Location = new System.Drawing.Point(418, 90);
            this.notes_list.Name = "notes_list";
            this.notes_list.RowHeadersVisible = false;
            this.notes_list.Size = new System.Drawing.Size(156, 179);
            this.notes_list.TabIndex = 6;
            this.notes_list.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.notes_list_RowsRemoved);
            this.notes_list.SelectionChanged += new System.EventHandler(this.notes_list_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Название заметки";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 155;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.new_note_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Напомнить об этой заметке через:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "(секунд)";
            // 
            // timer_txt
            // 
            this.timer_txt.Location = new System.Drawing.Point(196, 272);
            this.timer_txt.Name = "timer_txt";
            this.timer_txt.Size = new System.Drawing.Size(65, 20);
            this.timer_txt.TabIndex = 10;
            this.timer_txt.TextChanged += new System.EventHandler(this.timer_txt_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Новая заметка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(582, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timer_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.notes_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Приложение \"Заметки\"";
            ((System.ComponentModel.ISupportInitialize)(this.notes_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView notes_list;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timer_txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

