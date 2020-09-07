using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MCModListLoader {
    public partial class MCModpackListLoader : Form {

        private WebBrowser browser;

        public MCModpackListLoader() {
            InitializeComponent();
        }

        private void MCModpackListLoader_Load(object sender, EventArgs e) {
            browser = new WebBrowser();
            browser.Name = "Browser";

            browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            TabPage page = new TabPage();
            page.Name = "page" + tab_MLMaster.TabCount;
            page.Text = txt_Name.Text;
            page.BackColor = Color.White;

            tab_MLMaster.TabPages.Add(page);

            Label modlabel = new Label();
            modlabel.Name = page.Name + "_modlabel";
            modlabel.Text = "Modlist:";
            modlabel.Font = new Font("Segoe UI", 8);
            modlabel.SetBounds(4, 4, modlabel.Width, modlabel.Height);

            ListView modlist = new ListView();
            modlist.Name = page.Name + "_list";
            modlist.BackColor = Color.White;
            modlist.Font = modlabel.Font;
            modlist.BorderStyle = BorderStyle.FixedSingle;
            modlist.View = View.Details;
            modlist.Columns.Add("Mod");
            modlist.Columns.Add("Author");
            modlist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            modlist.Sorting = SortOrder.Ascending;
            modlist.FullRowSelect = true;
            modlist.SetBounds(modlabel.Bounds.X, modlabel.Bounds.Y + 16, page.Width - (modlabel.Bounds.X * 2), page.Height - (16 + modlabel.Bounds.X));

            page.Controls.Add(modlist);
            page.Controls.Add(modlabel);

            tab_MLMaster.SelectedTab = page;

            HtmlElementCollection root = browser.Document.GetElementsByTagName("ul");

            foreach (HtmlElement element in root) {
                HtmlElementCollection list = element.GetElementsByTagName("li");
                foreach (HtmlElement a in list) {
                    HtmlElementCollection aElement = a.GetElementsByTagName("a");
                    foreach (HtmlElement b in aElement) {
                        string mod = b.InnerText.Replace(b.InnerText.Substring(b.InnerText.IndexOf("(by") - 1), "");
                        string author = b.InnerText.Substring(b.InnerText.IndexOf("(by") + 4);
                        author = author.Substring(0, author.Length - 1);

                        ListViewItem item = new ListViewItem();
                        item.Text = mod;
                        item.SubItems.Add(author);

                        modlist.Items.Add(item);
                    }
                }
            }
            modlist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btn_MLBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Browse...";
            dialog.Filter = "HTML Files|*.html";

            dialog.ShowDialog();
            txt_ML.Text = dialog.FileName;
        }

        private void btn_Submit_Click(object sender, EventArgs e) {
            if (txt_ML.Text.Length == 0)
                MessageBox.Show("A modlist.html file is required in order to complete this process.", "Minecraft Modpack List Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txt_Name.Text.Length == 0)
                MessageBox.Show("A modlist name is required in order to complete this process.", "Minecraft Modpack List Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                try {
                    browser.Url = new Uri(txt_ML.Text);
                } catch (Exception ex) {
                    MessageBox.Show("An error occurred while trying to submit your modlist:\n\n" + ex.Message + "\n\nStack trace:\n" + ex.StackTrace, "Minecraft Modpack List Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            txt_ML.Text = "";
            txt_Name.Text = "";
        }

        private void btn_Export_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Browse...";
            dialog.Filter = "Text Files|*.txt|CSV Files|*.csv|All Files|*.*";
            dialog.FileName = txt_Name.Text;

            dialog.ShowDialog();

            string output = "";
            string auth = "";
            string del = rdb_DelCom.Checked ? "," : "\n";
            foreach (ListViewItem item in ((ListView)tab_MLMaster.SelectedTab.Controls[0]).Items) { 
                if (chk_ItemQuote.Checked)
                    output += "\"" + item.Text + "\"" + del;
                else
                    output += item.Text + del;

                if(chk_ExAuth.Checked) {
                    if (chk_ItemQuote.Checked)
                        auth += "\"" + item.SubItems[1].Text + "\"" + del;
                    else
                        auth += item.SubItems[1].Text + del;
                }
            }
            
            output = output.Substring(0, output.Length - 1);
            try {
                File.WriteAllText(dialog.FileName, output);

                if (chk_ExAuth.Checked) {
                    auth = auth.Substring(0, auth.Length - 1);
                    File.WriteAllText(dialog.FileName.Insert(dialog.FileName.Length - 4, "_author"), auth);
                }
            } catch(Exception ex) {
                MessageBox.Show("An error occurred while trying to export data:\n\n" + ex.Message + "\n\nStack trace:\n" + ex.StackTrace, "Minecraft Modpack List Loader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
