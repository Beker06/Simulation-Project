
namespace Proyecto_Individual_Simulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxM = new System.Windows.Forms.TextBox();
            this.tbxXo = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.tbxTurno = new System.Windows.Forms.TextBox();
            this.lblXo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.tbxApuesta = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblApuesta = new System.Windows.Forms.Label();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.tbxBolasNegras = new System.Windows.Forms.TextBox();
            this.lblBolasRojas = new System.Windows.Forms.Label();
            this.tbxBolasRojas = new System.Windows.Forms.TextBox();
            this.lblEsferasNegras = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Intento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudoaleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBolas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolasRojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolasNegras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNegras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolaExtraida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxGanancia = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.tbxDinero = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.tbxResTurno = new System.Windows.Forms.TextBox();
            this.lblTurnoRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctCaja = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pctCaja);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.tbxA);
            this.panel1.Controls.Add(this.tbxM);
            this.panel1.Controls.Add(this.tbxXo);
            this.panel1.Controls.Add(this.lblM);
            this.panel1.Controls.Add(this.tbxTurno);
            this.panel1.Controls.Add(this.lblXo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblc);
            this.panel1.Controls.Add(this.tbxApuesta);
            this.panel1.Controls.Add(this.lbla);
            this.panel1.Controls.Add(this.lblApuesta);
            this.panel1.Controls.Add(this.tbxC);
            this.panel1.Controls.Add(this.tbxBolasNegras);
            this.panel1.Controls.Add(this.lblBolasRojas);
            this.panel1.Controls.Add(this.tbxBolasRojas);
            this.panel1.Controls.Add(this.lblEsferasNegras);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 708);
            this.panel1.TabIndex = 37;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.btnCalcular.Location = new System.Drawing.Point(5, 556);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(194, 45);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.SystemColors.Control;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.btnReiniciar.Location = new System.Drawing.Point(5, 603);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(194, 45);
            this.btnReiniciar.TabIndex = 24;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.btnCerrar.Location = new System.Drawing.Point(5, 650);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(194, 45);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(41, 135);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(43, 20);
            this.tbxA.TabIndex = 13;
            this.tbxA.Text = "101";
            // 
            // tbxM
            // 
            this.tbxM.Location = new System.Drawing.Point(144, 161);
            this.tbxM.Name = "tbxM";
            this.tbxM.Size = new System.Drawing.Size(47, 20);
            this.tbxM.TabIndex = 16;
            this.tbxM.Text = "1701";
            // 
            // tbxXo
            // 
            this.tbxXo.Location = new System.Drawing.Point(47, 161);
            this.tbxXo.Name = "tbxXo";
            this.tbxXo.Size = new System.Drawing.Size(46, 20);
            this.tbxXo.TabIndex = 15;
            this.tbxXo.Text = "17";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblM.Location = new System.Drawing.Point(99, 160);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(40, 21);
            this.lblM.TabIndex = 12;
            this.lblM.Text = "M =";
            // 
            // tbxTurno
            // 
            this.tbxTurno.Location = new System.Drawing.Point(93, 288);
            this.tbxTurno.Name = "tbxTurno";
            this.tbxTurno.Size = new System.Drawing.Size(102, 20);
            this.tbxTurno.TabIndex = 22;
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblXo.Location = new System.Drawing.Point(0, 160);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(45, 21);
            this.lblXo.TabIndex = 11;
            this.lblXo.Text = "Xo =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(3, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Turno:";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblc.Location = new System.Drawing.Point(103, 134);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(33, 21);
            this.lblc.TabIndex = 10;
            this.lblc.Text = "c =";
            // 
            // tbxApuesta
            // 
            this.tbxApuesta.Location = new System.Drawing.Point(93, 259);
            this.tbxApuesta.Name = "tbxApuesta";
            this.tbxApuesta.Size = new System.Drawing.Size(102, 20);
            this.tbxApuesta.TabIndex = 21;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lbla.Location = new System.Drawing.Point(3, 134);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(34, 21);
            this.lbla.TabIndex = 9;
            this.lbla.Text = "a =";
            // 
            // lblApuesta
            // 
            this.lblApuesta.AutoSize = true;
            this.lblApuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblApuesta.Location = new System.Drawing.Point(4, 258);
            this.lblApuesta.Name = "lblApuesta";
            this.lblApuesta.Size = new System.Drawing.Size(86, 18);
            this.lblApuesta.TabIndex = 25;
            this.lblApuesta.Text = "Apuesta:";
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(141, 135);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(50, 20);
            this.tbxC.TabIndex = 14;
            this.tbxC.Text = "221";
            // 
            // tbxBolasNegras
            // 
            this.tbxBolasNegras.Location = new System.Drawing.Point(139, 230);
            this.tbxBolasNegras.Name = "tbxBolasNegras";
            this.tbxBolasNegras.Size = new System.Drawing.Size(56, 20);
            this.tbxBolasNegras.TabIndex = 20;
            // 
            // lblBolasRojas
            // 
            this.lblBolasRojas.AutoSize = true;
            this.lblBolasRojas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBolasRojas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblBolasRojas.Location = new System.Drawing.Point(3, 199);
            this.lblBolasRojas.Name = "lblBolasRojas";
            this.lblBolasRojas.Size = new System.Drawing.Size(116, 18);
            this.lblBolasRojas.TabIndex = 18;
            this.lblBolasRojas.Text = "Bolas Rojas:";
            // 
            // tbxBolasRojas
            // 
            this.tbxBolasRojas.Location = new System.Drawing.Point(139, 202);
            this.tbxBolasRojas.Name = "tbxBolasRojas";
            this.tbxBolasRojas.Size = new System.Drawing.Size(56, 20);
            this.tbxBolasRojas.TabIndex = 19;
            // 
            // lblEsferasNegras
            // 
            this.lblEsferasNegras.AutoSize = true;
            this.lblEsferasNegras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsferasNegras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblEsferasNegras.Location = new System.Drawing.Point(3, 227);
            this.lblEsferasNegras.Name = "lblEsferasNegras";
            this.lblEsferasNegras.Size = new System.Drawing.Size(129, 18);
            this.lblEsferasNegras.TabIndex = 20;
            this.lblEsferasNegras.Text = "Bolas Negras:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intento,
            this.Pseudoaleatorio,
            this.TotalBolas,
            this.BolasRojas,
            this.pRojas,
            this.BolasNegras,
            this.pNegras,
            this.BolaExtraida});
            this.dgvMain.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMain.Location = new System.Drawing.Point(225, 206);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(828, 440);
            this.dgvMain.TabIndex = 38;
            // 
            // Intento
            // 
            this.Intento.HeaderText = "Intento";
            this.Intento.Name = "Intento";
            this.Intento.ReadOnly = true;
            // 
            // Pseudoaleatorio
            // 
            this.Pseudoaleatorio.HeaderText = "Pseudoaleatorio";
            this.Pseudoaleatorio.Name = "Pseudoaleatorio";
            this.Pseudoaleatorio.ReadOnly = true;
            // 
            // TotalBolas
            // 
            this.TotalBolas.HeaderText = "Total de Bolas";
            this.TotalBolas.Name = "TotalBolas";
            this.TotalBolas.ReadOnly = true;
            // 
            // BolasRojas
            // 
            this.BolasRojas.HeaderText = "Bolas Rojas";
            this.BolasRojas.Name = "BolasRojas";
            this.BolasRojas.ReadOnly = true;
            // 
            // pRojas
            // 
            this.pRojas.HeaderText = "%Rojas";
            this.pRojas.Name = "pRojas";
            this.pRojas.ReadOnly = true;
            // 
            // BolasNegras
            // 
            this.BolasNegras.HeaderText = "Bolas Negras";
            this.BolasNegras.Name = "BolasNegras";
            this.BolasNegras.ReadOnly = true;
            // 
            // pNegras
            // 
            this.pNegras.HeaderText = "%Negras";
            this.pNegras.Name = "pNegras";
            this.pNegras.ReadOnly = true;
            // 
            // BolaExtraida
            // 
            this.BolaExtraida.HeaderText = "Bola Extraida";
            this.BolaExtraida.Name = "BolaExtraida";
            this.BolaExtraida.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(480, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 36);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Bola Roja, Bola Negra";
            // 
            // tbxGanancia
            // 
            this.tbxGanancia.BackColor = System.Drawing.Color.White;
            this.tbxGanancia.Enabled = false;
            this.tbxGanancia.Location = new System.Drawing.Point(497, 695);
            this.tbxGanancia.Name = "tbxGanancia";
            this.tbxGanancia.ReadOnly = true;
            this.tbxGanancia.Size = new System.Drawing.Size(78, 20);
            this.tbxGanancia.TabIndex = 45;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblGanancia.Location = new System.Drawing.Point(406, 694);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(85, 21);
            this.lblGanancia.TabIndex = 44;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // tbxDinero
            // 
            this.tbxDinero.BackColor = System.Drawing.Color.White;
            this.tbxDinero.Enabled = false;
            this.tbxDinero.Location = new System.Drawing.Point(686, 695);
            this.tbxDinero.Name = "tbxDinero";
            this.tbxDinero.ReadOnly = true;
            this.tbxDinero.Size = new System.Drawing.Size(78, 20);
            this.tbxDinero.TabIndex = 43;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblDinero.Location = new System.Drawing.Point(614, 694);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(66, 21);
            this.lblDinero.TabIndex = 42;
            this.lblDinero.Text = "Dinero:";
            // 
            // tbxResTurno
            // 
            this.tbxResTurno.BackColor = System.Drawing.Color.White;
            this.tbxResTurno.Enabled = false;
            this.tbxResTurno.Location = new System.Drawing.Point(294, 695);
            this.tbxResTurno.Name = "tbxResTurno";
            this.tbxResTurno.ReadOnly = true;
            this.tbxResTurno.Size = new System.Drawing.Size(78, 20);
            this.tbxResTurno.TabIndex = 41;
            // 
            // lblTurnoRes
            // 
            this.lblTurnoRes.AutoSize = true;
            this.lblTurnoRes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.lblTurnoRes.Location = new System.Drawing.Point(229, 694);
            this.lblTurnoRes.Name = "lblTurnoRes";
            this.lblTurnoRes.Size = new System.Drawing.Size(59, 21);
            this.lblTurnoRes.TabIndex = 40;
            this.lblTurnoRes.Text = "Turno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(221, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Hay una urna totalmente tapada la cual contiene bolas de dos colores diferentes ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(221, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "(Rojas y Negras). Cada turno se sacara una bola y no se volvera a introducir. Cua" +
    "ndo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(221, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(803, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "se hayan extraido todas las bolas rojas  se detendra el juego. Se ingresara en qu" +
    "e";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(222, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(852, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "En caso de predecir el turno exacto, se duplicara el dinero. Si se esta en un ran" +
    "go de +-2, se ganara la mitad de lo apostado.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(221, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(740, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "turno se cree que se sacaran todas las bolas rojas y una cantidad a apostar.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Proyecto_Individual_Simulacion.Properties.Resources.close;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1072, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pctCaja
            // 
            this.pctCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctCaja.Image = global::Proyecto_Individual_Simulacion.Properties.Resources.Bola_roja__bola_negra;
            this.pctCaja.Location = new System.Drawing.Point(6, 9);
            this.pctCaja.Name = "pctCaja";
            this.pctCaja.Size = new System.Drawing.Size(187, 114);
            this.pctCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCaja.TabIndex = 24;
            this.pctCaja.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 740);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxGanancia);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.tbxDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.tbxResTurno);
            this.Controls.Add(this.lblTurnoRes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bola Roja - Bola Negra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctCaja;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxM;
        private System.Windows.Forms.TextBox tbxXo;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox tbxTurno;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox tbxApuesta;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblApuesta;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.TextBox tbxBolasNegras;
        private System.Windows.Forms.Label lblBolasRojas;
        private System.Windows.Forms.TextBox tbxBolasRojas;
        private System.Windows.Forms.Label lblEsferasNegras;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudoaleatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBolas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolasRojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolasNegras;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNegras;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolaExtraida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxGanancia;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox tbxDinero;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.TextBox tbxResTurno;
        private System.Windows.Forms.Label lblTurnoRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

