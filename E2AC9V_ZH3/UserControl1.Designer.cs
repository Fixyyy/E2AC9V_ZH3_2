namespace E2AC9V_ZH3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StudentTextbox = new System.Windows.Forms.TextBox();
            this.StudentListbox = new System.Windows.Forms.ListBox();
            this.RendelesListbox = new System.Windows.Forms.ListBox();
            this.KonyvekListbox = new System.Windows.Forms.ListBox();
            this.KonyvekTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TeteldarabTextbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentTextbox
            // 
            this.StudentTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentTextbox.Location = new System.Drawing.Point(47, 42);
            this.StudentTextbox.Name = "StudentTextbox";
            this.StudentTextbox.Size = new System.Drawing.Size(134, 23);
            this.StudentTextbox.TabIndex = 0;
            this.StudentTextbox.TextChanged += new System.EventHandler(this.StudentTextbox_TextChanged);
            // 
            // StudentListbox
            // 
            this.StudentListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentListbox.FormattingEnabled = true;
            this.StudentListbox.ItemHeight = 15;
            this.StudentListbox.Location = new System.Drawing.Point(47, 100);
            this.StudentListbox.Name = "StudentListbox";
            this.StudentListbox.Size = new System.Drawing.Size(236, 409);
            this.StudentListbox.TabIndex = 1;
            this.StudentListbox.SelectedIndexChanged += new System.EventHandler(this.StudentListbox_SelectedIndexChanged);
            // 
            // RendelesListbox
            // 
            this.RendelesListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RendelesListbox.FormattingEnabled = true;
            this.RendelesListbox.ItemHeight = 15;
            this.RendelesListbox.Location = new System.Drawing.Point(388, 100);
            this.RendelesListbox.Name = "RendelesListbox";
            this.RendelesListbox.Size = new System.Drawing.Size(265, 409);
            this.RendelesListbox.TabIndex = 2;
            // 
            // KonyvekListbox
            // 
            this.KonyvekListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KonyvekListbox.FormattingEnabled = true;
            this.KonyvekListbox.ItemHeight = 15;
            this.KonyvekListbox.Location = new System.Drawing.Point(803, 100);
            this.KonyvekListbox.Name = "KonyvekListbox";
            this.KonyvekListbox.Size = new System.Drawing.Size(291, 409);
            this.KonyvekListbox.TabIndex = 3;
            this.KonyvekListbox.SelectedIndexChanged += new System.EventHandler(this.KonyvekListbox_SelectedIndexChanged);
            // 
            // KonyvekTextbox
            // 
            this.KonyvekTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KonyvekTextbox.Location = new System.Drawing.Point(960, 42);
            this.KonyvekTextbox.Name = "KonyvekTextbox";
            this.KonyvekTextbox.Size = new System.Drawing.Size(134, 23);
            this.KonyvekTextbox.TabIndex = 4;
            this.KonyvekTextbox.TextChanged += new System.EventHandler(this.KonyvekTextbox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(673, 228);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Tétel hozzáadás";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(673, 288);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Tétel törlése";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TeteldarabTextbox
            // 
            this.TeteldarabTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeteldarabTextbox.Location = new System.Drawing.Point(676, 177);
            this.TeteldarabTextbox.Name = "TeteldarabTextbox";
            this.TeteldarabTextbox.Size = new System.Drawing.Size(100, 23);
            this.TeteldarabTextbox.TabIndex = 7;
            this.TeteldarabTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.TeteldarabTextbox_Validating);
            this.TeteldarabTextbox.Validated += new System.EventHandler(this.TeteldarabTextbox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hozzáadandó mennyiség:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Keresés diákra:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(971, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Keresés könyv címére:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeteldarabTextbox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.KonyvekTextbox);
            this.Controls.Add(this.KonyvekListbox);
            this.Controls.Add(this.RendelesListbox);
            this.Controls.Add(this.StudentListbox);
            this.Controls.Add(this.StudentTextbox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1133, 617);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StudentTextbox;
        private ListBox StudentListbox;
        private ListBox RendelesListbox;
        private ListBox KonyvekListbox;
        private TextBox KonyvekTextbox;
        private Button AddButton;
        private Button DeleteButton;
        private TextBox TeteldarabTextbox;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
