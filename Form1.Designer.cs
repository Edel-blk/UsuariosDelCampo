namespace UsuariosDelCampo
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
            this.userID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.country = new System.Windows.Forms.ComboBox();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.active = new System.Windows.Forms.CheckBox();
            this.imagePicker = new System.Windows.Forms.GroupBox();
            this.uploadImage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.clean = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Button();
            this.Sexo.SuspendLayout();
            this.imagePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(127, 25);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(127, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 20);
            this.name.TabIndex = 1;
            // 
            // direction
            // 
            this.direction.Location = new System.Drawing.Point(127, 165);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(255, 20);
            this.direction.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(127, 123);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(127, 208);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 21);
            this.country.TabIndex = 4;
            // 
            // Sexo
            // 
            this.Sexo.Controls.Add(this.femaleButton);
            this.Sexo.Controls.Add(this.maleButton);
            this.Sexo.Location = new System.Drawing.Point(51, 256);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(342, 53);
            this.Sexo.TabIndex = 5;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo";
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(190, 19);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(71, 17);
            this.femaleButton.TabIndex = 1;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Femenino";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(76, 19);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(73, 17);
            this.maleButton.TabIndex = 0;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Masculino";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(241, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(388, 28);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(15, 14);
            this.active.TabIndex = 7;
            this.active.UseVisualStyleBackColor = true;
            // 
            // imagePicker
            // 
            this.imagePicker.Controls.Add(this.uploadImage);
            this.imagePicker.Controls.Add(this.pictureBox);
            this.imagePicker.Location = new System.Drawing.Point(409, 78);
            this.imagePicker.Name = "imagePicker";
            this.imagePicker.Size = new System.Drawing.Size(203, 231);
            this.imagePicker.TabIndex = 8;
            this.imagePicker.TabStop = false;
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(24, 187);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(110, 23);
            this.uploadImage.TabIndex = 1;
            this.uploadImage.Text = "Subir Imagen";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(24, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(160, 133);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(88, 348);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 9;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(216, 348);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Activo:";
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(433, 348);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(136, 23);
            this.deleteUser.TabIndex = 17;
            this.deleteUser.Text = "Borrar Usuario";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 397);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.imagePicker);
            this.Controls.Add(this.active);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.country);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.imagePicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox direction;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.GroupBox imagePicker;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteUser;
    }
}

