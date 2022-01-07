
namespace Telas_Pim
{
    partial class F_Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Reserva));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.tb_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_TipoQuarto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_Checkout = new System.Windows.Forms.DateTimePicker();
            this.dt_Checkin = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.tb_CPFbusca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 127;
            this.label1.Text = "CPF";
            // 
            // tb_CPF
            // 
            this.tb_CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPF.Location = new System.Drawing.Point(319, 166);
            this.tb_CPF.Mask = "000,000,000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(141, 22);
            this.tb_CPF.TabIndex = 128;
            // 
            // tb_Celular
            // 
            this.tb_Celular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Celular.Location = new System.Drawing.Point(528, 166);
            this.tb_Celular.Mask = "(99) 00000-0000";
            this.tb_Celular.Name = "tb_Celular";
            this.tb_Celular.Size = new System.Drawing.Size(141, 22);
            this.tb_Celular.TabIndex = 126;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(560, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 20);
            this.label23.TabIndex = 129;
            this.label23.Text = "Celular";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.Location = new System.Drawing.Point(93, 166);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(197, 22);
            this.tb_Nome.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 120;
            this.label5.Text = "Nome";
            // 
            // cb_TipoQuarto
            // 
            this.cb_TipoQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_TipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoQuarto.FormattingEnabled = true;
            this.cb_TipoQuarto.Items.AddRange(new object[] {
            "Standard Casal",
            "Standard Solteiro ",
            "Standard Triplo"});
            this.cb_TipoQuarto.Location = new System.Drawing.Point(123, 221);
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(153, 24);
            this.cb_TipoQuarto.TabIndex = 123;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dt_Checkout);
            this.groupBox2.Controls.Add(this.dt_Checkin);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(402, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 89);
            this.groupBox2.TabIndex = 125;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada/ Saida";
            // 
            // dt_Checkout
            // 
            this.dt_Checkout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Checkout.Location = new System.Drawing.Point(142, 46);
            this.dt_Checkout.Name = "dt_Checkout";
            this.dt_Checkout.Size = new System.Drawing.Size(99, 22);
            this.dt_Checkout.TabIndex = 26;
            this.dt_Checkout.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dt_Checkin
            // 
            this.dt_Checkin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Checkin.Location = new System.Drawing.Point(9, 46);
            this.dt_Checkin.Name = "dt_Checkin";
            this.dt_Checkin.Size = new System.Drawing.Size(99, 22);
            this.dt_Checkin.TabIndex = 25;
            this.dt_Checkin.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(141, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Check -Out";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Check -in";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 122;
            this.label6.Text = "Tipo de Quarto";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registrar.Location = new System.Drawing.Point(299, 359);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(148, 40);
            this.btn_Registrar.TabIndex = 130;
            this.btn_Registrar.Text = "   REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // tb_CPFbusca
            // 
            this.tb_CPFbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_CPFbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPFbusca.Location = new System.Drawing.Point(241, 75);
            this.tb_CPFbusca.Mask = "000,000,000-00";
            this.tb_CPFbusca.Name = "tb_CPFbusca";
            this.tb_CPFbusca.Size = new System.Drawing.Size(141, 22);
            this.tb_CPFbusca.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(238, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 132;
            this.label4.Text = "CPF";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(423, 74);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 23);
            this.btn_Buscar.TabIndex = 131;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // F_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_CPFbusca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.tb_Celular);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_TipoQuarto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Reserva";
            this.Text = "F_Reserva";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.MaskedTextBox tb_Celular;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_TipoQuarto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_Checkout;
        private System.Windows.Forms.DateTimePicker dt_Checkin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.MaskedTextBox tb_CPFbusca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Buscar;
    }
}