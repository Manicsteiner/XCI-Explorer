using System.ComponentModel;
using System.Windows.Forms;
using XCI_Explorer.Helpers;

namespace XCI_Explorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            B_LoadROM = new Button();
            TB_File = new TextBox();
            TABC_Main = new TabControl();
            TABP_XCI = new TabPage();
            TB_GameRev = new RichTextBox();
            label12 = new Label();
            B_TrimXCI = new Button();
            TB_ProdCode = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            TB_Dev = new TextBox();
            label10 = new Label();
            TB_Name = new TextBox();
            label9 = new Label();
            PB_GameIcon = new PictureBox();
            CB_RegionName = new ComboBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            B_ViewCert = new Button();
            B_ClearCert = new Button();
            B_ImportCert = new Button();
            B_ExportCert = new Button();
            TB_ExactUsedSpace = new TextBox();
            TB_ROMExactSize = new TextBox();
            TB_UsedSpace = new TextBox();
            TB_ROMSize = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TB_MKeyRev = new TextBox();
            label4 = new Label();
            TB_SDKVer = new TextBox();
            label3 = new Label();
            TB_Capacity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TB_TID = new TextBox();
            tabPage2 = new TabPage();
            LB_HashedRegionSize = new Label();
            LB_ActualHash = new Label();
            LB_ExpectedHash = new Label();
            B_Extract = new Button();
            LB_DataSize = new Label();
            LB_DataOffset = new Label();
            LB_SelectedData = new Label();
            TV_Partitions = new TreeView();
            backgroundWorker1 = new BackgroundWorker();
            TABC_Main.SuspendLayout();
            TABP_XCI.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)PB_GameIcon).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // B_LoadROM
            // 
            B_LoadROM.Location = new System.Drawing.Point(7, 22);
            B_LoadROM.Margin = new Padding(6, 6, 6, 6);
            B_LoadROM.Name = "B_LoadROM";
            B_LoadROM.Size = new System.Drawing.Size(138, 42);
            B_LoadROM.TabIndex = 0;
            B_LoadROM.Text = "Load Game";
            B_LoadROM.UseVisualStyleBackColor = true;
            B_LoadROM.Click += B_LoadROM_Click;
            // 
            // TB_File
            // 
            TB_File.AllowDrop = true;
            TB_File.Location = new System.Drawing.Point(156, 24);
            TB_File.Margin = new Padding(6, 6, 6, 6);
            TB_File.Name = "TB_File";
            TB_File.ReadOnly = true;
            TB_File.Size = new System.Drawing.Size(488, 30);
            TB_File.TabIndex = 1;
            TB_File.DragDrop += TABP_XCI_DragDrop;
            TB_File.DragEnter += TABP_XCI_DragEnter;
            // 
            // TABC_Main
            // 
            TABC_Main.Controls.Add(TABP_XCI);
            TABC_Main.Controls.Add(tabPage2);
            TABC_Main.Location = new System.Drawing.Point(7, 76);
            TABC_Main.Margin = new Padding(6, 6, 6, 6);
            TABC_Main.Name = "TABC_Main";
            TABC_Main.SelectedIndex = 0;
            TABC_Main.Size = new System.Drawing.Size(667, 1022);
            TABC_Main.TabIndex = 2;
            // 
            // TABP_XCI
            // 
            TABP_XCI.AllowDrop = true;
            TABP_XCI.Controls.Add(TB_GameRev);
            TABP_XCI.Controls.Add(label12);
            TABP_XCI.Controls.Add(B_TrimXCI);
            TABP_XCI.Controls.Add(TB_ProdCode);
            TABP_XCI.Controls.Add(label8);
            TABP_XCI.Controls.Add(groupBox2);
            TABP_XCI.Controls.Add(label7);
            TABP_XCI.Controls.Add(groupBox1);
            TABP_XCI.Controls.Add(TB_ExactUsedSpace);
            TABP_XCI.Controls.Add(TB_ROMExactSize);
            TABP_XCI.Controls.Add(TB_UsedSpace);
            TABP_XCI.Controls.Add(TB_ROMSize);
            TABP_XCI.Controls.Add(label6);
            TABP_XCI.Controls.Add(label5);
            TABP_XCI.Controls.Add(TB_MKeyRev);
            TABP_XCI.Controls.Add(label4);
            TABP_XCI.Controls.Add(TB_SDKVer);
            TABP_XCI.Controls.Add(label3);
            TABP_XCI.Controls.Add(TB_Capacity);
            TABP_XCI.Controls.Add(label2);
            TABP_XCI.Controls.Add(label1);
            TABP_XCI.Controls.Add(TB_TID);
            TABP_XCI.Location = new System.Drawing.Point(4, 33);
            TABP_XCI.Margin = new Padding(6, 6, 6, 6);
            TABP_XCI.Name = "TABP_XCI";
            TABP_XCI.Padding = new Padding(6, 6, 6, 6);
            TABP_XCI.Size = new System.Drawing.Size(659, 985);
            TABP_XCI.TabIndex = 0;
            TABP_XCI.Text = "Main";
            TABP_XCI.UseVisualStyleBackColor = true;
            TABP_XCI.Click += TABP_XCI_Click;
            TABP_XCI.DragDrop += TB_File_DragDrop;
            TABP_XCI.DragEnter += TB_File_DragEnter;
            // 
            // TB_GameRev
            // 
            TB_GameRev.Location = new System.Drawing.Point(28, 126);
            TB_GameRev.Margin = new Padding(6, 6, 6, 6);
            TB_GameRev.Name = "TB_GameRev";
            TB_GameRev.ReadOnly = true;
            TB_GameRev.Size = new System.Drawing.Size(431, 194);
            TB_GameRev.TabIndex = 23;
            TB_GameRev.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(138, 96);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(193, 24);
            label12.TabIndex = 22;
            label12.Text = "0 BASE, 0 UPD, 0 DLC";
            // 
            // B_TrimXCI
            // 
            B_TrimXCI.Location = new System.Drawing.Point(563, 356);
            B_TrimXCI.Margin = new Padding(6, 6, 6, 6);
            B_TrimXCI.Name = "B_TrimXCI";
            B_TrimXCI.Size = new System.Drawing.Size(70, 92);
            B_TrimXCI.TabIndex = 21;
            B_TrimXCI.Text = "Trim XCI";
            B_TrimXCI.UseVisualStyleBackColor = true;
            B_TrimXCI.Click += B_TrimXCI_Click;
            // 
            // TB_ProdCode
            // 
            TB_ProdCode.Location = new System.Drawing.Point(473, 282);
            TB_ProdCode.Margin = new Padding(6, 6, 6, 6);
            TB_ProdCode.Name = "TB_ProdCode";
            TB_ProdCode.ReadOnly = true;
            TB_ProdCode.Size = new System.Drawing.Size(156, 30);
            TB_ProdCode.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(473, 252);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(132, 24);
            label8.TabIndex = 19;
            label8.Text = "Product Code:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(TB_Dev);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TB_Name);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(PB_GameIcon);
            groupBox2.Controls.Add(CB_RegionName);
            groupBox2.Location = new System.Drawing.Point(28, 570);
            groupBox2.Margin = new Padding(6, 6, 6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 6, 6, 6);
            groupBox2.Size = new System.Drawing.Size(605, 356);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game Infos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(11, 138);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(99, 24);
            label11.TabIndex = 25;
            label11.Text = "Language:";
            label11.Click += label11_Click;
            // 
            // TB_Dev
            // 
            TB_Dev.Location = new System.Drawing.Point(11, 276);
            TB_Dev.Margin = new Padding(6, 6, 6, 6);
            TB_Dev.Name = "TB_Dev";
            TB_Dev.ReadOnly = true;
            TB_Dev.Size = new System.Drawing.Size(279, 30);
            TB_Dev.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(11, 246);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(102, 24);
            label10.TabIndex = 23;
            label10.Text = "Developer:";
            // 
            // TB_Name
            // 
            TB_Name.Location = new System.Drawing.Point(11, 70);
            TB_Name.Margin = new Padding(6, 6, 6, 6);
            TB_Name.Name = "TB_Name";
            TB_Name.ReadOnly = true;
            TB_Name.Size = new System.Drawing.Size(279, 30);
            TB_Name.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(11, 40);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(66, 24);
            label9.TabIndex = 21;
            label9.Text = "Name:";
            // 
            // PB_GameIcon
            // 
            PB_GameIcon.BackgroundImageLayout = ImageLayout.Zoom;
            PB_GameIcon.Location = new System.Drawing.Point(315, 40);
            PB_GameIcon.Margin = new Padding(6, 6, 6, 6);
            PB_GameIcon.Name = "PB_GameIcon";
            PB_GameIcon.Size = new System.Drawing.Size(279, 294);
            PB_GameIcon.TabIndex = 18;
            PB_GameIcon.TabStop = false;
            // 
            // CB_RegionName
            // 
            CB_RegionName.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_RegionName.FormattingEnabled = true;
            CB_RegionName.Location = new System.Drawing.Point(11, 168);
            CB_RegionName.Margin = new Padding(6, 6, 6, 6);
            CB_RegionName.Name = "CB_RegionName";
            CB_RegionName.Size = new System.Drawing.Size(279, 32);
            CB_RegionName.TabIndex = 17;
            CB_RegionName.SelectedIndexChanged += CB_RegionName_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(20, 96);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(91, 24);
            label7.TabIndex = 15;
            label7.Text = "Contents:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(B_ViewCert);
            groupBox1.Controls.Add(B_ClearCert);
            groupBox1.Controls.Add(B_ImportCert);
            groupBox1.Controls.Add(B_ExportCert);
            groupBox1.Location = new System.Drawing.Point(28, 460);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new System.Drawing.Size(605, 98);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cert";
            // 
            // B_ViewCert
            // 
            B_ViewCert.Location = new System.Drawing.Point(308, 36);
            B_ViewCert.Margin = new Padding(6, 6, 6, 6);
            B_ViewCert.Name = "B_ViewCert";
            B_ViewCert.Size = new System.Drawing.Size(136, 42);
            B_ViewCert.TabIndex = 3;
            B_ViewCert.Text = "View Cert";
            B_ViewCert.UseVisualStyleBackColor = true;
            B_ViewCert.Click += B_ViewCert_Click;
            // 
            // B_ClearCert
            // 
            B_ClearCert.Location = new System.Drawing.Point(458, 36);
            B_ClearCert.Margin = new Padding(6, 6, 6, 6);
            B_ClearCert.Name = "B_ClearCert";
            B_ClearCert.Size = new System.Drawing.Size(136, 42);
            B_ClearCert.TabIndex = 2;
            B_ClearCert.Text = "Clear Cert";
            B_ClearCert.UseVisualStyleBackColor = true;
            B_ClearCert.Click += B_ClearCert_Click;
            // 
            // B_ImportCert
            // 
            B_ImportCert.Location = new System.Drawing.Point(158, 36);
            B_ImportCert.Margin = new Padding(6, 6, 6, 6);
            B_ImportCert.Name = "B_ImportCert";
            B_ImportCert.Size = new System.Drawing.Size(136, 42);
            B_ImportCert.TabIndex = 1;
            B_ImportCert.Text = "Import Cert";
            B_ImportCert.UseVisualStyleBackColor = true;
            B_ImportCert.Click += B_ImportCert_Click;
            // 
            // B_ExportCert
            // 
            B_ExportCert.Location = new System.Drawing.Point(11, 36);
            B_ExportCert.Margin = new Padding(6, 6, 6, 6);
            B_ExportCert.Name = "B_ExportCert";
            B_ExportCert.Size = new System.Drawing.Size(136, 42);
            B_ExportCert.TabIndex = 0;
            B_ExportCert.Text = "Export Cert";
            B_ExportCert.UseVisualStyleBackColor = true;
            B_ExportCert.Click += B_ExportCert_Click;
            // 
            // TB_ExactUsedSpace
            // 
            TB_ExactUsedSpace.Location = new System.Drawing.Point(279, 406);
            TB_ExactUsedSpace.Margin = new Padding(6, 6, 6, 6);
            TB_ExactUsedSpace.Name = "TB_ExactUsedSpace";
            TB_ExactUsedSpace.ReadOnly = true;
            TB_ExactUsedSpace.Size = new System.Drawing.Size(275, 30);
            TB_ExactUsedSpace.TabIndex = 13;
            // 
            // TB_ROMExactSize
            // 
            TB_ROMExactSize.Location = new System.Drawing.Point(279, 356);
            TB_ROMExactSize.Margin = new Padding(6, 6, 6, 6);
            TB_ROMExactSize.Name = "TB_ROMExactSize";
            TB_ROMExactSize.ReadOnly = true;
            TB_ROMExactSize.Size = new System.Drawing.Size(275, 30);
            TB_ROMExactSize.TabIndex = 12;
            // 
            // TB_UsedSpace
            // 
            TB_UsedSpace.Location = new System.Drawing.Point(141, 406);
            TB_UsedSpace.Margin = new Padding(6, 6, 6, 6);
            TB_UsedSpace.Name = "TB_UsedSpace";
            TB_UsedSpace.ReadOnly = true;
            TB_UsedSpace.Size = new System.Drawing.Size(123, 30);
            TB_UsedSpace.TabIndex = 11;
            // 
            // TB_ROMSize
            // 
            TB_ROMSize.Location = new System.Drawing.Point(141, 356);
            TB_ROMSize.Margin = new Padding(6, 6, 6, 6);
            TB_ROMSize.Name = "TB_ROMSize";
            TB_ROMSize.ReadOnly = true;
            TB_ROMSize.Size = new System.Drawing.Size(123, 30);
            TB_ROMSize.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 406);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(111, 24);
            label6.TabIndex = 9;
            label6.Text = "Used space:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 362);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(98, 24);
            label5.TabIndex = 8;
            label5.Text = "ROM Size:";
            // 
            // TB_MKeyRev
            // 
            TB_MKeyRev.Location = new System.Drawing.Point(350, 42);
            TB_MKeyRev.Margin = new Padding(6, 6, 6, 6);
            TB_MKeyRev.Name = "TB_MKeyRev";
            TB_MKeyRev.ReadOnly = true;
            TB_MKeyRev.Size = new System.Drawing.Size(279, 30);
            TB_MKeyRev.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(346, 12);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 24);
            label4.TabIndex = 6;
            label4.Text = "MasterKey Revision:";
            // 
            // TB_SDKVer
            // 
            TB_SDKVer.Location = new System.Drawing.Point(473, 204);
            TB_SDKVer.Margin = new Padding(6, 6, 6, 6);
            TB_SDKVer.Name = "TB_SDKVer";
            TB_SDKVer.ReadOnly = true;
            TB_SDKVer.Size = new System.Drawing.Size(156, 30);
            TB_SDKVer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(473, 174);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 24);
            label3.TabIndex = 4;
            label3.Text = "SDK Version:";
            // 
            // TB_Capacity
            // 
            TB_Capacity.Location = new System.Drawing.Point(473, 126);
            TB_Capacity.Margin = new Padding(6, 6, 6, 6);
            TB_Capacity.Name = "TB_Capacity";
            TB_Capacity.ReadOnly = true;
            TB_Capacity.Size = new System.Drawing.Size(156, 30);
            TB_Capacity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(473, 96);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 24);
            label2.TabIndex = 2;
            label2.Text = "Capacity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 12);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 24);
            label1.TabIndex = 1;
            label1.Text = "Title ID:";
            // 
            // TB_TID
            // 
            TB_TID.Location = new System.Drawing.Point(28, 42);
            TB_TID.Margin = new Padding(6, 6, 6, 6);
            TB_TID.Name = "TB_TID";
            TB_TID.ReadOnly = true;
            TB_TID.Size = new System.Drawing.Size(308, 30);
            TB_TID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LB_HashedRegionSize);
            tabPage2.Controls.Add(LB_ActualHash);
            tabPage2.Controls.Add(LB_ExpectedHash);
            tabPage2.Controls.Add(B_Extract);
            tabPage2.Controls.Add(LB_DataSize);
            tabPage2.Controls.Add(LB_DataOffset);
            tabPage2.Controls.Add(LB_SelectedData);
            tabPage2.Controls.Add(TV_Partitions);
            tabPage2.Location = new System.Drawing.Point(4, 33);
            tabPage2.Margin = new Padding(6, 6, 6, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6, 6, 6, 6);
            tabPage2.Size = new System.Drawing.Size(659, 985);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Partitions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LB_HashedRegionSize
            // 
            LB_HashedRegionSize.AutoSize = true;
            LB_HashedRegionSize.Location = new System.Drawing.Point(11, 878);
            LB_HashedRegionSize.Margin = new Padding(6, 0, 6, 0);
            LB_HashedRegionSize.Name = "LB_HashedRegionSize";
            LB_HashedRegionSize.Size = new System.Drawing.Size(174, 24);
            LB_HashedRegionSize.TabIndex = 7;
            LB_HashedRegionSize.Text = "HashedRegionSize:";
            // 
            // LB_ActualHash
            // 
            LB_ActualHash.AutoSize = true;
            LB_ActualHash.Location = new System.Drawing.Point(11, 928);
            LB_ActualHash.Margin = new Padding(6, 0, 6, 0);
            LB_ActualHash.Name = "LB_ActualHash";
            LB_ActualHash.Size = new System.Drawing.Size(117, 24);
            LB_ActualHash.TabIndex = 6;
            LB_ActualHash.Text = "Actual Hash:";
            LB_ActualHash.DoubleClick += LB_ActualHash_DoubleClick;
            // 
            // LB_ExpectedHash
            // 
            LB_ExpectedHash.AutoSize = true;
            LB_ExpectedHash.Location = new System.Drawing.Point(11, 904);
            LB_ExpectedHash.Margin = new Padding(6, 0, 6, 0);
            LB_ExpectedHash.Name = "LB_ExpectedHash";
            LB_ExpectedHash.Size = new System.Drawing.Size(125, 24);
            LB_ExpectedHash.TabIndex = 5;
            LB_ExpectedHash.Text = "Header Hash:";
            LB_ExpectedHash.DoubleClick += LB_ExpectedHash_DoubleClick;
            // 
            // B_Extract
            // 
            B_Extract.Enabled = false;
            B_Extract.Location = new System.Drawing.Point(543, 788);
            B_Extract.Margin = new Padding(6, 6, 6, 6);
            B_Extract.Name = "B_Extract";
            B_Extract.Size = new System.Drawing.Size(88, 42);
            B_Extract.TabIndex = 4;
            B_Extract.Text = "Extract";
            B_Extract.UseVisualStyleBackColor = true;
            B_Extract.Click += B_Extract_Click;
            // 
            // LB_DataSize
            // 
            LB_DataSize.AutoSize = true;
            LB_DataSize.Location = new System.Drawing.Point(11, 854);
            LB_DataSize.Margin = new Padding(6, 0, 6, 0);
            LB_DataSize.Name = "LB_DataSize";
            LB_DataSize.Size = new System.Drawing.Size(48, 24);
            LB_DataSize.TabIndex = 3;
            LB_DataSize.Text = "Size:";
            // 
            // LB_DataOffset
            // 
            LB_DataOffset.AutoSize = true;
            LB_DataOffset.Location = new System.Drawing.Point(11, 830);
            LB_DataOffset.Margin = new Padding(6, 0, 6, 0);
            LB_DataOffset.Name = "LB_DataOffset";
            LB_DataOffset.Size = new System.Drawing.Size(66, 24);
            LB_DataOffset.TabIndex = 2;
            LB_DataOffset.Text = "Offset:";
            // 
            // LB_SelectedData
            // 
            LB_SelectedData.AutoSize = true;
            LB_SelectedData.Location = new System.Drawing.Point(11, 788);
            LB_SelectedData.Margin = new Padding(6, 0, 6, 0);
            LB_SelectedData.Name = "LB_SelectedData";
            LB_SelectedData.Size = new System.Drawing.Size(92, 24);
            LB_SelectedData.TabIndex = 1;
            LB_SelectedData.Text = "FileName";
            // 
            // TV_Partitions
            // 
            TV_Partitions.Dock = DockStyle.Top;
            TV_Partitions.HideSelection = false;
            TV_Partitions.Location = new System.Drawing.Point(6, 6);
            TV_Partitions.Margin = new Padding(6, 6, 6, 6);
            TV_Partitions.Name = "TV_Partitions";
            TV_Partitions.Size = new System.Drawing.Size(647, 766);
            TV_Partitions.TabIndex = 0;
            TV_Partitions.AfterSelect += TV_Partitions_AfterSelect;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(678, 1106);
            Controls.Add(TABC_Main);
            Controls.Add(TB_File);
            Controls.Add(B_LoadROM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "XCI Explorer";
            TABC_Main.ResumeLayout(false);
            TABP_XCI.ResumeLayout(false);
            TABP_XCI.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)PB_GameIcon).EndInit();
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private long[] SecureSize;
        private long[] NormalSize;
        private long[] SecureOffset;
        private long[] NormalOffset;
        private string[] SecureName = { };
        private long gameNcaOffset;
        private long gameNcaSize;
        private long PFS0Offset;
        private long PFS0Size;
        private long selectedOffset;
        private long selectedSize;
        private TreeViewFileSystem TV_Parti;
        private BetterTreeNode rootNode;
        private Button B_LoadROM;
        private TabControl TABC_Main;
        private TabPage TABP_XCI;
        private TabPage tabPage2;
        private TreeView TV_Partitions;
        private TextBox TB_SDKVer;
        private Label label3;
        private TextBox TB_Capacity;
        private Label label2;
        private Label label1;
        private TextBox TB_TID;
        private TextBox TB_MKeyRev;
        private Label label4;
        private TextBox TB_ExactUsedSpace;
        private TextBox TB_ROMExactSize;
        private TextBox TB_UsedSpace;
        private TextBox TB_ROMSize;
        private Label label6;
        private Label label5;
        private Label label7;
        private GroupBox groupBox1;
        private Button B_ClearCert;
        private Button B_ImportCert;
        private Button B_ExportCert;
        private ComboBox CB_RegionName;
        private TextBox TB_ProdCode;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox TB_Dev;
        private Label label10;
        private TextBox TB_Name;
        private Label label9;
        private PictureBox PB_GameIcon;
        private Button B_ViewCert;
        public TextBox TB_File;
        private Label LB_SelectedData;
        private Label LB_DataOffset;
        private Label LB_DataSize;
        private Button B_Extract;
        private Label LB_ExpectedHash;
        private Label LB_ActualHash;
        private Label LB_HashedRegionSize;
        private BackgroundWorker backgroundWorker1;
        private Button B_TrimXCI;
        private Label label11;
        private Label label12;
        private RichTextBox TB_GameRev;
    }
}