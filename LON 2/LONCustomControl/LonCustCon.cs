using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace LONCustomControl
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:LonCustCon runat=server></{0}:LonCustCon>")]
    public class LonCustCon : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? "[" + this.ID + "]" : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            
            string path =@"D:\project\LON\Project\LON\LON\Template\"+this.ID+".htm";
            StreamReader reader = new StreamReader(path);
            output.Write(reader.ReadToEnd());
        }
    }
}
