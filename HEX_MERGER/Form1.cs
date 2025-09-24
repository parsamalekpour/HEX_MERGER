using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEX_MERGER
{
    public partial class Form1 : Form
    {

        private string bootloaderPath = "";
        private string mainPath = "";
        private string outputPath = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnBrowesFile1_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Hex Files|*.hex";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bootloaderPath = dlg.FileName;
                    txtFile1.Text = bootloaderPath;
                    var info = GetHexFileInfo(bootloaderPath);
                    lblSizeBootloader.Text = $"Start: 0x{info.start:X8}, Size: {info.size} bytes";
                }
            }
        }

        private void btnMainFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Hex Files|*.hex";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    mainPath = dlg.FileName;
                    txtMainFile.Text = mainPath;
                    var info = GetHexFileInfo(mainPath);
                    lblSizeMain.Text = $"Start: 0x{info.start:X8}, Size: {info.size} bytes";
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Hex Files|*.hex";
                dlg.FileName = "combined.hex";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    outputPath = dlg.FileName;
                    txtOutput.Text = outputPath;
                    lblSizeOutput.Text = "Will be generated after merge";
                }
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bootloaderPath) || string.IsNullOrEmpty(mainPath) || string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Please select all files first.");
                return;
            }

            try
            {
                var memory = new SortedDictionary<uint, byte>();
                LoadHexFile(bootloaderPath, memory);
                LoadHexFile(mainPath, memory);
                WriteHexFile(outputPath, memory);

                MessageBox.Show("Merge completed!\nFile saved at:\n" + outputPath);

                var info = GetHexFileInfo(outputPath);
                lblSizeOutput.Text = $"Start: 0x{info.start:X8}, Size: {info.size} bytes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowBottloader_Click(object sender, EventArgs e)
        {
            if(btnShowBottloader.Text == "<")
            {
                hexBox.Visible = false;
                btnShowBottloader.Text = ">";
                this.Width = 350;
            }

            else if(File.Exists(bootloaderPath))
            {
                hexBox.LineInfoOffset = GetHexFileInfo(bootloaderPath).start;
                LoadHexFile(bootloaderPath);
                
                hexBox.Visible = true;
                btnShowBottloader.Text = "<";
                this.Width = 750;
            }
            
        }

        private void btnShowMain_Click(object sender, EventArgs e)
        {
            if (btnShowMain.Text == "<")
            {
                hexBox.Visible = false;
                btnShowMain.Text = ">";
                this.Width = 350;
            }

            else if (File.Exists(mainPath))
            {
                hexBox.LineInfoOffset = GetHexFileInfo(mainPath).start;
                LoadHexFile(mainPath);

                hexBox.Visible = true;
                btnShowMain.Text = "<";
                this.Width = 750;
            }
        }

        private void btnShowOutput_Click(object sender, EventArgs e)
        {
            if (btnShowOutput.Text == "<")
            {
                hexBox.Visible = false;
                btnShowOutput.Text = ">";
                this.Width = 350;
            }

            else if (File.Exists(outputPath))
            {
                hexBox.LineInfoOffset = GetHexFileInfo(outputPath).start;
                LoadHexFile(outputPath);

                hexBox.Visible = true;
                btnShowOutput.Text = "<";
                this.Width = 750;
            }
        }

        // ===================== HEX LOGIC =====================
        private void LoadHexFile(string filePath)
        {
            // Read the whole file into memory (file will be closed immediately)
            byte[] data = File.ReadAllBytes(filePath);

            // Use DynamicByteProvider (in-memory, editable)
            var byteProvider = new DynamicByteProvider(data);
            hexBox.ByteProvider = byteProvider;
        }


        private (uint start, uint size) GetHexFileInfo(string path)
        {
            uint extAddr = 0;
            uint? minAddr = null;
            uint maxAddr = 0;

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line) || line[0] != ':') continue;

                int length = Convert.ToInt32(line.Substring(1, 2), 16);
                uint addr = Convert.ToUInt32(line.Substring(3, 4), 16);
                int type = Convert.ToInt32(line.Substring(7, 2), 16);

                if (type == 0x00) // data
                {
                    for (int i = 0; i < length; i++)
                    {
                        uint fullAddr = extAddr + addr + (uint)i;
                        if (minAddr == null || fullAddr < minAddr) minAddr = fullAddr;
                        if (fullAddr > maxAddr) maxAddr = fullAddr;
                    }
                }
                else if (type == 0x04) // extended linear address
                {
                    extAddr = (uint)Convert.ToUInt32(line.Substring(9, 4), 16) << 16;
                }
            }

            uint start = minAddr ?? 0;
            uint size = (minAddr == null) ? 0 : (maxAddr - start + 1);
            return (start, size);
        }

        private void LoadHexFile(string path, SortedDictionary<uint, byte> memory)
        {
            uint extAddr = 0;
            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line) || line[0] != ':') continue;

                int length = Convert.ToInt32(line.Substring(1, 2), 16);
                uint addr = Convert.ToUInt32(line.Substring(3, 4), 16);
                int type = Convert.ToInt32(line.Substring(7, 2), 16);

                if (type == 0x00) // Data record
                {
                    for (int i = 0; i < length; i++)
                    {
                        byte data = Convert.ToByte(line.Substring(9 + i * 2, 2), 16);
                        uint fullAddr = extAddr + addr + (uint)i;
                        memory[fullAddr] = data;
                    }
                }
                else if (type == 0x04) // Extended Linear Address
                {
                    extAddr = (uint)Convert.ToUInt32(line.Substring(9, 4), 16) << 16;
                }
            }
        }

        private void WriteHexFile(string path, SortedDictionary<uint, byte> memory)
        {
            using (var writer = new StreamWriter(path))
            {
                uint? currentSegment = null;
                List<byte> buffer = new List<byte>();
                ushort lastOffset = 0;
                uint lastAddr = 0;

                foreach (var kvp in memory)
                {
                    uint addr = kvp.Key;
                    byte data = kvp.Value;

                    uint segment = addr >> 16;
                    ushort offset = (ushort)(addr & 0xFFFF);

                    if (currentSegment != segment)
                    {
                        if (buffer.Count > 0)
                        {
                            WriteDataRecord(writer, lastOffset, buffer);
                            buffer.Clear();
                        }
                        // Extended Linear Address record
                        string rec = $":02000004{segment:X4}{Checksum(2, 0, 4, (byte)(segment >> 8), (byte)(segment & 0xFF)):X2}";
                        writer.WriteLine(rec);
                        currentSegment = segment;
                    }

                    if (buffer.Count == 0)
                        lastOffset = offset;
                    else if (offset != lastOffset + buffer.Count || buffer.Count >= 16)
                    {
                        WriteDataRecord(writer, lastOffset, buffer);
                        buffer.Clear();
                        lastOffset = offset;
                    }

                    buffer.Add(data);
                    lastAddr = addr;
                }

                if (buffer.Count > 0)
                    WriteDataRecord(writer, lastOffset, buffer);

                writer.WriteLine(":00000001FF"); // EOF
            }
        }

        private void WriteDataRecord(StreamWriter writer, ushort offset, List<byte> data)
        {
            int len = data.Count;
            int sum = len + (offset >> 8) + (offset & 0xFF) + 0x00;
            string record = $":{len:X2}{offset:X4}00";

            foreach (var b in data)
            {
                record += $"{b:X2}";
                sum += b;
            }

            byte chk = (byte)((~sum + 1) & 0xFF);
            record += $"{chk:X2}";
            writer.WriteLine(record);
        }

        private byte Checksum(params int[] bytes)
        {
            int sum = 0;
            foreach (int b in bytes) sum += b;
            return (byte)((~sum + 1) & 0xFF);
        }

 
    }
}
