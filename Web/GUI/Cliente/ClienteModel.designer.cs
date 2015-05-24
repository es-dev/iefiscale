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
            this.editAnagraficaAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editAnagraficaAzienda);
            this.container.Controls.Add(this.editAzienda);
            this.container.Controls.Add(this.editIDCliente);
            this.container.Controls.Add(this.editIDConto);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editIDConto, 0);
            this.container.Controls.SetChildIndex(this.editIDCliente, 0);
            this.container.Controls.SetChildIndex(this.editAzienda, 0);
            this.container.Controls.SetChildIndex(this.editAnagraficaAzienda, 0);
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
            this.editIDConto.Label = "Id conto";
            this.editIDConto.LabelWidth = 175;
            this.editIDConto.Location = new System.Drawing.Point(25, 156);
            this.editIDConto.Name = "editIDConto";
            this.editIDConto.ReadOnly = false;
            this.editIDConto.Required = true;
            this.editIDConto.Size = new System.Drawing.Size(813, 30);
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
            this.editIDCliente.Label = "Id cliente";
            this.editIDCliente.LabelWidth = 175;
            this.editIDCliente.Location = new System.Drawing.Point(25, 199);
            this.editIDCliente.Name = "editIDCliente";
            this.editIDCliente.ReadOnly = false;
            this.editIDCliente.Required = true;
            this.editIDCliente.Size = new System.Drawing.Size(813, 30);
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
            // editAnagraficaAzienda
            // 
            this.editAnagraficaAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAnagraficaAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAnagraficaAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editAnagraficaAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAnagraficaAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAnagraficaAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAnagraficaAzienda.Changed = true;
            this.editAnagraficaAzienda.Editing = false;
            this.editAnagraficaAzienda.Label = "Anagrafica azienda";
            this.editAnagraficaAzienda.LabelWidth = 175;
            this.editAnagraficaAzienda.Location = new System.Drawing.Point(25, 111);
            this.editAnagraficaAzienda.Model = null;
            this.editAnagraficaAzienda.Name = "editAnagraficaAzienda";
            this.editAnagraficaAzienda.ReadOnly = false;
            this.editAnagraficaAzienda.Required = true;
            this.editAnagraficaAzienda.Size = new System.Drawing.Size(811, 30);
            this.editAnagraficaAzienda.TabIndex = 1000;
            this.editAnagraficaAzienda.Value = null;
            this.editAnagraficaAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaAzienda_ComboConfirm);
            this.editAnagraficaAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaAzienda_ComboClick);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editIDConto;
        private Library.Template.Controls.TemplateEditText editIDCliente;
        private Library.Template.Controls.TemplateEditCombo editAzienda;
        private Library.Template.Controls.TemplateEditCombo editAnagraficaAzienda;


    }
}
