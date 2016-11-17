using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ADS.Core.Domain.Controller;

namespace Advanced_Data_Structures
{
    public partial class AdsApplication : Form
    {
        private LibraryController _ctrl;

        public AdsApplication()
        {
            InitializeComponent();
            _ctrl = new LibraryController();
            comboBox2.Items.Clear();
            comboBoxCheckoutSelectLibrary.Items.Clear();
            string[] libs = _ctrl.ShowAllLibraries();
            for (int i = 0; i < libs.Length; i++)
            {
                comboBox2.Items.Add(libs[i]);
                comboBoxCheckoutSelectLibrary.Items.Add(libs[i]);
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            string keyword1 = textBox8.Text;
            string keyword2 = textBox12.Text;
            string library = comboBox2.SelectedItem?.ToString();

            if (keyword1 == "" && keyword2 == "")
            {
                if (string.IsNullOrEmpty(library))
                {
                    richTextBox1.Text = _ctrl.ShowAllBooks();
                }
                else
                {
                    richTextBox1.Text = _ctrl.ShowAllBooks(library);
                }
            }
            else
            {
                if (keyword1 != "")
                {
                    if (string.IsNullOrEmpty(library))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    richTextBox1.Text = _ctrl.SearchBookByName(keyword1, library);
                }
                else
                {
                    if (string.IsNullOrEmpty(library))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    richTextBox1.Text = _ctrl.SearchBookByIsbn(keyword2, library);
                }

            }

        }

        private void buttonSearchByLibraryCardId_Click(object sender, System.EventArgs e)
        {
            string readerId = textBoxSearchByLibraryCardId.Text;
            string[] readers = _ctrl.SearchReaderById(readerId);
            checkedListBoxFoundReaders.Items.Clear();
            foreach (var reader in readers)
            {
                checkedListBoxFoundReaders.Items.Add(reader);
            }
        }

        private void buttonSearchByLibraryCardIdCheckout_Click(object sender, System.EventArgs e)
        {
            string readerId = textBoxSearchByLibraryCardId.Text;
            string[] readers = _ctrl.SearchReaderById(readerId);
            checkedListBox2.Items.Clear();
            foreach (var reader in readers)
            {
                checkedListBox2.Items.Add(reader);
            }
        }

        private void buttonSearchByReaderName_Click(object sender, System.EventArgs e)
        {
            string readerId = textBoxSearchByReaderName.Text;
            string[] readers = _ctrl.SearchReaderByName(readerId);
            checkedListBoxFoundReaders.Items.Clear();
            foreach (var reader in readers)
            {
                if (reader != null)
                {
                    checkedListBoxFoundReaders.Items.Add(reader);
                }
            }
        }

        private void buttonSearchByReaderNameCheckout_Click(object sender, System.EventArgs e)
        {
            string readerId = textBoxSearchByReaderName.Text;
            string[] readers = _ctrl.SearchReaderByName(readerId);
            checkedListBox2.Items.Clear();
            foreach (var reader in readers)
            {
                if (reader != null)
                {
                    checkedListBox2.Items.Add(reader);
                }
            }
        }

        private void checkedListBoxFoundReaders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < checkedListBoxFoundReaders.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        checkedListBoxFoundReaders.SetItemChecked(ix, false);
                    }
                }
            }
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            string name, surname, address, dateOfBirth;
            name = textBoxNewReaderName.Text;
            surname = textBoxNewReaderSurname.Text;
            address = textBoxNewReaderAddress.Text;
            dateOfBirth = dateTimePickerNewReaderDateOfBirth.Text;
            _ctrl.AddNewReader(name, surname, address, dateOfBirth);
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            string keyword = textBox11.Text;
            if (keyword == "")
            {
                richTextBox2.Text = _ctrl.ShowAllReaders();
                return;
            }
            try
            {
                int number = int.Parse(keyword);
                string[] found = _ctrl.SearchReaderById(keyword);
                richTextBox2.Text = ArrToStr(found);
            }
            catch (Exception)
            {
                string found = ArrToStr(_ctrl.SearchReaderByName(keyword));
                richTextBox2.Text = found;
            }
        }

        private string ArrToStr(string[] a)
        {
            string text = "";

            for (int i = 0; i < a.Length; i++)
            {
                text += a[i] + "\n";
            }

            return text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                richTextBox3.Text = ArrToStr(_ctrl.ShowAllLibraries());
            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string title = textBoxRegisterTitle.Text;
            string author = textBoxRegisterAuthors.Text;
            string genre = textBoxRegisterGenre.Text;
            string isbn = textBoxRegisterIsbn.Text;
            int fee = int.Parse(textBoxRegisterFee.Text);
            int borrowLength = int.Parse(textBoxRegisterBorrowLength.Text);
            string libraryName = comboBoxRegisterLibrary.SelectedItem.ToString();
            // v konstruktore chyba fee
            // borrow length

            // chyba dopocet eanu, to je zasa navyse vo formulari
            // 

            _ctrl.AddNewBook(title, author, genre, isbn, isbn, libraryName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBoxCurrentlyBorrowed.Items.Clear();
            string[] s = _ctrl.ShowBorrowedBooksCurrently(textBoxReaderId.Text);

            foreach (var book in s)
            {
                if (book != null)
                {
                    checkedListBoxCurrentlyBorrowed.Items.Add(book);
                }
            }
        }

        private void buttonSelectFromFoundReaders_Click(object sender, EventArgs e)
        {
            // nastavi sa konkretny user do session
            var selectedReader = checkedListBoxFoundReaders.SelectedItem.ToString().Split(',');
            var readerId = selectedReader[1].Trim();

            checkedListBoxCheckoutCurrent.Items.Clear();
            checkedListBoxCheckoutPrevious.Items.Clear();
            checkedListBoxCheckoutLate.Items.Clear();

            if (readerId != "")
            {
                string[] s = _ctrl.ShowBorrowedBooksCurrently(readerId);
                string[] previous = _ctrl.ShowBorrowedBooksPast(readerId);
                string[] late = _ctrl.ShowLateReturnedBooks(readerId, new DateTime(), new DateTime());

                if (s != null)
                {
                    foreach (var book in s)
                    {
                        if (book != null)
                        {
                            checkedListBoxCheckoutCurrent.Items.Add(book);
                        }
                    }
                }

                if (previous != null)
                {
                    foreach (var book in previous)
                    {
                        if (book != null)
                        {
                            checkedListBoxCheckoutPrevious.Items.Add(book);
                        }
                    }
                }

                if (late != null)
                {
                    foreach (var book in late)
                    {
                        if (book != null)
                        {
                            checkedListBoxCheckoutLate.Items.Add(book);
                        }
                    }
                }
            }
            // session poskytne interface na zobrazenie userovych
            // a- v minulosti pozicanych knih
            // b- aktualne pozicanych knih
            // c- omeskanych vypoziciek
            // d-to stringu sera
            // metody na get a set jeho vlastnosti - zmena adresy, mena, flagu, ci si moze pozicat knihu
        }

        private void buttonCheckinSearchBook_Click(object sender, EventArgs e)
        {
            string bookId;
            try
            {
                bookId = textBoxCheckoutSearchBook.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Write a valid book id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }

            string library = comboBoxCheckoutSelectLibrary.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(library))
            {
                MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var books = _ctrl.SearchBookByIsbnArray(bookId, library);
            checkedListBoxCheckoutBorrowBooks.Items.Clear();
            foreach (var book in books)
            {
                checkedListBoxCheckoutBorrowBooks.Items.Add(book);
            }
        }

        private void buttonCheckoutSelectBooksToBorrow_Click(object sender, EventArgs e)
        {
            var library = comboBoxCheckoutSelectLibrary.SelectedItem?.ToString();
            var book = checkedListBoxCheckoutBorrowBooks.CheckedItems[0].ToString().Split(',');
            // to do
            int bookId = int.Parse(book[2]);
            string isbn = book[1];
            // od ot
            _ctrl.BorrowBook(bookId, isbn, _ctrl._model.ReaderSession.Reader.UniqueId, library);

            // dorobit kontrolu
            // a a ci si moze reader poziciavat knihy
            // b ci kniha niej e pozicana, archivovana alebo co
            
            // dorobit znovunacitanie zoznamu pozicanych knih v GUIcku
        }

        private void checkedListBoxCheckoutBorrowBooks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < checkedListBoxCheckoutBorrowBooks.Items.Count; ++ix)
                {
                    if (e.Index != ix)
                    {
                        checkedListBoxCheckoutBorrowBooks.SetItemChecked(ix, false);
                    }
                }
            }
        }
    }
}