namespace Gestion
{
    partial class Administracion
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
            this.datagridemp = new System.Windows.Forms.DataGridView();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvolv = new System.Windows.Forms.Button();
            this.btncarga = new System.Windows.Forms.Button();
            this.btnbor = new System.Windows.Forms.Button();
            this.btnbusc = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nven = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridemp)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridemp
            // 
            this.datagridemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridemp.Location = new System.Drawing.Point(-2, 84);
            this.datagridemp.Name = "datagridemp";
            this.datagridemp.RowTemplate.Height = 25;
            this.datagridemp.Size = new System.Drawing.Size(595, 368);
            this.datagridemp.TabIndex = 0;
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdni.Location = new System.Drawing.Point(12, 35);
            this.txtdni.MaxLength = 10;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(133, 26);
            this.txtdni.TabIndex = 1;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(229, 35);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 26);
            this.txtnom.TabIndex = 2;
            // 
            // txtap
            // 
            this.txtap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtap.Location = new System.Drawing.Point(443, 35);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(100, 26);
            this.txtap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(549, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "APELLIDO";
            // 
            // btnvolv
            // 
            this.btnvolv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvolv.Location = new System.Drawing.Point(613, 404);
            this.btnvolv.Name = "btnvolv";
            this.btnvolv.Size = new System.Drawing.Size(90, 34);
            this.btnvolv.TabIndex = 7;
            this.btnvolv.Text = "Volver";
            this.btnvolv.UseVisualStyleBackColor = true;
            this.btnvolv.Click += new System.EventHandler(this.btnvolv_click);
            // 
            // btncarga
            // 
            this.btncarga.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncarga.Location = new System.Drawing.Point(613, 178);
            this.btncarga.Name = "btncarga";
            this.btncarga.Size = new System.Drawing.Size(90, 52);
            this.btncarga.TabIndex = 8;
            this.btncarga.Text = "Cargar empleado";
            this.btncarga.UseVisualStyleBackColor = true;
            this.btncarga.Click += new System.EventHandler(this.btncarga_Click);
            // 
            // btnbor
            // 
            this.btnbor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbor.Location = new System.Drawing.Point(613, 342);
            this.btnbor.Name = "btnbor";
            this.btnbor.Size = new System.Drawing.Size(90, 45);
            this.btnbor.TabIndex = 9;
            this.btnbor.Text = "Borrar";
            this.btnbor.UseVisualStyleBackColor = true;
            this.btnbor.Click += new System.EventHandler(this.btnbor_Click);
            // 
            // btnbusc
            // 
            this.btnbusc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbusc.Location = new System.Drawing.Point(613, 254);
            this.btnbusc.Name = "btnbusc";
            this.btnbusc.Size = new System.Drawing.Size(90, 42);
            this.btnbusc.TabIndex = 10;
            this.btnbusc.Text = "Buscar";
            this.btnbusc.UseVisualStyleBackColor = true;
            this.btnbusc.Click += new System.EventHandler(this.btnbusc_Click);
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtedad.Location = new System.Drawing.Point(641, 40);
            this.txtedad.MaxLength = 2;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(40, 26);
            this.txtedad.TabIndex = 11;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(687, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // btnmod
            // 
            this.btnmod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmod.Location = new System.Drawing.Point(613, 302);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(90, 34);
            this.btnmod.TabIndex = 13;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(687, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ventas";
            // 
            // nven
            // 
            this.nven.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nven.Location = new System.Drawing.Point(613, 84);
            this.nven.MaxLength = 2;
            this.nven.Name = "nven";
            this.nven.ReadOnly = true;
            this.nven.Size = new System.Drawing.Size(68, 26);
            this.nven.TabIndex = 14;
            this.nven.Text = "0";
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nven);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.btnbusc);
            this.Controls.Add(this.btnbor);
            this.Controls.Add(this.btncarga);
            this.Controls.Add(this.btnvolv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.datagridemp);
            this.Name = "Administracion";
            this.Text = "Administracion";
            ((System.ComponentModel.ISupportInitialize)(this.datagridemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridemp;
        private TextBox txtdni;
        private TextBox txtnom;
        private TextBox txtap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnvolv;
        private Button btncarga;
        private Button btnbor;
        private Button btnbusc;
        private TextBox txtedad;
        private Label label4;
        private Button btnmod;
        private Label label5;
        private TextBox nven;
    }
}