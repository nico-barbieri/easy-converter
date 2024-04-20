using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EasyConverter
{
    public partial class EasyConverter : Form
    {
        // Lista per memorizzare i percorsi dei file selezionati
        private List<string> filePaths = new List<string>();

        public EasyConverter()
        {
            InitializeComponent();
            PopulateOutputFormats();
        }

        private Dictionary<string, string> supportedFormats = new Dictionary<string, string>()
        {
            { "MP3 (MPEG audio layer 3)", ".mp3" },
            { "WAV (Waveform audio)", ".wav" },
            { "M4A (MPEG-4 audio)", ".m4a" },
            { "AAC (Advanced Audio Coding)", ".aac" },
            { "FLAC (Free Lossless Audio Codec)", ".flac" },
            { "OGG (Ogg Vorbis)", ".ogg" },
            { "MP4 (MPEG-4 Part 14)", ".mp4" },
            { "AVI (Audio Video Interleave)", ".avi" },
            { "MKV (Matroska Multimedia Container)", ".mkv" },
            { "MOV (Apple QuickTime Movie)", ".mov" },
            { "WEBM (WebM)", ".webm" },
            { "JPEG (Joint Photographic Experts Group)", ".jpg" },
            { "PNG (Portable Network Graphics)", ".png" },
            { "GIF (Graphics Interchange Format)", ".gif" },
            { "BMP (Bitmap image)", ".bmp" },
            { "TIFF (Tagged Image File Format)", ".tiff" }
        };

        private void PopulateOutputFormats()
        {
            // Aggiungi i nomi dei formati alla lista dei formati di output
            foreach (var format in supportedFormats.Keys)
            {
                ExtensionSelection.Items.Add(format);
            }
        }

        private void AddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "File audio|*.mp3;*.wav;*.m4a|Tutti i file|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    // Aggiungi il nome del file alla lista dei file
                    FileList.Items.Add(Path.GetFileName(fileName));

                    // Aggiungi il percorso completo alla lista dei percorsi
                    filePaths.Add(fileName);
                }
            }
        }

        private void RemoveFiles_Click(object sender, EventArgs e)
        {
            // Creare una copia degli elementi selezionati
            var selectedItems = new List<object>();
            foreach (var selectedItem in FileList.SelectedItems)
            {
                selectedItems.Add(selectedItem);
            }

            // Rimuovere gli elementi dalla lista dei file e dai percorsi
            foreach (var selectedItem in selectedItems)
            {
                FileList.Items.Remove(selectedItem);
                int index = FileList.Items.IndexOf(selectedItem);
                if (index >= 0)
                {
                    filePaths.RemoveAt(index);
                }
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            // Assicurati che sia selezionato un formato di output
            if (ExtensionSelection.SelectedItem == null)
            {
                MessageBox.Show("Selezionare un formato di output.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Effettua la conversione per ogni file nella lista
            foreach (string filePath in filePaths)
            {
                string outputFormat = ExtensionSelection.SelectedItem.ToString();
                string outputExtension = GetExtensionFromFormat(outputFormat);
                if (outputExtension == null)
                {
                    MessageBox.Show($"Formato di output non valido: {outputFormat}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string outputFileName = Path.ChangeExtension(Path.GetFileName(filePath), outputExtension);
                string outputPath = Path.GetDirectoryName(filePath);

                // Costruisci il comando FFmpeg per la conversione del file
                string ffmpegCommand = $"-i \"{filePath}\" \"{Path.Combine(outputPath, outputFileName)}\"";

                // Avvia FFmpeg come processo esterno per eseguire la conversione
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = ffmpegCommand,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    // Attendi il completamento del processo e gestisci eventuali errori
                    process.WaitForExit();
                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show($"Errore durante la conversione di {Path.GetFileName(filePath)}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Conversione completata!", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetExtensionFromFormat(string format)
        {
            // Ottieni l'estensione corrispondente al formato selezionato
            if (supportedFormats.ContainsKey(format))
            {
                return supportedFormats[format];
            }
            else
            {
                return null; // Formato non supportato
            }
        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            // Aggiungi i file trascinati nella lista dei file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    // Aggiungi solo il nome del file alla lista dei file
                    FileList.Items.Add(Path.GetFileName(file));

                    // Aggiungi il percorso completo alla lista dei percorsi
                    filePaths.Add(file);
                }
            }
        }

        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            // Accetta solo il trascinamento di file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ExtensionSelection_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
