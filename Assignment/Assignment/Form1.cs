using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        private bool isNew = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadForm1();
            this.LoadLibrary();
        }

        private void LoadForm1()
        {
            string query = "Select Book.*,[Library].category from Book,[Library] where Book.id = [Library].id";

            if(string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " AND Book.name like '%"+searchtxt.Text+"%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            bkTable.AutoGenerateColumns = false;
            bkTable.DataSource = dt;
            bkTable.Refresh();
            bkTable.ClearSelection();

            this.newBook();
        }

        private void LoadLibrary()
        {
            string query = "Select * from [Library]";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            cattxt.DataSource = dt;
            cattxt.DisplayMember = "category";
            cattxt.ValueMember = "id";
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadForm1();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadForm1();
        }

        private void bkTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string id = bkTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleBook();
            }
        }

        private void LoadSingleBook()
        {
            string query = "Select * from Book Where bookId = '"+idtxt.Text+"'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["bookId"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            authortxt.Text = dt.Rows[0]["author"].ToString();
            qntxt.Text = dt.Rows[0]["quantity"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
            cattxt.SelectedValue = dt.Rows[0]["id"].ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.newBook();
        }

        private void newBook()
        {
            isNew = true;
            idtxt.Text = "";
            nametxt.Text = "";
            authortxt.Text = "";
            qntxt.Text = "";
            pricetxt.Text = "";
            bkTable.ClearSelection();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "Delete from Book Where bookId = '" + idtxt.Text + "'";

            if(DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Book Deleted");
                this.LoadForm1();
                this.newBook();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = idtxt.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID required...");
                idtxt.Focus();
                return;
            }

            string name = nametxt.Text;

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name required...");
                nametxt.Focus();
                return;
            }

            string author = authortxt.Text;

            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Author required...");
                authortxt.Focus();
                return;
            }

            string quantity = qntxt.Text;

            if (string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Quantity required...");
                qntxt.Focus();
                return;
            }

            string price = pricetxt.Text;

            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Price required...");
                pricetxt.Focus();
                return;
            }

            if (cattxt.SelectedValue == null)
            {
                MessageBox.Show("Invalid Category...");
                cattxt.Focus();
                return;
            }

            string query = "";

            if(isNew == true)
            {
                query = "Insert into Book(bookId,name,author,quantity,price,id) values('" + id + "','" + name + "','" + author + "'," + quantity + "," + price + "," + cattxt.SelectedValue + ")";
            }
            else
            {
                query = "Update Book set bookId = '" + id + "',name = '" + name + "',author = '" + author + "',quantity = " + quantity + ",price = " + price + ",id = " + cattxt.SelectedValue + " where bookId = '" + idtxt.Text + "'";
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Inserted/Updated");
                this.LoadForm1();
                this.newBook();
            }
        }
    }
}
