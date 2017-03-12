namespace browser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.addressBox1 = new Awesomium.Windows.Forms.AddressBox();
            this.webSessionProvider1 = new Awesomium.Windows.Forms.WebSessionProvider(this.components);
            this.webControlContextMenu1 = new Awesomium.Windows.Forms.WebControlContextMenu(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.Location = new System.Drawing.Point(12, 38);
            this.webControl1.NavigationInfo = Awesomium.Core.NavigationInfo.Normal;
            this.webControl1.Size = new System.Drawing.Size(545, 350);
            this.webControl1.Source = new System.Uri("http://vk.com/", System.UriKind.Absolute);
            this.webControl1.TabIndex = 0;
            this.webControl1.ViewType = Awesomium.Core.WebViewType.Offscreen;
            this.webControl1.DocumentReady += new Awesomium.Core.DocumentReadyEventHandler(this.Awesomium_Windows_Forms_WebControl_DocumentReady);
            // 
            // addressBox1
            // 
            this.addressBox1.AcceptsReturn = true;
            this.addressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressBox1.Location = new System.Drawing.Point(12, 12);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(758, 20);
            this.addressBox1.TabIndex = 1;
            this.addressBox1.URL = new System.Uri("", System.UriKind.Relative);
            this.addressBox1.WebControl = this.webControl1;
            this.addressBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBox1_KeyDown);
            this.addressBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox1_KeyPress);
            // 
            // webSessionProvider1
            // 
            this.webSessionProvider1.Views.Add(this.webControl1);
            // 
            // webControlContextMenu1
            // 
            this.webControlContextMenu1.Name = "webControlContextMenu1";
            this.webControlContextMenu1.Size = new System.Drawing.Size(204, 126);
            this.webControlContextMenu1.View = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 350);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.webControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl webControl1;
        private Awesomium.Windows.Forms.AddressBox addressBox1;
        private Awesomium.Windows.Forms.WebSessionProvider webSessionProvider1;
        private Awesomium.Windows.Forms.WebControlContextMenu webControlContextMenu1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

