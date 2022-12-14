namespace E2AC9V_ZH3
{
    partial class UserControl2
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
            this.KonyvSzures = new System.Windows.Forms.TextBox();
            this.KonyvekLista = new System.Windows.Forms.ListBox();
            this.Konyvek = new System.Windows.Forms.DataGridView();
            this.textbookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Konyvek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KonyvSzures
            // 
            this.KonyvSzures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KonyvSzures.Location = new System.Drawing.Point(47, 55);
            this.KonyvSzures.Name = "KonyvSzures";
            this.KonyvSzures.Size = new System.Drawing.Size(148, 23);
            this.KonyvSzures.TabIndex = 0;
            this.KonyvSzures.TextChanged += new System.EventHandler(this.KonyvSzures_TextChanged);
            // 
            // KonyvekLista
            // 
            this.KonyvekLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KonyvekLista.FormattingEnabled = true;
            this.KonyvekLista.ItemHeight = 15;
            this.KonyvekLista.Location = new System.Drawing.Point(47, 112);
            this.KonyvekLista.Name = "KonyvekLista";
            this.KonyvekLista.Size = new System.Drawing.Size(148, 394);
            this.KonyvekLista.TabIndex = 1;
            this.KonyvekLista.SelectedIndexChanged += new System.EventHandler(this.KonyvekLista_SelectedIndexChanged);
            // 
            // Konyvek
            // 
            this.Konyvek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Konyvek.AutoGenerateColumns = false;
            this.Konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Konyvek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbookIdDataGridViewTextBoxColumn,
            this.stockNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.notAvailableDataGridViewCheckBoxColumn,
            this.ordersDataGridViewTextBoxColumn});
            this.Konyvek.DataSource = this.textbookBindingSource;
            this.Konyvek.Location = new System.Drawing.Point(304, 112);
            this.Konyvek.Name = "Konyvek";
            this.Konyvek.RowTemplate.Height = 25;
            this.Konyvek.Size = new System.Drawing.Size(654, 394);
            this.Konyvek.TabIndex = 2;
            // 
            // textbookIdDataGridViewTextBoxColumn
            // 
            this.textbookIdDataGridViewTextBoxColumn.DataPropertyName = "TextbookId";
            this.textbookIdDataGridViewTextBoxColumn.HeaderText = "TextbookId";
            this.textbookIdDataGridViewTextBoxColumn.Name = "textbookIdDataGridViewTextBoxColumn";
            // 
            // stockNumberDataGridViewTextBoxColumn
            // 
            this.stockNumberDataGridViewTextBoxColumn.DataPropertyName = "StockNumber";
            this.stockNumberDataGridViewTextBoxColumn.HeaderText = "StockNumber";
            this.stockNumberDataGridViewTextBoxColumn.Name = "stockNumberDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // notAvailableDataGridViewCheckBoxColumn
            // 
            this.notAvailableDataGridViewCheckBoxColumn.DataPropertyName = "NotAvailable";
            this.notAvailableDataGridViewCheckBoxColumn.HeaderText = "NotAvailable";
            this.notAvailableDataGridViewCheckBoxColumn.Name = "notAvailableDataGridViewCheckBoxColumn";
            this.notAvailableDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordersDataGridViewTextBoxColumn.Visible = false;
            // 
            // textbookBindingSource
            // 
            this.textbookBindingSource.DataSource = typeof(E2AC9V_ZH3.Models.Textbook);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keresés a könyv címére:";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Konyvek);
            this.Controls.Add(this.KonyvekLista);
            this.Controls.Add(this.KonyvSzures);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1080, 634);
            ((System.ComponentModel.ISupportInitialize)(this.Konyvek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox KonyvSzures;
        private ListBox KonyvekLista;
        private DataGridView Konyvek;
        private DataGridViewTextBoxColumn textbookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn notAvailableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private BindingSource textbookBindingSource;
        private Label label1;
    }
}
