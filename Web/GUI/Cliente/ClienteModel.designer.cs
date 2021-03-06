using System.Drawing;

namespace Web.GUI.Cliente
{
    partial class ClienteModel
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.editIDConto = new Library.Template.Controls.TemplateEditText();
            this.editIDCliente = new Library.Template.Controls.TemplateEditText();
            this.editAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditCombo();
            this.editCodiceFiscale = new Library.Template.Controls.TemplateEditCodiceFiscale();
            this.editComune = new Library.Template.Controls.TemplateEditCountry();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditPartitaIva();
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editCodiceFiscale);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editIDCliente);
            this.container.Controls.Add(this.editIDConto);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editIDConto, 0);
            this.container.Controls.SetChildIndex(this.editIDCliente, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editCodiceFiscale, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editIDConto
            // 
            this.editIDConto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDConto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDConto.BackColor = System.Drawing.Color.Transparent;
            this.editIDConto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDConto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDConto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDConto.Changed = true;
            this.editIDConto.Editing = false;
            this.editIDConto.Label = "ID Conto";
            this.editIDConto.LabelWidth = 175;
            this.editIDConto.Location = new System.Drawing.Point(25, 506);
            this.editIDConto.Name = "editIDConto";
            this.editIDConto.ReadOnly = false;
            this.editIDConto.Required = true;
            this.editIDConto.Size = new System.Drawing.Size(811, 30);
            this.editIDConto.TabIndex = 2;
            this.editIDConto.Text = "EditControl";
            this.editIDConto.Value = null;
            // 
            // editIDCliente
            // 
            this.editIDCliente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDCliente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDCliente.BackColor = System.Drawing.Color.Transparent;
            this.editIDCliente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDCliente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDCliente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDCliente.Changed = true;
            this.editIDCliente.Editing = false;
            this.editIDCliente.Label = "ID Cliente";
            this.editIDCliente.LabelWidth = 175;
            this.editIDCliente.Location = new System.Drawing.Point(25, 550);
            this.editIDCliente.Name = "editIDCliente";
            this.editIDCliente.ReadOnly = false;
            this.editIDCliente.Required = true;
            this.editIDCliente.Size = new System.Drawing.Size(811, 30);
            this.editIDCliente.TabIndex = 3;
            this.editIDCliente.Text = "EditControl";
            this.editIDCliente.Value = null;
            // 
            // editAzienda
            // 
            this.editAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAzienda.Changed = true;
            this.editAzienda.Editing = false;
            this.editAzienda.Label = "Azienda";
            this.editAzienda.LabelWidth = 175;
            this.editAzienda.Location = new System.Drawing.Point(25, 66);
            this.editAzienda.Model = null;
            this.editAzienda.Name = "editAzienda";
            this.editAzienda.ReadOnly = false;
            this.editAzienda.Required = true;
            this.editAzienda.Size = new System.Drawing.Size(811, 30);
            this.editAzienda.TabIndex = 1000;
            this.editAzienda.Value = null;
            this.editAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAzienda_ComboConfirm);
            this.editAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAzienda_ComboClick);
            // 
            // editRagioneSociale
            // 
            this.editRagioneSociale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editRagioneSociale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editRagioneSociale.BackColor = System.Drawing.Color.Transparent;
            this.editRagioneSociale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editRagioneSociale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editRagioneSociale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editRagioneSociale.Changed = true;
            this.editRagioneSociale.Editing = false;
            this.editRagioneSociale.Label = "Ragione sociale";
            this.editRagioneSociale.LabelWidth = 175;
            this.editRagioneSociale.Location = new System.Drawing.Point(25, 110);
            this.editRagioneSociale.Model = null;
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = true;
            this.editRagioneSociale.Size = new System.Drawing.Size(811, 30);
            this.editRagioneSociale.TabIndex = 1000;
            this.editRagioneSociale.Value = null;
            this.editRagioneSociale.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaAzienda_ComboConfirm);
            this.editRagioneSociale.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaAzienda_ComboClick);
            // 
            // editCodiceFiscale
            // 
            this.editCodiceFiscale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodiceFiscale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodiceFiscale.BackColor = System.Drawing.Color.Transparent;
            this.editCodiceFiscale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodiceFiscale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodiceFiscale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodiceFiscale.Changed = true;
            this.editCodiceFiscale.Editing = false;
            this.editCodiceFiscale.Label = "Codice fiscale";
            this.editCodiceFiscale.LabelWidth = 175;
            this.editCodiceFiscale.Location = new System.Drawing.Point(25, 462);
            this.editCodiceFiscale.Name = "editCodiceFiscale";
            this.editCodiceFiscale.ReadOnly = true;
            this.editCodiceFiscale.Required = true;
            this.editCodiceFiscale.Size = new System.Drawing.Size(811, 30);
            this.editCodiceFiscale.TabIndex = 9;
            this.editCodiceFiscale.Text = "TemplateEditPartitaIva";
            this.editCodiceFiscale.Value = "---";
            // 
            // editComune
            // 
            this.editComune.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editComune.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editComune.BackColor = System.Drawing.Color.Transparent;
            this.editComune.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editComune.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editComune.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editComune.Changed = true;
            this.editComune.Editing = false;
            this.editComune.Label = "Comune";
            this.editComune.LabelWidth = 175;
            this.editComune.Location = new System.Drawing.Point(25, 242);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = true;
            this.editComune.Required = true;
            this.editComune.Size = new System.Drawing.Size(811, 30);
            this.editComune.TabIndex = 4;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
            // 
            // editPartitaIVA
            // 
            this.editPartitaIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPartitaIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPartitaIVA.BackColor = System.Drawing.Color.Transparent;
            this.editPartitaIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPartitaIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPartitaIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPartitaIVA.Changed = true;
            this.editPartitaIVA.Editing = false;
            this.editPartitaIVA.Label = "Partita IVA";
            this.editPartitaIVA.LabelWidth = 175;
            this.editPartitaIVA.Location = new System.Drawing.Point(25, 418);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = true;
            this.editPartitaIVA.Required = true;
            this.editPartitaIVA.Size = new System.Drawing.Size(811, 30);
            this.editPartitaIVA.TabIndex = 9;
            this.editPartitaIVA.Text = "TemplateEditPartitaIva";
            this.editPartitaIVA.Value = "---";
            // 
            // editEmail
            // 
            this.editEmail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editEmail.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEmail.BackColor = System.Drawing.Color.Transparent;
            this.editEmail.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEmail.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEmail.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEmail.Changed = true;
            this.editEmail.Editing = false;
            this.editEmail.Label = "Email";
            this.editEmail.LabelWidth = 175;
            this.editEmail.Location = new System.Drawing.Point(25, 374);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = true;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(811, 30);
            this.editEmail.TabIndex = 8;
            this.editEmail.Text = "TemplateEditEmail";
            this.editEmail.Value = null;
            // 
            // editTelefono
            // 
            this.editTelefono.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTelefono.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTelefono.BackColor = System.Drawing.Color.Transparent;
            this.editTelefono.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTelefono.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTelefono.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTelefono.Changed = true;
            this.editTelefono.Editing = false;
            this.editTelefono.Label = "Telefono";
            this.editTelefono.LabelWidth = 175;
            this.editTelefono.Location = new System.Drawing.Point(25, 286);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = true;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(811, 30);
            this.editTelefono.TabIndex = 6;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = null;
            // 
            // editFAX
            // 
            this.editFAX.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFAX.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFAX.BackColor = System.Drawing.Color.Transparent;
            this.editFAX.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFAX.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFAX.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFAX.Changed = true;
            this.editFAX.Editing = false;
            this.editFAX.Label = "FAX";
            this.editFAX.LabelWidth = 175;
            this.editFAX.Location = new System.Drawing.Point(25, 330);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = true;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(811, 30);
            this.editFAX.TabIndex = 7;
            this.editFAX.Text = "EditControl";
            this.editFAX.Value = null;
            // 
            // editCAP
            // 
            this.editCAP.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCAP.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCAP.BackColor = System.Drawing.Color.Transparent;
            this.editCAP.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCAP.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCAP.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCAP.Changed = true;
            this.editCAP.Editing = false;
            this.editCAP.Label = "CAP";
            this.editCAP.LabelWidth = 175;
            this.editCAP.Location = new System.Drawing.Point(25, 198);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = true;
            this.editCAP.Required = true;
            this.editCAP.Size = new System.Drawing.Size(811, 30);
            this.editCAP.TabIndex = 3;
            this.editCAP.Text = "EditControl";
            this.editCAP.Value = null;
            // 
            // editIndirizzo
            // 
            this.editIndirizzo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIndirizzo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIndirizzo.BackColor = System.Drawing.Color.Transparent;
            this.editIndirizzo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIndirizzo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIndirizzo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIndirizzo.Changed = true;
            this.editIndirizzo.Editing = false;
            this.editIndirizzo.Label = "Indirizzo";
            this.editIndirizzo.LabelWidth = 175;
            this.editIndirizzo.Location = new System.Drawing.Point(25, 154);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = true;
            this.editIndirizzo.Required = true;
            this.editIndirizzo.Size = new System.Drawing.Size(813, 30);
            this.editIndirizzo.TabIndex = 2;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editIDConto;
        private Library.Template.Controls.TemplateEditText editIDCliente;
        private Library.Template.Controls.TemplateEditCombo editAzienda;
        private Library.Template.Controls.TemplateEditCombo editRagioneSociale;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditPartitaIva editPartitaIVA;
        private Library.Template.Controls.TemplateEditCountry editComune;
        private Library.Template.Controls.TemplateEditCodiceFiscale editCodiceFiscale;


    }
}
