using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplorerApplication
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            var docs = new TreeNode("My Documents");
            docs.Tag = "C:\\Users\bailey.heinen\\Documents";
           // docs.Tag = System.IO.Path.GetFullPath("C:\\Users\bailey.heinen\\Documents");
        }
    }
}
