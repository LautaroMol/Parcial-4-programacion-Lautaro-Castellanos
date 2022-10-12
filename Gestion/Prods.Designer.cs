namespace Gestion
{
    partial class Prods
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
            this.btnagr = new System.Windows.Forms.Button();
            this.txtven = new System.Windows.Forms.TextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btnbusc = new System.Windows.Forms.Button();
            this.btnbor = new System.Windows.Forms.Button();
            this.btning = new System.Windows.Forms.Button();
            this.btnvolv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.datagridemp = new System.Windows.Forms.DataGridView();
            this.lbnom = new System.Windows.Forms.Label();
            this.lbap = new System.Windows.Forms.Label();
            this.lbed = new System.Windows.Forms.Label();
            this.lbven = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtaddven = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagr
            // 
            this.btnagr.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagr.Location = new System.Drawing.Point(820, 401);
            this.btnagr.Name = "btnagr";
            this.btnagr.Size = new System.Drawing.Size(75, 39);
            this.btnagr.TabIndex = 31;
            this.btnagr.Text = "Agregar Ventas";
            this.btnagr.UseVisualStyleBackColor = true;
            this.btnagr.Click += new System.EventHandler(this.btnagr_Click);
            // 
            // txtven
            // 
            this.txtven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtven.Location = new System.Drawing.Point(768, 96);
            this.txtven.MaxLength = 100;
            this.txtven.Name = "txtven";
            this.txtven.ReadOnly = true;
            this.txtven.Size = new System.Drawing.Size(61, 26);
            this.txtven.TabIndex = 30;
            this.txtven.Text = "0";
            this.txtven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // btnmod
            // 
            this.btnmod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmod.Location = new System.Drawing.Point(750, 255);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(121, 44);
            this.btnmod.TabIndex = 29;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(565, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtstock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtstock.Location = new System.Drawing.Point(504, 96);
            this.txtstock.MaxLength = 100;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(55, 26);
            this.txtstock.TabIndex = 20;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // btnbusc
            // 
            this.btnbusc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbusc.Location = new System.Drawing.Point(750, 207);
            this.btnbusc.Name = "btnbusc";
            this.btnbusc.Size = new System.Drawing.Size(121, 42);
            this.btnbusc.TabIndex = 26;
            this.btnbusc.Text = "Buscar";
            this.btnbusc.UseVisualStyleBackColor = true;
            this.btnbusc.Click += new System.EventHandler(this.btnbusc_Click);
            // 
            // btnbor
            // 
            this.btnbor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbor.Location = new System.Drawing.Point(750, 305);
            this.btnbor.Name = "btnbor";
            this.btnbor.Size = new System.Drawing.Size(121, 44);
            this.btnbor.TabIndex = 25;
            this.btnbor.Text = "Borrar";
            this.btnbor.UseVisualStyleBackColor = true;
            this.btnbor.Click += new System.EventHandler(this.btnbor_Click);
            // 
            // btning
            // 
            this.btning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btning.Location = new System.Drawing.Point(229, 21);
            this.btning.Name = "btning";
            this.btning.Size = new System.Drawing.Size(75, 26);
            this.btning.TabIndex = 24;
            this.btning.Text = "Ingresar";
            this.btning.UseVisualStyleBackColor = true;
            this.btning.Click += new System.EventHandler(this.btning_Click);
            // 
            // btnvolv
            // 
            this.btnvolv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvolv.Location = new System.Drawing.Point(774, 563);
            this.btnvolv.Name = "btnvolv";
            this.btnvolv.Size = new System.Drawing.Size(121, 61);
            this.btnvolv.TabIndex = 23;
            this.btnvolv.Text = "Volver";
            this.btnvolv.UseVisualStyleBackColor = true;
            this.btnvolv.Click += new System.EventHandler(this.btnvolv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre Del Prod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "DNI";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(262, 96);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 26);
            this.txtnom.TabIndex = 19;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(39, 96);
            this.txtid.MaxLength = 20;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 18;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdni.Location = new System.Drawing.Point(39, 21);
            this.txtdni.MaxLength = 10;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(133, 26);
            this.txtdni.TabIndex = 17;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // datagridemp
            // 
            this.datagridemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridemp.Location = new System.Drawing.Point(12, 147);
            this.datagridemp.Name = "datagridemp";
            this.datagridemp.RowTemplate.Height = 25;
            this.datagridemp.Size = new System.Drawing.Size(724, 477);
            this.datagridemp.TabIndex = 16;
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbnom.Location = new System.Drawing.Point(321, 48);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(13, 18);
            this.lbnom.TabIndex = 32;
            this.lbnom.Text = "-";
            // 
            // lbap
            // 
            this.lbap.AutoSize = true;
            this.lbap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbap.Location = new System.Drawing.Point(473, 48);
            this.lbap.Name = "lbap";
            this.lbap.Size = new System.Drawing.Size(13, 18);
            this.lbap.TabIndex = 33;
            this.lbap.Text = "-";
            // 
            // lbed
            // 
            this.lbed.AutoSize = true;
            this.lbed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbed.Location = new System.Drawing.Point(652, 48);
            this.lbed.Name = "lbed";
            this.lbed.Size = new System.Drawing.Size(13, 18);
            this.lbed.TabIndex = 34;
            this.lbed.Text = "-";
            // 
            // lbven
            // 
            this.lbven.AutoSize = true;
            this.lbven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbven.Location = new System.Drawing.Point(774, 48);
            this.lbven.Name = "lbven";
            this.lbven.Size = new System.Drawing.Size(13, 18);
            this.lbven.TabIndex = 35;
            this.lbven.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(321, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(473, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(652, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Edad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(774, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "N de Ventas:";
            // 
            // btncar
            // 
            this.btncar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncar.Location = new System.Drawing.Point(750, 147);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(121, 54);
            this.btncar.TabIndex = 40;
            this.btncar.Text = "Cargar Prod";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(708, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Precio";
            // 
            // txtpr
            // 
            this.txtpr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtpr.Location = new System.Drawing.Point(625, 96);
            this.txtpr.MaxLength = 100;
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(77, 26);
            this.txtpr.TabIndex = 21;
            this.txtpr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(835, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Vendidos";
            // 
            // txtaddven
            // 
            this.txtaddven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtaddven.Location = new System.Drawing.Point(742, 406);
            this.txtaddven.MaxLength = 100;
            this.txtaddven.Name = "txtaddven";
            this.txtaddven.Size = new System.Drawing.Size(72, 26);
            this.txtaddven.TabIndex = 44;
            this.txtaddven.Text = "0";
            this.txtaddven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // Prods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 631);
            this.ControlBox = false;
            this.Controls.Add(this.txtaddven);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.btncar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbven);
            this.Controls.Add(this.lbed);
            this.Controls.Add(this.lbap);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.btnagr);
            this.Controls.Add(this.txtven);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.btnbusc);
            this.Controls.Add(this.btnbor);
            this.Controls.Add(this.btning);
            this.Controls.Add(this.btnvolv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.datagridemp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prods";
            ((System.ComponentModel.ISupportInitialize)(this.datagridemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnagr;
        private TextBox txtven;
        private Button btnmod;
        private Label label4;
        private TextBox txtstock;
        private Button btnbusc;
        private Button btnbor;
        private Button btning;
        private Button btnvolv;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtnom;
        private TextBox txtid;
        private TextBox txtdni;
        private DataGridView datagridemp;
        private Label lbnom;
        private Label lbap;
        private Label lbed;
        private Label lbven;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btncar;
        private Label label9;
        private TextBox txtpr;
        private Label label10;
        private TextBox txtaddven;
    }
}