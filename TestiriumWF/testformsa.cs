using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammFunctions;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;
using System.IO;

namespace TestiriumWF
{
    public partial class testformsa : Form
    {
        ImageFunctions _imageFunctions = new ImageFunctions();
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        private byte[] _bytes;

        public testformsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mySqlFunctions.CallProcedure("push_new_image",
                new MySqlParameter[] { new MySqlParameter("image", 
                _imageFunctions.ConvertImageIntoBytes(_imageFunctions.GetImageStream())) });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _bytes = (byte[])_mySqlFunctions.CallProcedureWithReturnedDataTable("get_image_by_id",
                    new MySqlParameter[] { new MySqlParameter("id", textBox1.Text) }).Rows[0][0];

                pictureBox1.Image = _imageFunctions.ConvertBytesIntoImage(_bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SHA256Hash sHA256Hash = new SHA256Hash();

            textBox4.Text = sHA256Hash.HashPassword(login.Text, password.Text);
        }
    }
}
