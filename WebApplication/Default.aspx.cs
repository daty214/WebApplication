using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        private int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                i = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bind(i);
        }

        private void bind(int i)
        {
            return;
        }
    }
}