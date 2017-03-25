using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;

namespace ConditionalRadioButton
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultImage.Visible = false;
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (pencilRadio.Checked)
            {
                
                resultLabel.Text = "So you're an avid pencil user?";
                resultImage.ImageUrl = "~/pencil.jpg";
                resultImage.Visible = true;

            }
            else if(penRadio.Checked){

                resultLabel.Text = "I too enjoy using pens";
                resultImage.ImageUrl = "~/pen.jpg";
                resultImage.Visible = true;
            }
            else if(laptopRadio.Checked){

                resultLabel.Text = "Thats nice, but you know you're just browsing reddit";
                resultImage.ImageUrl = "~/laptop.jpg";
                resultImage.Visible = true;

            }
            else if (tabletRadio.Checked)
            {
                resultLabel.Text = "Lets be real tablets suck for taking notes";
                resultImage.ImageUrl = "~/tablet.jpg";
                resultImage.Visible = true;
            }
            else
            {
                resultLabel.Text = "You need to select something";
                resultImage.Visible = false;
            }
        }
    }
}