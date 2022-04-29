using System.IO;
using System.Security.Cryptography.Xml;

namespace CreateSignatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string message = string.Empty;
        public List<string> signatures = new();
        public List<Tuple<string, int, int, int>> mylist = new();
        ConversionEngine engine = new();

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new(fileStream))
                    {
                        string line = reader.ReadLine();

                        while ( !reader.EndOfStream) 
                        {
                            Tuple<int, int, int> conversion = engine.StringConversion(line);

                            // add a Tuple to the list
                            mylist.Add(new Tuple<string, int, int, int>(line, conversion.Item1, conversion.Item2, conversion.Item3));

                            line = reader.ReadLine();
                        }

                        InputFileTxt.Text = filePath.ToString();
                    }

                    for (int i = 0; i < mylist.Count; i++)
                    {
                        string word = mylist[i].Item1;
                        int length = mylist[i].Item2;
                        int product = mylist[i].Item3;
                        int sum = mylist[i].Item4;

                        string signature = $"{word}, {length}, {product}, {sum}";
                        signatures.Add(signature);
                    }

                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    using (StreamWriter outputFile = new(Path.Combine(docPath, "Signatures.txt")))
{
                        foreach (var line in signatures) outputFile.WriteLine(line);
                    }

                    OutputFileTxt.Text = $"{docPath}\\Signatures.txt";

                }
            }

            
        }
    }
}