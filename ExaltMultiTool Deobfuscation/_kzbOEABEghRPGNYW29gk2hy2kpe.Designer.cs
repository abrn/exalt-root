using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x020000DA RID: 218
internal class _kzbOEABEghRPGNYW29gk2hy2kpe : UserControl
{
	// Token: 0x0600058E RID: 1422 RVA: 0x00023518 File Offset: 0x00021718
	public _kzbOEABEghRPGNYW29gk2hy2kpe()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		ListBox.ObjectCollection items = this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Items;
		object[] items2 = Settings.Default.SavedAccounts.Cast<string>().ToArray<string>();
		items.AddRange(items2);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00023558 File Offset: 0x00021758
	private void _GIVuESM8AWwHuE4bn0pVMjPZp2S(object sender, EventArgs e)
	{
		if (File.Exists(Settings.Default.ExaltGamePath))
		{
			this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Enabled = true;
			this._XexgEGwxcm8SUqK79xhjiz5mCBH.Text = "Exalt found.";
			return;
		}
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Enabled = false;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Text = "Exalt install not detected!";
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x000235B0 File Offset: 0x000217B0
	public void _W9Bctc3kvC6dDum7AXuIgZErmx7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MessageBox.Show("Please locate RotMG Exalt.exe within your Documents folder so it can be used with MultiLogin.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Locate RotMG Exalt game file...";
		openFileDialog.Filter = "RotMG Exalt (*.exe)|*.exe";
		if (string.IsNullOrWhiteSpace(Settings.Default.ExaltGamePath))
		{
			Settings.Default.ExaltGamePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production";
		}
		openFileDialog.InitialDirectory = Settings.Default.ExaltGamePath;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (openFileDialog.FileName.EndsWith("RotMG Exalt.exe"))
			{
				Settings.Default.ExaltGamePath = openFileDialog.FileName;
				this._RkB5xzaLoVEpe3SPpV8bbPcPd1Q();
			}
		}
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0002365C File Offset: 0x0002185C
	private void _WJMQ9kmfkA4ySYqHzszRy7VbRfI(object sender, EventArgs e)
	{
		bool enabled = this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.SelectedIndex != -1;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Enabled = enabled;
		this._vutua7GJ2AE48la4ZfSZduME88J.Enabled = enabled;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Enabled = enabled;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x000236A0 File Offset: 0x000218A0
	private void _U6dbRaz2TsMR5ROxP2pK00GyxpO(object sender, EventArgs e)
	{
		_kzbOEABEghRPGNYW29gk2hy2kpe._L6IfNQQhWM1ybiFuifhPrm154ZB l6IfNQQhWM1ybiFuifhPrm154ZB;
		l6IfNQQhWM1ybiFuifhPrm154ZB._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		l6IfNQQhWM1ybiFuifhPrm154ZB._hJqaCfUafwosIZWql6GPDTaWQvj = AsyncVoidMethodBuilder.Create();
		l6IfNQQhWM1ybiFuifhPrm154ZB._VIVnDceCb5ujwt6SoxgBQeoPhEj = -1;
		l6IfNQQhWM1ybiFuifhPrm154ZB._hJqaCfUafwosIZWql6GPDTaWQvj.Start<_kzbOEABEghRPGNYW29gk2hy2kpe._L6IfNQQhWM1ybiFuifhPrm154ZB>(ref l6IfNQQhWM1ybiFuifhPrm154ZB);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x000236D8 File Offset: 0x000218D8
	private void _yug2LCORKdgH67Prf9BS6GAdXRD(object sender, EventArgs e)
	{
		object selectedItem = this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.SelectedItem;
		if (selectedItem != null)
		{
			this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Items.Remove(selectedItem);
			this._RkB5xzaLoVEpe3SPpV8bbPcPd1Q();
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0002370C File Offset: 0x0002190C
	private void _6VkuVAusVrAtOYGG20CYTrY0IPH(object sender, EventArgs e)
	{
		_kzbOEABEghRPGNYW29gk2hy2kpe._RjdDDnSi7prRia4qsM5U2CWX6Zx rjdDDnSi7prRia4qsM5U2CWX6Zx;
		rjdDDnSi7prRia4qsM5U2CWX6Zx._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		rjdDDnSi7prRia4qsM5U2CWX6Zx._hJqaCfUafwosIZWql6GPDTaWQvj = AsyncVoidMethodBuilder.Create();
		rjdDDnSi7prRia4qsM5U2CWX6Zx._VIVnDceCb5ujwt6SoxgBQeoPhEj = -1;
		rjdDDnSi7prRia4qsM5U2CWX6Zx._hJqaCfUafwosIZWql6GPDTaWQvj.Start<_kzbOEABEghRPGNYW29gk2hy2kpe._RjdDDnSi7prRia4qsM5U2CWX6Zx>(ref rjdDDnSi7prRia4qsM5U2CWX6Zx);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00023744 File Offset: 0x00021944
	private void _Kqj3Co8KmUmFXf6ger7ACdRiv8AA(object sender, EventArgs e)
	{
		object selectedItem = this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.SelectedItem;
		if (selectedItem != null)
		{
			string[] array = (selectedItem as string).Split(new char[]
			{
				':'
			});
			_AeMKsR1PsUj3nMvFNJ8PA27BYIO._u7ga6IKB4PyD5qGeSHNJ0VnV5Ro(array[0], array[1]);
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00023784 File Offset: 0x00021984
	private Task<string> _degYHIYbaFmEoO6lU57xNHV4wKj(string email = "", string password = "")
	{
		_kzbOEABEghRPGNYW29gk2hy2kpe._17p6mDZA4JGTXNjK5DzXxKNndVp 17p6mDZA4JGTXNjK5DzXxKNndVp;
		17p6mDZA4JGTXNjK5DzXxKNndVp._zxT2T6MTzpCZq4RVLm05iSL41id = email;
		17p6mDZA4JGTXNjK5DzXxKNndVp._PaGOjM6x6moq3GkAdXf0AXroAYm = password;
		17p6mDZA4JGTXNjK5DzXxKNndVp._hJqaCfUafwosIZWql6GPDTaWQvj = AsyncTaskMethodBuilder<string>.Create();
		17p6mDZA4JGTXNjK5DzXxKNndVp._VIVnDceCb5ujwt6SoxgBQeoPhEj = -1;
		17p6mDZA4JGTXNjK5DzXxKNndVp._hJqaCfUafwosIZWql6GPDTaWQvj.Start<_kzbOEABEghRPGNYW29gk2hy2kpe._17p6mDZA4JGTXNjK5DzXxKNndVp>(ref 17p6mDZA4JGTXNjK5DzXxKNndVp);
		return 17p6mDZA4JGTXNjK5DzXxKNndVp._hJqaCfUafwosIZWql6GPDTaWQvj.Task;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x000237D0 File Offset: 0x000219D0
	private void _RkB5xzaLoVEpe3SPpV8bbPcPd1Q()
	{
		Settings.Default.SavedAccounts.Clear();
		Settings.Default.SavedAccounts.AddRange(this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Items.Cast<string>().ToArray<string>());
		Settings.Default.Save();
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0002381C File Offset: 0x00021A1C
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00023848 File Offset: 0x00021A48
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		this._UBpFiXjXmW4HUIyvG86l99grd9E = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_kzbOEABEghRPGNYW29gk2hy2kpe));
		this._rTc9rsZ4PWTwKNdXmOjciwL1edr = new Timer(this._UBpFiXjXmW4HUIyvG86l99grd9E);
		this._vutua7GJ2AE48la4ZfSZduME88J = new Button();
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF = new Button();
		this._modhW6kafYE4OXqdoLwX4zgrQQu = new Button();
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd = new Button();
		this._QKposhihTxWg6iDAVQ73Are4C8O = new LinkLabel();
		this._XexgEGwxcm8SUqK79xhjiz5mCBH = new Label();
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg = new ListBox();
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA = new Panel();
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP = new Panel();
		this._SU2xoj3PT1FPIIcuSKux00s5HYb = new Label();
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq = new Panel();
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.SuspendLayout();
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.SuspendLayout();
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.SuspendLayout();
		base.SuspendLayout();
		this._rTc9rsZ4PWTwKNdXmOjciwL1edr.Enabled = true;
		this._rTc9rsZ4PWTwKNdXmOjciwL1edr.Interval = 1000;
		this._rTc9rsZ4PWTwKNdXmOjciwL1edr.Tick += this._GIVuESM8AWwHuE4bn0pVMjPZp2S;
		this._vutua7GJ2AE48la4ZfSZduME88J.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this._vutua7GJ2AE48la4ZfSZduME88J.BackColor = Color.FromArgb(162, 57, 202);
		this._vutua7GJ2AE48la4ZfSZduME88J.Enabled = false;
		this._vutua7GJ2AE48la4ZfSZduME88J.FlatAppearance.BorderSize = 0;
		this._vutua7GJ2AE48la4ZfSZduME88J.FlatStyle = FlatStyle.Flat;
		this._vutua7GJ2AE48la4ZfSZduME88J.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._vutua7GJ2AE48la4ZfSZduME88J.ForeColor = Color.Gold;
		this._vutua7GJ2AE48la4ZfSZduME88J.Location = new Point(441, 264);
		this._vutua7GJ2AE48la4ZfSZduME88J.Name = "btnDelete";
		this._vutua7GJ2AE48la4ZfSZduME88J.Size = new Size(48, 25);
		this._vutua7GJ2AE48la4ZfSZduME88J.TabIndex = 9;
		this._vutua7GJ2AE48la4ZfSZduME88J.Text = "Delete";
		this._vutua7GJ2AE48la4ZfSZduME88J.UseVisualStyleBackColor = false;
		this._vutua7GJ2AE48la4ZfSZduME88J.Click += this._yug2LCORKdgH67Prf9BS6GAdXRD;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.BackColor = Color.FromArgb(162, 57, 202);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.FlatAppearance.BorderSize = 0;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.FlatStyle = FlatStyle.Flat;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.ForeColor = Color.Gold;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Location = new Point(385, 264);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Name = "btnAdd";
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Size = new Size(50, 25);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.TabIndex = 8;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Text = "Add";
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.UseVisualStyleBackColor = false;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Click += this._U6dbRaz2TsMR5ROxP2pK00GyxpO;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this._modhW6kafYE4OXqdoLwX4zgrQQu.BackColor = Color.FromArgb(162, 57, 202);
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Enabled = false;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.FlatAppearance.BorderSize = 0;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.FlatStyle = FlatStyle.Flat;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._modhW6kafYE4OXqdoLwX4zgrQQu.ForeColor = Color.Gold;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Location = new Point(117, 264);
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Name = "btnEdit";
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Size = new Size(48, 25);
		this._modhW6kafYE4OXqdoLwX4zgrQQu.TabIndex = 7;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Text = "Edit";
		this._modhW6kafYE4OXqdoLwX4zgrQQu.UseVisualStyleBackColor = false;
		this._modhW6kafYE4OXqdoLwX4zgrQQu.Click += this._Kqj3Co8KmUmFXf6ger7ACdRiv8AA;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.BackColor = Color.FromArgb(162, 57, 202);
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Enabled = false;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.FlatAppearance.BorderSize = 0;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.FlatStyle = FlatStyle.Flat;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.ForeColor = Color.Gold;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Location = new Point(11, 264);
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Name = "btnLogin";
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Size = new Size(100, 25);
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.TabIndex = 6;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Text = "Login";
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.UseVisualStyleBackColor = false;
		this._Y19jPjeAd0aHaqI2cloL2LwT7sd.Click += this._Kqj3Co8KmUmFXf6ger7ACdRiv8AA;
		this._QKposhihTxWg6iDAVQ73Are4C8O.AutoSize = true;
		this._QKposhihTxWg6iDAVQ73Are4C8O.BackColor = Color.Transparent;
		this._QKposhihTxWg6iDAVQ73Are4C8O.LinkColor = Color.Gold;
		this._QKposhihTxWg6iDAVQ73Are4C8O.Location = new Point(3, 3);
		this._QKposhihTxWg6iDAVQ73Are4C8O.Name = "btnSettings";
		this._QKposhihTxWg6iDAVQ73Are4C8O.Size = new Size(177, 13);
		this._QKposhihTxWg6iDAVQ73Are4C8O.TabIndex = 11;
		this._QKposhihTxWg6iDAVQ73Are4C8O.TabStop = true;
		this._QKposhihTxWg6iDAVQ73Are4C8O.Text = "→ Click to locate RotMG Exalt.exe";
		this._QKposhihTxWg6iDAVQ73Are4C8O.LinkClicked += this._W9Bctc3kvC6dDum7AXuIgZErmx7;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.AutoSize = true;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.BackColor = Color.Transparent;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.ForeColor = Color.Gold;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Location = new Point(6, 7);
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Name = "lblStatus";
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Size = new Size(236, 25);
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.TabIndex = 10;
		this._XexgEGwxcm8SUqK79xhjiz5mCBH.Text = "Exalt install not detected!";
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.BackColor = Color.FromArgb(44, 31, 52);
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.BorderStyle = BorderStyle.FixedSingle;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Dock = DockStyle.Fill;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.ForeColor = Color.Gainsboro;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.FormattingEnabled = true;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.IntegralHeight = false;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Location = new Point(0, 0);
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Name = "lstAccounts";
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.Size = new Size(478, 172);
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.TabIndex = 12;
		this._cg0FfO3yAv7bEEBoZg3OK4RqNxg.SelectedIndexChanged += this._WJMQ9kmfkA4ySYqHzszRy7VbRfI;
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.Controls.Add(this._cg0FfO3yAv7bEEBoZg3OK4RqNxg);
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.Location = new Point(11, 87);
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.Name = "pnlAccounts";
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.Size = new Size(478, 172);
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.TabIndex = 13;
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.BackColor = Color.FromArgb(44, 31, 52);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.BorderStyle = BorderStyle.FixedSingle;
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Controls.Add(this._SU2xoj3PT1FPIIcuSKux00s5HYb);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Font = new Font("Segoe UI", 8.25f);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Location = new Point(11, 61);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Name = "pnlInfo";
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.Size = new Size(478, 23);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.TabIndex = 15;
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.AutoSize = true;
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.BackColor = Color.Transparent;
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.Font = new Font("Segoe UI", 8.25f);
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.ForeColor = Color.Gold;
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.Location = new Point(3, 3);
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.Name = "lblHelp";
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.Size = new Size(443, 13);
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.TabIndex = 13;
		this._SU2xoj3PT1FPIIcuSKux00s5HYb.Text = "Multi Login tool is optional. You can launch Exalt normally via the Launcher or Steam.";
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.BackColor = Color.FromArgb(44, 31, 52);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.BorderStyle = BorderStyle.FixedSingle;
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Controls.Add(this._QKposhihTxWg6iDAVQ73Are4C8O);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Font = new Font("Segoe UI", 8.25f);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Location = new Point(11, 35);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Name = "pnlButton";
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.Size = new Size(478, 23);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.TabIndex = 16;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = Color.FromArgb(14, 11, 22);
		this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.Controls.Add(this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq);
		base.Controls.Add(this._fv3ehZTCLAYbjZmXVjCqK6sc6BP);
		base.Controls.Add(this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA);
		base.Controls.Add(this._XexgEGwxcm8SUqK79xhjiz5mCBH);
		base.Controls.Add(this._vutua7GJ2AE48la4ZfSZduME88J);
		base.Controls.Add(this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF);
		base.Controls.Add(this._modhW6kafYE4OXqdoLwX4zgrQQu);
		base.Controls.Add(this._Y19jPjeAd0aHaqI2cloL2LwT7sd);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Name = "MultiLoginControl";
		base.Size = new Size(500, 300);
		this._rc9N1KJeKF5TLXEAGAeLJsuCdfeA.ResumeLayout(false);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.ResumeLayout(false);
		this._fv3ehZTCLAYbjZmXVjCqK6sc6BP.PerformLayout();
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.ResumeLayout(false);
		this._lwZ4JIPmIHqG1lMNMAaYRMNCOFq.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000712 RID: 1810
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x04000713 RID: 1811
	private Timer _rTc9rsZ4PWTwKNdXmOjciwL1edr;

	// Token: 0x04000714 RID: 1812
	private Button _vutua7GJ2AE48la4ZfSZduME88J;

	// Token: 0x04000715 RID: 1813
	private Button _f3FqoQ9uobA2iAJQ1zcfBT2eQjF;

	// Token: 0x04000716 RID: 1814
	private Button _modhW6kafYE4OXqdoLwX4zgrQQu;

	// Token: 0x04000717 RID: 1815
	private Button _Y19jPjeAd0aHaqI2cloL2LwT7sd;

	// Token: 0x04000718 RID: 1816
	private LinkLabel _QKposhihTxWg6iDAVQ73Are4C8O;

	// Token: 0x04000719 RID: 1817
	private Label _XexgEGwxcm8SUqK79xhjiz5mCBH;

	// Token: 0x0400071A RID: 1818
	private ListBox _cg0FfO3yAv7bEEBoZg3OK4RqNxg;

	// Token: 0x0400071B RID: 1819
	private Panel _rc9N1KJeKF5TLXEAGAeLJsuCdfeA;

	// Token: 0x0400071C RID: 1820
	private Panel _fv3ehZTCLAYbjZmXVjCqK6sc6BP;

	// Token: 0x0400071D RID: 1821
	private Label _SU2xoj3PT1FPIIcuSKux00s5HYb;

	// Token: 0x0400071E RID: 1822
	private Panel _lwZ4JIPmIHqG1lMNMAaYRMNCOFq;
}
