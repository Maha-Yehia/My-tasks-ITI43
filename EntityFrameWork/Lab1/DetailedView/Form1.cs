using DetailedView.Models;
using DetailedView.Models;
using Microsoft.EntityFrameworkCore;

namespace DetailedView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosed += (sender, e) => Context?.Dispose();
        }

        Context.pubsContext Context;

        BindingNavigator nav;
        BindingSource TitleBS;
        BindingSource PublisherBS;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            Context = new();
            Context.Titles.Load();
            Context.Publishers.Load();

            TitleBS = new();
            TitleBS.DataSource = Context.Titles.Local.ToBindingList();
            PublisherBS = new();
            PublisherBS.DataSource = Context.Publishers.Local.ToBindingList();

            nav = new(TitleBS);
            this.Controls.Add(nav);

            lblTitleID.DataBindings.Add("Text", TitleBS, "TitleId");
            txtTitle.DataBindings.Add("Text", TitleBS, "Title1");
            txtType.DataBindings.Add("Text", TitleBS, "Type");
            drpPublisher.DataSource = PublisherBS;
            drpPublisher.DisplayMember = "PubName";
            drpPublisher.ValueMember = "PubId";
            drpPublisher.DataBindings.Add("SelectedValue", TitleBS, "PubId");
          
            numPrice.DataBindings.Add("Value" , TitleBS , "Price" , true , DataSourceUpdateMode.OnPropertyChanged , DBNull.Value);

            numAdvance.DataBindings.Add("Value", TitleBS, "Advance", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            numRoyalty.DataBindings.Add("Value", TitleBS, "Royalty", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            numYTDSales.DataBindings.Add("Value", TitleBS, "YtdSales", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            txtNotes.DataBindings.Add("Text", TitleBS, "Notes");
            dtPublicationDate.DataBindings.Add("Value", TitleBS, "Pubdate");

            TitleBS.AddingNew += TitleListBS_AddingNew;
        }

        private void TitleListBS_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            e.NewObject = new Title() { Advance = 0, Notes = "", Price = 0, Pubdate = DateTime.Today, Royalty = 0, Title1 = "New Title", Type = "", YtdSales = 0, TitleId = ((new Random()).Next() % 999999).ToString() };
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                TitleBS.DataSource = Context.Titles.Local.ToBindingList();
            }
            finally
            {
                MessageBox.Show($"Rows Updatd: {count}");
            }
        }

    }
}
