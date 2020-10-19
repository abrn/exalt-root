using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x02000004 RID: 4
internal partial class _O8RCBX441Egsj4ff5BOJx95ggk8 : Form
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00009AD8 File Offset: 0x00007CD8
	// (set) Token: 0x06000018 RID: 24 RVA: 0x00009AEC File Offset: 0x00007CEC
	public Proxy _Dm8uy44VjdFaIzNrCEi9uYdmSKl { get; private set; }

	// Token: 0x06000019 RID: 25 RVA: 0x00009B00 File Offset: 0x00007D00
	public _O8RCBX441Egsj4ff5BOJx95ggk8()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		this._Dm8uy44VjdFaIzNrCEi9uYdmSKl = new Proxy();
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00009B24 File Offset: 0x00007D24
	private void _U1M7Zz7fLRf66SuVw7t2mnDAUeJ(object sender, EventArgs e)
	{
		_O8RCBX441Egsj4ff5BOJx95ggk8._PqFoXZH9kdKpwqqZkP1HZFKCXke pqFoXZH9kdKpwqqZkP1HZFKCXke;
		pqFoXZH9kdKpwqqZkP1HZFKCXke._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		pqFoXZH9kdKpwqqZkP1HZFKCXke._hJqaCfUafwosIZWql6GPDTaWQvj = AsyncVoidMethodBuilder.Create();
		pqFoXZH9kdKpwqqZkP1HZFKCXke._VIVnDceCb5ujwt6SoxgBQeoPhEj = -1;
		pqFoXZH9kdKpwqqZkP1HZFKCXke._hJqaCfUafwosIZWql6GPDTaWQvj.Start<_O8RCBX441Egsj4ff5BOJx95ggk8._PqFoXZH9kdKpwqqZkP1HZFKCXke>(ref pqFoXZH9kdKpwqqZkP1HZFKCXke);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00009B5C File Offset: 0x00007D5C
	private void _xTp0Tpcq6wQLqwW4AwLD3OqZIZk(object sender, EventArgs e)
	{
		this._iGnwanefX2m6q9Bb2OR52PQSHnA.BringToFront();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00009B74 File Offset: 0x00007D74
	private void _yqlrX1kDEGgcHsFLonzJJRwc6V4(object sender, EventArgs e)
	{
		this._ugjYmyxpQfMfP3teoIdSwM91U9b.BringToFront();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00009B8C File Offset: 0x00007D8C
	public void _4li9iSaJ9SOHrqoMDwihQo4pCeR(object sender, EventArgs e)
	{
		this._wdYcNxK01tJFeSuNF6e7uda2JauA.BringToFront();
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00009BA4 File Offset: 0x00007DA4
	public void _IV9dt2EXRsUCz3y9qJW09OSBzrj(object sender, EventArgs e)
	{
		this._6AZYbS7ubQ8eMEERmE9eiHrGKWv.BringToFront();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00009BBC File Offset: 0x00007DBC
	private void _Uh2rnbPqeC7Q4Fl357NIOsAoCKh(object sender, EventArgs e)
	{
		Process.Start("https://realmstock.com/pages/rotmg-unity-exalt-hacks-cheats");
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00009BD4 File Offset: 0x00007DD4
	private void _Uwd71f0qoYIwwEccgu2Mdm1CZdJ(object sender, FormClosingEventArgs e)
	{
		if (!this._6ipaevcl12RPuerbw5pco1QqTo4.Enabled)
		{
			return;
		}
		DialogResult dialogResult = MessageBox.Show(base.ParentForm, "Are you sure you want to EXIT?", "RealmStock Multi-Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		e.Cancel = (dialogResult == DialogResult.No);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00009C14 File Offset: 0x00007E14
	private void _Cs3aAeHw6XzekfRcd3PyIcCHO17A(object sender, FormClosedEventArgs e)
	{
		Settings.Default.Save();
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00009C2C File Offset: 0x00007E2C
	public void _ABUfxS8nLZyftEbHQhwJba2vTZL(int id, Keys key)
	{
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B.RegisterHotKey(base.Handle, id, 0, key.GetHashCode());
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00009C54 File Offset: 0x00007E54
	public void _R1d8LMwixV0kVs1Hd0sSH0SP0Nh(int id)
	{
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B.UnregisterHotKey(base.Handle, id);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00009C70 File Offset: 0x00007E70
	protected virtual void _mX2HU6M2Mva8QUe3avcemVQnBqi(ref Message m)
	{
		base.WndProc(ref m);
		if (m.Msg == 786)
		{
			int num = (int)m.LParam >> 16 & 65535;
			int id = m.WParam.ToInt32();
			int num2;
			_IHUllfO6Rr4ri1gTkx9LNb4zz7B.GetWindowThreadProcessId(_IHUllfO6Rr4ri1gTkx9LNb4zz7B.GetForegroundWindow(), out num2);
			this._Dm8uy44VjdFaIzNrCEi9uYdmSKl._TDrFXcTAjgN5GbHg6KToDxTmgfK(id);
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00009CD0 File Offset: 0x00007ED0
	private void _Ss3PWkcZAIGdf7dGqtBf4fYAKqDA(object sender, EventArgs e)
	{
		foreach (Process process in Process.GetProcessesByName("RotMG Exalt Launcher"))
		{
			if (!_AeMKsR1PsUj3nMvFNJ8PA27BYIO._6aOF1kRdHAJ12JEKkgKBTV5DOgE.Contains(process.Id))
			{
				_AeMKsR1PsUj3nMvFNJ8PA27BYIO._6aOF1kRdHAJ12JEKkgKBTV5DOgE.Add(process.Id);
				MessageBox.Show("RotMG Exalt must be launched via the Multi Tool in order for hacks to apply!", "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00009D30 File Offset: 0x00007F30
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00009D5C File Offset: 0x00007F5C
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		this._UBpFiXjXmW4HUIyvG86l99grd9E = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_O8RCBX441Egsj4ff5BOJx95ggk8));
		this._g50TPPuZYaZr238BfESooGaNzhQ = new ImageList(this._UBpFiXjXmW4HUIyvG86l99grd9E);
		this._pSpvHElXSDYbP8BVDTyCIr19gum = new Panel();
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM = new Panel();
		this._6ipaevcl12RPuerbw5pco1QqTo4 = new MenuStrip();
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah = new ToolStripMenuItem();
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE = new ToolStripMenuItem();
		this._NSTrKjxk862rd9eltmjwsiAmD2d = new ToolStripMenuItem();
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz = new ToolStripMenuItem();
		this._Q60kOY6EaC9vhIWpPBjwgHDLlSA = new Timer(this._UBpFiXjXmW4HUIyvG86l99grd9E);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.SuspendLayout();
		this._6ipaevcl12RPuerbw5pco1QqTo4.SuspendLayout();
		base.SuspendLayout();
		this._g50TPPuZYaZr238BfESooGaNzhQ.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imagesTabs.ImageStream");
		this._g50TPPuZYaZr238BfESooGaNzhQ.TransparentColor = Color.Transparent;
		this._g50TPPuZYaZr238BfESooGaNzhQ.Images.SetKeyName(0, "Crown.png");
		this._pSpvHElXSDYbP8BVDTyCIr19gum.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._pSpvHElXSDYbP8BVDTyCIr19gum.BackColor = Color.FromArgb(14, 11, 22);
		this._pSpvHElXSDYbP8BVDTyCIr19gum.BackgroundImage = (Image)componentResourceManager.GetObject("pnlContent.BackgroundImage");
		this._pSpvHElXSDYbP8BVDTyCIr19gum.BackgroundImageLayout = ImageLayout.Zoom;
		this._pSpvHElXSDYbP8BVDTyCIr19gum.BorderStyle = BorderStyle.FixedSingle;
		this._pSpvHElXSDYbP8BVDTyCIr19gum.Location = new Point(12, 57);
		this._pSpvHElXSDYbP8BVDTyCIr19gum.Name = "pnlContent";
		this._pSpvHElXSDYbP8BVDTyCIr19gum.Size = new Size(560, 342);
		this._pSpvHElXSDYbP8BVDTyCIr19gum.TabIndex = 1;
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.BorderStyle = BorderStyle.FixedSingle;
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.Controls.Add(this._6ipaevcl12RPuerbw5pco1QqTo4);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.Location = new Point(12, 12);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.Name = "pnlStrip";
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.Size = new Size(560, 39);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.TabIndex = 2;
		this._6ipaevcl12RPuerbw5pco1QqTo4.BackgroundImage = (Image)componentResourceManager.GetObject("stripMain.BackgroundImage");
		this._6ipaevcl12RPuerbw5pco1QqTo4.Dock = DockStyle.Fill;
		this._6ipaevcl12RPuerbw5pco1QqTo4.Enabled = false;
		this._6ipaevcl12RPuerbw5pco1QqTo4.ImageScalingSize = new Size(24, 24);
		this._6ipaevcl12RPuerbw5pco1QqTo4.Items.AddRange(new ToolStripItem[]
		{
			this._L9rG2pPM8Yv2kSWiYp8hILaZnah,
			this._uSVmWDLLZlLhx3TAXSN38gMJMSE,
			this._NSTrKjxk862rd9eltmjwsiAmD2d,
			this._fILJeNKnPOdeCHcnqJ7nSQhNSz
		});
		this._6ipaevcl12RPuerbw5pco1QqTo4.Location = new Point(0, 0);
		this._6ipaevcl12RPuerbw5pco1QqTo4.Name = "stripMain";
		this._6ipaevcl12RPuerbw5pco1QqTo4.Size = new Size(558, 37);
		this._6ipaevcl12RPuerbw5pco1QqTo4.TabIndex = 2;
		this._6ipaevcl12RPuerbw5pco1QqTo4.Text = "menuStrip1";
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.ForeColor = Color.Gold;
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Image = (Image)componentResourceManager.GetObject("btnAbout.Image");
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Name = "btnAbout";
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Size = new Size(77, 33);
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Text = "Start";
		this._L9rG2pPM8Yv2kSWiYp8hILaZnah.Click += this._xTp0Tpcq6wQLqwW4AwLD3OqZIZk;
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.ForeColor = Color.Gold;
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Image = (Image)componentResourceManager.GetObject("instructionsToolStripMenuItem.Image");
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Name = "instructionsToolStripMenuItem";
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Size = new Size(121, 33);
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Text = "Instructions";
		this._uSVmWDLLZlLhx3TAXSN38gMJMSE.Click += this._IV9dt2EXRsUCz3y9qJW09OSBzrj;
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
		this._NSTrKjxk862rd9eltmjwsiAmD2d.ForeColor = Color.Gold;
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Image = (Image)componentResourceManager.GetObject("btnHacks.Image");
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Name = "btnHacks";
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Size = new Size(85, 33);
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Text = "Hacks";
		this._NSTrKjxk862rd9eltmjwsiAmD2d.Click += this._yqlrX1kDEGgcHsFLonzJJRwc6V4;
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Alignment = ToolStripItemAlignment.Right;
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.ForeColor = Color.Gold;
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Image = (Image)componentResourceManager.GetObject("lblVersion.Image");
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Name = "lblVersion";
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Size = new Size(130, 33);
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Text = "For Exalt X1.2.0.0.2";
		this._fILJeNKnPOdeCHcnqJ7nSQhNSz.Click += this._Uh2rnbPqeC7Q4Fl357NIOsAoCKh;
		this._Q60kOY6EaC9vhIWpPBjwgHDLlSA.Enabled = true;
		this._Q60kOY6EaC9vhIWpPBjwgHDLlSA.Interval = 3000;
		this._Q60kOY6EaC9vhIWpPBjwgHDLlSA.Tick += this._Ss3PWkcZAIGdf7dGqtBf4fYAKqDA;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = Color.Black;
		this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(584, 411);
		base.Controls.Add(this._6JEprXIt34H2eH4Cc8mBMKv9ACM);
		base.Controls.Add(this._pSpvHElXSDYbP8BVDTyCIr19gum);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		this.MinimumSize = new Size(600, 450);
		base.Name = "FrmMultiTool";
		this.Text = "RealmStock Exalt Multi-Tool v0.17a";
		base.FormClosing += this._Uwd71f0qoYIwwEccgu2Mdm1CZdJ;
		base.FormClosed += this._Cs3aAeHw6XzekfRcd3PyIcCHO17A;
		base.Shown += this._U1M7Zz7fLRf66SuVw7t2mnDAUeJ;
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.ResumeLayout(false);
		this._6JEprXIt34H2eH4Cc8mBMKv9ACM.PerformLayout();
		this._6ipaevcl12RPuerbw5pco1QqTo4.ResumeLayout(false);
		this._6ipaevcl12RPuerbw5pco1QqTo4.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000A3F4 File Offset: 0x000085F4
	[CompilerGenerated]
	private void _1H2yAqkYI4OYBYAOnsLbckjJJnT()
	{
		try
		{
			Console.WriteLine("System: Initializing proxy...");
			_JzyrOApzC09RC3fmb10FDURmyCl._gKKd0PApBLw4Hl4Oj4Z6UarwYVc();
			ServerParser.Parse();
			this._Dm8uy44VjdFaIzNrCEi9uYdmSKl._eF71c6Wm9DMjCayXZwHo3e5aDoP();
		}
		catch (Exception ex)
		{
			IWin32Window parentForm = base.ParentForm;
			string str = "Failed to initialize Proxy!\n\nPlease make sure:\n- Your AntiVirus is not blocking this program\n- This no other Exalt tools are running\n- Loading the client normally works fine\n\nMore details:\n";
			Exception ex2 = ex;
			MessageBox.Show(parentForm, str + ((ex2 != null) ? ex2.ToString() : null));
			base.Close();
		}
	}

	// Token: 0x04000096 RID: 150
	[CompilerGenerated]
	private Proxy _SLdblYquzMpZV24iA2joen6oBWc;

	// Token: 0x04000097 RID: 151
	private _Mf7nnCoCiU2JtgFBsAknpCVgODr _iGnwanefX2m6q9Bb2OR52PQSHnA;

	// Token: 0x04000098 RID: 152
	private _Q1iu4PEWGR2odhAgRlKQSWbHhWM _ugjYmyxpQfMfP3teoIdSwM91U9b;

	// Token: 0x04000099 RID: 153
	private _kzbOEABEghRPGNYW29gk2hy2kpe _wdYcNxK01tJFeSuNF6e7uda2JauA;

	// Token: 0x0400009A RID: 154
	private _nW2r0aRNoaN2otN0RLRiGoFBjOK _6AZYbS7ubQ8eMEERmE9eiHrGKWv;

	// Token: 0x0400009B RID: 155
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x0400009C RID: 156
	private ImageList _g50TPPuZYaZr238BfESooGaNzhQ;

	// Token: 0x0400009D RID: 157
	private Panel _pSpvHElXSDYbP8BVDTyCIr19gum;

	// Token: 0x0400009E RID: 158
	private Panel _6JEprXIt34H2eH4Cc8mBMKv9ACM;

	// Token: 0x0400009F RID: 159
	private MenuStrip _6ipaevcl12RPuerbw5pco1QqTo4;

	// Token: 0x040000A0 RID: 160
	private ToolStripMenuItem _L9rG2pPM8Yv2kSWiYp8hILaZnah;

	// Token: 0x040000A1 RID: 161
	private ToolStripMenuItem _NSTrKjxk862rd9eltmjwsiAmD2d;

	// Token: 0x040000A2 RID: 162
	private ToolStripMenuItem _fILJeNKnPOdeCHcnqJ7nSQhNSz;

	// Token: 0x040000A3 RID: 163
	private ToolStripMenuItem _uSVmWDLLZlLhx3TAXSN38gMJMSE;

	// Token: 0x040000A4 RID: 164
	private Timer _Q60kOY6EaC9vhIWpPBjwgHDLlSA;
}
