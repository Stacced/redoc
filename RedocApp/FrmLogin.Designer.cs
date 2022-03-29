
namespace RedocApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picConnection = new System.Windows.Forms.PictureBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // picConnection
            // 
            this.picConnection.Image = ((System.Drawing.Image)(resources.GetObject("picConnection.Image")));
            this.picConnection.Location = new System.Drawing.Point(12, 12);
            this.picConnection.Name = "picConnection";
            this.picConnection.Size = new System.Drawing.Size(409, 257);
            this.picConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConnection.TabIndex = 0;
            this.picConnection.TabStop = false;
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.78151F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(12, 282);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(409, 39);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Connexion";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 331);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(155, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "&Nom d\'utilisateur";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(197, 334);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "admin";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "admin";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 377);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "&Mot de passe";
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgotPassword.Location = new System.Drawing.Point(8, 482);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(173, 20);
            this.llbForgotPassword.TabIndex = 6;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Mot de &passe oublié ?";
            // 
            // llbCreateAccount
            // 
            this.llbCreateAccount.AutoSize = true;
            this.llbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCreateAccount.Location = new System.Drawing.Point(274, 482);
            this.llbCreateAccount.Name = "llbCreateAccount";
            this.llbCreateAccount.Size = new System.Drawing.Size(148, 20);
            this.llbCreateAccount.TabIndex = 7;
            this.llbCreateAccount.TabStop = true;
            this.llbCreateAccount.Text = "&Créer mon compte";
            this.llbCreateAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(409, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "✅ &Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparator.Enabled = false;
            this.lblSeparator.Location = new System.Drawing.Point(12, 270);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(409, 1);
            this.lblSeparator.TabIndex = 10;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 513);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llbCreateAccount);
            this.Controls.Add(this.llbForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.picConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDOC - Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.picConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picConnection;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llbForgotPassword;
        private System.Windows.Forms.LinkLabel llbCreateAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSeparator;
    }
}

