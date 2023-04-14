namespace Aplicacion_Windows_form
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechai = new System.Windows.Forms.DateTimePicker();
            this.telefonoi = new System.Windows.Forms.TextBox();
            this.departamentoi = new System.Windows.Forms.TextBox();
            this.nombrei = new System.Windows.Forms.TextBox();
            this.cii = new System.Windows.Forms.TextBox();
            this.cia = new System.Windows.Forms.TextBox();
            this.nombrea = new System.Windows.Forms.TextBox();
            this.departamentoa = new System.Windows.Forms.TextBox();
            this.telefonoa = new System.Windows.Forms.TextBox();
            this.fechaa = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.insertarb = new System.Windows.Forms.Button();
            this.eliminarb = new System.Windows.Forms.Button();
            this.actualizarb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSERTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha nacimieno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Departamento:";
            // 
            // fechai
            // 
            this.fechai.Location = new System.Drawing.Point(195, 396);
            this.fechai.Name = "fechai";
            this.fechai.Size = new System.Drawing.Size(286, 22);
            this.fechai.TabIndex = 7;
            // 
            // telefonoi
            // 
            this.telefonoi.Location = new System.Drawing.Point(732, 345);
            this.telefonoi.Name = "telefonoi";
            this.telefonoi.Size = new System.Drawing.Size(185, 22);
            this.telefonoi.TabIndex = 8;
            this.telefonoi.Text = "(591)";
            // 
            // departamentoi
            // 
            this.departamentoi.Location = new System.Drawing.Point(732, 382);
            this.departamentoi.Name = "departamentoi";
            this.departamentoi.Size = new System.Drawing.Size(185, 22);
            this.departamentoi.TabIndex = 9;
            // 
            // nombrei
            // 
            this.nombrei.Location = new System.Drawing.Point(195, 358);
            this.nombrei.Name = "nombrei";
            this.nombrei.Size = new System.Drawing.Size(286, 22);
            this.nombrei.TabIndex = 10;
            // 
            // cii
            // 
            this.cii.Location = new System.Drawing.Point(195, 330);
            this.cii.Name = "cii";
            this.cii.Size = new System.Drawing.Size(286, 22);
            this.cii.TabIndex = 11;
            // 
            // cia
            // 
            this.cia.Location = new System.Drawing.Point(195, 664);
            this.cia.Name = "cia";
            this.cia.Size = new System.Drawing.Size(286, 22);
            this.cia.TabIndex = 22;
            // 
            // nombrea
            // 
            this.nombrea.Location = new System.Drawing.Point(195, 692);
            this.nombrea.Name = "nombrea";
            this.nombrea.Size = new System.Drawing.Size(286, 22);
            this.nombrea.TabIndex = 21;
            // 
            // departamentoa
            // 
            this.departamentoa.Location = new System.Drawing.Point(732, 716);
            this.departamentoa.Name = "departamentoa";
            this.departamentoa.Size = new System.Drawing.Size(185, 22);
            this.departamentoa.TabIndex = 20;
            // 
            // telefonoa
            // 
            this.telefonoa.Location = new System.Drawing.Point(732, 679);
            this.telefonoa.Name = "telefonoa";
            this.telefonoa.Size = new System.Drawing.Size(185, 22);
            this.telefonoa.TabIndex = 19;
            this.telefonoa.Text = "(591)";
            // 
            // fechaa
            // 
            this.fechaa.Location = new System.Drawing.Point(195, 730);
            this.fechaa.Name = "fechaa";
            this.fechaa.Size = new System.Drawing.Size(286, 22);
            this.fechaa.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Departamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 684);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 730);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha nacimieno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 697);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nombre completo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 670);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "CI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 637);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "ACTUALIZAR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "ELIMINAR";
            // 
            // cie
            // 
            this.cie.Location = new System.Drawing.Point(195, 509);
            this.cie.Name = "cie";
            this.cie.Size = new System.Drawing.Size(286, 22);
            this.cie.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 515);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "CI:";
            // 
            // insertarb
            // 
            this.insertarb.Location = new System.Drawing.Point(770, 431);
            this.insertarb.Name = "insertarb";
            this.insertarb.Size = new System.Drawing.Size(146, 28);
            this.insertarb.TabIndex = 27;
            this.insertarb.Text = "Insertar";
            this.insertarb.UseVisualStyleBackColor = true;
            this.insertarb.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarb
            // 
            this.eliminarb.Location = new System.Drawing.Point(770, 515);
            this.eliminarb.Name = "eliminarb";
            this.eliminarb.Size = new System.Drawing.Size(146, 28);
            this.eliminarb.TabIndex = 28;
            this.eliminarb.Text = "Eliminar";
            this.eliminarb.UseVisualStyleBackColor = true;
            this.eliminarb.Click += new System.EventHandler(this.eliminarb_Click);
            // 
            // actualizarb
            // 
            this.actualizarb.Location = new System.Drawing.Point(771, 748);
            this.actualizarb.Name = "actualizarb";
            this.actualizarb.Size = new System.Drawing.Size(146, 28);
            this.actualizarb.TabIndex = 29;
            this.actualizarb.Text = "Actualizar";
            this.actualizarb.UseVisualStyleBackColor = true;
            this.actualizarb.Click += new System.EventHandler(this.actualizarb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 810);
            this.Controls.Add(this.actualizarb);
            this.Controls.Add(this.eliminarb);
            this.Controls.Add(this.insertarb);
            this.Controls.Add(this.cie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cia);
            this.Controls.Add(this.nombrea);
            this.Controls.Add(this.departamentoa);
            this.Controls.Add(this.telefonoa);
            this.Controls.Add(this.fechaa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cii);
            this.Controls.Add(this.nombrei);
            this.Controls.Add(this.departamentoi);
            this.Controls.Add(this.telefonoi);
            this.Controls.Add(this.fechai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechai;
        private System.Windows.Forms.TextBox telefonoi;
        private System.Windows.Forms.TextBox departamentoi;
        private System.Windows.Forms.TextBox nombrei;
        private System.Windows.Forms.TextBox cii;
        private System.Windows.Forms.TextBox cia;
        private System.Windows.Forms.TextBox nombrea;
        private System.Windows.Forms.TextBox departamentoa;
        private System.Windows.Forms.TextBox telefonoa;
        private System.Windows.Forms.DateTimePicker fechaa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button insertarb;
        private System.Windows.Forms.Button eliminarb;
        private System.Windows.Forms.Button actualizarb;
    }
}

