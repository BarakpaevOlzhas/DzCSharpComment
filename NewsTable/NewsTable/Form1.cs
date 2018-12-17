using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsTable
{
    public partial class Form1 : Form
    {
        public List<New> ListNew { set; get; }
        public List<Comment> ListComment { set; get; }
        public int Count { set; get; }        

        public Form1()
        {
            

            ListNew = new List<New>();
            ListComment = new List<Comment>();

            InitializeComponent();
            userControlAddNew1.BringToFront();
            using (NewsContext NewsTable = new NewsContext())
            {                
                    NewsTable.Database.CreateIfNotExists();

                    NewsTable.Database.Initialize(false);

                    foreach (var i in NewsTable.NewT)
                    {
                        ListNew.Add(i);
                    }

                    foreach (var i in NewsTable.CommentT)
                    {
                        ListComment.Add(i);
                    }

                    if (ListNew.Count != 0)
                    {
                        labelHead.Text = ListNew[0].Head;
                        labelText.Text = ListNew[0].Basis;
                        Count = 0;
                    }                
            }

            foreach (var i in ListComment)
            {
                if (i.IdNew == ListNew[Count])
                {
                    labelComment.Text += i.Text + '\n' + '\n';
                }
            }
        }

        private void labelHead_Click(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (Count < ListNew.Count - 1)
            {
                Count++;
                labelHead.Text = ListNew[Count].Head;
                labelText.Text = ListNew[Count].Basis;
                labelComment.Text = "";

                foreach (var i in ListComment)
                {
                    if (i.IdNew == ListNew[Count])
                    {
                        labelComment.Text += i.Text + '\n' + '\n';
                    }
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (Count != 0)
            {
                Count--;
                labelHead.Text = ListNew[Count].Head;
                labelText.Text = ListNew[Count].Basis;
                labelComment.Text = "";

                foreach (var i in ListComment)
                {
                    if (i.IdNew == ListNew[Count])
                    {
                        labelComment.Text += i.Text + '\n' + '\n';
                    }
                }
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            userControlAddNew1.Visible = true;
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            userControlAddNew1.Visible = false;
        }

        private void userControlAddNew1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListNew.Count; i++) 
            {               
                ListNew.Remove(ListNew[i]);
                i--;
            }
            for (int i = 0; i < ListComment.Count; i++)
            {
                ListComment.Remove(ListComment[i]);
                i--;
            }
            labelComment.Text = "";

            using (NewsContext NewsTable = new NewsContext())
            {        
                foreach (var i in NewsTable.NewT)
                {
                    ListNew.Add(i);
                }

                foreach (var i in NewsTable.CommentT)
                {
                    ListComment.Add(i);
                }

                if (ListNew.Count != 0)
                {
                    labelHead.Text = ListNew[0].Head;
                    labelText.Text = ListNew[0].Basis;
                    Count = 0;
                }
            }

            foreach (var i in ListComment)
            {
                if (i.IdNew == ListNew[Count])
                {
                    labelComment.Text += i.Text + '\n' + '\n';
                }
            }
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {           
            using (NewsContext NewsTable = new NewsContext())
            {
                Guid sd = ListNew[Count].Id;

                New newss = NewsTable.NewT
        .Where(c => c.Id == sd)
        .FirstOrDefault();

                NewsTable.CommentT.Add(new Comment {                   
                    Text = textBoxCommentAdd.Text,
                    IdNew = newss
                });

                NewsTable.SaveChanges();
            }
        }

        private void userControlAddNew1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
