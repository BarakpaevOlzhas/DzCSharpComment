using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsTable
{
    public partial class UserControlAddNew : UserControl
    {
        public UserControlAddNew()
        {
            InitializeComponent();
        }

        private void buttonAddNewT_Click(object sender, EventArgs e)
        {
            using (NewsContext NewsTable = new NewsContext())
            {
                NewsTable.NewT.Add(new New {
                    Basis = textBoxText.Text,
                    Head = textBoxHead.Text                   
                });

                NewsTable.SaveChanges();
            }            
        }
    }
}
