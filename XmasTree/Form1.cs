namespace XmasTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_tree.Text = "\n" + textBox_header.Text + "\n \n";
            int rowCount = Convert.ToInt32(textBox_rowCount.Text);
            int limiter = 3;
            for (int i = 1; i <= rowCount - 2; i++)
            {
                int spaceCount = rowCount- i + 1;
                for (int j = 0; j < spaceCount; j++) label_tree.Text += " ";
                if(i == 1) label_tree.Text += "*" + "\n";
                else if ( i == 2) label_tree.Text += "* *" + "\n";
                else
                {
                    label_tree.Text += "*";
                        for(int k = 0; k < limiter; k++)
                        {
                            label_tree.Text += " ";
                        }
                    limiter += 2;
                    label_tree.Text+= "*" + "\n";
                }
            }
            for(int i = 0; i < 2; i++)
            { 
                label_tree.Text += " ";
            }
            if (rowCount > 3)
            {
                for (int i = 0; i < limiter + 2; i++)
                {
                    label_tree.Text += "*";
                }
                label_tree.Text += "\n";
            }
            for(int i = 0; i < rowCount; i++)
            {
                label_tree.Text += " ";
            }
            label_tree.Text += "*" + "\n \n";
            label_tree.Text += textBox_footer.Text;
        }
    }
}
