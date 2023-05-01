namespace RTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnClose.Click += (sender, e) => this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var answer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (answer == DialogResult.No)
                e.Cancel = true;
        }

        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text File |*.rtf|Text Files|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName, (RichTextBoxStreamType)(openFileDialog1.FilterIndex - 1));
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text File |*.rtf|Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName, (RichTextBoxStreamType)(openFileDialog1.FilterIndex - 1));
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        Custom CustomDialog = new();

        private void btnCustom_Click(object sender, EventArgs e)
        {
            CustomDialog.UserText = "Enter Text Here";
            if (CustomDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.AppendText(CustomDialog.UserText);
            }
        }
    }
}
