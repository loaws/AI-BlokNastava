namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (txtComment.Text != string.Empty)
            {
                var data = new MLModel.ModelInput()
                {
                    Col0 = txtComment.Text,
                };
                var result = MLModel.Predict(data);
                string comment = "Komentar: " + data.Col0 + "\n";
                string sentiment = result.PredictedLabel == 0 ? "Sentiment: Pozitivan\n" : "Sentiment: Negativan\n";
                string scores = "Pozitivan skor: " + result.Score[1].ToString("0.000") + "\n" +
                                   "Negativan skor: " + result.Score[0].ToString("0.000");
                lblResult.Text = comment + sentiment + scores;
            }
            else
            {
                MessageBox.Show("Unesi komentar!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
