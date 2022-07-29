using System;
using System.Windows.Forms;
using System.IO;

namespace GiveMeOOF
{
    public partial class GiveMeOof : Form
    {

        string rbxPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Roblox\Versions";

        public GiveMeOof()
        {
            InitializeComponent();
            changeAllVersionsOof.Checked = true;
            versionTextBoxOof.Text = "";
            versionTextBoxOof.Enabled = false;
            label1.Enabled = false;
        }

        private void changeOof_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(rbxPath))
            {
                if (changeAllVersionsOof.Checked)
                {

                    foreach (string directory in Directory.GetDirectories(rbxPath))
                    {
                        string dirstr = directory;
                        string dirname = dirstr.Substring(dirstr.LastIndexOf(@"\") + 1);

                        Console.WriteLine("dirstr: " + dirstr);
                        Console.WriteLine("dirname: " + dirname);

                        DirectoryInfo dir = new DirectoryInfo(dirstr);

                        if (dir.Exists)
                        {
                            if (dirname.Contains("version"))
                            {
                                string soundPath = dirstr + "\\content\\sounds\\";


                                try
                                {
                                    Console.WriteLine("soundPath: " + soundPath);
                                    Extract("GiveMeOOF", soundPath, "Resources", "oof.ogg");
                                    if (File.Exists(soundPath + "ouch.ogg")) File.Delete(soundPath + "ouch.ogg");
                                    File.Move(soundPath + "oof.ogg", soundPath + "ouch.ogg");

                                }
                                catch { MessageBox.Show("Sorry, an unexpected error occured. Please try again", "Give Me OOF", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                            }
                        }

                    }
                }
                else
                {
                    string version = versionTextBoxOof.Text;
                    string versionPath = rbxPath + "\\" + version;
                    if (Directory.Exists(versionPath))
                    {
                        string dirstr = versionPath;
                        string dirname = version;

                        Console.WriteLine("dirstr: " + dirstr);
                        Console.WriteLine("dirname: " + dirname);

                        DirectoryInfo dir = new DirectoryInfo(dirstr);

                        if (dir.Exists)
                        {
                            if (dirname.Contains("version"))
                            {
                                string soundPath = dirstr + "\\content\\sounds\\";


                                try
                                {
                                    Console.WriteLine("soundPath: " + soundPath);
                                    Extract("GiveMeOOF", soundPath, "Resources", "oof.ogg");
                                    if (File.Exists(soundPath + "ouch.ogg")) File.Delete(soundPath + "ouch.ogg");
                                    File.Move(soundPath + "oof.ogg", soundPath + "ouch.ogg");

                                }
                                catch { MessageBox.Show("Sorry, an unexpected error occured. Please try again", "Give Me OOF", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                            }
                            else
                            {
                                MessageBox.Show("That version does not exist in your Roblox folder. Please enter a valid version and try again.", "Give Me OOF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("That version does not exist in your Roblox folder. Please enter a valid version and try again.", "Give Me OOF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You dont have Roblox installed! Please install Roblox and try again.", "Give Me OOF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeAllVersionsOof_CheckedChanged(object sender, EventArgs e)
        {
            if (changeAllVersionsOof.Checked)
            {
                versionTextBoxOof.Text = "";
                versionTextBoxOof.Enabled = false;
                label1.Enabled = false;
            }
            else
            {
                versionTextBoxOof.Enabled = true;
                label1.Enabled = true;
            }
        }

        private static void Extract(string nameSpace, string outputDir, string resourceLocation, string file)
        {
            using (System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(nameSpace + "." + resourceLocation + @"." + file))
            {
                using (System.IO.FileStream fileStream = new System.IO.FileStream(System.IO.Path.Combine(outputDir, file), System.IO.FileMode.Create))
                {
                    for (int i = 0; i < stream.Length; i++)
                    {
                        fileStream.WriteByte((byte)stream.ReadByte());
                    }
                    fileStream.Close();
                }
            }
        }
    }
}
