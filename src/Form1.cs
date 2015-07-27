using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Win10ThemeRevealer
{
    public partial class Form1 : Form
    {

        readonly string System32Path = Environment.GetFolderPath(Environment.SpecialFolder.System);
        readonly string ThemesPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Resources\\Themes";
        string WowThemeName = "Windows Color Revived";
        string WowThemeFileName = "windowsColor";
        string LiteThemeName = "Windows Lite";
        string LiteThemeFileName = "aerolite";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Build < 10240)
            {
                MessageBox.Show("This program is designed for Windows 10 (Build 10240) or later only!"
                   , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Win32.SetFormIcon(this.Handle, Application.ExecutablePath);
        }
        private void btnReveal_Click(object sender, EventArgs e)
        {
            // Copy MUI files
            foreach (string muiDir in Directory.GetDirectories(ThemesPath + "\\aero", "*-*"))
            {
                if (File.Exists(muiDir + "\\aero.msstyles.mui"))
                {
                    File.Copy(muiDir + "\\aero.msstyles.mui", muiDir + "\\" + WowThemeFileName + ".msstyles.mui", true);
                }
            }
            // Copy msstyles file
            try
            {
                using (FileStream dest = new FileStream(ThemesPath + "\\aero\\" + WowThemeFileName + ".msstyles",
                    FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    byte[] b = File.ReadAllBytes(ThemesPath + "\\aero\\aero.msstyles");
                    dest.Write(b, 0, b.Length);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot write to " + WowThemeFileName + ".msstyles!", "Error!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // Install modified theme file
            File.WriteAllText(ThemesPath + "\\" + WowThemeFileName + ".theme",
                Properties.Resources.modifiedTheme
                .Replace("#THEME_NAME", WowThemeName)
                .Replace("#THEME_FILENAME", WowThemeFileName));
            File.WriteAllText(ThemesPath + "\\" + LiteThemeFileName + ".theme",
                Properties.Resources.modifiedTheme
                .Replace("#THEME_NAME", LiteThemeName)
                .Replace("#THEME_FILENAME", LiteThemeFileName));
            // Done!
            MessageBox.Show("Done! Select your favorite theme now. :D ","OK!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnTryWindowsColorRevived_Click(object sender, EventArgs e)
        {
            OpenTheme(ThemesPath + "\\" + WowThemeFileName + ".theme");
        }

        private void btnTryWindowsLite_Click(object sender, EventArgs e)
        {
            OpenTheme(ThemesPath + "\\" + LiteThemeFileName + ".theme");
        }

        private void btnRestoreSystemDefault_Click(object sender, EventArgs e)
        {
            // Switch default theme
            OpenTheme(ThemesPath + "\\aero.theme");
            MessageBox.Show("Press OK when Windows has reverted to its default theme.","Just one more click");
            // Delete the wow theme
            File.Delete(ThemesPath + "\\" + LiteThemeFileName + ".theme");
            File.Delete(ThemesPath + "\\" + WowThemeFileName + ".theme");
            File.Delete(ThemesPath + "\\aero\\" + WowThemeFileName + ".msstyles");
            foreach (string muiDir in Directory.GetDirectories(ThemesPath + "\\aero", "*-*"))
            {
                if (File.Exists(muiDir + "\\" + WowThemeFileName + ".msstyles.mui"))
                {
                    File.Delete(muiDir + "\\" + WowThemeFileName + ".msstyles.mui");
                }
            }
        }

        private void lnkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://raymai97.github.io/Win10ThemeRevealer");
        }

        void OpenTheme(string themePath)
        {
            if (File.Exists(themePath))
            {
                Process.Start(System32Path + "\\rundll32.exe", System32Path + "\\themecpl.dll,OpenThemeAction " + themePath);
            }
            else
            {
                MessageBox.Show(themePath, "Theme is not exist!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
