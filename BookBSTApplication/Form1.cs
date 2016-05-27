using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBST;

namespace BookBSTApplication
{
    public partial class Form1 : Form
    {
        protected BookBST.BookBST Books = new BookBST.BookBST();
        private int SelectedRowIndex = -1;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Books.GetBookList();int rowIndex = -1;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Text = "";
            lbl_SuccessMessage.Text = "";
            try
            {
                bool success = true;
                int isbn, rating, year;
                if (!Int32.TryParse(tb_isbn.Text, out isbn))
                {
                    success = false;
                    lbl_ErrorMessage.Text += "ISBN must be a valid integer\n";
                }
                if (!Int32.TryParse(num_rating.Text, out rating))
                {
                    success = false;
                    lbl_ErrorMessage.Text += "Rating must be a valid number\n";
                }
                if (!Int32.TryParse(tb_year.Text, out year))
                {
                    success = false;
                    lbl_ErrorMessage.Text += "Year must be a valid 4 digit year";
                }
                if (!success)
                {
                    return;
                }
                Book b = new Book(isbn, tb_author.Text, tb_title.Text, rating, year);
                Books.Add(b);
                dataGridView1.DataSource = Books.GetBookList();
                lbl_SuccessMessage.Text = "Book Added Successfully!";
            }
            catch (Exception ex)
            {
                lbl_ErrorMessage.Text = ex.Message;
            }
            tb_isbn.Text = "";
            tb_author.Text = "";
            tb_title.Text = "";
            num_rating.Text = "";
            tb_year.Text = "";
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Text = "";
            lbl_SuccessMessage.Text = "";

            int isbn;
            bool success = Int32.TryParse(tb_Find.Text, out isbn);
            if (!success)
            {
                lbl_ErrorMessage.Text = "Please enter an Integer to find by ISBN";
                tb_Find.Focus();
            }
            else
            {
                try
                {
                    Book b = Books.Find(isbn);
                    //  If we made it here, all was good
                    lbl_SuccessMessage.Text = String.Format("ISBN #{0} was found!\nTitle: {1}, Author: {2}", isbn, b.Title, b.Author);
                    
                    // Highlight the row in the datagrid
                    
                    DataGridViewRow row = dataGridView1.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells["Isbn"].Value.ToString().Equals(isbn.ToString()))
                        .First();
                    if (SelectedRowIndex > -1) dataGridView1.Rows[SelectedRowIndex].Selected = false;
                    SelectedRowIndex = row.Index;
                    dataGridView1.Rows[SelectedRowIndex].Selected = true;
                    tb_Find.Text = "";
                    
                }
                catch (Exception ex)
                {
                    lbl_ErrorMessage.Text = ex.Message;
                    tb_Find.Focus();
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Text = "";
            lbl_SuccessMessage.Text = "";
            try
            {
                int isbn;
                if (Int32.TryParse(tb_Remove.Text, out isbn))
                {
                    Book removed = Books.Remove(isbn);
                    lbl_SuccessMessage.Text =
                        String.Format("Book removed successfully!\nISBN: {0}, Title: {1}, Author: {2}", removed.Isbn,
                            removed.Title, removed.Author);
                    dataGridView1.DataSource = Books.GetBookList();
                }
                else
                {
                    throw new Exception("Please enter a valid ISBN to remove");
                }
            }
            catch (Exception ex)
            {
                lbl_ErrorMessage.Text = ex.Message;
            }
            
            tb_Remove.Text = "";
        }
    }
}
