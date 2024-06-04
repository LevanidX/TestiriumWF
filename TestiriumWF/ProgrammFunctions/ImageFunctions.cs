using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.ProgrammFunctions
{
    internal class ImageFunctions
    {
        public Stream GetImageStream()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.png)|*.png";
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.OpenFile();
            }

            return null;
        }

        public void OpenImage(PictureBox pictureBox, Stream stream) => pictureBox.Image = new Bitmap(stream);

        public byte[] ConvertImageIntoBytes(Stream stream) => new BinaryReader(stream).ReadBytes((int)stream.Length);

        public Image ConvertBytesIntoImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
