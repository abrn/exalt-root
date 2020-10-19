using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x020000D3 RID: 211
internal partial class _3epUp89nX32qcURFompyGb29FFH : Form
{
	// Token: 0x06000561 RID: 1377 RVA: 0x00020260 File Offset: 0x0001E460
	public _3epUp89nX32qcURFompyGb29FFH()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		ListBox.ObjectCollection items = this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items;
		object[] items2 = Settings.Default.FameIngoredEnemies.Select(new Func<int, ObjectStructure>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._EVTxd4FutMXcbddiAynenLmYFct)).Where(new Func<ObjectStructure, bool>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._iaMumB66yrjbxwC5cOmDetlbF79)).Select(new Func<ObjectStructure, string>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._0den32egAr0cKX0iVwV8NiASMtp)).ToArray<string>();
		items.AddRange(items2);
		this._8Y1BnHR7y3GUz2633Ga83YHkjuh("");
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.SelectedIndex = 0;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.SelectedIndex = -1;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0002032C File Offset: 0x0001E52C
	private void _yEstmdVZbDP3Emhdcky58AfDzlN(object sender, EventArgs e)
	{
		this._TmBRbzJjQjSt17hgepv668iGEK.Clear();
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00020344 File Offset: 0x0001E544
	private void _l6DAqjA32SdbOsgCHz2PFuBhP9F(object sender, EventArgs e)
	{
		this._8Y1BnHR7y3GUz2633Ga83YHkjuh(this._TmBRbzJjQjSt17hgepv668iGEK.Text);
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00020364 File Offset: 0x0001E564
	private void _8Y1BnHR7y3GUz2633Ga83YHkjuh(string filter = "")
	{
		_3epUp89nX32qcURFompyGb29FFH._XZORrafniN0joJMdlgEofnqnt2k xzorrafniN0joJMdlgEofnqnt2k = new _3epUp89nX32qcURFompyGb29FFH._XZORrafniN0joJMdlgEofnqnt2k();
		xzorrafniN0joJMdlgEofnqnt2k._Wcsyk4fpkP7CcKtnbgGHtDKh3LbA = filter;
		xzorrafniN0joJMdlgEofnqnt2k._Wcsyk4fpkP7CcKtnbgGHtDKh3LbA = xzorrafniN0joJMdlgEofnqnt2k._Wcsyk4fpkP7CcKtnbgGHtDKh3LbA.ToLower();
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Items.Clear();
		ListBox.ObjectCollection items = this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Items;
		object[] items2 = _JzyrOApzC09RC3fmb10FDURmyCl.Objects.Map.Values.Where(new Func<ObjectStructure, bool>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._OXi9CcRvYwj6n7zNJuSufOBUSvH)).Select(new Func<ObjectStructure, string>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._tZeac4BCRa46WM4A0qQFX014MrY)).Where(new Func<string, bool>(xzorrafniN0joJMdlgEofnqnt2k._bKvB6It4vCTQjQ5I4sGikvOF7QP)).ToArray<string>();
		items.AddRange(items2);
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00020420 File Offset: 0x0001E620
	private void _yzo8RV8cui7MexB7s81x22zXTGb(object sender, EventArgs e)
	{
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Enabled = (this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.SelectedIndex > -1);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00020448 File Offset: 0x0001E648
	private void _XEkCUYM7358fNUqEDFNE3ovZxw(object sender, EventArgs e)
	{
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Enabled = (this._JJkvI0iec5HhxVHQ7okG89EgkOv.SelectedIndex > -1);
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00020470 File Offset: 0x0001E670
	private void _U6dbRaz2TsMR5ROxP2pK00GyxpO(object sender, EventArgs e)
	{
		if (!this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items.Contains(this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.SelectedItem))
		{
			this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items.Add(this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.SelectedItem);
			this._PiUAcNTiYFxtRzTu8mUsA1qRcMh();
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x000204BC File Offset: 0x0001E6BC
	private void _wQO6e6NIqyM0V2bNbmKEXJd7AtO(object sender, EventArgs e)
	{
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items.Remove(this._JJkvI0iec5HhxVHQ7okG89EgkOv.SelectedItem);
		this._PiUAcNTiYFxtRzTu8mUsA1qRcMh();
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x000204EC File Offset: 0x0001E6EC
	private void _PiUAcNTiYFxtRzTu8mUsA1qRcMh()
	{
		Settings.Default.FameIngoredEnemies = this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items.Cast<string>().Select(new Func<string, int>(_3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD.<>9._jIkfL3wFtCzeAZ2xsxsBnWKD04b)).ToArray<int>();
		Settings.Default.Save();
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00020548 File Offset: 0x0001E748
	private void _M5vBUQXTjoxSKUpFKWJvPZwd50BA(object sender, EventArgs e)
	{
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Items.Clear();
		this._PiUAcNTiYFxtRzTu8mUsA1qRcMh();
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0002056C File Offset: 0x0001E76C
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00020598 File Offset: 0x0001E798
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_3epUp89nX32qcURFompyGb29FFH));
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR = new Label();
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu = new Panel();
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF = new Button();
		this._CekQKkcRToYx4hSootyPyeNB53d = new Label();
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb = new Panel();
		this._JJkvI0iec5HhxVHQ7okG89EgkOv = new ListBox();
		this._TmBRbzJjQjSt17hgepv668iGEK = new TextBox();
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l = new ListBox();
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq = new Button();
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm = new Button();
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.SuspendLayout();
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.SuspendLayout();
		base.SuspendLayout();
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.AutoSize = true;
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.BackColor = Color.Transparent;
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.ForeColor = Color.Gold;
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.Location = new Point(12, 9);
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.Name = "lblEnemies";
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.Size = new Size(112, 25);
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.TabIndex = 0;
		this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR.Text = "All Enemies";
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.Controls.Add(this._NmKCZ9UNVe2ErB5WyHRh62MNt3l);
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.Location = new Point(17, 37);
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.Name = "pnlEnemies";
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.Size = new Size(244, 272);
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.TabIndex = 14;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.BackColor = Color.FromArgb(162, 57, 202);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Enabled = false;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.FlatAppearance.BorderSize = 0;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.FlatStyle = FlatStyle.Flat;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.ForeColor = Color.Gold;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Location = new Point(17, 343);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Name = "btnAdd";
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Size = new Size(244, 25);
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.TabIndex = 11;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Text = "Add Selected";
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.UseVisualStyleBackColor = false;
		this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF.Click += this._U6dbRaz2TsMR5ROxP2pK00GyxpO;
		this._CekQKkcRToYx4hSootyPyeNB53d.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._CekQKkcRToYx4hSootyPyeNB53d.AutoSize = true;
		this._CekQKkcRToYx4hSootyPyeNB53d.BackColor = Color.Transparent;
		this._CekQKkcRToYx4hSootyPyeNB53d.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._CekQKkcRToYx4hSootyPyeNB53d.ForeColor = Color.Gold;
		this._CekQKkcRToYx4hSootyPyeNB53d.Location = new Point(262, 9);
		this._CekQKkcRToYx4hSootyPyeNB53d.Name = "lblIgnored";
		this._CekQKkcRToYx4hSootyPyeNB53d.Size = new Size(161, 25);
		this._CekQKkcRToYx4hSootyPyeNB53d.TabIndex = 9;
		this._CekQKkcRToYx4hSootyPyeNB53d.Text = "Ignored Enemies";
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.Controls.Add(this._JJkvI0iec5HhxVHQ7okG89EgkOv);
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.Location = new Point(267, 37);
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.Name = "pnlIgnored";
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.Size = new Size(200, 272);
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.TabIndex = 15;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.BackColor = Color.FromArgb(14, 11, 22);
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.BorderStyle = BorderStyle.FixedSingle;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Dock = DockStyle.Fill;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.ForeColor = Color.Gainsboro;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.FormattingEnabled = true;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.IntegralHeight = false;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Location = new Point(0, 0);
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Name = "lstIgnored";
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.Size = new Size(200, 272);
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.TabIndex = 10;
		this._JJkvI0iec5HhxVHQ7okG89EgkOv.SelectedIndexChanged += this._XEkCUYM7358fNUqEDFNE3ovZxw;
		this._TmBRbzJjQjSt17hgepv668iGEK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._TmBRbzJjQjSt17hgepv668iGEK.BackColor = Color.FromArgb(14, 11, 22);
		this._TmBRbzJjQjSt17hgepv668iGEK.BorderStyle = BorderStyle.FixedSingle;
		this._TmBRbzJjQjSt17hgepv668iGEK.ForeColor = Color.Gold;
		this._TmBRbzJjQjSt17hgepv668iGEK.Location = new Point(17, 315);
		this._TmBRbzJjQjSt17hgepv668iGEK.Name = "tbxFilter";
		this._TmBRbzJjQjSt17hgepv668iGEK.Size = new Size(244, 22);
		this._TmBRbzJjQjSt17hgepv668iGEK.TabIndex = 13;
		this._TmBRbzJjQjSt17hgepv668iGEK.Text = "Search...";
		this._TmBRbzJjQjSt17hgepv668iGEK.Click += this._yEstmdVZbDP3Emhdcky58AfDzlN;
		this._TmBRbzJjQjSt17hgepv668iGEK.TextChanged += this._l6DAqjA32SdbOsgCHz2PFuBhP9F;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.BackColor = Color.FromArgb(14, 11, 22);
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.BorderStyle = BorderStyle.FixedSingle;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Dock = DockStyle.Fill;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.ForeColor = Color.Gainsboro;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.FormattingEnabled = true;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.IntegralHeight = false;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Location = new Point(0, 0);
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Name = "lstEnemies";
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.Size = new Size(244, 272);
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.TabIndex = 8;
		this._NmKCZ9UNVe2ErB5WyHRh62MNt3l.SelectedIndexChanged += this._yzo8RV8cui7MexB7s81x22zXTGb;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.BackColor = Color.FromArgb(14, 11, 22);
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.FlatAppearance.BorderColor = Color.Gray;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.FlatStyle = FlatStyle.Flat;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Font = new Font("Segoe UI", 8.25f);
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.ForeColor = Color.Gold;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Location = new Point(267, 315);
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Name = "btnRemoveAll";
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Size = new Size(200, 22);
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.TabIndex = 16;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Text = "Remove All";
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.UseVisualStyleBackColor = false;
		this._qeCiCJtDZYDdn4A4PK2KdanTKwq.Click += this._M5vBUQXTjoxSKUpFKWJvPZwd50BA;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.BackColor = Color.FromArgb(162, 57, 202);
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.FlatAppearance.BorderSize = 0;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.FlatStyle = FlatStyle.Flat;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.ForeColor = Color.Gold;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Location = new Point(267, 343);
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Name = "btnRemove";
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Size = new Size(200, 25);
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.TabIndex = 12;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Text = "Remove Selected";
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.UseVisualStyleBackColor = false;
		this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm.Click += this._wQO6e6NIqyM0V2bNbmKEXJd7AtO;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = SystemColors.ActiveCaptionText;
		this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(484, 386);
		base.Controls.Add(this._qeCiCJtDZYDdn4A4PK2KdanTKwq);
		base.Controls.Add(this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb);
		base.Controls.Add(this._ogAi2z1mJ23FjmFBo2wpFa3Ichu);
		base.Controls.Add(this._TmBRbzJjQjSt17hgepv668iGEK);
		base.Controls.Add(this._2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm);
		base.Controls.Add(this._f3FqoQ9uobA2iAJQ1zcfBT2eQjF);
		base.Controls.Add(this._CekQKkcRToYx4hSootyPyeNB53d);
		base.Controls.Add(this._yFTb8Sg6jfd6lbqB7sqWiD4IdTR);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ForeColor = Color.Gainsboro;
		base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FrmSettingsIgnoredEnemies";
		base.StartPosition = FormStartPosition.Manual;
		this.Text = "RealmStock Multi-Tool";
		this._ogAi2z1mJ23FjmFBo2wpFa3Ichu.ResumeLayout(false);
		this._b8NcOZm6A7WkLJbFd0DEcCqfhgAb.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040006D2 RID: 1746
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x040006D3 RID: 1747
	private Label _yFTb8Sg6jfd6lbqB7sqWiD4IdTR;

	// Token: 0x040006D4 RID: 1748
	private Panel _ogAi2z1mJ23FjmFBo2wpFa3Ichu;

	// Token: 0x040006D5 RID: 1749
	private ListBox _NmKCZ9UNVe2ErB5WyHRh62MNt3l;

	// Token: 0x040006D6 RID: 1750
	private Button _f3FqoQ9uobA2iAJQ1zcfBT2eQjF;

	// Token: 0x040006D7 RID: 1751
	private Label _CekQKkcRToYx4hSootyPyeNB53d;

	// Token: 0x040006D8 RID: 1752
	private Panel _b8NcOZm6A7WkLJbFd0DEcCqfhgAb;

	// Token: 0x040006D9 RID: 1753
	private ListBox _JJkvI0iec5HhxVHQ7okG89EgkOv;

	// Token: 0x040006DA RID: 1754
	private TextBox _TmBRbzJjQjSt17hgepv668iGEK;

	// Token: 0x040006DB RID: 1755
	private Button _qeCiCJtDZYDdn4A4PK2KdanTKwq;

	// Token: 0x040006DC RID: 1756
	private Button _2M3Yt8E0iSAbvQnM6tTUxFrQ0Lm;

	// Token: 0x020000D4 RID: 212
	[CompilerGenerated]
	[Serializable]
	private sealed class _qdlkGmn0olvAHtUU1NApb4QOAAD
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x00020F18 File Offset: 0x0001F118
		internal ObjectStructure _EVTxd4FutMXcbddiAynenLmYFct(int id)
		{
			return _JzyrOApzC09RC3fmb10FDURmyCl.Objects.ByID((ushort)id);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00020F34 File Offset: 0x0001F134
		internal bool _iaMumB66yrjbxwC5cOmDetlbF79(ObjectStructure type)
		{
			return type.Enemy;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00020F48 File Offset: 0x0001F148
		internal string _0den32egAr0cKX0iVwV8NiASMtp(ObjectStructure type)
		{
			return type._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00020F5C File Offset: 0x0001F15C
		internal bool _OXi9CcRvYwj6n7zNJuSufOBUSvH(ObjectStructure type)
		{
			return type.Enemy;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00020F70 File Offset: 0x0001F170
		internal string _tZeac4BCRa46WM4A0qQFX014MrY(ObjectStructure type)
		{
			return type._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00020F84 File Offset: 0x0001F184
		internal int _jIkfL3wFtCzeAZ2xsxsBnWKD04b(string Item)
		{
			return (int)_JzyrOApzC09RC3fmb10FDURmyCl.Objects.ByName(Item)._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID;
		}

		// Token: 0x040006DD RID: 1757
		public static readonly _3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD <>9 = new _3epUp89nX32qcURFompyGb29FFH._qdlkGmn0olvAHtUU1NApb4QOAAD();

		// Token: 0x040006DE RID: 1758
		public static Func<int, ObjectStructure> <>9__0_0;

		// Token: 0x040006DF RID: 1759
		public static Func<ObjectStructure, bool> <>9__0_1;

		// Token: 0x040006E0 RID: 1760
		public static Func<ObjectStructure, string> <>9__0_2;

		// Token: 0x040006E1 RID: 1761
		public static Func<ObjectStructure, bool> <>9__3_0;

		// Token: 0x040006E2 RID: 1762
		public static Func<ObjectStructure, string> <>9__3_1;

		// Token: 0x040006E3 RID: 1763
		public static Func<string, int> <>9__8_0;
	}

	// Token: 0x020000D5 RID: 213
	[CompilerGenerated]
	private sealed class _XZORrafniN0joJMdlgEofnqnt2k
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		internal bool _bKvB6It4vCTQjQ5I4sGikvOF7QP(string name)
		{
			return this._Wcsyk4fpkP7CcKtnbgGHtDKh3LbA == "" || name.ToLower().Contains(this._Wcsyk4fpkP7CcKtnbgGHtDKh3LbA);
		}

		// Token: 0x040006E4 RID: 1764
		public string _Wcsyk4fpkP7CcKtnbgGHtDKh3LbA;
	}
}
