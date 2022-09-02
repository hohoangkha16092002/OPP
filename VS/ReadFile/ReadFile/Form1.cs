using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace ReadFile
{
    public partial class Reader : Form
    {
        string fileName=null;
        string ktra;

        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";

        public Reader()
        {
            InitializeComponent();
        }
        protected void button1_Click(object sender, EventArgs e) ///OPEN
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                //Lấy đường dẫn đến file(thư mục)
                string s = File.ReadAllText(fileName);
                textBox1.Text = s;
            }
        }
        private void btnSave_Click(object sender, EventArgs e) ///SAVE
        {
            if (textBox1.Text != "" && fileName != null)
            {
                File.WriteAllText(fileName, textBox1.Text);
                ktra = textBox1.Text;
            }
                
            else if(fileName == null) btnSaveAs_Click(sender, e);
        }
        protected void btnSaveAs_Click(object sender, EventArgs e) ///SAVE AS
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\Kah\Desktop";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {             
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sWriter = new StreamWriter(fs);
                sWriter.Write(textBox1.Text);
                ktra = textBox1.Text;
                sWriter.Flush();
                sWriter.Close();
            }
        }
        private void btnFont_Click(object sender, EventArgs e)  ///FONT
        {
            
            FontDialog dlg = new FontDialog(); //Khởi tạo đối tượng FontDialog 
            //Hiển thị hộp thoại    dlg.ShowDialog();
            dlg.ShowColor = true;
            dlg.ShowApply = true;
            dlg.ShowEffects = true;
            dlg.ShowHelp = true;
            dlg.Color = Color.White;
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = dlg.Font;
                textBox1.BackColor = dlg.Color;
            }
        }
        private void btnClose_Click(object sender, EventArgs e) ///CLOSE
        {
            if (textBox1.Text != "" && textBox1.Text != ktra)
            {
                if (textBox1.Text != File.ReadAllText(fileName))
                {
                    DialogResult dlr = MessageBox.Show("File chưa được lưu,bạn vẫn muốn thoát chương trình?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes) this.Close();
                }
                else this.Close();
            }
            else this.Close();
        }
        private void gbxXuat_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.btnSaveAs.Image = Image.FromFile("D:\\HOCTAP\\OPP\\VS\\ReadFile\\ReadFile\\Resources\\icons8-save-as-30.png");

            //btnSave.Image = Image.FromFile("D:\\HOCTAP\\OPP\\VS\\ReadFile\\ReadFile\\Resources\\save.png");
            //btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            //btnSave.TextAlign = ContentAlignment.MiddleCenter;
        }
        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }


        protected void btnNew_Click_1(object sender, EventArgs e) ///NEW
        {
            SaveFileDialog newFileDialog1 = new SaveFileDialog();
            newFileDialog1.InitialDirectory = @"C:\Users\Kah\Desktop";
            newFileDialog1.Title = "Save text Files";//
            newFileDialog1.DefaultExt = "txt";
            newFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            newFileDialog1.ShowDialog();
            FileStream fs = new FileStream(newFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
            fileName = newFileDialog1.FileName;
            fs.Flush();
            fs.Close();
            textBox1.Text = File.ReadAllText(fileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnNew_Click_1(sender,e);
        }
    }
}
