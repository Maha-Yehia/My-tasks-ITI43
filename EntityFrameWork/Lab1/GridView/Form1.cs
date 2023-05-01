using GridView.Models;
using Microsoft.EntityFrameworkCore;

namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormClosed += (sender, e) => Context?.Dispose();
        }

        Context.pubsContext Context = new();
        DataGridViewComboBoxColumn PublisherCol;

        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Titles.Load();
            Context.Publishers.Load();

            grdTitles.DataSource = Context.Titles.Local.ToBindingList();

            PublisherCol = new DataGridViewComboBoxColumn();
            PublisherCol.DataSource = Context.Publishers.Local.ToBindingList();
            PublisherCol.DisplayMember = "PubName";
            PublisherCol.ValueMember = "PubId";
            PublisherCol.DataPropertyName = "PubId";
            grdTitles.Columns.Add(PublisherCol);

            grdTitles.Columns["Pub"].Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                count = Context.SaveChanges();
            }
            catch (Exception)
            {
                Context = new();
                Context.Titles.Load();
                grdTitles.DataSource = Context.Titles.Local.ToBindingList();
            }
            finally
            {
                MessageBox.Show($"Rows Updatd: {count}");
            }
        }
    }
}