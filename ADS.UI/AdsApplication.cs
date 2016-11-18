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
            comboBoxSearchBookSelectLibrary.Items.Clear();
            comboBoxCheckoutSelectLibrary.Items.Clear();
            comboBoxShowBorrowedBooks.Items.Clear();
            comboBoxReturnBook.Items.Clear();
            string[] libs = _ctrl.ShowAllLibraries();
            for (int i = 0; i < libs.Length; i++)
            {
                comboBoxSearchBookSelectLibrary.Items.Add(libs[i]);
                comboBoxCheckoutSelectLibrary.Items.Add(libs[i]);
                comboBoxArchiveBookLibrary.Items.Add(libs[i]);
                comboBoxShowBorrowedBooks.Items.Add(libs[i]);
                comboBoxReturnBook.Items.Add(libs[i]);
            }
        }

        private void buttonSearchBook_Click(object sender, System.EventArgs e)
        {
            string bookTitle = textBoxSearchBookName.Text;
            string bookIsbn = textBoxSearchBookId.Text;

            string libraryName = comboBoxSearchBookSelectLibrary.SelectedItem?.ToString();

            if (bookTitle == "" && bookIsbn == "")
            {
                if (string.IsNullOrEmpty(libraryName))
                {
                    richTextBoxSearchedBooks.Text = _ctrl.ShowAllBooks();
                }
                else
                {
                    richTextBoxSearchedBooks.Text = _ctrl.ShowAllBooks(libraryName);
                }
            }
            else
            {
                if (bookTitle != "" && bookIsbn == "")
                {
                    if (string.IsNullOrEmpty(libraryName))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    richTextBoxSearchedBooks.Text = _ctrl.SearchBookByName(bookTitle, libraryName);
                }
                else if(bookTitle != "" && bookIsbn != "")
                {
                    if (string.IsNullOrEmpty(libraryName))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    richTextBoxSearchedBooks.Text = _ctrl.SearchBookByIsbn(bookIsbn, libraryName);
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
            string keyword = textBoxSearchReadername.Text;
            if (keyword == "")
            {
                richTextBoxSearchedReaders.Text = _ctrl.ShowAllReaders();
                return;
            }
            try
            {
                int number = int.Parse(keyword);
                string[] found = _ctrl.SearchReaderById(keyword);
                richTextBoxSearchedReaders.Text = ArrToStr(found);
            }
            catch (Exception)
            {
                string found = ArrToStr(_ctrl.SearchReaderByName(keyword));
                richTextBoxSearchedReaders.Text = found;
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
            if (textBoxSearchLibraryName.Text == "")
            {
                richTextBoxSearchedLibraries.Text = ArrToStr(_ctrl.ShowAllLibraries());
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

        private void buttonSelectFromFoundReaders_Click(object sender, EventArgs e)
        {
            // nastavi sa konkretny user do session

            RefreshReader();
            // session poskytne interface na zobrazenie userovych
            // a- v minulosti pozicanych knih
            // b- aktualne pozicanych knih
            // c- omeskanych vypoziciek
            // d-to stringu sera
            // metody na get a set jeho vlastnosti - zmena adresy, mena, flagu, ci si moze pozicat knihu
        }

        private void buttonCheckinSearchBook_Click(object sender, EventArgs e)
        {
            RefreshLibrary();
        }

        private void buttonCheckoutSelectBooksToBorrow_Click(object sender, EventArgs e)
        {
            if (_ctrl._model.ReaderSession == null)
            {
                MessageBox.Show("No reader is selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var library = comboBoxCheckoutSelectLibrary.SelectedItem?.ToString();
            var book = checkedListBoxCheckoutBorrowBooks.CheckedItems[0].ToString().Split(',');
            // to do
            int bookId = int.Parse(book[2]);
            string isbn = book[1];
            // od ot
            bool flag = _ctrl.BorrowBook(bookId, isbn, _ctrl._model.ReaderSession.Reader.UniqueId, library);
            if (!flag)
            {
                MessageBox.Show("Book can't be borrowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book was successfully borrowed", "Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshReader();
                RefreshLibrary();
            }
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

        private void buttonArchiveBookSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxArchiveBookName.Text;
            string bookId = textBoxArchiveBookId.Text;
            string library = comboBoxArchiveBookLibrary.SelectedItem?.ToString();

            if (name == "" && bookId == "")
            {
                if (string.IsNullOrEmpty(library))
                {
                    var books = _ctrl.ShowAllBooksArray();
                    checkedListBoxArchiveBook.Items.Clear();
                    foreach (var book in books)
                    {
                        checkedListBoxArchiveBook.Items.Add(book);
                    }
                }
                else
                {
                    var books = _ctrl.ShowAllBooksArray(library);
                    checkedListBoxArchiveBook.Items.Clear();
                    foreach (var book in books)
                    {
                        checkedListBoxArchiveBook.Items.Add(book);
                    }
                }
            }
            else
            {
                if (name != "")
                {
                    if (string.IsNullOrEmpty(library))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var books = _ctrl.SearchBookByNameArray(name, library);
                    checkedListBoxArchiveBook.Items.Clear();
                    foreach (var book in books)
                    {
                        checkedListBoxArchiveBook.Items.Add(book);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(library))
                    {
                        MessageBox.Show("Select a library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var books = _ctrl.SearchBookByIsbnArray(bookId, library);
                    checkedListBoxArchiveBook.Items.Clear();
                    foreach (var book in books)
                    {
                        checkedListBoxArchiveBook.Items.Add(book);
                    }
                }

            }
        }

        private void buttonArchiveBook_Click(object sender, EventArgs e)
        {
            var book = checkedListBoxArchiveBook.SelectedItem.ToString().Split(',');
            var bookIsbn = book[1].Trim();
            var bookId = int.Parse(book[2].Trim());
            var flag = _ctrl.ArchiveBook(bookIsbn, bookId);
            if (flag)
            {
                MessageBox.Show("Book successfully archived", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book was not archived", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var libId = comboBoxShowBorrowedBooks.SelectedItem.ToString();
            richTextBoxShowBorrowedBooks.Text = _ctrl.ShowBorrowedBooksInLibrary(libId);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var bookToReturn = checkedListBoxCheckoutCurrent.CheckedItems[0].ToString().Split(',');
                var isbn = bookToReturn[1].Trim();
                var bookId = int.Parse(bookToReturn[2].Trim());
                var readerId = _ctrl._model.ReaderSession.Reader.UniqueId;
                var libraryId = comboBoxReturnBook.SelectedItem.ToString();
                var flag = _ctrl.ReturnBook(isbn, bookId, readerId, libraryId);
                if (flag)
                {
                    MessageBox.Show("Book successfully returned", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book was not returned", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No book or reader was selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            RefreshReader();
        }

        private void RefreshReader()
        {
            if (checkedListBoxFoundReaders.SelectedItem == null)
            {
                if (checkedListBoxFoundReaders.Items.Count < 2)
                {
                    MessageBox.Show("Type in a keyword to show readers' data", "Information missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Please, select a reader", "Information missing", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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
        }

        public void RefreshLibrary()
        {
            try
            {
                string bookId = textBoxCheckoutSearchBook.Text;
                string library = comboBoxCheckoutSelectLibrary.SelectedItem?.ToString();
                if (bookId != "")
                {
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
                else
                {
                    var books = _ctrl.ShowAllBooksArray(library);
                    checkedListBoxCheckoutBorrowBooks.Items.Clear();
                    foreach (var book in books)
                    {
                        checkedListBoxCheckoutBorrowBooks.Items.Add(book);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Write a valid book id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}