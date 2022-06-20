using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace listaH5
{
    public partial class Form1 : Form
    {
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        private string url1 = @"C:\Users\Nikogotonieobchodzi\Desktop\bezurzyteczne 2\skrypty\c#\listaH5\nic\";
        private string url2 = @"C:\Users\Nikogotonieobchodzi\Desktop\bezurzyteczne 2\skrypty\c#\listaH5\2nic\";

        public Form1()
        {
            InitializeComponent();
        }

        public void loadFilesAndDirectories(string filePath, ListView listView)
        {
            DirectoryInfo fileList;
            string tempFilePath = filePath + currentlySelectedItemName + @"\";
            FileAttributes fileAttr;
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                    string fileExtension = "";
                    listView.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView.Items.Add(files[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView.Items.Add(files[i].Name, 7);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView.Items.Add(files[i].Name, 6);
                                break;
                            case ".PDF":
                                listView.Items.Add(files[i].Name, 4);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView.Items.Add(files[i].Name, 3);
                                break;
                            case ".TXT":
                                listView.Items.Add(files[i].Name, 10);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView.Items.Add(files[i].Name, 9);
                                break;

                            default:
                                listView.Items.Add(files[i].Name, 8);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView.Items.Add(dirs[i].Name, 1);
                    }
                }
                
            }
            catch (Exception e){}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scierzka.Text = url1;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void okno12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Okno 1")
            {
                b.Text = "Okno 2";
                scierzka.Text = url2;
                for (int i = 0; i < listView1.SelectedItems.Count; i++) listView1.SelectedItems[i].Selected = false;
                listView1.Enabled = false;
                listView2.Enabled = true;
            }
            else
            {
                b.Text = "Okno 1";
                scierzka.Text = url1;
                for (int i = 0; i < listView2.SelectedItems.Count; i++) listView2.SelectedItems[i].Selected = false;
                listView2.Enabled = false;
                listView1.Enabled = true;
            }
        }

        private void Otworz_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog { Description = "Wybierz folder" })
            {
                if (fbd.ShowDialog() == DialogResult.OK) 
                {
                    if (okno12.Text == "Okno 1")
                    {
                        url1 = (new Uri(fbd.SelectedPath)).ToString();
                        url1 = url1.Remove(0, 8) + @"\";
                        url1 = url1.Replace('/',@"\"[0]);
                        scierzka.Text = url1;
                        isFile = false;
                        loadFilesAndDirectories(url1, listView1);
                    }
                    else
                    {
                        url2 = (new Uri(fbd.SelectedPath)).ToString();
                        url2 = url2.Remove(0, 8) + @"\";
                        url2 = url2.Replace('/', @"\"[0]);
                        scierzka.Text = url2;
                        isFile = false;
                        loadFilesAndDirectories(url2, listView2);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (okno12.Text == "Okno 1")
            {
                string path = url1;
                path = path.Substring(0, path.LastIndexOf(@"\"));
                path = path.Substring(0, path.LastIndexOf(@"\"));
                path += @"\";
                this.isFile = false;
                scierzka.Text = url1 = path;
                loadFilesAndDirectories(url1, listView1);
            }
            else
            {
                string path = url2;
                path = path.Substring(0, path.LastIndexOf(@"\"));
                path = path.Substring(0, path.LastIndexOf(@"\"));
                path += @"\";
                this.isFile = false;
                scierzka.Text = url2 = path;
                loadFilesAndDirectories(url2, listView2);
            }
        }

        private string wlasnosci(FileInfo Fi)
        {
            string ciag = "";

            ciag += "Nazwa: " + Fi.Name.ToString();
            ciag += "\nData utworzenia: " + Fi.CreationTimeUtc.ToString();
            ciag += "\nData edycji: " + Fi.LastWriteTimeUtc.ToString();
            ciag += "\nData dostepu: " + Fi.LastAccessTimeUtc.ToString();
            ciag += "\nWielkosc: " + Fi.Length.ToString() + "[b]\n\n";

            return ciag;
        }

        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            updateScierzka(url1, e);
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            updateScierzka(url2, e);
        }

        private void updateScierzka(string filePath, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            dane.Text = "";
            string url = filePath + "/" + currentlySelectedItemName;

            try
            {
                FileAttributes fileAttr = File.GetAttributes(url);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isFile = false;
                    dane.Text = "Wielkosc: " + GetDirectorySize(url) + "[b]";
                }
                else
                {
                    isFile = true;
                    dane.Text = wlasnosci(new FileInfo(url));
                    dane.Text += "Zawartosc:\n" + System.IO.File.ReadAllText(url);
                }
            }
            catch { isFile = true; }
        }

        private void listView1_DoubleClick(object sender, EventArgs e) {}

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isFile) url2 = scierzka.Text = url2 + currentlySelectedItemName + @"\";
            loadFilesAndDirectories(url2, listView2);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(!isFile) url1 = scierzka.Text = url1 + currentlySelectedItemName + @"\";
            loadFilesAndDirectories(url1, listView1);
        }

        private bool sprawdz(string name, string url, bool file, bool potwierdzenie)
        {
            if (name == "") return false;

            string[] niedozwolon = {"CON", "PRN", "AUX", "NUL",
            "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
            "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"};

            HashSet<string> niedozwolone = new HashSet<string>(niedozwolon);

            if (niedozwolone.Contains(name.ToUpper()))
            {
                MessageBox.Show("Niedozwolona Nazwa");
                return false;
            }

            string[] zle = { "<", ">", ":", "\"", @"/", @"\", @"|", "?", "*" };

            int i;
            for (i = 0; i < zle.Length; i++) if (name.Contains(zle[i]))
                {
                    MessageBox.Show("Niedozwolony Znak w Nazwie");
                    return false;
                }

            if (name[name.Length - 1] == '.' || name[name.Length - 1] == ' ')
            {
                MessageBox.Show("Nazwa nie moze konczyc sie kropka ani spacja");
                return false;
            }

            url = url + name;

            if(file)
            {
                if (File.Exists(url))
                {
                    if(potwierdzenie)
                    {
                        return DialogResult.Yes == MessageBox.Show(
                            "Juz istnieje plik o takiej nazwie\nCzy chcesz go nadpisac?", 
                            "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        MessageBox.Show("Juz istnieje plik o takiej nazwie");
                        return false;
                    }
                }
            }
            else
            {
                if (Directory.Exists(url))
                {
                    if (potwierdzenie)
                    {
                        return DialogResult.Yes == MessageBox.Show(
                            "Juz istnieje folder o takiej nazwie\nCzy chcesz go nadpisac?",
                            "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        MessageBox.Show("Juz istnieje folder o takiej nazwie");
                        return false;
                    }
                }
            }

            return true;
        }

        private void UtworzFolder_Click(object sender, EventArgs e)
        {
            string name = nazwa.Text;
            string url = scierzka.Text + name;

            if (!sprawdz(name, scierzka.Text, false, false)) return;

            Directory.CreateDirectory(url);

            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            bool file;

            ListView lista;
            if (okno12.Text == "Okno 1") lista = listView1;
            else lista = listView2;

            for (int i = 0; i < lista.SelectedItems.Count; i++)
            {
                string url = scierzka.Text + lista.SelectedItems[i].Text;
                if (MessageBox.Show("Czy chcesz usunac " + lista.SelectedItems[i].Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        FileAttributes fileAttr = File.GetAttributes(url);
                        if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) file = false;
                        else file = true;
                    }
                    catch { return; }

                    if (file)
                    {
                        FileInfo plik = new FileInfo(url);
                        plik.Delete();
                    }
                    else
                    {
                        DirectoryInfo dir = new DirectoryInfo(url);
                        dir.Delete(true);
                    }

                    if (url1.Contains(url)) url1 = url2;
                    if (url2.Contains(url)) url2 = url1;
                }
            }

            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void ZmianaNazwy_Click(object sender, EventArgs e)
        {
            
            string name = nazwa.Text;

            bool file;

            ListView lista;
            if (okno12.Text == "Okno 1") lista = listView1;
            else lista = listView2;

            if (lista.SelectedItems.Count < 1) return;

            string url = scierzka.Text + lista.SelectedItems[0].Text;
                
            try
            {
                FileAttributes fileAttr = File.GetAttributes(url);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) file = false;
                else file = true;
            }
            catch { return; }

            if (file)
            {
                if (!sprawdz(name, scierzka.Text, true, false)) return;
                FileInfo plik = new FileInfo(url);
                plik.MoveTo(scierzka.Text + name);
            }
            else
            {
                if (!sprawdz(name, scierzka.Text, false, false)) return;
                DirectoryInfo dir = new DirectoryInfo(url);
                dir.MoveTo(scierzka.Text + name);
            }

            if (url1.Contains(url)) url1 = url1.Replace(url, scierzka.Text + name);
            if (url2.Contains(url)) url2 = url2.Replace(url, scierzka.Text + name);


            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        public static void Copy(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (var dir in source.GetDirectories())
                Copy(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        }

        private void Kopiuj_Click(object sender, EventArgs e)
        {
            bool file;
            string nieurl;
            ListView lista;
            if (okno12.Text == "Okno 1")
            {
                lista = listView1;
                nieurl = url2;
            }
            else
            {
                lista = listView2;
                nieurl = url1;
            }

            for (int i = 0; i < lista.SelectedItems.Count; i++)
            {
                string url = scierzka.Text + lista.SelectedItems[i].Text;
                if (nieurl.Contains(url)||url1 == url2) MessageBox.Show("Nie mozna wykonac dzialania");
                else
                {
                    try
                    {
                        FileAttributes fileAttr = File.GetAttributes(url);
                        if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) file = false;
                        else file = true;
                    }
                    catch { return; }

                    
                    if (file)
                    {
                        if (sprawdz(lista.SelectedItems[i].Text, nieurl, true, true))
                        {
                            FileInfo plik = new FileInfo(url);
                            plik.CopyTo(nieurl + lista.SelectedItems[i].Text, true);
                        }
                    }
                    else
                    {
                        if (sprawdz(lista.SelectedItems[i].Text, nieurl, false, true))
                        {
                            if (Directory.Exists(nieurl + lista.SelectedItems[i].Text))
                            {
                                DirectoryInfo temp = new DirectoryInfo(nieurl + lista.SelectedItems[i].Text);
                                temp.Delete(true);
                            }
                            Directory.CreateDirectory(nieurl + lista.SelectedItems[i].Text);
                            Copy(new DirectoryInfo(url), new DirectoryInfo(nieurl + lista.SelectedItems[i].Text));
                        }
                    }
                }
            }

            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void Przenies_Click(object sender, EventArgs e)
        {
            bool file;
            string nieurl;
            ListView lista;
            if (okno12.Text == "Okno 1")
            {
                lista = listView1;
                nieurl = url2;
            }
            else
            {
                lista = listView2;
                nieurl = url1;
            }

            for (int i = 0; i < lista.SelectedItems.Count; i++)
            {
                string url = scierzka.Text + lista.SelectedItems[i].Text;
                /*try
                {
                    FileStream filey = new FileStream(url, FileMode.Open, FileAccess.Read);
                    filey.Close();
                }
                catch
                {
                    MessageBox.Show("Nie mozna wykonac dzialania\n plik jest uzywany przez inny proces");
                    return;
                }*/
                if (nieurl.Contains(url) || url1 == url2) MessageBox.Show("Nie mozna wykonac dzialania");
                else
                {
                    try
                    {
                        FileAttributes fileAttr = File.GetAttributes(url);
                        if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) file = false;
                        else file = true;
                    }
                    catch { return; }


                    if (file)
                    {
                        if (sprawdz(lista.SelectedItems[i].Text, nieurl, true, true))
                        {
                            FileInfo plik = new FileInfo(url);
                            plik.MoveTo(nieurl + lista.SelectedItems[i].Text);
                        }
                    }
                    else
                    {
                        if (sprawdz(lista.SelectedItems[i].Text, nieurl, false, true))
                        {
                            if (Directory.Exists(nieurl + lista.SelectedItems[i].Text))
                            {
                                DirectoryInfo temp = new DirectoryInfo(nieurl + lista.SelectedItems[i].Text);
                                temp.Delete(true);
                            }
                            DirectoryInfo dir = new DirectoryInfo(url);
                            dir.MoveTo(nieurl + lista.SelectedItems[i].Text);
                        }
                    }
                }
            }

            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void Przeszukaj_Click(object sender, EventArgs e)
        {
            dane.Text = "";
            Znajdz(new DirectoryInfo(scierzka.Text), nazwa.Text);
        }

        private void Znajdz(DirectoryInfo dir, string nazwa)
        {
            FileInfo[] plik = dir.GetFiles();
            DirectoryInfo[] folder = dir.GetDirectories();

            for(int i = 0; i < plik.Length; i++)
            {
                string temp = plik[i].FullName;
                temp = temp.Replace(scierzka.Text, "");
                if (plik[i].Name.Contains(nazwa)) dane.Text += temp + "\n";
            }

            for (int i = 0; i < folder.Length; i++)
            {
                string temp = folder[i].FullName;
                temp = temp.Replace(scierzka.Text, "");
                if (folder[i].Name.Contains(nazwa)) dane.Text += temp + "\n";
                Znajdz(folder[i], nazwa);
            }
        }

        private void UtworzPlik_Click(object sender, EventArgs e)
        {
            string name = nazwa.Text;
            string url = scierzka.Text + name;

            if (!sprawdz(name, scierzka.Text, false, false)) return;

            File.Create(url);

            isFile = false;
            loadFilesAndDirectories(url1, listView1);
            loadFilesAndDirectories(url2, listView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dane.Text = "";
            DriveInfo[] drives = DriveInfo.GetDrives();

            for (int i = 0; i < drives.Length; i++)
            {
                try
                {
                    dane.Text += "Nazwa Dysku: " + drives[i].Name + "\nPojemnosc Dysku: " +
                    drives[i].TotalSize / 1073741824 + "[Gb]\n Wolne miejsce: " + drives[i].TotalFreeSpace / 1073741824 + "[Gb]\n\n";
                }
                catch (Exception b)
                {
                    //dane.Text += b.ToString();
                }
            }
        }
    }
}
