namespace EasyDirectoryCreator
{
    partial class frmPrincipal
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblInstructionNewDirectory = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.tbLayoutLog = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblQuantityOk = new System.Windows.Forms.Label();
            this.lblQuantityNok = new System.Windows.Forms.Label();
            this.tbLayout.SuspendLayout();
            this.tbLayoutLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "[]"});
            this.txtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.Location = new System.Drawing.Point(247, 76);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(550, 321);
            this.txtBox.TabIndex = 5;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.Black;
            this.pnlLine2.Location = new System.Drawing.Point(244, 3);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(1, 34);
            this.pnlLine2.TabIndex = 4;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Black;
            this.tbLayout.SetColumnSpan(this.pnlLine, 3);
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine.Location = new System.Drawing.Point(0, 40);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(800, 3);
            this.pnlLine.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(0, 43);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(241, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblInstructionNewDirectory
            // 
            this.lblInstructionNewDirectory.AutoSize = true;
            this.lblInstructionNewDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructionNewDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInstructionNewDirectory.Location = new System.Drawing.Point(3, 0);
            this.lblInstructionNewDirectory.Name = "lblInstructionNewDirectory";
            this.lblInstructionNewDirectory.Size = new System.Drawing.Size(235, 40);
            this.lblInstructionNewDirectory.TabIndex = 0;
            this.lblInstructionNewDirectory.Text = "Selecione onde deseja criar a estrutura de pastas";
            this.lblInstructionNewDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDirectory.Location = new System.Drawing.Point(247, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(550, 40);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Diretório: ";
            this.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLayout
            // 
            this.tbLayout.ColumnCount = 3;
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.23839F));
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.7616F));
            this.tbLayout.Controls.Add(this.lblDirectory, 2, 0);
            this.tbLayout.Controls.Add(this.lblInstructionNewDirectory, 0, 0);
            this.tbLayout.Controls.Add(this.btnSelect, 0, 2);
            this.tbLayout.Controls.Add(this.pnlLine, 0, 1);
            this.tbLayout.Controls.Add(this.pnlLine2, 1, 0);
            this.tbLayout.Controls.Add(this.txtBox, 2, 3);
            this.tbLayout.Controls.Add(this.btnCreate, 2, 4);
            this.tbLayout.Controls.Add(this.txtBoxLog, 0, 3);
            this.tbLayout.Controls.Add(this.tbLayoutLog, 0, 4);
            this.tbLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayout.Location = new System.Drawing.Point(0, 0);
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.RowCount = 5;
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbLayout.Size = new System.Drawing.Size(800, 450);
            this.tbLayout.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(648, 403);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 44);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Criar estrutura";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.BackColor = System.Drawing.Color.White;
            this.txtBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxLog.Location = new System.Drawing.Point(0, 73);
            this.txtBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxLog.Multiline = true;
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.ReadOnly = true;
            this.txtBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxLog.Size = new System.Drawing.Size(241, 327);
            this.txtBoxLog.TabIndex = 7;
            // 
            // tbLayoutLog
            // 
            this.tbLayoutLog.ColumnCount = 2;
            this.tbLayoutLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutLog.Controls.Add(this.lblQuantityNok, 1, 1);
            this.tbLayoutLog.Controls.Add(this.btnClearLog, 0, 0);
            this.tbLayoutLog.Controls.Add(this.lblQuantityOk, 1, 0);
            this.tbLayoutLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutLog.Location = new System.Drawing.Point(3, 403);
            this.tbLayoutLog.Name = "tbLayoutLog";
            this.tbLayoutLog.RowCount = 2;
            this.tbLayoutLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutLog.Size = new System.Drawing.Size(235, 44);
            this.tbLayoutLog.TabIndex = 8;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearLog.Location = new System.Drawing.Point(0, 0);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearLog.Name = "btnClearLog";
            this.tbLayoutLog.SetRowSpan(this.btnClearLog, 2);
            this.btnClearLog.Size = new System.Drawing.Size(117, 44);
            this.btnClearLog.TabIndex = 9;
            this.btnClearLog.Text = "Limpar Logs";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuantityOk
            // 
            this.lblQuantityOk.AutoSize = true;
            this.lblQuantityOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantityOk.Location = new System.Drawing.Point(120, 0);
            this.lblQuantityOk.Name = "lblQuantityOk";
            this.lblQuantityOk.Size = new System.Drawing.Size(112, 22);
            this.lblQuantityOk.TabIndex = 10;
            this.lblQuantityOk.Text = "OK: ";
            this.lblQuantityOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantityNok
            // 
            this.lblQuantityNok.AutoSize = true;
            this.lblQuantityNok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantityNok.Location = new System.Drawing.Point(120, 22);
            this.lblQuantityNok.Name = "lblQuantityNok";
            this.lblQuantityNok.Size = new System.Drawing.Size(112, 22);
            this.lblQuantityNok.TabIndex = 11;
            this.lblQuantityNok.Text = "Failed: ";
            this.lblQuantityNok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLayout);
            this.Name = "frmPrincipal";
            this.Text = "Easy Directory";
            this.tbLayout.ResumeLayout(false);
            this.tbLayout.PerformLayout();
            this.tbLayoutLog.ResumeLayout(false);
            this.tbLayoutLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.TableLayoutPanel tbLayout;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label lblInstructionNewDirectory;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBoxLog;
        private System.Windows.Forms.TableLayoutPanel tbLayoutLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label lblQuantityOk;
        private System.Windows.Forms.Label lblQuantityNok;
    }
}
