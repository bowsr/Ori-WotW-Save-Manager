using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OriWotWSaveManager {
    public partial class Form1: Form {

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 7323;
        private const uint MOD_NONE = 0x0000;

        private ContextMenuStrip saveListContextMenu;

        public Form1() {
            InitializeComponent();

            var saveContextRename = new ToolStripMenuItem { Text = "Rename (F2)" };
            var saveContextDelete = new ToolStripMenuItem { Text = "Delete (Del)" };
            saveContextRename.Click += (sender, e) => { RenameSave(); };
            saveContextDelete.Click += (sender, e) => { DeleteSave(); };

            saveListContextMenu = new ContextMenuStrip();
            saveListContextMenu.Items.Add(saveContextRename);
            saveListContextMenu.Items.Add(saveContextDelete);

            importButton.Click += (sender, e) => { ImportSaveFile(); };
            loadButton.Click += (sender, e) => { LoadSaveFile(); };
            debugButton.Click += (sender, e) => { ToggleDebugMode(); };
            saveSelectionList.MouseDown += SaveSelectionList_MouseDown;
            saveSelectionList.KeyDown += SaveSelectionList_KeyDown;

            PopulateSaveList();
            CheckDebugMode();

            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NONE, Keys.F9.GetHashCode());
        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            if(m.Msg == 0x0312) {
                LoadSaveFile();
            }
        }

        protected override void OnClosing(CancelEventArgs e) {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            
            base.OnClosing(e);
        }

        private void ImportSaveFile() {
            if(!FileHandler.CheckSaveFileExists()) {
                ThrowError("No save file in the 1st slot exists");
                return;
            }
            string name = Prompt.ShowDialog("Enter desired save file name.", "Import Save File");
            if(name.Length == 0) return;
            FileHandler.ImportSaveFile(name);
            saveSelectionList.Items.Add(name);
        }

        private void LoadSaveFile() {
            if(saveSelectionList.SelectedIndex == -1) return;

            FileHandler.LoadSaveFile(saveSelectionList.SelectedItem.ToString());
        }

        private void ToggleDebugMode() {
            if(FileHandler.CheckDebugFileExists())
                FileHandler.DeleteDebugFile();
            else
                FileHandler.CreateDebugDirAndFile();
            CheckDebugMode();
        }

        private void PopulateSaveList() {
            string[] saves = FileHandler.GetSaveFileList();
            if(saves.Length > 0)
                foreach(string p in saves)
                    saveSelectionList.Items.Add(Path.GetFileNameWithoutExtension(p));
        }

        private void CheckDebugMode() {
            if(FileHandler.CheckDebugFileExists()) {
                debugStatusText.ForeColor = Color.FromArgb(0, 200, 0);
                debugStatusText.Text = "Enabled";
            } else {
                debugStatusText.ForeColor = Color.FromArgb(200, 0, 0);
                debugStatusText.Text = "Disabled";
            }
        }

        private void SaveSelectionList_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Delete) DeleteSave();
            if(e.KeyCode == Keys.F2) RenameSave();
        }

        private void SaveSelectionList_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                saveSelectionList.SelectedIndex = saveSelectionList.IndexFromPoint(e.Location);
                if(saveSelectionList.SelectedIndex != -1) {
                    saveListContextMenu.Show(Cursor.Position);
                    saveListContextMenu.Visible = true;
                } else 
                    saveListContextMenu.Visible = false;
            }
        }

        private void RenameSave() {
            if(saveSelectionList.SelectedIndex == -1) return;

            string name = Prompt.ShowDialog("Enter the new save file name.", "Rename " + saveSelectionList.SelectedItem.ToString());
            if(name.Length == 0) return;
            foreach(object o in saveSelectionList.Items) {
                if(o.ToString() == name) {
                    ThrowError("Save File " + name + " already exists");
                    return;
                }
            }
            FileHandler.RenameSaveFile(saveSelectionList.SelectedItem.ToString(), name);
            var index = saveSelectionList.SelectedIndex;
            saveSelectionList.Items.RemoveAt(index);
            saveSelectionList.Items.Add(name);
        }

        private void DeleteSave() {
            if(saveSelectionList.SelectedIndex == -1) return;

            FileHandler.DeleteSaveFile(saveSelectionList.SelectedItem.ToString());
            var index = saveSelectionList.SelectedIndex;
            saveSelectionList.Items.RemoveAt(index);
        }

        private void ThrowError(string msg) {
            ThreadExceptionDialog ted = new ThreadExceptionDialog(new IOException(msg));
            ted.ShowDialog();
        }
    }
}
