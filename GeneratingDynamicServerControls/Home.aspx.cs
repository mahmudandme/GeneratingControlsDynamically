using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeneratingDynamicServerControls
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AddControl();
        }

        public void AddControl()
        {
            TextBox textBox1 = new TextBox();
            textBox1.Text = "TextBox";
            textBox1.Width = 200;
            textBox1.Height = 50;
            TextBox textBox2 = new TextBox();
            textBox2.Text = "TextBox";
            textBox2.Width = 200;
            textBox2.Height = 50;
            form1.Controls.Add(textBox1);

            //Panel panel = new Panel();
            Panel1.Controls.Add(textBox2);

            for (int i = 0; i < 10; i++)
            {
                TextBox textBox = new TextBox();
                textBox.ID = "textBox"+ i;
                textBox.Width = 200;
                textBox.Height = 40;
                textBox.Text = "TextBox" + i;
                Panel1.Controls.Add(textBox);
                textBox.CssClass = "form-control";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Text = "TextBox";
            textBox1.Width = 200;
            textBox1.Height = 50;
            TextBox textBox2 = new TextBox();
            textBox2.Text = "TextBox";
            textBox2.Width = 200;
            textBox2.Height = 50;
            form1.Controls.Add(textBox1);

            //Panel panel = new Panel();
            Panel1.Controls.Add(textBox2);

            for (int i = 0; i < 10; i++)
            {
                TextBox textBox = new TextBox();
                textBox.ID = "textBox" + i;
                textBox.Width = 200;
                textBox.Height = 40;
                textBox.Text = "TextBox" + i;
                Panel1.Controls.Add(textBox);
                textBox.CssClass = "form-control";
            }
        }
    }
}

