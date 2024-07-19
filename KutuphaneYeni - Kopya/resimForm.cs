using KutuphaneYeni.DBResimler;
using KutuphaneYeni.Entities.EntityResim;
using KutuphaneYeni.İmage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYeni
{
    public partial class resimForm : Form
    {
  
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<Resimler> liste = new List<Resimler>();
        public Image SelectedImage { get; private set; }
        private int _kullaniciid;

        public resimForm(int kullaniciid)
        {
            _kullaniciid = kullaniciid;
            InitializeComponent();
        }

        private async void ekleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.png|*.jpg|*.jpeg|*.gif|*.bmp|*.JPEG|*.PNG|*.GIF|";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int x = 10;
                int y = 10;
                int maxWidth = 0;

                foreach (string filename in files)
                {
                    try
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(filename);
                        pic.Size = new Size(150, 150);
                        pic.Location = new Point(x, y);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(x, y + 150);

                        checkBox.CheckStateChanged += (s, ev) =>
                        {
                            if (checkBox.Checked)
                            {
                                foreach (CheckBox otherCheckBox in checkBoxes)
                                {
                                    if (otherCheckBox != checkBox)
                                    {
                                        otherCheckBox.Enabled = false;
                                    }
                                }
                            }
                            else
                            {
                                foreach (CheckBox otherCheckBox in checkBoxes)
                                {
                                    otherCheckBox.Enabled = true;
                                }
                            }
                        };

                        ContextMenu checkBoxContextMenu = new ContextMenu();
                        MenuItem deleteMenuItem = new MenuItem("Sil");
                        MenuItem setAsDefaultMenuItem = new MenuItem("Varsayılan Olarak Ayarla");

                        deleteMenuItem.Click += (s, ev) =>
                        {
                            int index = checkBoxes.IndexOf(checkBox);
                            if (index >= 0 && index < pictureBoxes.Count)
                            {
                                panel2.Controls.Remove(checkBox);
                                panel2.Controls.Remove(pictureBoxes[index]);
                                checkBoxes.RemoveAt(index);
                                pictureBoxes.RemoveAt(index);
                            }
                        };

                        setAsDefaultMenuItem.Click += async (s, ev) =>
                        {
                            checkBox.Checked = true;

                            int index = checkBoxes.IndexOf(checkBox);
                            if (index >= 0 && index < liste.Count)
                            {
                                Resimler selectedResim = liste[index];
                                selectedResim.VarsayilanResim = true;
                                await ApiResim.DuzenleResim(selectedResim);
                            }
                        };

                        checkBoxContextMenu.MenuItems.Add(deleteMenuItem);
                        checkBoxContextMenu.MenuItems.Add(setAsDefaultMenuItem);
                        checkBox.ContextMenu = checkBoxContextMenu;

                        x += pic.Width + 10;
                        maxWidth = Math.Max(pic.Width, maxWidth);

                        if (x > panel2.ClientSize.Width - 100)
                        {
                            x = 10;
                            y += pic.Height + 10;
                        }

                        pictureBoxes.Add(pic);
                        checkBoxes.Add(checkBox);

                        bool isDefault = VarsayilanAyarla(filename);
                        checkBox.Checked = isDefault;

                        Resimler item = new Resimler();
                        item.KullaniciID = _kullaniciid;
                        item.Resim = imgClass.ImageToByteArray(pic.Image);
                        item.VarsayilanResim = checkBox.Checked;
                        liste.Add(item);
                        pic.Click += (s, ev) => OnPictureBoxClick(pic);

                        panel2.Controls.Add(checkBox);
                        panel2.Controls.Add(pic);
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }

                panel2.AutoScroll = true;
                panel2.HorizontalScroll.Enabled = false;
                panel2.HorizontalScroll.Visible = false;
                panel2.VerticalScroll.Enabled = true;
                panel2.VerticalScroll.Visible = true;
                panel2.AutoScrollMinSize = new Size(0, y + 200);
                ApiResim.EkleResim(liste);



            }
        }

        private void kapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnPictureBoxClick(PictureBox pictureBox)
        {
            if (pictureBox != null && pictureBox.Image != null)
            {
                SelectedImage = pictureBox.Image;
            }
        }

        private bool VarsayilanAyarla(string filename)
        {
            // Varsayılan ayarlanacaksa true, aksi halde false döndür
            return false;
        }

        private  void resimForm_Load(object sender, EventArgs e)
        {
            var existingPicturesCount = pictureBoxes.Count;
            var liste =  ApiResim.GetResimlerByKullaniciID(_kullaniciid);
            int row = existingPicturesCount / 3;
            int col = existingPicturesCount % 3;
            int rowHeight = 150;
            int colWidth = 150;
            int margin = 10;

            foreach (var item in liste)
            {
                PictureBox pic = new PictureBox();
                pic.Image = imgClass.ByteArrayToImage(item.Resim);
                pic.Size = new Size(colWidth, colWidth);
                pic.Location = new Point(col * (colWidth + margin), row * (rowHeight + margin));
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(col * (colWidth + margin), (row + 1) * (rowHeight + margin));
                checkBox.Tag = item.ID;
                checkBox.Checked = item.VarsayilanResim.GetValueOrDefault();
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.CheckStateChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        foreach (CheckBox otherCheckBox in checkBoxes)
                        {
                            if (otherCheckBox != checkBox)
                            {
                                otherCheckBox.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        foreach (CheckBox otherCheckBox in checkBoxes)
                        {
                            otherCheckBox.Enabled = true;
                        }
                    }
                };
                ContextMenu checkBoxContextMenu = new ContextMenu();
                MenuItem deleteMenuItem = new MenuItem("Sil");
                MenuItem setAsDefaultMenuItem = new MenuItem("Varsayılan Olarak Ayarla");
                deleteMenuItem.Click +=  (s, ev) =>
                {
                    int index = checkBoxes.IndexOf(checkBox);
                    if (index >= 0 && index < pictureBoxes.Count)
                    {
                        int resimID = (int)checkBox.Tag;
                         ApiResim.SilResim(resimID);

                        panel2.Controls.Remove(checkBox);
                        panel2.Controls.Remove(pictureBoxes[index]);
                        checkBoxes.RemoveAt(index);
                        pictureBoxes.RemoveAt(index);
                    }
                };
                setAsDefaultMenuItem.Click += async (s, ev) =>
                {
                    checkBox.Checked = true;

                    int index = checkBoxes.IndexOf(checkBox);
                    if (index >= 0 && index < liste.Count)
                    {
                        Resimler selectedResim = liste[index];
                        selectedResim.VarsayilanResim = true;
                         await ApiResim .DuzenleResim(selectedResim);
                    }
                };
                checkBoxContextMenu.MenuItems.Add(deleteMenuItem);
                checkBoxContextMenu.MenuItems.Add(setAsDefaultMenuItem);
                checkBox.ContextMenu = checkBoxContextMenu;

                pictureBoxes.Add(pic);
                checkBoxes.Add(checkBox);

                pic.Click += (s, ev) => OnPictureBoxClick(pic);

                panel2.Controls.Add(checkBox);
                panel2.Controls.Add(pic);

                col++;
                if (col >= 3)
                {
                    col = 0;
                    row++;
                }
            }

            panel2.AutoScroll = true;
        }
        private  async void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var _sender = ((CheckBox)sender);
            //var _res =DBResimler.DBResimler.Liste().Where(x => x.ID == Convert.ToInt32(_sender.Tag)).FirstOrDefault();
            var resimler =  ApiResim.GetResimler();
            var _res = resimler.Where(x => x.ID == Convert.ToInt32(_sender.Tag)).FirstOrDefault();
            _res.VarsayilanResim = _sender.Checked;
             await ApiResim.DuzenleResim(new Resimler
            {
                ID = _res.ID,
                KullaniciID = _res.KullaniciID,
                VarsayilanResim = _res.VarsayilanResim,
                Resim = _res.Resim,
            });

        }



    }
}
