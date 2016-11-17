using ADS.Core.Domain.Controller;

namespace Advanced_Data_Structures
{
    partial class AdsApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdsApplication));
            this.tabControlOuter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlCheckout = new System.Windows.Forms.TabControl();
            this.tabPageCheckoutReader = new System.Windows.Forms.TabPage();
            this.buttonSelectFromFoundReaders = new System.Windows.Forms.Button();
            this.buttonSearchByReaderName = new System.Windows.Forms.Button();
            this.buttonSearchByLibraryCardId = new System.Windows.Forms.Button();
            this.checkedListBoxFoundReaders = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearchByReaderName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearchByLibraryCardId = new System.Windows.Forms.TextBox();
            this.tabPageCheckoutCurrent = new System.Windows.Forms.TabPage();
            this.checkedListBoxCheckoutCurrent = new System.Windows.Forms.CheckedListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tabPageCheckoutPrevious = new System.Windows.Forms.TabPage();
            this.checkedListBoxCheckoutPrevious = new System.Windows.Forms.CheckedListBox();
            this.tabPageCheckoutLateReturns = new System.Windows.Forms.TabPage();
            this.checkedListBoxCheckoutLate = new System.Windows.Forms.CheckedListBox();
            this.tabPageCheckoutBorrow = new System.Windows.Forms.TabPage();
            this.labelBorrowSelectLibrary = new System.Windows.Forms.Label();
            this.comboBoxCheckoutSelectLibrary = new System.Windows.Forms.ComboBox();
            this.buttonCheckoutSelectBooksToBorrow = new System.Windows.Forms.Button();
            this.buttonCheckoutSearchBook = new System.Windows.Forms.Button();
            this.checkedListBoxCheckoutBorrowBooks = new System.Windows.Forms.CheckedListBox();
            this.labelBorrowBookId = new System.Windows.Forms.Label();
            this.textBoxCheckoutSearchBook = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlCheckin = new System.Windows.Forms.TabControl();
            this.tabPageCheckinReader = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReaderId = new System.Windows.Forms.TextBox();
            this.tabPageCheckinCurrent = new System.Windows.Forms.TabPage();
            this.checkedListBoxCurrentlyBorrowed = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageCheckinPrevious = new System.Windows.Forms.TabPage();
            this.checkedListBoxPastBorrowed = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPageCheckinReservations = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlRegister = new System.Windows.Forms.TabControl();
            this.tabPageRegisterReader = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePickerNewReaderDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNewReaderAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNewReaderSurname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNewReaderName = new System.Windows.Forms.TextBox();
            this.buttonRegisterNewUser = new System.Windows.Forms.Button();
            this.tabPageRegisterBook = new System.Windows.Forms.TabPage();
            this.buttonRegisterNewBook = new System.Windows.Forms.Button();
            this.comboBoxRegisterLibrary = new System.Windows.Forms.ComboBox();
            this.textBoxRegisterBookId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxRegisterFee = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxRegisterBorrowLength = new System.Windows.Forms.TextBox();
            this.textBoxRegisterIsbn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRegisterGenre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxRegisterAuthors = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRegisterTitle = new System.Windows.Forms.TextBox();
            this.tabPageRegisterLibrary = new System.Windows.Forms.TabPage();
            this.buttonRegisterNewLibrary = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNewLibraryName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControlArchive = new System.Windows.Forms.TabControl();
            this.tabPageArchiveBook = new System.Windows.Forms.TabPage();
            this.buttonArchiveBook = new System.Windows.Forms.Button();
            this.labelArchiveBookLibrary = new System.Windows.Forms.Label();
            this.labelArchiveBookId = new System.Windows.Forms.Label();
            this.textBoxArchiveBookId = new System.Windows.Forms.TextBox();
            this.labelArchiveBookName = new System.Windows.Forms.Label();
            this.comboBoxArchiveBookLibrary = new System.Windows.Forms.ComboBox();
            this.textBoxArchiveBookName = new System.Windows.Forms.TextBox();
            this.buttonArchiveBookSearch = new System.Windows.Forms.Button();
            this.tabPageArchiveReader = new System.Windows.Forms.TabPage();
            this.buttonArchiveReader = new System.Windows.Forms.Button();
            this.textBoxArchiveReaderSearch = new System.Windows.Forms.TextBox();
            this.buttonArchiveReaderSearch = new System.Windows.Forms.Button();
            this.richTextBoxArchiveReader = new System.Windows.Forms.RichTextBox();
            this.tabPageArchiveLibrary = new System.Windows.Forms.TabPage();
            this.buttonArchiveSelectedLibrary = new System.Windows.Forms.Button();
            this.textBoxArchiveLibraryName = new System.Windows.Forms.TextBox();
            this.buttonArchiveLibrarySearch = new System.Windows.Forms.Button();
            this.richTextBoxArchiveLibrary = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPageSearchBook = new System.Windows.Forms.TabPage();
            this.labelSearchBookSelectLibrary = new System.Windows.Forms.Label();
            this.labelSearchBookId = new System.Windows.Forms.Label();
            this.textBoxSearchBookId = new System.Windows.Forms.TextBox();
            this.labelSearchBookName = new System.Windows.Forms.Label();
            this.comboBoxSearchBookSelectLibrary = new System.Windows.Forms.ComboBox();
            this.textBoxSearchBookName = new System.Windows.Forms.TextBox();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.richTextBoxSearchedBooks = new System.Windows.Forms.RichTextBox();
            this.tabPageSearchReader = new System.Windows.Forms.TabPage();
            this.textBoxSearchReadername = new System.Windows.Forms.TextBox();
            this.buttonSearchReader = new System.Windows.Forms.Button();
            this.richTextBoxSearchedReaders = new System.Windows.Forms.RichTextBox();
            this.tabPageSearchLibrary = new System.Windows.Forms.TabPage();
            this.textBoxSearchLibraryName = new System.Windows.Forms.TextBox();
            this.buttonSearchLibrary = new System.Windows.Forms.Button();
            this.richTextBoxSearchedLibraries = new System.Windows.Forms.RichTextBox();
            this.checkedListBoxArchiveBook = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxShowBorrowedBooks = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBoxShowBorrowedBooks = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxReturnBook = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlOuter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlCheckout.SuspendLayout();
            this.tabPageCheckoutReader.SuspendLayout();
            this.tabPageCheckoutCurrent.SuspendLayout();
            this.tabPageCheckoutPrevious.SuspendLayout();
            this.tabPageCheckoutLateReturns.SuspendLayout();
            this.tabPageCheckoutBorrow.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlCheckin.SuspendLayout();
            this.tabPageCheckinReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageCheckinCurrent.SuspendLayout();
            this.tabPageCheckinPrevious.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControlRegister.SuspendLayout();
            this.tabPageRegisterReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageRegisterBook.SuspendLayout();
            this.tabPageRegisterLibrary.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControlArchive.SuspendLayout();
            this.tabPageArchiveBook.SuspendLayout();
            this.tabPageArchiveReader.SuspendLayout();
            this.tabPageArchiveLibrary.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControlSearch.SuspendLayout();
            this.tabPageSearchBook.SuspendLayout();
            this.tabPageSearchReader.SuspendLayout();
            this.tabPageSearchLibrary.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOuter
            // 
            this.tabControlOuter.Controls.Add(this.tabPage1);
            this.tabControlOuter.Controls.Add(this.tabPage2);
            this.tabControlOuter.Controls.Add(this.tabPage3);
            this.tabControlOuter.Controls.Add(this.tabPage4);
            this.tabControlOuter.Controls.Add(this.tabPage5);
            this.tabControlOuter.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlOuter.Location = new System.Drawing.Point(12, 12);
            this.tabControlOuter.Name = "tabControlOuter";
            this.tabControlOuter.Padding = new System.Drawing.Point(50, 10);
            this.tabControlOuter.SelectedIndex = 0;
            this.tabControlOuter.Size = new System.Drawing.Size(767, 742);
            this.tabControlOuter.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlCheckout);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 697);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check-out";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlCheckout
            // 
            this.tabControlCheckout.Controls.Add(this.tabPageCheckoutReader);
            this.tabControlCheckout.Controls.Add(this.tabPageCheckoutCurrent);
            this.tabControlCheckout.Controls.Add(this.tabPageCheckoutPrevious);
            this.tabControlCheckout.Controls.Add(this.tabPageCheckoutLateReturns);
            this.tabControlCheckout.Controls.Add(this.tabPageCheckoutBorrow);
            this.tabControlCheckout.Location = new System.Drawing.Point(6, 6);
            this.tabControlCheckout.Name = "tabControlCheckout";
            this.tabControlCheckout.Padding = new System.Drawing.Point(30, 10);
            this.tabControlCheckout.SelectedIndex = 0;
            this.tabControlCheckout.Size = new System.Drawing.Size(746, 685);
            this.tabControlCheckout.TabIndex = 1;
            // 
            // tabPageCheckoutReader
            // 
            this.tabPageCheckoutReader.Controls.Add(this.buttonSelectFromFoundReaders);
            this.tabPageCheckoutReader.Controls.Add(this.buttonSearchByReaderName);
            this.tabPageCheckoutReader.Controls.Add(this.buttonSearchByLibraryCardId);
            this.tabPageCheckoutReader.Controls.Add(this.checkedListBoxFoundReaders);
            this.tabPageCheckoutReader.Controls.Add(this.label8);
            this.tabPageCheckoutReader.Controls.Add(this.textBoxSearchByReaderName);
            this.tabPageCheckoutReader.Controls.Add(this.label9);
            this.tabPageCheckoutReader.Controls.Add(this.label10);
            this.tabPageCheckoutReader.Controls.Add(this.textBoxSearchByLibraryCardId);
            this.tabPageCheckoutReader.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckoutReader.Name = "tabPageCheckoutReader";
            this.tabPageCheckoutReader.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckoutReader.TabIndex = 3;
            this.tabPageCheckoutReader.Text = "Reader";
            this.tabPageCheckoutReader.UseVisualStyleBackColor = true;
            // 
            // buttonSelectFromFoundReaders
            // 
            this.buttonSelectFromFoundReaders.Location = new System.Drawing.Point(456, 266);
            this.buttonSelectFromFoundReaders.Name = "buttonSelectFromFoundReaders";
            this.buttonSelectFromFoundReaders.Size = new System.Drawing.Size(217, 37);
            this.buttonSelectFromFoundReaders.TabIndex = 8;
            this.buttonSelectFromFoundReaders.Text = "Select";
            this.buttonSelectFromFoundReaders.UseVisualStyleBackColor = true;
            this.buttonSelectFromFoundReaders.Click += new System.EventHandler(this.buttonSelectFromFoundReaders_Click);
            // 
            // buttonSearchByReaderName
            // 
            this.buttonSearchByReaderName.Location = new System.Drawing.Point(255, 183);
            this.buttonSearchByReaderName.Name = "buttonSearchByReaderName";
            this.buttonSearchByReaderName.Size = new System.Drawing.Size(134, 27);
            this.buttonSearchByReaderName.TabIndex = 7;
            this.buttonSearchByReaderName.Text = "Search";
            this.buttonSearchByReaderName.UseVisualStyleBackColor = true;
            this.buttonSearchByReaderName.Click += new System.EventHandler(this.buttonSearchByReaderName_Click);
            // 
            // buttonSearchByLibraryCardId
            // 
            this.buttonSearchByLibraryCardId.Location = new System.Drawing.Point(255, 115);
            this.buttonSearchByLibraryCardId.Name = "buttonSearchByLibraryCardId";
            this.buttonSearchByLibraryCardId.Size = new System.Drawing.Size(134, 27);
            this.buttonSearchByLibraryCardId.TabIndex = 6;
            this.buttonSearchByLibraryCardId.Text = "Search";
            this.buttonSearchByLibraryCardId.UseVisualStyleBackColor = true;
            this.buttonSearchByLibraryCardId.Click += new System.EventHandler(this.buttonSearchByLibraryCardId_Click);
            // 
            // checkedListBoxFoundReaders
            // 
            this.checkedListBoxFoundReaders.FormattingEnabled = true;
            this.checkedListBoxFoundReaders.Location = new System.Drawing.Point(36, 266);
            this.checkedListBoxFoundReaders.Name = "checkedListBoxFoundReaders";
            this.checkedListBoxFoundReaders.Size = new System.Drawing.Size(353, 164);
            this.checkedListBoxFoundReaders.TabIndex = 5;
            this.checkedListBoxFoundReaders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFoundReaders_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Reader\'s name";
            // 
            // textBoxSearchByReaderName
            // 
            this.textBoxSearchByReaderName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchByReaderName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchByReaderName.Location = new System.Drawing.Point(36, 183);
            this.textBoxSearchByReaderName.Name = "textBoxSearchByReaderName";
            this.textBoxSearchByReaderName.Size = new System.Drawing.Size(222, 27);
            this.textBoxSearchByReaderName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(32, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search by...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Library card id";
            // 
            // textBoxSearchByLibraryCardId
            // 
            this.textBoxSearchByLibraryCardId.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchByLibraryCardId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchByLibraryCardId.Location = new System.Drawing.Point(36, 115);
            this.textBoxSearchByLibraryCardId.Name = "textBoxSearchByLibraryCardId";
            this.textBoxSearchByLibraryCardId.Size = new System.Drawing.Size(222, 27);
            this.textBoxSearchByLibraryCardId.TabIndex = 0;
            // 
            // tabPageCheckoutCurrent
            // 
            this.tabPageCheckoutCurrent.Controls.Add(this.label24);
            this.tabPageCheckoutCurrent.Controls.Add(this.comboBoxReturnBook);
            this.tabPageCheckoutCurrent.Controls.Add(this.checkedListBoxCheckoutCurrent);
            this.tabPageCheckoutCurrent.Controls.Add(this.button10);
            this.tabPageCheckoutCurrent.Controls.Add(this.button11);
            this.tabPageCheckoutCurrent.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckoutCurrent.Name = "tabPageCheckoutCurrent";
            this.tabPageCheckoutCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckoutCurrent.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckoutCurrent.TabIndex = 0;
            this.tabPageCheckoutCurrent.Text = "Current";
            this.tabPageCheckoutCurrent.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCheckoutCurrent
            // 
            this.checkedListBoxCheckoutCurrent.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxCheckoutCurrent.FormattingEnabled = true;
            this.checkedListBoxCheckoutCurrent.Location = new System.Drawing.Point(59, 42);
            this.checkedListBoxCheckoutCurrent.Name = "checkedListBoxCheckoutCurrent";
            this.checkedListBoxCheckoutCurrent.Size = new System.Drawing.Size(399, 554);
            this.checkedListBoxCheckoutCurrent.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(491, 148);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(217, 37);
            this.button10.TabIndex = 5;
            this.button10.Text = "Prolong";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(491, 201);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(217, 37);
            this.button11.TabIndex = 4;
            this.button11.Text = "Return";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tabPageCheckoutPrevious
            // 
            this.tabPageCheckoutPrevious.Controls.Add(this.checkedListBoxCheckoutPrevious);
            this.tabPageCheckoutPrevious.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckoutPrevious.Name = "tabPageCheckoutPrevious";
            this.tabPageCheckoutPrevious.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckoutPrevious.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckoutPrevious.TabIndex = 1;
            this.tabPageCheckoutPrevious.Text = "Previous";
            this.tabPageCheckoutPrevious.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCheckoutPrevious
            // 
            this.checkedListBoxCheckoutPrevious.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxCheckoutPrevious.FormattingEnabled = true;
            this.checkedListBoxCheckoutPrevious.Location = new System.Drawing.Point(59, 42);
            this.checkedListBoxCheckoutPrevious.Name = "checkedListBoxCheckoutPrevious";
            this.checkedListBoxCheckoutPrevious.Size = new System.Drawing.Size(399, 554);
            this.checkedListBoxCheckoutPrevious.TabIndex = 7;
            // 
            // tabPageCheckoutLateReturns
            // 
            this.tabPageCheckoutLateReturns.Controls.Add(this.checkedListBoxCheckoutLate);
            this.tabPageCheckoutLateReturns.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckoutLateReturns.Name = "tabPageCheckoutLateReturns";
            this.tabPageCheckoutLateReturns.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckoutLateReturns.TabIndex = 2;
            this.tabPageCheckoutLateReturns.Text = "Late returns";
            this.tabPageCheckoutLateReturns.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCheckoutLate
            // 
            this.checkedListBoxCheckoutLate.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxCheckoutLate.FormattingEnabled = true;
            this.checkedListBoxCheckoutLate.Location = new System.Drawing.Point(59, 42);
            this.checkedListBoxCheckoutLate.Name = "checkedListBoxCheckoutLate";
            this.checkedListBoxCheckoutLate.Size = new System.Drawing.Size(399, 554);
            this.checkedListBoxCheckoutLate.TabIndex = 7;
            // 
            // tabPageCheckoutBorrow
            // 
            this.tabPageCheckoutBorrow.Controls.Add(this.labelBorrowSelectLibrary);
            this.tabPageCheckoutBorrow.Controls.Add(this.comboBoxCheckoutSelectLibrary);
            this.tabPageCheckoutBorrow.Controls.Add(this.buttonCheckoutSelectBooksToBorrow);
            this.tabPageCheckoutBorrow.Controls.Add(this.buttonCheckoutSearchBook);
            this.tabPageCheckoutBorrow.Controls.Add(this.checkedListBoxCheckoutBorrowBooks);
            this.tabPageCheckoutBorrow.Controls.Add(this.labelBorrowBookId);
            this.tabPageCheckoutBorrow.Controls.Add(this.textBoxCheckoutSearchBook);
            this.tabPageCheckoutBorrow.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckoutBorrow.Name = "tabPageCheckoutBorrow";
            this.tabPageCheckoutBorrow.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckoutBorrow.TabIndex = 4;
            this.tabPageCheckoutBorrow.Text = "Borrow";
            this.tabPageCheckoutBorrow.UseVisualStyleBackColor = true;
            // 
            // labelBorrowSelectLibrary
            // 
            this.labelBorrowSelectLibrary.AutoSize = true;
            this.labelBorrowSelectLibrary.Location = new System.Drawing.Point(49, 68);
            this.labelBorrowSelectLibrary.Name = "labelBorrowSelectLibrary";
            this.labelBorrowSelectLibrary.Size = new System.Drawing.Size(84, 18);
            this.labelBorrowSelectLibrary.TabIndex = 15;
            this.labelBorrowSelectLibrary.Text = "Select library";
            // 
            // comboBoxCheckoutSelectLibrary
            // 
            this.comboBoxCheckoutSelectLibrary.FormattingEnabled = true;
            this.comboBoxCheckoutSelectLibrary.Location = new System.Drawing.Point(52, 100);
            this.comboBoxCheckoutSelectLibrary.Name = "comboBoxCheckoutSelectLibrary";
            this.comboBoxCheckoutSelectLibrary.Size = new System.Drawing.Size(217, 26);
            this.comboBoxCheckoutSelectLibrary.TabIndex = 14;
            // 
            // buttonCheckoutSelectBooksToBorrow
            // 
            this.buttonCheckoutSelectBooksToBorrow.Location = new System.Drawing.Point(471, 385);
            this.buttonCheckoutSelectBooksToBorrow.Name = "buttonCheckoutSelectBooksToBorrow";
            this.buttonCheckoutSelectBooksToBorrow.Size = new System.Drawing.Size(217, 37);
            this.buttonCheckoutSelectBooksToBorrow.TabIndex = 13;
            this.buttonCheckoutSelectBooksToBorrow.Text = "Borrow";
            this.buttonCheckoutSelectBooksToBorrow.UseVisualStyleBackColor = true;
            this.buttonCheckoutSelectBooksToBorrow.Click += new System.EventHandler(this.buttonCheckoutSelectBooksToBorrow_Click);
            // 
            // buttonCheckoutSearchBook
            // 
            this.buttonCheckoutSearchBook.Location = new System.Drawing.Point(271, 180);
            this.buttonCheckoutSearchBook.Name = "buttonCheckoutSearchBook";
            this.buttonCheckoutSearchBook.Size = new System.Drawing.Size(134, 27);
            this.buttonCheckoutSearchBook.TabIndex = 12;
            this.buttonCheckoutSearchBook.Text = "Search";
            this.buttonCheckoutSearchBook.UseVisualStyleBackColor = true;
            this.buttonCheckoutSearchBook.Click += new System.EventHandler(this.buttonCheckinSearchBook_Click);
            // 
            // checkedListBoxCheckoutBorrowBooks
            // 
            this.checkedListBoxCheckoutBorrowBooks.CheckOnClick = true;
            this.checkedListBoxCheckoutBorrowBooks.FormattingEnabled = true;
            this.checkedListBoxCheckoutBorrowBooks.Location = new System.Drawing.Point(52, 258);
            this.checkedListBoxCheckoutBorrowBooks.Name = "checkedListBoxCheckoutBorrowBooks";
            this.checkedListBoxCheckoutBorrowBooks.Size = new System.Drawing.Size(353, 164);
            this.checkedListBoxCheckoutBorrowBooks.TabIndex = 11;
            this.checkedListBoxCheckoutBorrowBooks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCheckoutBorrowBooks_ItemCheck);
            // 
            // labelBorrowBookId
            // 
            this.labelBorrowBookId.AutoSize = true;
            this.labelBorrowBookId.Location = new System.Drawing.Point(49, 159);
            this.labelBorrowBookId.Name = "labelBorrowBookId";
            this.labelBorrowBookId.Size = new System.Drawing.Size(53, 18);
            this.labelBorrowBookId.TabIndex = 10;
            this.labelBorrowBookId.Text = "Book id";
            // 
            // textBoxCheckoutSearchBook
            // 
            this.textBoxCheckoutSearchBook.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxCheckoutSearchBook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCheckoutSearchBook.Location = new System.Drawing.Point(52, 180);
            this.textBoxCheckoutSearchBook.Name = "textBoxCheckoutSearchBook";
            this.textBoxCheckoutSearchBook.Size = new System.Drawing.Size(222, 27);
            this.textBoxCheckoutSearchBook.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlCheckin);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 697);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check-in";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlCheckin
            // 
            this.tabControlCheckin.Controls.Add(this.tabPageCheckinReader);
            this.tabControlCheckin.Controls.Add(this.tabPageCheckinCurrent);
            this.tabControlCheckin.Controls.Add(this.tabPageCheckinPrevious);
            this.tabControlCheckin.Controls.Add(this.tabPageCheckinReservations);
            this.tabControlCheckin.Controls.Add(this.tabPage7);
            this.tabControlCheckin.Location = new System.Drawing.Point(6, 6);
            this.tabControlCheckin.Name = "tabControlCheckin";
            this.tabControlCheckin.Padding = new System.Drawing.Point(30, 10);
            this.tabControlCheckin.SelectedIndex = 0;
            this.tabControlCheckin.Size = new System.Drawing.Size(746, 685);
            this.tabControlCheckin.TabIndex = 0;
            // 
            // tabPageCheckinReader
            // 
            this.tabPageCheckinReader.Controls.Add(this.label4);
            this.tabPageCheckinReader.Controls.Add(this.button5);
            this.tabPageCheckinReader.Controls.Add(this.label3);
            this.tabPageCheckinReader.Controls.Add(this.button4);
            this.tabPageCheckinReader.Controls.Add(this.label2);
            this.tabPageCheckinReader.Controls.Add(this.button1);
            this.tabPageCheckinReader.Controls.Add(this.label1);
            this.tabPageCheckinReader.Controls.Add(this.checkedListBox2);
            this.tabPageCheckinReader.Controls.Add(this.pictureBox1);
            this.tabPageCheckinReader.Controls.Add(this.label7);
            this.tabPageCheckinReader.Controls.Add(this.textBox2);
            this.tabPageCheckinReader.Controls.Add(this.label6);
            this.tabPageCheckinReader.Controls.Add(this.label5);
            this.tabPageCheckinReader.Controls.Add(this.textBoxReaderId);
            this.tabPageCheckinReader.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckinReader.Name = "tabPageCheckinReader";
            this.tabPageCheckinReader.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckinReader.TabIndex = 3;
            this.tabPageCheckinReader.Text = "Reader";
            this.tabPageCheckinReader.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(453, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(456, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "Select";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(453, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reader\'s Id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 27);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSearchByReaderNameCheckout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(453, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address line 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearchByLibraryCardIdCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(452, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name von Surname";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(36, 266);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(353, 344);
            this.checkedListBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Reader\'s name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(36, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(32, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Search by...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Library card id";
            // 
            // textBoxReaderId
            // 
            this.textBoxReaderId.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxReaderId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxReaderId.Location = new System.Drawing.Point(36, 115);
            this.textBoxReaderId.Name = "textBoxReaderId";
            this.textBoxReaderId.Size = new System.Drawing.Size(222, 27);
            this.textBoxReaderId.TabIndex = 0;
            // 
            // tabPageCheckinCurrent
            // 
            this.tabPageCheckinCurrent.Controls.Add(this.checkedListBoxCurrentlyBorrowed);
            this.tabPageCheckinCurrent.Controls.Add(this.button3);
            this.tabPageCheckinCurrent.Controls.Add(this.button2);
            this.tabPageCheckinCurrent.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckinCurrent.Name = "tabPageCheckinCurrent";
            this.tabPageCheckinCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckinCurrent.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckinCurrent.TabIndex = 0;
            this.tabPageCheckinCurrent.Text = "Current";
            this.tabPageCheckinCurrent.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCurrentlyBorrowed
            // 
            this.checkedListBoxCurrentlyBorrowed.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxCurrentlyBorrowed.FormattingEnabled = true;
            this.checkedListBoxCurrentlyBorrowed.Location = new System.Drawing.Point(59, 42);
            this.checkedListBoxCurrentlyBorrowed.Name = "checkedListBoxCurrentlyBorrowed";
            this.checkedListBoxCurrentlyBorrowed.Size = new System.Drawing.Size(399, 554);
            this.checkedListBoxCurrentlyBorrowed.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Prolong";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPageCheckinPrevious
            // 
            this.tabPageCheckinPrevious.Controls.Add(this.checkedListBoxPastBorrowed);
            this.tabPageCheckinPrevious.Controls.Add(this.dateTimePicker1);
            this.tabPageCheckinPrevious.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckinPrevious.Name = "tabPageCheckinPrevious";
            this.tabPageCheckinPrevious.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckinPrevious.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckinPrevious.TabIndex = 1;
            this.tabPageCheckinPrevious.Text = "Previous";
            this.tabPageCheckinPrevious.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxPastBorrowed
            // 
            this.checkedListBoxPastBorrowed.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxPastBorrowed.FormattingEnabled = true;
            this.checkedListBoxPastBorrowed.Location = new System.Drawing.Point(59, 118);
            this.checkedListBoxPastBorrowed.Name = "checkedListBoxPastBorrowed";
            this.checkedListBoxPastBorrowed.Size = new System.Drawing.Size(399, 488);
            this.checkedListBoxPastBorrowed.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPageCheckinReservations
            // 
            this.tabPageCheckinReservations.Location = new System.Drawing.Point(4, 41);
            this.tabPageCheckinReservations.Name = "tabPageCheckinReservations";
            this.tabPageCheckinReservations.Size = new System.Drawing.Size(738, 640);
            this.tabPageCheckinReservations.TabIndex = 2;
            this.tabPageCheckinReservations.Text = "Reservations";
            this.tabPageCheckinReservations.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControlRegister);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(759, 697);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControlRegister
            // 
            this.tabControlRegister.Controls.Add(this.tabPageRegisterReader);
            this.tabControlRegister.Controls.Add(this.tabPageRegisterBook);
            this.tabControlRegister.Controls.Add(this.tabPageRegisterLibrary);
            this.tabControlRegister.Location = new System.Drawing.Point(6, 6);
            this.tabControlRegister.Name = "tabControlRegister";
            this.tabControlRegister.Padding = new System.Drawing.Point(30, 10);
            this.tabControlRegister.SelectedIndex = 0;
            this.tabControlRegister.Size = new System.Drawing.Size(746, 685);
            this.tabControlRegister.TabIndex = 1;
            // 
            // tabPageRegisterReader
            // 
            this.tabPageRegisterReader.Controls.Add(this.button8);
            this.tabPageRegisterReader.Controls.Add(this.pictureBox2);
            this.tabPageRegisterReader.Controls.Add(this.checkBox3);
            this.tabPageRegisterReader.Controls.Add(this.checkBox2);
            this.tabPageRegisterReader.Controls.Add(this.checkBox1);
            this.tabPageRegisterReader.Controls.Add(this.dateTimePickerNewReaderDateOfBirth);
            this.tabPageRegisterReader.Controls.Add(this.label13);
            this.tabPageRegisterReader.Controls.Add(this.textBoxNewReaderAddress);
            this.tabPageRegisterReader.Controls.Add(this.label14);
            this.tabPageRegisterReader.Controls.Add(this.label11);
            this.tabPageRegisterReader.Controls.Add(this.textBoxNewReaderSurname);
            this.tabPageRegisterReader.Controls.Add(this.label12);
            this.tabPageRegisterReader.Controls.Add(this.textBoxNewReaderName);
            this.tabPageRegisterReader.Controls.Add(this.buttonRegisterNewUser);
            this.tabPageRegisterReader.Location = new System.Drawing.Point(4, 41);
            this.tabPageRegisterReader.Name = "tabPageRegisterReader";
            this.tabPageRegisterReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegisterReader.Size = new System.Drawing.Size(738, 640);
            this.tabPageRegisterReader.TabIndex = 0;
            this.tabPageRegisterReader.Text = "Reader";
            this.tabPageRegisterReader.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(424, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 37);
            this.button8.TabIndex = 21;
            this.button8.Text = "Choose from file";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(424, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 195);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(51, 440);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 22);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Is disabled";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(51, 394);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 22);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Is a senior";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(51, 351);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 22);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Is a student";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNewReaderDateOfBirth
            // 
            this.dateTimePickerNewReaderDateOfBirth.Location = new System.Drawing.Point(51, 217);
            this.dateTimePickerNewReaderDateOfBirth.Name = "dateTimePickerNewReaderDateOfBirth";
            this.dateTimePickerNewReaderDateOfBirth.Size = new System.Drawing.Size(245, 25);
            this.dateTimePickerNewReaderDateOfBirth.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Address";
            // 
            // textBoxNewReaderAddress
            // 
            this.textBoxNewReaderAddress.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxNewReaderAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNewReaderAddress.Location = new System.Drawing.Point(51, 285);
            this.textBoxNewReaderAddress.Name = "textBoxNewReaderAddress";
            this.textBoxNewReaderAddress.Size = new System.Drawing.Size(245, 27);
            this.textBoxNewReaderAddress.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Dateo f birth (mm/dd/yyyy)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Surname";
            // 
            // textBoxNewReaderSurname
            // 
            this.textBoxNewReaderSurname.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxNewReaderSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNewReaderSurname.Location = new System.Drawing.Point(51, 142);
            this.textBoxNewReaderSurname.Name = "textBoxNewReaderSurname";
            this.textBoxNewReaderSurname.Size = new System.Drawing.Size(245, 27);
            this.textBoxNewReaderSurname.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Name";
            // 
            // textBoxNewReaderName
            // 
            this.textBoxNewReaderName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxNewReaderName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNewReaderName.Location = new System.Drawing.Point(51, 74);
            this.textBoxNewReaderName.Name = "textBoxNewReaderName";
            this.textBoxNewReaderName.Size = new System.Drawing.Size(245, 27);
            this.textBoxNewReaderName.TabIndex = 8;
            // 
            // buttonRegisterNewUser
            // 
            this.buttonRegisterNewUser.Location = new System.Drawing.Point(424, 536);
            this.buttonRegisterNewUser.Name = "buttonRegisterNewUser";
            this.buttonRegisterNewUser.Size = new System.Drawing.Size(200, 37);
            this.buttonRegisterNewUser.TabIndex = 7;
            this.buttonRegisterNewUser.Text = "Register";
            this.buttonRegisterNewUser.UseVisualStyleBackColor = true;
            this.buttonRegisterNewUser.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPageRegisterBook
            // 
            this.tabPageRegisterBook.Controls.Add(this.buttonRegisterNewBook);
            this.tabPageRegisterBook.Controls.Add(this.comboBoxRegisterLibrary);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterBookId);
            this.tabPageRegisterBook.Controls.Add(this.label19);
            this.tabPageRegisterBook.Controls.Add(this.label20);
            this.tabPageRegisterBook.Controls.Add(this.label21);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterFee);
            this.tabPageRegisterBook.Controls.Add(this.label22);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterBorrowLength);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterIsbn);
            this.tabPageRegisterBook.Controls.Add(this.label15);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterGenre);
            this.tabPageRegisterBook.Controls.Add(this.label16);
            this.tabPageRegisterBook.Controls.Add(this.label17);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterAuthors);
            this.tabPageRegisterBook.Controls.Add(this.label18);
            this.tabPageRegisterBook.Controls.Add(this.textBoxRegisterTitle);
            this.tabPageRegisterBook.Location = new System.Drawing.Point(4, 41);
            this.tabPageRegisterBook.Name = "tabPageRegisterBook";
            this.tabPageRegisterBook.Size = new System.Drawing.Size(738, 640);
            this.tabPageRegisterBook.TabIndex = 2;
            this.tabPageRegisterBook.Text = "Book";
            this.tabPageRegisterBook.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterNewBook
            // 
            this.buttonRegisterNewBook.Location = new System.Drawing.Point(391, 375);
            this.buttonRegisterNewBook.Name = "buttonRegisterNewBook";
            this.buttonRegisterNewBook.Size = new System.Drawing.Size(200, 37);
            this.buttonRegisterNewBook.TabIndex = 41;
            this.buttonRegisterNewBook.Text = "Register";
            this.buttonRegisterNewBook.UseVisualStyleBackColor = true;
            this.buttonRegisterNewBook.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBoxRegisterLibrary
            // 
            this.comboBoxRegisterLibrary.FormattingEnabled = true;
            this.comboBoxRegisterLibrary.Items.AddRange(new object[] {
            "Library 1",
            "Library 2",
            "Library 3",
            "Library 4"});
            this.comboBoxRegisterLibrary.Location = new System.Drawing.Point(346, 286);
            this.comboBoxRegisterLibrary.Name = "comboBoxRegisterLibrary";
            this.comboBoxRegisterLibrary.Size = new System.Drawing.Size(245, 26);
            this.comboBoxRegisterLibrary.TabIndex = 40;
            // 
            // textBoxRegisterBookId
            // 
            this.textBoxRegisterBookId.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterBookId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterBookId.Location = new System.Drawing.Point(346, 217);
            this.textBoxRegisterBookId.Name = "textBoxRegisterBookId";
            this.textBoxRegisterBookId.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterBookId.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(343, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 18);
            this.label19.TabIndex = 38;
            this.label19.Text = "Library";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(343, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 18);
            this.label20.TabIndex = 36;
            this.label20.Text = "Id of book";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(343, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 18);
            this.label21.TabIndex = 35;
            this.label21.Text = "Fee for late return per day";
            // 
            // textBoxRegisterFee
            // 
            this.textBoxRegisterFee.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterFee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterFee.Location = new System.Drawing.Point(346, 142);
            this.textBoxRegisterFee.Name = "textBoxRegisterFee";
            this.textBoxRegisterFee.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterFee.TabIndex = 34;
            this.textBoxRegisterFee.Text = "50";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(343, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 18);
            this.label22.TabIndex = 33;
            this.label22.Text = "Standard borrow length";
            // 
            // textBoxRegisterBorrowLength
            // 
            this.textBoxRegisterBorrowLength.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterBorrowLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterBorrowLength.Location = new System.Drawing.Point(346, 74);
            this.textBoxRegisterBorrowLength.Name = "textBoxRegisterBorrowLength";
            this.textBoxRegisterBorrowLength.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterBorrowLength.TabIndex = 32;
            this.textBoxRegisterBorrowLength.Text = "30";
            // 
            // textBoxRegisterIsbn
            // 
            this.textBoxRegisterIsbn.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterIsbn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterIsbn.Location = new System.Drawing.Point(51, 217);
            this.textBoxRegisterIsbn.Name = "textBoxRegisterIsbn";
            this.textBoxRegisterIsbn.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterIsbn.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 26;
            this.label15.Text = "Genre";
            // 
            // textBoxRegisterGenre
            // 
            this.textBoxRegisterGenre.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterGenre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterGenre.Location = new System.Drawing.Point(51, 285);
            this.textBoxRegisterGenre.Name = "textBoxRegisterGenre";
            this.textBoxRegisterGenre.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterGenre.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 18);
            this.label16.TabIndex = 24;
            this.label16.Text = "ISBN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "Authors";
            // 
            // textBoxRegisterAuthors
            // 
            this.textBoxRegisterAuthors.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterAuthors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterAuthors.Location = new System.Drawing.Point(51, 142);
            this.textBoxRegisterAuthors.Name = "textBoxRegisterAuthors";
            this.textBoxRegisterAuthors.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterAuthors.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "Title";
            // 
            // textBoxRegisterTitle
            // 
            this.textBoxRegisterTitle.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxRegisterTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRegisterTitle.Location = new System.Drawing.Point(51, 74);
            this.textBoxRegisterTitle.Name = "textBoxRegisterTitle";
            this.textBoxRegisterTitle.Size = new System.Drawing.Size(245, 27);
            this.textBoxRegisterTitle.TabIndex = 20;
            // 
            // tabPageRegisterLibrary
            // 
            this.tabPageRegisterLibrary.Controls.Add(this.buttonRegisterNewLibrary);
            this.tabPageRegisterLibrary.Controls.Add(this.label28);
            this.tabPageRegisterLibrary.Controls.Add(this.textBoxNewLibraryName);
            this.tabPageRegisterLibrary.Location = new System.Drawing.Point(4, 41);
            this.tabPageRegisterLibrary.Name = "tabPageRegisterLibrary";
            this.tabPageRegisterLibrary.Size = new System.Drawing.Size(738, 640);
            this.tabPageRegisterLibrary.TabIndex = 3;
            this.tabPageRegisterLibrary.Text = "Library";
            this.tabPageRegisterLibrary.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterNewLibrary
            // 
            this.buttonRegisterNewLibrary.Location = new System.Drawing.Point(411, 72);
            this.buttonRegisterNewLibrary.Name = "buttonRegisterNewLibrary";
            this.buttonRegisterNewLibrary.Size = new System.Drawing.Size(200, 37);
            this.buttonRegisterNewLibrary.TabIndex = 42;
            this.buttonRegisterNewLibrary.Text = "Register";
            this.buttonRegisterNewLibrary.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(58, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 18);
            this.label28.TabIndex = 23;
            this.label28.Text = "Name of library";
            // 
            // textBoxNewLibraryName
            // 
            this.textBoxNewLibraryName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxNewLibraryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNewLibraryName.Location = new System.Drawing.Point(61, 82);
            this.textBoxNewLibraryName.Name = "textBoxNewLibraryName";
            this.textBoxNewLibraryName.Size = new System.Drawing.Size(245, 27);
            this.textBoxNewLibraryName.TabIndex = 22;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControlArchive);
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(759, 697);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Archive";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControlArchive
            // 
            this.tabControlArchive.Controls.Add(this.tabPageArchiveBook);
            this.tabControlArchive.Controls.Add(this.tabPageArchiveReader);
            this.tabControlArchive.Controls.Add(this.tabPageArchiveLibrary);
            this.tabControlArchive.Location = new System.Drawing.Point(6, 6);
            this.tabControlArchive.Name = "tabControlArchive";
            this.tabControlArchive.Padding = new System.Drawing.Point(30, 10);
            this.tabControlArchive.SelectedIndex = 0;
            this.tabControlArchive.Size = new System.Drawing.Size(746, 685);
            this.tabControlArchive.TabIndex = 2;
            // 
            // tabPageArchiveBook
            // 
            this.tabPageArchiveBook.Controls.Add(this.checkedListBoxArchiveBook);
            this.tabPageArchiveBook.Controls.Add(this.buttonArchiveBook);
            this.tabPageArchiveBook.Controls.Add(this.labelArchiveBookLibrary);
            this.tabPageArchiveBook.Controls.Add(this.labelArchiveBookId);
            this.tabPageArchiveBook.Controls.Add(this.textBoxArchiveBookId);
            this.tabPageArchiveBook.Controls.Add(this.labelArchiveBookName);
            this.tabPageArchiveBook.Controls.Add(this.comboBoxArchiveBookLibrary);
            this.tabPageArchiveBook.Controls.Add(this.textBoxArchiveBookName);
            this.tabPageArchiveBook.Controls.Add(this.buttonArchiveBookSearch);
            this.tabPageArchiveBook.Location = new System.Drawing.Point(4, 41);
            this.tabPageArchiveBook.Name = "tabPageArchiveBook";
            this.tabPageArchiveBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArchiveBook.Size = new System.Drawing.Size(738, 640);
            this.tabPageArchiveBook.TabIndex = 0;
            this.tabPageArchiveBook.Text = "Book";
            this.tabPageArchiveBook.UseVisualStyleBackColor = true;
            // 
            // buttonArchiveBook
            // 
            this.buttonArchiveBook.Location = new System.Drawing.Point(473, 400);
            this.buttonArchiveBook.Name = "buttonArchiveBook";
            this.buttonArchiveBook.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveBook.TabIndex = 22;
            this.buttonArchiveBook.Text = "Archive Selected";
            this.buttonArchiveBook.UseVisualStyleBackColor = true;
            this.buttonArchiveBook.Click += new System.EventHandler(this.buttonArchiveBook_Click);
            // 
            // labelArchiveBookLibrary
            // 
            this.labelArchiveBookLibrary.AutoSize = true;
            this.labelArchiveBookLibrary.Location = new System.Drawing.Point(470, 237);
            this.labelArchiveBookLibrary.Name = "labelArchiveBookLibrary";
            this.labelArchiveBookLibrary.Size = new System.Drawing.Size(84, 18);
            this.labelArchiveBookLibrary.TabIndex = 21;
            this.labelArchiveBookLibrary.Text = "Select library";
            // 
            // labelArchiveBookId
            // 
            this.labelArchiveBookId.AutoSize = true;
            this.labelArchiveBookId.Location = new System.Drawing.Point(470, 140);
            this.labelArchiveBookId.Name = "labelArchiveBookId";
            this.labelArchiveBookId.Size = new System.Drawing.Size(114, 18);
            this.labelArchiveBookId.TabIndex = 20;
            this.labelArchiveBookId.Text = "Search by book id";
            // 
            // textBoxArchiveBookId
            // 
            this.textBoxArchiveBookId.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxArchiveBookId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxArchiveBookId.Location = new System.Drawing.Point(473, 168);
            this.textBoxArchiveBookId.Name = "textBoxArchiveBookId";
            this.textBoxArchiveBookId.Size = new System.Drawing.Size(217, 27);
            this.textBoxArchiveBookId.TabIndex = 19;
            // 
            // labelArchiveBookName
            // 
            this.labelArchiveBookName.AutoSize = true;
            this.labelArchiveBookName.Location = new System.Drawing.Point(470, 53);
            this.labelArchiveBookName.Name = "labelArchiveBookName";
            this.labelArchiveBookName.Size = new System.Drawing.Size(103, 18);
            this.labelArchiveBookName.TabIndex = 18;
            this.labelArchiveBookName.Text = "Search by name";
            // 
            // comboBoxArchiveBookLibrary
            // 
            this.comboBoxArchiveBookLibrary.FormattingEnabled = true;
            this.comboBoxArchiveBookLibrary.Location = new System.Drawing.Point(473, 269);
            this.comboBoxArchiveBookLibrary.Name = "comboBoxArchiveBookLibrary";
            this.comboBoxArchiveBookLibrary.Size = new System.Drawing.Size(217, 26);
            this.comboBoxArchiveBookLibrary.TabIndex = 17;
            // 
            // textBoxArchiveBookName
            // 
            this.textBoxArchiveBookName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxArchiveBookName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxArchiveBookName.Location = new System.Drawing.Point(473, 81);
            this.textBoxArchiveBookName.Name = "textBoxArchiveBookName";
            this.textBoxArchiveBookName.Size = new System.Drawing.Size(217, 27);
            this.textBoxArchiveBookName.TabIndex = 16;
            // 
            // buttonArchiveBookSearch
            // 
            this.buttonArchiveBookSearch.Location = new System.Drawing.Point(473, 334);
            this.buttonArchiveBookSearch.Name = "buttonArchiveBookSearch";
            this.buttonArchiveBookSearch.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveBookSearch.TabIndex = 15;
            this.buttonArchiveBookSearch.Text = "Search in Books";
            this.buttonArchiveBookSearch.UseVisualStyleBackColor = true;
            this.buttonArchiveBookSearch.Click += new System.EventHandler(this.buttonArchiveBookSearch_Click);
            // 
            // tabPageArchiveReader
            // 
            this.tabPageArchiveReader.Controls.Add(this.buttonArchiveReader);
            this.tabPageArchiveReader.Controls.Add(this.textBoxArchiveReaderSearch);
            this.tabPageArchiveReader.Controls.Add(this.buttonArchiveReaderSearch);
            this.tabPageArchiveReader.Controls.Add(this.richTextBoxArchiveReader);
            this.tabPageArchiveReader.Location = new System.Drawing.Point(4, 41);
            this.tabPageArchiveReader.Name = "tabPageArchiveReader";
            this.tabPageArchiveReader.Size = new System.Drawing.Size(738, 640);
            this.tabPageArchiveReader.TabIndex = 2;
            this.tabPageArchiveReader.Text = "Reader";
            this.tabPageArchiveReader.UseVisualStyleBackColor = true;
            // 
            // buttonArchiveReader
            // 
            this.buttonArchiveReader.Location = new System.Drawing.Point(473, 160);
            this.buttonArchiveReader.Name = "buttonArchiveReader";
            this.buttonArchiveReader.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveReader.TabIndex = 14;
            this.buttonArchiveReader.Text = "Archive Selected";
            this.buttonArchiveReader.UseVisualStyleBackColor = true;
            // 
            // textBoxArchiveReaderSearch
            // 
            this.textBoxArchiveReaderSearch.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxArchiveReaderSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxArchiveReaderSearch.Location = new System.Drawing.Point(473, 53);
            this.textBoxArchiveReaderSearch.Name = "textBoxArchiveReaderSearch";
            this.textBoxArchiveReaderSearch.Size = new System.Drawing.Size(217, 27);
            this.textBoxArchiveReaderSearch.TabIndex = 13;
            // 
            // buttonArchiveReaderSearch
            // 
            this.buttonArchiveReaderSearch.Location = new System.Drawing.Point(473, 98);
            this.buttonArchiveReaderSearch.Name = "buttonArchiveReaderSearch";
            this.buttonArchiveReaderSearch.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveReaderSearch.TabIndex = 12;
            this.buttonArchiveReaderSearch.Text = "Search in Readers";
            this.buttonArchiveReaderSearch.UseVisualStyleBackColor = true;
            // 
            // richTextBoxArchiveReader
            // 
            this.richTextBoxArchiveReader.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxArchiveReader.Name = "richTextBoxArchiveReader";
            this.richTextBoxArchiveReader.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxArchiveReader.TabIndex = 11;
            this.richTextBoxArchiveReader.Text = "";
            // 
            // tabPageArchiveLibrary
            // 
            this.tabPageArchiveLibrary.Controls.Add(this.buttonArchiveSelectedLibrary);
            this.tabPageArchiveLibrary.Controls.Add(this.textBoxArchiveLibraryName);
            this.tabPageArchiveLibrary.Controls.Add(this.buttonArchiveLibrarySearch);
            this.tabPageArchiveLibrary.Controls.Add(this.richTextBoxArchiveLibrary);
            this.tabPageArchiveLibrary.Location = new System.Drawing.Point(4, 41);
            this.tabPageArchiveLibrary.Name = "tabPageArchiveLibrary";
            this.tabPageArchiveLibrary.Size = new System.Drawing.Size(738, 640);
            this.tabPageArchiveLibrary.TabIndex = 3;
            this.tabPageArchiveLibrary.Text = "Library";
            this.tabPageArchiveLibrary.UseVisualStyleBackColor = true;
            // 
            // buttonArchiveSelectedLibrary
            // 
            this.buttonArchiveSelectedLibrary.Location = new System.Drawing.Point(473, 161);
            this.buttonArchiveSelectedLibrary.Name = "buttonArchiveSelectedLibrary";
            this.buttonArchiveSelectedLibrary.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveSelectedLibrary.TabIndex = 17;
            this.buttonArchiveSelectedLibrary.Text = "Search in Libraries";
            this.buttonArchiveSelectedLibrary.UseVisualStyleBackColor = true;
            // 
            // textBoxArchiveLibraryName
            // 
            this.textBoxArchiveLibraryName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxArchiveLibraryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxArchiveLibraryName.Location = new System.Drawing.Point(473, 53);
            this.textBoxArchiveLibraryName.Name = "textBoxArchiveLibraryName";
            this.textBoxArchiveLibraryName.Size = new System.Drawing.Size(217, 27);
            this.textBoxArchiveLibraryName.TabIndex = 16;
            // 
            // buttonArchiveLibrarySearch
            // 
            this.buttonArchiveLibrarySearch.Location = new System.Drawing.Point(473, 98);
            this.buttonArchiveLibrarySearch.Name = "buttonArchiveLibrarySearch";
            this.buttonArchiveLibrarySearch.Size = new System.Drawing.Size(217, 37);
            this.buttonArchiveLibrarySearch.TabIndex = 15;
            this.buttonArchiveLibrarySearch.Text = "Search in Libraries";
            this.buttonArchiveLibrarySearch.UseVisualStyleBackColor = true;
            // 
            // richTextBoxArchiveLibrary
            // 
            this.richTextBoxArchiveLibrary.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxArchiveLibrary.Name = "richTextBoxArchiveLibrary";
            this.richTextBoxArchiveLibrary.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxArchiveLibrary.TabIndex = 14;
            this.richTextBoxArchiveLibrary.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControlSearch);
            this.tabPage5.Location = new System.Drawing.Point(4, 41);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(759, 697);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Search";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageSearchBook);
            this.tabControlSearch.Controls.Add(this.tabPageSearchReader);
            this.tabControlSearch.Controls.Add(this.tabPageSearchLibrary);
            this.tabControlSearch.Controls.Add(this.tabPage6);
            this.tabControlSearch.Location = new System.Drawing.Point(6, 6);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.Padding = new System.Drawing.Point(30, 10);
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(746, 685);
            this.tabControlSearch.TabIndex = 2;
            // 
            // tabPageSearchBook
            // 
            this.tabPageSearchBook.Controls.Add(this.labelSearchBookSelectLibrary);
            this.tabPageSearchBook.Controls.Add(this.labelSearchBookId);
            this.tabPageSearchBook.Controls.Add(this.textBoxSearchBookId);
            this.tabPageSearchBook.Controls.Add(this.labelSearchBookName);
            this.tabPageSearchBook.Controls.Add(this.comboBoxSearchBookSelectLibrary);
            this.tabPageSearchBook.Controls.Add(this.textBoxSearchBookName);
            this.tabPageSearchBook.Controls.Add(this.buttonSearchBook);
            this.tabPageSearchBook.Controls.Add(this.richTextBoxSearchedBooks);
            this.tabPageSearchBook.Location = new System.Drawing.Point(4, 41);
            this.tabPageSearchBook.Name = "tabPageSearchBook";
            this.tabPageSearchBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchBook.Size = new System.Drawing.Size(738, 640);
            this.tabPageSearchBook.TabIndex = 0;
            this.tabPageSearchBook.Text = "Book";
            this.tabPageSearchBook.UseVisualStyleBackColor = true;
            // 
            // labelSearchBookSelectLibrary
            // 
            this.labelSearchBookSelectLibrary.AutoSize = true;
            this.labelSearchBookSelectLibrary.Location = new System.Drawing.Point(470, 237);
            this.labelSearchBookSelectLibrary.Name = "labelSearchBookSelectLibrary";
            this.labelSearchBookSelectLibrary.Size = new System.Drawing.Size(84, 18);
            this.labelSearchBookSelectLibrary.TabIndex = 13;
            this.labelSearchBookSelectLibrary.Text = "Select library";
            // 
            // labelSearchBookId
            // 
            this.labelSearchBookId.AutoSize = true;
            this.labelSearchBookId.Location = new System.Drawing.Point(470, 140);
            this.labelSearchBookId.Name = "labelSearchBookId";
            this.labelSearchBookId.Size = new System.Drawing.Size(114, 18);
            this.labelSearchBookId.TabIndex = 12;
            this.labelSearchBookId.Text = "Search by book id";
            // 
            // textBoxSearchBookId
            // 
            this.textBoxSearchBookId.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchBookId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchBookId.Location = new System.Drawing.Point(473, 168);
            this.textBoxSearchBookId.Name = "textBoxSearchBookId";
            this.textBoxSearchBookId.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearchBookId.TabIndex = 11;
            // 
            // labelSearchBookName
            // 
            this.labelSearchBookName.AutoSize = true;
            this.labelSearchBookName.Location = new System.Drawing.Point(470, 53);
            this.labelSearchBookName.Name = "labelSearchBookName";
            this.labelSearchBookName.Size = new System.Drawing.Size(103, 18);
            this.labelSearchBookName.TabIndex = 10;
            this.labelSearchBookName.Text = "Search by name";
            // 
            // comboBoxSearchBookSelectLibrary
            // 
            this.comboBoxSearchBookSelectLibrary.FormattingEnabled = true;
            this.comboBoxSearchBookSelectLibrary.Location = new System.Drawing.Point(473, 269);
            this.comboBoxSearchBookSelectLibrary.Name = "comboBoxSearchBookSelectLibrary";
            this.comboBoxSearchBookSelectLibrary.Size = new System.Drawing.Size(217, 26);
            this.comboBoxSearchBookSelectLibrary.TabIndex = 9;
            // 
            // textBoxSearchBookName
            // 
            this.textBoxSearchBookName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchBookName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchBookName.Location = new System.Drawing.Point(473, 81);
            this.textBoxSearchBookName.Name = "textBoxSearchBookName";
            this.textBoxSearchBookName.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearchBookName.TabIndex = 8;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(473, 334);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(217, 37);
            this.buttonSearchBook.TabIndex = 7;
            this.buttonSearchBook.Text = "Search in Books";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // richTextBoxSearchedBooks
            // 
            this.richTextBoxSearchedBooks.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxSearchedBooks.Name = "richTextBoxSearchedBooks";
            this.richTextBoxSearchedBooks.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxSearchedBooks.TabIndex = 0;
            this.richTextBoxSearchedBooks.Text = "";
            // 
            // tabPageSearchReader
            // 
            this.tabPageSearchReader.Controls.Add(this.textBoxSearchReadername);
            this.tabPageSearchReader.Controls.Add(this.buttonSearchReader);
            this.tabPageSearchReader.Controls.Add(this.richTextBoxSearchedReaders);
            this.tabPageSearchReader.Location = new System.Drawing.Point(4, 41);
            this.tabPageSearchReader.Name = "tabPageSearchReader";
            this.tabPageSearchReader.Size = new System.Drawing.Size(738, 640);
            this.tabPageSearchReader.TabIndex = 2;
            this.tabPageSearchReader.Text = "Reader";
            this.tabPageSearchReader.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchReadername
            // 
            this.textBoxSearchReadername.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchReadername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchReadername.Location = new System.Drawing.Point(473, 53);
            this.textBoxSearchReadername.Name = "textBoxSearchReadername";
            this.textBoxSearchReadername.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearchReadername.TabIndex = 10;
            // 
            // buttonSearchReader
            // 
            this.buttonSearchReader.Location = new System.Drawing.Point(473, 98);
            this.buttonSearchReader.Name = "buttonSearchReader";
            this.buttonSearchReader.Size = new System.Drawing.Size(217, 37);
            this.buttonSearchReader.TabIndex = 9;
            this.buttonSearchReader.Text = "Search in Readers";
            this.buttonSearchReader.UseVisualStyleBackColor = true;
            this.buttonSearchReader.Click += new System.EventHandler(this.button12_Click);
            // 
            // richTextBoxSearchedReaders
            // 
            this.richTextBoxSearchedReaders.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxSearchedReaders.Name = "richTextBoxSearchedReaders";
            this.richTextBoxSearchedReaders.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxSearchedReaders.TabIndex = 8;
            this.richTextBoxSearchedReaders.Text = "";
            // 
            // tabPageSearchLibrary
            // 
            this.tabPageSearchLibrary.Controls.Add(this.textBoxSearchLibraryName);
            this.tabPageSearchLibrary.Controls.Add(this.buttonSearchLibrary);
            this.tabPageSearchLibrary.Controls.Add(this.richTextBoxSearchedLibraries);
            this.tabPageSearchLibrary.Location = new System.Drawing.Point(4, 41);
            this.tabPageSearchLibrary.Name = "tabPageSearchLibrary";
            this.tabPageSearchLibrary.Size = new System.Drawing.Size(738, 640);
            this.tabPageSearchLibrary.TabIndex = 3;
            this.tabPageSearchLibrary.Text = "Library";
            this.tabPageSearchLibrary.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchLibraryName
            // 
            this.textBoxSearchLibraryName.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBoxSearchLibraryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchLibraryName.Location = new System.Drawing.Point(473, 53);
            this.textBoxSearchLibraryName.Name = "textBoxSearchLibraryName";
            this.textBoxSearchLibraryName.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearchLibraryName.TabIndex = 13;
            // 
            // buttonSearchLibrary
            // 
            this.buttonSearchLibrary.Location = new System.Drawing.Point(473, 98);
            this.buttonSearchLibrary.Name = "buttonSearchLibrary";
            this.buttonSearchLibrary.Size = new System.Drawing.Size(217, 37);
            this.buttonSearchLibrary.TabIndex = 12;
            this.buttonSearchLibrary.Text = "Search in Libraries";
            this.buttonSearchLibrary.UseVisualStyleBackColor = true;
            this.buttonSearchLibrary.Click += new System.EventHandler(this.button13_Click);
            // 
            // richTextBoxSearchedLibraries
            // 
            this.richTextBoxSearchedLibraries.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxSearchedLibraries.Name = "richTextBoxSearchedLibraries";
            this.richTextBoxSearchedLibraries.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxSearchedLibraries.TabIndex = 11;
            this.richTextBoxSearchedLibraries.Text = "";
            // 
            // checkedListBoxArchiveBook
            // 
            this.checkedListBoxArchiveBook.FormattingEnabled = true;
            this.checkedListBoxArchiveBook.Location = new System.Drawing.Point(51, 56);
            this.checkedListBoxArchiveBook.Name = "checkedListBoxArchiveBook";
            this.checkedListBoxArchiveBook.Size = new System.Drawing.Size(377, 484);
            this.checkedListBoxArchiveBook.TabIndex = 23;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBoxShowBorrowedBooks);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.comboBoxShowBorrowedBooks);
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Location = new System.Drawing.Point(4, 41);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(738, 640);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Borrowed";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(476, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 18);
            this.label23.TabIndex = 16;
            this.label23.Text = "Select library";
            // 
            // comboBoxShowBorrowedBooks
            // 
            this.comboBoxShowBorrowedBooks.FormattingEnabled = true;
            this.comboBoxShowBorrowedBooks.Location = new System.Drawing.Point(479, 86);
            this.comboBoxShowBorrowedBooks.Name = "comboBoxShowBorrowedBooks";
            this.comboBoxShowBorrowedBooks.Size = new System.Drawing.Size(217, 26);
            this.comboBoxShowBorrowedBooks.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(479, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 37);
            this.button6.TabIndex = 14;
            this.button6.Text = "Show borrowed books";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBoxShowBorrowedBooks
            // 
            this.richTextBoxShowBorrowedBooks.Location = new System.Drawing.Point(35, 53);
            this.richTextBoxShowBorrowedBooks.Name = "richTextBoxShowBorrowedBooks";
            this.richTextBoxShowBorrowedBooks.Size = new System.Drawing.Size(404, 564);
            this.richTextBoxShowBorrowedBooks.TabIndex = 17;
            this.richTextBoxShowBorrowedBooks.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(488, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 18);
            this.label24.TabIndex = 17;
            this.label24.Text = "Select library";
            // 
            // comboBoxReturnBook
            // 
            this.comboBoxReturnBook.FormattingEnabled = true;
            this.comboBoxReturnBook.Location = new System.Drawing.Point(491, 80);
            this.comboBoxReturnBook.Name = "comboBoxReturnBook";
            this.comboBoxReturnBook.Size = new System.Drawing.Size(217, 26);
            this.comboBoxReturnBook.TabIndex = 16;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.comboBox1);
            this.tabPage7.Controls.Add(this.button7);
            this.tabPage7.Controls.Add(this.button9);
            this.tabPage7.Controls.Add(this.checkedListBox1);
            this.tabPage7.Controls.Add(this.label26);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 41);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(738, 640);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Return";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 18);
            this.label25.TabIndex = 22;
            this.label25.Text = "Select library";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 26);
            this.comboBox1.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(471, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(217, 37);
            this.button7.TabIndex = 20;
            this.button7.Text = "Borrow";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(271, 180);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 27);
            this.button9.TabIndex = 19;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(52, 258);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(353, 164);
            this.checkedListBox1.TabIndex = 18;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(49, 159);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 18);
            this.label26.TabIndex = 17;
            this.label26.Text = "Book id";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(52, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 16;
            // 
            // AdsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 750);
            this.Controls.Add(this.tabControlOuter);
            this.Name = "AdsApplication";
            this.Text = "Book Borrowing System";
            this.tabControlOuter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlCheckout.ResumeLayout(false);
            this.tabPageCheckoutReader.ResumeLayout(false);
            this.tabPageCheckoutReader.PerformLayout();
            this.tabPageCheckoutCurrent.ResumeLayout(false);
            this.tabPageCheckoutCurrent.PerformLayout();
            this.tabPageCheckoutPrevious.ResumeLayout(false);
            this.tabPageCheckoutLateReturns.ResumeLayout(false);
            this.tabPageCheckoutBorrow.ResumeLayout(false);
            this.tabPageCheckoutBorrow.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControlCheckin.ResumeLayout(false);
            this.tabPageCheckinReader.ResumeLayout(false);
            this.tabPageCheckinReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageCheckinCurrent.ResumeLayout(false);
            this.tabPageCheckinPrevious.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControlRegister.ResumeLayout(false);
            this.tabPageRegisterReader.ResumeLayout(false);
            this.tabPageRegisterReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageRegisterBook.ResumeLayout(false);
            this.tabPageRegisterBook.PerformLayout();
            this.tabPageRegisterLibrary.ResumeLayout(false);
            this.tabPageRegisterLibrary.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControlArchive.ResumeLayout(false);
            this.tabPageArchiveBook.ResumeLayout(false);
            this.tabPageArchiveBook.PerformLayout();
            this.tabPageArchiveReader.ResumeLayout(false);
            this.tabPageArchiveReader.PerformLayout();
            this.tabPageArchiveLibrary.ResumeLayout(false);
            this.tabPageArchiveLibrary.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageSearchBook.ResumeLayout(false);
            this.tabPageSearchBook.PerformLayout();
            this.tabPageSearchReader.ResumeLayout(false);
            this.tabPageSearchReader.PerformLayout();
            this.tabPageSearchLibrary.ResumeLayout(false);
            this.tabPageSearchLibrary.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOuter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlCheckin;
        private System.Windows.Forms.TabPage tabPageCheckinCurrent;
        private System.Windows.Forms.TabPage tabPageCheckinPrevious;
        private System.Windows.Forms.TabPage tabPageCheckinReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBoxCurrentlyBorrowed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageCheckinReader;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReaderId;
        private System.Windows.Forms.CheckedListBox checkedListBoxPastBorrowed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControlRegister;
        private System.Windows.Forms.TabPage tabPageRegisterReader;
        private System.Windows.Forms.TabPage tabPageRegisterBook;
        private System.Windows.Forms.TabPage tabPageRegisterLibrary;
        private System.Windows.Forms.TabControl tabControlArchive;
        private System.Windows.Forms.TabPage tabPageArchiveBook;
        private System.Windows.Forms.TabPage tabPageArchiveReader;
        private System.Windows.Forms.TabPage tabPageArchiveLibrary;
        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageSearchBook;
        private System.Windows.Forms.TabPage tabPageSearchReader;
        private System.Windows.Forms.TabPage tabPageSearchLibrary;
        private System.Windows.Forms.RichTextBox richTextBoxSearchedBooks;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.TabControl tabControlCheckout;
        private System.Windows.Forms.TabPage tabPageCheckoutReader;
        private System.Windows.Forms.Button buttonSelectFromFoundReaders;
        private System.Windows.Forms.Button buttonSearchByReaderName;
        private System.Windows.Forms.Button buttonSearchByLibraryCardId;
        private System.Windows.Forms.CheckedListBox checkedListBoxFoundReaders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearchByReaderName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearchByLibraryCardId;
        private System.Windows.Forms.TabPage tabPageCheckoutCurrent;
        private System.Windows.Forms.CheckedListBox checkedListBoxCheckoutCurrent;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TabPage tabPageCheckoutPrevious;
        private System.Windows.Forms.CheckedListBox checkedListBoxCheckoutPrevious;
        private System.Windows.Forms.TabPage tabPageCheckoutLateReturns;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewReaderDateOfBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNewReaderAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNewReaderSurname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNewReaderName;
        private System.Windows.Forms.Button buttonRegisterNewUser;
        private System.Windows.Forms.TextBox textBoxRegisterIsbn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxRegisterGenre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxRegisterAuthors;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxRegisterTitle;
        private System.Windows.Forms.Button buttonRegisterNewBook;
        private System.Windows.Forms.ComboBox comboBoxRegisterLibrary;
        private System.Windows.Forms.TextBox textBoxRegisterBookId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxRegisterFee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxRegisterBorrowLength;
        private System.Windows.Forms.Button buttonSearchReader;
        private System.Windows.Forms.RichTextBox richTextBoxSearchedReaders;
        private System.Windows.Forms.TextBox textBoxSearchReadername;
        private System.Windows.Forms.Label labelSearchBookSelectLibrary;
        private System.Windows.Forms.Label labelSearchBookId;
        private System.Windows.Forms.TextBox textBoxSearchBookId;
        private System.Windows.Forms.Label labelSearchBookName;
        private System.Windows.Forms.ComboBox comboBoxSearchBookSelectLibrary;
        private System.Windows.Forms.TextBox textBoxSearchBookName;
        private System.Windows.Forms.TextBox textBoxSearchLibraryName;
        private System.Windows.Forms.Button buttonSearchLibrary;
        private System.Windows.Forms.RichTextBox richTextBoxSearchedLibraries;
        private System.Windows.Forms.CheckedListBox checkedListBoxCheckoutLate;
        private System.Windows.Forms.TabPage tabPageCheckoutBorrow;
        private System.Windows.Forms.Button buttonCheckoutSelectBooksToBorrow;
        private System.Windows.Forms.Button buttonCheckoutSearchBook;
        private System.Windows.Forms.CheckedListBox checkedListBoxCheckoutBorrowBooks;
        private System.Windows.Forms.Label labelBorrowBookId;
        private System.Windows.Forms.TextBox textBoxCheckoutSearchBook;
        private System.Windows.Forms.Label labelBorrowSelectLibrary;
        private System.Windows.Forms.ComboBox comboBoxCheckoutSelectLibrary;
        private System.Windows.Forms.Button buttonRegisterNewLibrary;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNewLibraryName;
        private System.Windows.Forms.Label labelArchiveBookLibrary;
        private System.Windows.Forms.Label labelArchiveBookId;
        private System.Windows.Forms.TextBox textBoxArchiveBookId;
        private System.Windows.Forms.Label labelArchiveBookName;
        private System.Windows.Forms.ComboBox comboBoxArchiveBookLibrary;
        private System.Windows.Forms.TextBox textBoxArchiveBookName;
        private System.Windows.Forms.Button buttonArchiveBookSearch;
        private System.Windows.Forms.TextBox textBoxArchiveReaderSearch;
        private System.Windows.Forms.Button buttonArchiveReaderSearch;
        private System.Windows.Forms.RichTextBox richTextBoxArchiveReader;
        private System.Windows.Forms.TextBox textBoxArchiveLibraryName;
        private System.Windows.Forms.Button buttonArchiveLibrarySearch;
        private System.Windows.Forms.RichTextBox richTextBoxArchiveLibrary;
        private System.Windows.Forms.Button buttonArchiveBook;
        private System.Windows.Forms.Button buttonArchiveReader;
        private System.Windows.Forms.Button buttonArchiveSelectedLibrary;
        private System.Windows.Forms.CheckedListBox checkedListBoxArchiveBook;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBoxShowBorrowedBooks;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBoxShowBorrowedBooks;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxReturnBook;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox1;
    }
}

