namespace Black_Lotus_CSharp
{
    partial class Client
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button6 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuMetroTextbox_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_color = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox_tpNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox_qty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_addprod = new System.Windows.Forms.Button();
            this.button_updateprod = new System.Windows.Forms.Button();
            this.bunifuMetroTextbox_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(403, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "MANAGE CLIENTS";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(385, 157);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(711, 339);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            this.bunifuCustomDataGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomDataGrid1_MouseClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(136, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remove";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuMetroTextbox_id
            // 
            this.bunifuMetroTextbox_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_id.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_id.BorderThickness = 1;
            this.bunifuMetroTextbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_id.isPassword = false;
            this.bunifuMetroTextbox_id.Location = new System.Drawing.Point(115, 159);
            this.bunifuMetroTextbox_id.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_id.Name = "bunifuMetroTextbox_id";
            this.bunifuMetroTextbox_id.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_id.TabIndex = 17;
            this.bunifuMetroTextbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_id.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_id_OnValueChanged);
            // 
            // bunifuMetroTextbox_name
            // 
            this.bunifuMetroTextbox_name.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_name.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_name.BorderThickness = 1;
            this.bunifuMetroTextbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_name.isPassword = false;
            this.bunifuMetroTextbox_name.Location = new System.Drawing.Point(115, 209);
            this.bunifuMetroTextbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_name.Name = "bunifuMetroTextbox_name";
            this.bunifuMetroTextbox_name.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_name.TabIndex = 18;
            this.bunifuMetroTextbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox_color
            // 
            this.bunifuMetroTextbox_color.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_color.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_color.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_color.BorderThickness = 1;
            this.bunifuMetroTextbox_color.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_color.isPassword = false;
            this.bunifuMetroTextbox_color.Location = new System.Drawing.Point(115, 260);
            this.bunifuMetroTextbox_color.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_color.Name = "bunifuMetroTextbox_color";
            this.bunifuMetroTextbox_color.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_color.TabIndex = 19;
            this.bunifuMetroTextbox_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = " Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "NIC : ";
            // 
            // bunifuMetroTextbox_tpNo
            // 
            this.bunifuMetroTextbox_tpNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_tpNo.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_tpNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_tpNo.BorderThickness = 1;
            this.bunifuMetroTextbox_tpNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_tpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_tpNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_tpNo.isPassword = false;
            this.bunifuMetroTextbox_tpNo.Location = new System.Drawing.Point(115, 312);
            this.bunifuMetroTextbox_tpNo.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_tpNo.Name = "bunifuMetroTextbox_tpNo";
            this.bunifuMetroTextbox_tpNo.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_tpNo.TabIndex = 23;
            this.bunifuMetroTextbox_tpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "TP. No : ";
            // 
            // bunifuMetroTextbox_qty
            // 
            this.bunifuMetroTextbox_qty.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_qty.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_qty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_qty.BorderThickness = 1;
            this.bunifuMetroTextbox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_qty.isPassword = false;
            this.bunifuMetroTextbox_qty.Location = new System.Drawing.Point(115, 363);
            this.bunifuMetroTextbox_qty.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_qty.Name = "bunifuMetroTextbox_qty";
            this.bunifuMetroTextbox_qty.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_qty.TabIndex = 25;
            this.bunifuMetroTextbox_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Address :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_addprod
            // 
            this.button_addprod.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addprod.Image = ((System.Drawing.Image)(resources.GetObject("button_addprod.Image")));
            this.button_addprod.Location = new System.Drawing.Point(20, 421);
            this.button_addprod.Name = "button_addprod";
            this.button_addprod.Size = new System.Drawing.Size(107, 39);
            this.button_addprod.TabIndex = 27;
            this.button_addprod.TabStop = false;
            this.button_addprod.Text = "New";
            this.button_addprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_addprod.UseVisualStyleBackColor = false;
            this.button_addprod.Click += new System.EventHandler(this.button_addprod_Click);
            // 
            // button_updateprod
            // 
            this.button_updateprod.BackColor = System.Drawing.Color.Gold;
            this.button_updateprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateprod.Image = ((System.Drawing.Image)(resources.GetObject("button_updateprod.Image")));
            this.button_updateprod.Location = new System.Drawing.Point(265, 421);
            this.button_updateprod.Name = "button_updateprod";
            this.button_updateprod.Size = new System.Drawing.Size(114, 39);
            this.button_updateprod.TabIndex = 28;
            this.button_updateprod.Text = "Update";
            this.button_updateprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_updateprod.UseVisualStyleBackColor = false;
            this.button_updateprod.Click += new System.EventHandler(this.button_updateprod_Click);
            // 
            // bunifuMetroTextbox_search
            // 
            this.bunifuMetroTextbox_search.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_search.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_search.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_search.BorderThickness = 1;
            this.bunifuMetroTextbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_search.isPassword = false;
            this.bunifuMetroTextbox_search.Location = new System.Drawing.Point(467, 117);
            this.bunifuMetroTextbox_search.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_search.Name = "bunifuMetroTextbox_search";
            this.bunifuMetroTextbox_search.Size = new System.Drawing.Size(233, 28);
            this.bunifuMetroTextbox_search.TabIndex = 29;
            this.bunifuMetroTextbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_search.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_search_OnValueChanged);
            this.bunifuMetroTextbox_search.Enter += new System.EventHandler(this.search);
            this.bunifuMetroTextbox_search.Leave += new System.EventHandler(this.searchleave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(381, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Search";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.bunifuCustomDataGrid1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 57);
            this.panel1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(971, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1063, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(46, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "WFM CMS";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1118, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuMetroTextbox_search);
            this.Controls.Add(this.button_updateprod);
            this.Controls.Add(this.button_addprod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuMetroTextbox_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuMetroTextbox_tpNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMetroTextbox_color);
            this.Controls.Add(this.bunifuMetroTextbox_name);
            this.Controls.Add(this.bunifuMetroTextbox_id);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_color;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_name;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_qty;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_tpNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addprod;
        private System.Windows.Forms.Button button_updateprod;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_search;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}