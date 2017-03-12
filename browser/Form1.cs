using Awesomium.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        private void addressBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void addressBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            if (e.KeyCode == Keys.Return)
            {
                //MessageBox.Show(e.KeyCode.ToString());
                //this.webControl1.Source = new Uri(this.addressBox1.URL);
                textBox1.Text = webControl1.HTML;
                //webControl1.
            }
        }

        private void Awesomium_Windows_Forms_WebControl_DocumentReady(object sender, DocumentReadyEventArgs e)
        {
            try
            {
                dynamic document = (JSObject)webControl1.ExecuteJavascriptWithResult("document");

                if (document == null)
                    return;

                using (document)
                {
                    // This is an invocation. If the object does not contain
                    // a method named 'getElementById', you would get a 
                    // RuntimeBinderException. Of course this cannot be the
                    // case with the 'document' object.
                    dynamic elem = document.getElementById("index_email");

                    if (elem == null)
                        return;

                    using (elem)
                        // This is a property setting. If the object does not
                        // contain a property named 'value', you should NOT get an
                        // exception. JavaScript is dynamic so this code would just
                        // add a 'value' property to the object, even if one was not
                        // there before, and set its value to "test".
                        elem.value = "test";
                }
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return;
            }
            catch
            {
                throw;
            }
        }
    }
}
