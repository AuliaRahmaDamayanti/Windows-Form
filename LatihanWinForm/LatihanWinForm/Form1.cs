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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
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

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if(!mskNpm.MaskFull)
            {
                MessageBox.Show("NPM harus diisi!!!", "PERINGATAN", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            if (!(txtNama.Text.Length > 0))
            {
                MessageBox.Show("Nama harus diisi!!!", "PERINGATAN", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            var jeniskelamin = rdoLakilaki.Checked ? "Laki - laki" : "Perempuan";

           var msg = string.Format("NPM : {0} \nNama : {1} \nJenis Kelamin : {2} \nTempat, tgl Lahir : {3}",
            mskNpm.Text, txtNama.Text, jeniskelamin, dtpTanggalLahir);

           var result = MessageBox.Show("Apakah data ingin disimpan ?", "Konfirmasi" ,
               MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
              var noUrut = lvwMahasiswa.Items.Count + 1;
              var item = new ListViewItem(noUrut.ToString());
              item.SubItems.Add(mskNpm.Text);
                item.SubItems.Add(txtNama.Text);
                item.SubItems.Add(jeniskelamin);
                item.SubItems.Add(txtTempatLahir.Text);
                item.SubItems.Add(dtpTanggalLahir.Value.ToString("dd/MM/yyyy"));

                lvwMahasiswa.Items.Add(item);
                ResetForm();

               

                if (lvwMahasiswa.SelectedItems.Count > 0)
         {
                    }
                 // reset form input 
            }

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTutup_Click_1(object sender, EventArgs e)
        {
            var msg = "Apakah Anda Yakin ?";

            var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void ResetForm()
        {
            mskNpm.Clear();
            txtNama.Clear();
            rdoLakilaki.Checked = true;
            txtTempatLahir.Clear();
            dtpTanggalLahir.Value = DateTime.Today;

            mskNpm.Focus();
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
                    for(var i = 0; i < lvwMahasiswa.Items.Count; i++)
                    {
                        var noUrut = i + 1;
                        lvwMahasiswa.Items[i].SubItems[0].Text = Convert.ToString(noUrut);
                    }
                }
                }
                else // data belum dipilih   
                {
                    MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
        }

        private void lvwMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            if (jk == "Laki - laki")
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
