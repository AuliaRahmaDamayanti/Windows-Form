using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanWinForm
{
    public partial class FrmListMahasiswa : Form
    {
        public FrmListMahasiswa()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Npm", 70, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Nama", 180, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Jenis Kelamin", 80, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tempat Lahir", 75, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tgl. Lahir", 75, HorizontalAlignment.Left);
        }

        private void lvwMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void FrmListMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var index = lvwMahasiswa.SelectedIndices[0];
                var nama = lvwMahasiswa.Items[index].SubItems[2].Text;

                var msg = string.Format("Apakah data mahasiswa '{0}' ingin dihapus ?", nama);

                var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lvwMahasiswa.Items[index].Remove();
                }
            }
            else // data belum dipilih   
            {        
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,                
                    MessageBoxIcon.Exclamation);
            } 
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            var msg = "Apakah Anda Yakin ?";

            var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void lvwMahasiswa_DoubleClick(object sender, EventArgs e)
        {
            var index = lvwMahasiswa.SelectedIndices[0];
            var npm = lvwMahasiswa.Items[index].SubItems[1].Text;
            var nama = lvwMahasiswa.Items[index].SubItems[2].Text;
            var jk = lvwMahasiswa.Items[index].SubItems[3].Text;
            var lahir = lvwMahasiswa.Items[index].SubItems[4].Text;
            var tgl = lvwMahasiswa.Items[index].SubItems[5].Text;
            mskNpm.Text = npm;
            txtNama.Text = nama;

            if(jk == "Laki - laki")
            {
                rdoLakilaki.Checked = true;
            }
            else if (jk == "perempuan")
            {
                rdoPerempuan.Checked = true;
            }
            txtTempatLahir.Text = lahir;
            dtpTanggalLahir.Text = tgl;
        }
    }
}
