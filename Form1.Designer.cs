namespace UploadFiles
{
  partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.folderName = new System.Windows.Forms.TextBox();
      this.selectFiles = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.filesSelected = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.upload = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(27, 35);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(189, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nhập tên folder:";
      this.label1.Click += new System.EventHandler(this.selectFiles_Click);
      // 
      // folderName
      // 
      this.folderName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.folderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.folderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.folderName.Location = new System.Drawing.Point(220, 35);
      this.folderName.Margin = new System.Windows.Forms.Padding(5);
      this.folderName.Name = "folderName";
      this.folderName.Size = new System.Drawing.Size(795, 27);
      this.folderName.TabIndex = 1;
      // 
      // selectFiles
      // 
      this.selectFiles.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.selectFiles.Cursor = System.Windows.Forms.Cursors.Hand;
      this.selectFiles.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectFiles.ForeColor = System.Drawing.Color.DarkBlue;
      this.selectFiles.Location = new System.Drawing.Point(1025, 22);
      this.selectFiles.Margin = new System.Windows.Forms.Padding(5);
      this.selectFiles.Name = "selectFiles";
      this.selectFiles.Padding = new System.Windows.Forms.Padding(5);
      this.selectFiles.Size = new System.Drawing.Size(255, 50);
      this.selectFiles.TabIndex = 2;
      this.selectFiles.Text = "CHỌN TỆP";
      this.selectFiles.UseVisualStyleBackColor = false;
      this.selectFiles.Click += new System.EventHandler(this.selectFiles_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(27, 113);
      this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(188, 28);
      this.label2.TabIndex = 4;
      this.label2.Text = "Các tệp đã chọn:";
      this.label2.Click += new System.EventHandler(this.upload_Click);
      // 
      // filesSelected
      // 
      this.filesSelected.BackColor = System.Drawing.Color.WhiteSmoke;
      this.filesSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.filesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.filesSelected.Location = new System.Drawing.Point(27, 146);
      this.filesSelected.Margin = new System.Windows.Forms.Padding(5);
      this.filesSelected.Multiline = true;
      this.filesSelected.Name = "filesSelected";
      this.filesSelected.Size = new System.Drawing.Size(1253, 375);
      this.filesSelected.TabIndex = 6;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // upload
      // 
      this.upload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
      this.upload.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.upload.Location = new System.Drawing.Point(500, 554);
      this.upload.Margin = new System.Windows.Forms.Padding(5);
      this.upload.Name = "upload";
      this.upload.Size = new System.Drawing.Size(338, 66);
      this.upload.TabIndex = 7;
      this.upload.Text = "TẢI TỆP LÊN";
      this.upload.UseVisualStyleBackColor = true;
      this.upload.Click += new System.EventHandler(this.upload_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(1389, 634);
      this.Controls.Add(this.upload);
      this.Controls.Add(this.filesSelected);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.selectFiles);
      this.Controls.Add(this.folderName);
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.Text = "Upload files";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox folderName;
    private System.Windows.Forms.Button selectFiles;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox filesSelected;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button upload;
  }
}

