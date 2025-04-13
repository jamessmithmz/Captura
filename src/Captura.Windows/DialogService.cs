using System.Windows.Forms;
using Captura.Models;
// using Ookii.Dialogs.Wpf;

namespace Captura.Windows
{
    // ReSharper disable once ClassNeverInstantiated.Global
    class DialogService : IDialogService
    {
        public string PickFolder(string Current, string Description)
        {
            //using (var dlg = new VistaFolderBrowserDialog
            //{
            //    SelectedPath = Current,
            //    UseDescriptionForTitle = true,
            //    Description = Description
            //})
            var dlg = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog { IsFolderPicker = true, Multiselect = false };
            {
                if (dlg.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok) //  System.Windows.Forms.DialogResult.OK)
                    return dlg.FileName;
            }

            return null;
        }

        public string PickFile(string InitialFolder, string Description)
        {
            var ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = InitialFolder,
                Title = Description
            };

            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }
    }
}