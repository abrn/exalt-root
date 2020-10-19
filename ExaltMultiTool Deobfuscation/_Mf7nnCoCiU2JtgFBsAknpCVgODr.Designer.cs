using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x020000D6 RID: 214
internal class _Mf7nnCoCiU2JtgFBsAknpCVgODr : UserControl
{
	// Token: 0x06000577 RID: 1399 RVA: 0x00020FEC File Offset: 0x0001F1EC
	public _Mf7nnCoCiU2JtgFBsAknpCVgODr()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00021008 File Offset: 0x0001F208
	private void _xBefSqfpyucmyoQLrpydInLxIjJ(object sender, EventArgs e)
	{
		if (this._3FhqPruoaSWMFZvb36zSzEqOtTC.SelectedIndex != -1)
		{
			Settings.Default.CurrentServer = this._3FhqPruoaSWMFZvb36zSzEqOtTC.Items[this._3FhqPruoaSWMFZvb36zSzEqOtTC.SelectedIndex].ToString();
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00021050 File Offset: 0x0001F250
	private void _zEIbBveoWYVGrZZs0UrIlmG4Pw2(object sender, EventArgs e)
	{
		_Mf7nnCoCiU2JtgFBsAknpCVgODr._02stcEQHwvxQfFRP5pxCqhUurDw 02stcEQHwvxQfFRP5pxCqhUurDw;
		02stcEQHwvxQfFRP5pxCqhUurDw._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		02stcEQHwvxQfFRP5pxCqhUurDw._hJqaCfUafwosIZWql6GPDTaWQvj = AsyncVoidMethodBuilder.Create();
		02stcEQHwvxQfFRP5pxCqhUurDw._VIVnDceCb5ujwt6SoxgBQeoPhEj = -1;
		02stcEQHwvxQfFRP5pxCqhUurDw._hJqaCfUafwosIZWql6GPDTaWQvj.Start<_Mf7nnCoCiU2JtgFBsAknpCVgODr._02stcEQHwvxQfFRP5pxCqhUurDw>(ref 02stcEQHwvxQfFRP5pxCqhUurDw);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00021088 File Offset: 0x0001F288
	private void _wu4NKDZSWkbAHXoFin7O7ao7Ial(object sender, EventArgs e)
	{
		Process.Start("https://realmstock.com/");
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x000210A0 File Offset: 0x0001F2A0
	private void _GXxfIylGQahV343RoMRNGYZyir(object sender, EventArgs e)
	{
		for (;;)
		{
			if (File.Exists(Settings.Default.ExaltLauncherPath))
			{
				if (Control.ModifierKeys != Keys.Alt)
				{
					goto IL_CB;
				}
			}
			string text = "C:\\Program Files\\RotMG Exalt Launcher\\RotMG Exalt Launcher.exe";
			if (!File.Exists(text))
			{
				MessageBox.Show(base.ParentForm, "Please locate the RotMG Exalt Launcher file where you installed it so that we can start RotMG.\n\nDefault location is similar to: " + text, "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Title = "Locate RotMG Exalt Launcher file...",
					Filter = "RotMG Exalt Launcher (*.exe)|*.exe",
					InitialDirectory = Path.GetDirectoryName(text)
				};
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					break;
				}
				if (!openFileDialog.FileName.EndsWith("RotMG Exalt Launcher.exe"))
				{
					break;
				}
				Settings.Default.ExaltLauncherPath = openFileDialog.FileName;
				Settings.Default.Save();
			}
			else
			{
				Settings.Default.ExaltLauncherPath = text;
			}
		}
		return;
		IL_CB:
		_AeMKsR1PsUj3nMvFNJ8PA27BYIO._mNU0yVH4EShRKUXDCDDhYFIVI4O(false);
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00021180 File Offset: 0x0001F380
	private void _YA23q9MoGq5Hzdhkjb75CxGkKNe(object sender, EventArgs e)
	{
		while (!File.Exists(Settings.Default.ExaltSteamPath) || Control.ModifierKeys == Keys.Alt)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam\\steamapps\\common\\Realm of the Mad God\\RotMG Exalt Launcher.exe");
			if (!File.Exists(text))
			{
				MessageBox.Show(base.ParentForm, "Please locate the STEAM RotMG Exalt Launcher file where you installed it so that we can start RotMG.\n\nDefault location is similar to: " + text, "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Title = "Locate RotMG Exalt Launcher file...",
					Filter = "RotMG Exalt Launcher (*.exe)|*.exe",
					InitialDirectory = Path.GetDirectoryName(text)
				};
				if (openFileDialog.ShowDialog() != DialogResult.OK || !openFileDialog.FileName.EndsWith("RotMG Exalt Launcher.exe"))
				{
					return;
				}
				Settings.Default.ExaltSteamPath = openFileDialog.FileName;
				Settings.Default.Save();
			}
			else
			{
				Settings.Default.ExaltSteamPath = text;
			}
		}
		_AeMKsR1PsUj3nMvFNJ8PA27BYIO._mNU0yVH4EShRKUXDCDDhYFIVI4O(true);
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00021268 File Offset: 0x0001F468
	private void _4li9iSaJ9SOHrqoMDwihQo4pCeR(object sender, EventArgs e)
	{
		(base.ParentForm as _O8RCBX441Egsj4ff5BOJx95ggk8)._4li9iSaJ9SOHrqoMDwihQo4pCeR(this, EventArgs.Empty);
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0002128C File Offset: 0x0001F48C
	private void _q0V7N8CzByN2RYEmjbBr5tI78AD(object sender, EventArgs e)
	{
		(base.ParentForm as _O8RCBX441Egsj4ff5BOJx95ggk8)._IV9dt2EXRsUCz3y9qJW09OSBzrj(this, EventArgs.Empty);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x000212B0 File Offset: 0x0001F4B0
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x000212DC File Offset: 0x0001F4DC
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_Mf7nnCoCiU2JtgFBsAknpCVgODr));
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht = new PictureBox();
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA = new Label();
		this._igYr9alHFQC72a0C0DD1ubHSSKo = new Panel();
		this._jnRWS57C6rT8T35L0qqCiCqhEHF = new Label();
		this._H6H47cWzE0z2tiFTqwckmW2A8qE = new PictureBox();
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA = new PictureBox();
		this._3FhqPruoaSWMFZvb36zSzEqOtTC = new ComboBox();
		this._UXlSqwCGaR3BR90GYbrmBdnup7h = new Panel();
		this._d9qACr7O9TsDq7iF4B5e6sziZMy = new Label();
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG = new Label();
		this._22prBPREEyLZOWuoc1fD7HEZ6nS = new PictureBox();
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl = new Panel();
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn = new Label();
		this._dQoZLXIbtJ06olhp917a0StGepn = new TableLayoutPanel();
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI = new Button();
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF = new Button();
		this._jjV1F7c6McYPsrLqSOma3SC0Knf = new Button();
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk = new Button();
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp = new Label();
		((ISupportInitialize)this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht).BeginInit();
		this._igYr9alHFQC72a0C0DD1ubHSSKo.SuspendLayout();
		((ISupportInitialize)this._H6H47cWzE0z2tiFTqwckmW2A8qE).BeginInit();
		((ISupportInitialize)this._RTCOlADJBRyZ1glqXXO5TwWdQRA).BeginInit();
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.SuspendLayout();
		((ISupportInitialize)this._22prBPREEyLZOWuoc1fD7HEZ6nS).BeginInit();
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.SuspendLayout();
		this._dQoZLXIbtJ06olhp917a0StGepn.SuspendLayout();
		base.SuspendLayout();
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.BackColor = Color.Transparent;
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Cursor = Cursors.Hand;
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Image = (Image)componentResourceManager.GetObject("pbxLogo.Image");
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Location = new Point(3, 3);
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Name = "pbxLogo";
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Size = new Size(494, 100);
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.SizeMode = PictureBoxSizeMode.Zoom;
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.TabIndex = 1;
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.TabStop = false;
		this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht.Click += this._wu4NKDZSWkbAHXoFin7O7ao7Ial;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.AutoSize = true;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.BackColor = Color.Transparent;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.ForeColor = Color.Gold;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.Location = new Point(46, 53);
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.Name = "lblPlayersOnine";
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.RightToLeft = RightToLeft.No;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.Size = new Size(176, 21);
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.TabIndex = 6;
		this._7iUSsM3IpgPp4uiAkbvSMPX1AoA.Text = "0 RotMG Players Online";
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.BackColor = Color.FromArgb(44, 31, 52);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.BorderStyle = BorderStyle.FixedSingle;
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Controls.Add(this._jnRWS57C6rT8T35L0qqCiCqhEHF);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Controls.Add(this._7iUSsM3IpgPp4uiAkbvSMPX1AoA);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Controls.Add(this._H6H47cWzE0z2tiFTqwckmW2A8qE);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Controls.Add(this._RTCOlADJBRyZ1glqXXO5TwWdQRA);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Font = new Font("Segoe UI", 8.25f);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Location = new Point(3, 101);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Name = "pnlAbout";
		this._igYr9alHFQC72a0C0DD1ubHSSKo.Size = new Size(257, 90);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.TabIndex = 8;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.AutoSize = true;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.BackColor = Color.Transparent;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.ForeColor = Color.Gold;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.Location = new Point(46, 10);
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.Name = "lblClientsConnected";
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.RightToLeft = RightToLeft.No;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.Size = new Size(184, 21);
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.TabIndex = 12;
		this._jnRWS57C6rT8T35L0qqCiCqhEHF.Text = "0 Exalt Clients Connected";
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.Image = (Image)componentResourceManager.GetObject("pbxPlayersOnlineIcon.Image");
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.Location = new Point(5, 46);
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.Name = "pbxPlayersOnlineIcon";
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.Size = new Size(40, 40);
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.SizeMode = PictureBoxSizeMode.Zoom;
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.TabIndex = 9;
		this._H6H47cWzE0z2tiFTqwckmW2A8qE.TabStop = false;
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.Image = (Image)componentResourceManager.GetObject("pbxClientsConnectedIcon.Image");
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.Location = new Point(5, 3);
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.Name = "pbxClientsConnectedIcon";
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.Size = new Size(40, 40);
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.SizeMode = PictureBoxSizeMode.Zoom;
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.TabIndex = 7;
		this._RTCOlADJBRyZ1glqXXO5TwWdQRA.TabStop = false;
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.DropDownStyle = ComboBoxStyle.DropDownList;
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.Font = new Font("Segoe UI", 12f);
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.FormattingEnabled = true;
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.Location = new Point(13, 50);
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.Name = "lstServers";
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.Size = new Size(207, 29);
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.TabIndex = 13;
		this._3FhqPruoaSWMFZvb36zSzEqOtTC.SelectedIndexChanged += this._xBefSqfpyucmyoQLrpydInLxIjJ;
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.BackColor = Color.FromArgb(44, 31, 52);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.BorderStyle = BorderStyle.FixedSingle;
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Controls.Add(this._d9qACr7O9TsDq7iF4B5e6sziZMy);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Controls.Add(this._3FhqPruoaSWMFZvb36zSzEqOtTC);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Controls.Add(this._AMEKx38mLo7rkoAAIRgtZZ4TDjG);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Controls.Add(this._22prBPREEyLZOWuoc1fD7HEZ6nS);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Font = new Font("Segoe UI", 8.25f);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Location = new Point(263, 101);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Name = "pnlServerSelect";
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.Size = new Size(234, 90);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.TabIndex = 16;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Anchor = AnchorStyles.None;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.AutoSize = true;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.BackColor = Color.Transparent;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.ForeColor = Color.Gold;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Location = new Point(42, 4);
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Name = "lblCurrentServer";
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.RightToLeft = RightToLeft.No;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Size = new Size(190, 21);
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.TabIndex = 14;
		this._d9qACr7O9TsDq7iF4B5e6sziZMy.Text = "Proxy Server Destination";
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Anchor = AnchorStyles.None;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.AutoSize = true;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.BackColor = Color.Transparent;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Font = new Font("Segoe UI", 8.25f);
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.ForeColor = Color.Gold;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Location = new Point(43, 25);
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Name = "lblServerChangeInfo";
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.RightToLeft = RightToLeft.No;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Size = new Size(161, 13);
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.TabIndex = 16;
		this._AMEKx38mLo7rkoAAIRgtZZ4TDjG.Text = "Use '/con' to change in-game!";
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.Anchor = AnchorStyles.None;
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.Image = (Image)componentResourceManager.GetObject("pbxProxyServer.Image");
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.Location = new Point(-1, 1);
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.Name = "pbxProxyServer";
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.Size = new Size(40, 40);
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.SizeMode = PictureBoxSizeMode.Zoom;
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.TabIndex = 15;
		this._22prBPREEyLZOWuoc1fD7HEZ6nS.TabStop = false;
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.BackColor = Color.FromArgb(44, 31, 52);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.BorderStyle = BorderStyle.FixedSingle;
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Controls.Add(this._tKBTSAORY4UWZkVWDYEkF4vaVRn);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Controls.Add(this._dQoZLXIbtJ06olhp917a0StGepn);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Controls.Add(this._L4aVGUFAjnQeUesF0J5bmFgE0qp);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Font = new Font("Segoe UI", 8.25f);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Location = new Point(3, 194);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Name = "pnlLaunch";
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.Size = new Size(494, 103);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.TabIndex = 17;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Anchor = AnchorStyles.None;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.AutoSize = true;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.BackColor = Color.Transparent;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Font = new Font("Segoe UI", 8.25f);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.ForeColor = Color.Gold;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Location = new Point(104, 22);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Name = "label1";
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.RightToLeft = RightToLeft.No;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Size = new Size(280, 13);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.TabIndex = 18;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Text = "You must start RotMG from below to enable our tool!";
		this._dQoZLXIbtJ06olhp917a0StGepn.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._dQoZLXIbtJ06olhp917a0StGepn.ColumnCount = 4;
		this._dQoZLXIbtJ06olhp917a0StGepn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		this._dQoZLXIbtJ06olhp917a0StGepn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		this._dQoZLXIbtJ06olhp917a0StGepn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		this._dQoZLXIbtJ06olhp917a0StGepn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
		this._dQoZLXIbtJ06olhp917a0StGepn.Controls.Add(this._VSiKmNOa52UnfbCYLgDXvlxYOBI, 3, 0);
		this._dQoZLXIbtJ06olhp917a0StGepn.Controls.Add(this._nDBwNyLc9YP1epEsYCMd2RyrFfF, 0, 0);
		this._dQoZLXIbtJ06olhp917a0StGepn.Controls.Add(this._jjV1F7c6McYPsrLqSOma3SC0Knf, 1, 0);
		this._dQoZLXIbtJ06olhp917a0StGepn.Controls.Add(this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk, 2, 0);
		this._dQoZLXIbtJ06olhp917a0StGepn.Location = new Point(1, 39);
		this._dQoZLXIbtJ06olhp917a0StGepn.Margin = new Padding(1);
		this._dQoZLXIbtJ06olhp917a0StGepn.Name = "tableLaunchers";
		this._dQoZLXIbtJ06olhp917a0StGepn.RowCount = 1;
		this._dQoZLXIbtJ06olhp917a0StGepn.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this._dQoZLXIbtJ06olhp917a0StGepn.RowStyles.Add(new RowStyle(SizeType.Absolute, 61f));
		this._dQoZLXIbtJ06olhp917a0StGepn.Size = new Size(490, 61);
		this._dQoZLXIbtJ06olhp917a0StGepn.TabIndex = 17;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.BackColor = Color.FromArgb(162, 57, 202);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.BackgroundImage = (Image)componentResourceManager.GetObject("btnInstructions.BackgroundImage");
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.BackgroundImageLayout = ImageLayout.Zoom;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Dock = DockStyle.Fill;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.FlatAppearance.BorderColor = Color.Silver;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.FlatStyle = FlatStyle.Flat;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.ForeColor = Color.FromArgb(224, 224, 224);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Location = new Point(367, 1);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Margin = new Padding(1);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Name = "btnInstructions";
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Size = new Size(122, 59);
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.TabIndex = 10;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Text = "Instructions";
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.TextAlign = ContentAlignment.TopCenter;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.UseVisualStyleBackColor = false;
		this._VSiKmNOa52UnfbCYLgDXvlxYOBI.Click += this._q0V7N8CzByN2RYEmjbBr5tI78AD;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.BackColor = Color.FromArgb(162, 57, 202);
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.BackgroundImage = (Image)componentResourceManager.GetObject("btnExaltLauncher.BackgroundImage");
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.BackgroundImageLayout = ImageLayout.Zoom;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Dock = DockStyle.Fill;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.FlatAppearance.BorderColor = Color.Gold;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.FlatStyle = FlatStyle.Flat;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.ForeColor = Color.Gold;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Location = new Point(1, 1);
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Margin = new Padding(1);
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Name = "btnExaltLauncher";
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Size = new Size(120, 59);
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.TabIndex = 7;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Text = "Exalt Launcher";
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.TextAlign = ContentAlignment.TopCenter;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.UseVisualStyleBackColor = false;
		this._nDBwNyLc9YP1epEsYCMd2RyrFfF.Click += this._GXxfIylGQahV343RoMRNGYZyir;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.BackColor = Color.FromArgb(162, 57, 202);
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.BackgroundImage = (Image)componentResourceManager.GetObject("btnSteamLauncher.BackgroundImage");
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.BackgroundImageLayout = ImageLayout.Zoom;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Dock = DockStyle.Fill;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.FlatAppearance.BorderColor = Color.LightSkyBlue;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.FlatStyle = FlatStyle.Flat;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.ForeColor = Color.Aquamarine;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Location = new Point(123, 1);
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Margin = new Padding(1);
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Name = "btnSteamLauncher";
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Size = new Size(120, 59);
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.TabIndex = 8;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Text = "Steam Launcher";
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.TextAlign = ContentAlignment.TopCenter;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.UseVisualStyleBackColor = false;
		this._jjV1F7c6McYPsrLqSOma3SC0Knf.Click += this._YA23q9MoGq5Hzdhkjb75CxGkKNe;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.BackColor = Color.FromArgb(162, 57, 202);
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.BackgroundImage = (Image)componentResourceManager.GetObject("btnMultiLogin.BackgroundImage");
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.BackgroundImageLayout = ImageLayout.Zoom;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Dock = DockStyle.Fill;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.FlatAppearance.BorderColor = Color.Lime;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.FlatStyle = FlatStyle.Flat;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.ForeColor = Color.Lime;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Location = new Point(245, 1);
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Margin = new Padding(1);
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Name = "btnMultiLogin";
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Size = new Size(120, 59);
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.TabIndex = 9;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Text = "Multi Login";
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.TextAlign = ContentAlignment.TopCenter;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.UseVisualStyleBackColor = false;
		this._PmpcYbUDpBOT5FCfnbp0SjZ98Nk.Click += this._4li9iSaJ9SOHrqoMDwihQo4pCeR;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Anchor = AnchorStyles.None;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.AutoSize = true;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.BackColor = Color.Transparent;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.ForeColor = Color.Gold;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Location = new Point(175, 1);
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Name = "lblStart";
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.RightToLeft = RightToLeft.No;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Size = new Size(139, 21);
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.TabIndex = 15;
		this._L4aVGUFAjnQeUesF0J5bmFgE0qp.Text = "Start RotMG Exalt";
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.Controls.Add(this._ZdIZyddJnjgIBiQqbhTiwAhbdfl);
		base.Controls.Add(this._UXlSqwCGaR3BR90GYbrmBdnup7h);
		base.Controls.Add(this._igYr9alHFQC72a0C0DD1ubHSSKo);
		base.Controls.Add(this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Name = "StartControl";
		base.Size = new Size(500, 300);
		base.Load += this._zEIbBveoWYVGrZZs0UrIlmG4Pw2;
		((ISupportInitialize)this._aj6lIoDAGfu8gtgDEt4rnWcG6Ht).EndInit();
		this._igYr9alHFQC72a0C0DD1ubHSSKo.ResumeLayout(false);
		this._igYr9alHFQC72a0C0DD1ubHSSKo.PerformLayout();
		((ISupportInitialize)this._H6H47cWzE0z2tiFTqwckmW2A8qE).EndInit();
		((ISupportInitialize)this._RTCOlADJBRyZ1glqXXO5TwWdQRA).EndInit();
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.ResumeLayout(false);
		this._UXlSqwCGaR3BR90GYbrmBdnup7h.PerformLayout();
		((ISupportInitialize)this._22prBPREEyLZOWuoc1fD7HEZ6nS).EndInit();
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.ResumeLayout(false);
		this._ZdIZyddJnjgIBiQqbhTiwAhbdfl.PerformLayout();
		this._dQoZLXIbtJ06olhp917a0StGepn.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00022578 File Offset: 0x00020778
	[CompilerGenerated]
	private void _bPqS2EAmeON84CjToYkBQc3TqnD(Client c)
	{
		base.Invoke(new MethodInvoker(this._0juzkvdaCksCEU9N3f3TwOeIItO));
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00022598 File Offset: 0x00020798
	[CompilerGenerated]
	private void _0juzkvdaCksCEU9N3f3TwOeIItO()
	{
		Control jnRWS57C6rT8T35L0qqCiCqhEHF = this._jnRWS57C6rT8T35L0qqCiCqhEHF;
		string format = "{0} Exalt Client{1} Connected";
		int num = this._U5ozatRqEdUz0Q5nh2nQUzXGmFc + 1;
		this._U5ozatRqEdUz0Q5nh2nQUzXGmFc = num;
		jnRWS57C6rT8T35L0qqCiCqhEHF.Text = string.Format(format, num, (this._U5ozatRqEdUz0Q5nh2nQUzXGmFc > 1 || this._U5ozatRqEdUz0Q5nh2nQUzXGmFc == 0) ? 's' : ' ');
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x000225EC File Offset: 0x000207EC
	[CompilerGenerated]
	private void _ScCdyVkA9kFABUWUGiQxHPWt0GK(Client c)
	{
		base.Invoke(new MethodInvoker(this._ae5sMIZECltDIhyAl7mKVniLijS));
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0002260C File Offset: 0x0002080C
	[CompilerGenerated]
	private void _ae5sMIZECltDIhyAl7mKVniLijS()
	{
		Control jnRWS57C6rT8T35L0qqCiCqhEHF = this._jnRWS57C6rT8T35L0qqCiCqhEHF;
		string format = "{0} Exalt Client{1} Connected";
		int num = this._U5ozatRqEdUz0Q5nh2nQUzXGmFc - 1;
		this._U5ozatRqEdUz0Q5nh2nQUzXGmFc = num;
		jnRWS57C6rT8T35L0qqCiCqhEHF.Text = string.Format(format, num, (this._U5ozatRqEdUz0Q5nh2nQUzXGmFc > 1 || this._U5ozatRqEdUz0Q5nh2nQUzXGmFc == 0) ? 's' : ' ');
	}

	// Token: 0x040006E5 RID: 1765
	private int _U5ozatRqEdUz0Q5nh2nQUzXGmFc;

	// Token: 0x040006E6 RID: 1766
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x040006E7 RID: 1767
	private PictureBox _aj6lIoDAGfu8gtgDEt4rnWcG6Ht;

	// Token: 0x040006E8 RID: 1768
	private Label _7iUSsM3IpgPp4uiAkbvSMPX1AoA;

	// Token: 0x040006E9 RID: 1769
	private Panel _igYr9alHFQC72a0C0DD1ubHSSKo;

	// Token: 0x040006EA RID: 1770
	private PictureBox _RTCOlADJBRyZ1glqXXO5TwWdQRA;

	// Token: 0x040006EB RID: 1771
	private PictureBox _H6H47cWzE0z2tiFTqwckmW2A8qE;

	// Token: 0x040006EC RID: 1772
	private Label _jnRWS57C6rT8T35L0qqCiCqhEHF;

	// Token: 0x040006ED RID: 1773
	private ComboBox _3FhqPruoaSWMFZvb36zSzEqOtTC;

	// Token: 0x040006EE RID: 1774
	private Panel _UXlSqwCGaR3BR90GYbrmBdnup7h;

	// Token: 0x040006EF RID: 1775
	private Label _d9qACr7O9TsDq7iF4B5e6sziZMy;

	// Token: 0x040006F0 RID: 1776
	private PictureBox _22prBPREEyLZOWuoc1fD7HEZ6nS;

	// Token: 0x040006F1 RID: 1777
	private Label _AMEKx38mLo7rkoAAIRgtZZ4TDjG;

	// Token: 0x040006F2 RID: 1778
	private Panel _ZdIZyddJnjgIBiQqbhTiwAhbdfl;

	// Token: 0x040006F3 RID: 1779
	private Button _nDBwNyLc9YP1epEsYCMd2RyrFfF;

	// Token: 0x040006F4 RID: 1780
	private Button _PmpcYbUDpBOT5FCfnbp0SjZ98Nk;

	// Token: 0x040006F5 RID: 1781
	private Button _jjV1F7c6McYPsrLqSOma3SC0Knf;

	// Token: 0x040006F6 RID: 1782
	private Button _VSiKmNOa52UnfbCYLgDXvlxYOBI;

	// Token: 0x040006F7 RID: 1783
	private Label _L4aVGUFAjnQeUesF0J5bmFgE0qp;

	// Token: 0x040006F8 RID: 1784
	private TableLayoutPanel _dQoZLXIbtJ06olhp917a0StGepn;

	// Token: 0x040006F9 RID: 1785
	private Label _tKBTSAORY4UWZkVWDYEkF4vaVRn;

	// Token: 0x020000D7 RID: 215
	[CompilerGenerated]
	[Serializable]
	private sealed class _ATYVLw6ZZPibC9RovOPRO3ph7sb
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x0002268C File Offset: 0x0002088C
		internal string _iiiRmAyBvtT8Wly8tGvc61rJNJm(string key)
		{
			return key;
		}

		// Token: 0x040006FA RID: 1786
		public static readonly _Mf7nnCoCiU2JtgFBsAknpCVgODr._ATYVLw6ZZPibC9RovOPRO3ph7sb <>9 = new _Mf7nnCoCiU2JtgFBsAknpCVgODr._ATYVLw6ZZPibC9RovOPRO3ph7sb();

		// Token: 0x040006FB RID: 1787
		public static Func<string, string> <>9__3_0;
	}
}
