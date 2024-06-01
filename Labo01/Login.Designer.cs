namespace Labo01
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optAdmin = new System.Windows.Forms.RadioButton();
            this.optEtudiant = new System.Windows.Forms.RadioButton();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(950, 550);
            this.panelShow.TabIndex = 8;
            this.panelShow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShow_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optAdmin);
            this.panel1.Controls.Add(this.optEtudiant);
            this.panel1.Controls.Add(this.bt_Connect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_PWD);
            this.panel1.Controls.Add(this.txt_Login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 54);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // optAdmin
            // 
            this.optAdmin.AutoSize = true;
            this.optAdmin.Location = new System.Drawing.Point(872, 20);
            this.optAdmin.Name = "optAdmin";
            this.optAdmin.Size = new System.Drawing.Size(54, 17);
            this.optAdmin.TabIndex = 14;
            this.optAdmin.TabStop = true;
            this.optAdmin.Text = "Admin";
            this.optAdmin.UseVisualStyleBackColor = true;
            // 
            // optEtudiant
            // 
            this.optEtudiant.AutoSize = true;
            this.optEtudiant.Location = new System.Drawing.Point(750, 20);
            this.optEtudiant.Name = "optEtudiant";
            this.optEtudiant.Size = new System.Drawing.Size(64, 17);
            this.optEtudiant.TabIndex = 13;
            this.optEtudiant.TabStop = true;
            this.optEtudiant.Text = "Etudiant";
            this.optEtudiant.UseVisualStyleBackColor = true;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Connect.ForeColor = System.Drawing.Color.Black;
            this.bt_Connect.Location = new System.Drawing.Point(568, 13);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(126, 28);
            this.bt_Connect.TabIndex = 12;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(280, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // txt_PWD
            // 
            this.txt_PWD.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PWD.ForeColor = System.Drawing.Color.Black;
            this.txt_PWD.Location = new System.Drawing.Point(360, 13);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.PasswordChar = '*';
            this.txt_PWD.Size = new System.Drawing.Size(149, 28);
            this.txt_PWD.TabIndex = 9;
            // 
            // txt_Login
            // 
            this.txt_Login.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.ForeColor = System.Drawing.Color.Black;
            this.txt_Login.Location = new System.Drawing.Point(87, 13);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(144, 28);
            this.txt_Login.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optAdmin;
        private System.Windows.Forms.RadioButton optEtudiant;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.TextBox txt_Login;
    }
}

