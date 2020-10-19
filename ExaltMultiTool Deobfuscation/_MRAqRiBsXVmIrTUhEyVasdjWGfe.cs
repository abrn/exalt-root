using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x020000D1 RID: 209
internal partial class _MRAqRiBsXVmIrTUhEyVasdjWGfe : Form
{
	// Token: 0x0600055A RID: 1370 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
	public _MRAqRiBsXVmIrTUhEyVasdjWGfe()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		int num = 5;
		Type typeFromHandle = typeof(EffectType);
		foreach (string text in Enum.GetNames(typeFromHandle))
		{
			MemberInfo field = typeFromHandle.GetField(text);
			CheckBox checkBox = new CheckBox();
			this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Controls.Add(checkBox);
			checkBox.AutoSize = true;
			checkBox.Font = this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Font;
			checkBox.Text = "Ignore '" + text + "'";
			checkBox.Tag = text;
			checkBox.Checked = Settings.Default.AntiLagIgnoredEffects.Contains(text);
			checkBox.Location = new Point(5, num);
			num += checkBox.Height + 5;
			DescriptionAttribute descriptionAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
			if (descriptionAttribute != null && !string.IsNullOrWhiteSpace(descriptionAttribute.Description))
			{
				CheckBox checkBox2 = checkBox;
				checkBox2.Text = checkBox2.Text + " | " + descriptionAttribute.Description;
			}
			checkBox.CheckedChanged += this._cYvNKS3VwXgTDdHb3vk96fQCvzu;
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
	private void _cYvNKS3VwXgTDdHb3vk96fQCvzu(object sender, EventArgs e)
	{
		CheckBox checkBox = sender as CheckBox;
		if (checkBox != null)
		{
			_MRAqRiBsXVmIrTUhEyVasdjWGfe._nYtdBfyfKisx2KGFXwkyoL1KOm1 nYtdBfyfKisx2KGFXwkyoL1KOm = new _MRAqRiBsXVmIrTUhEyVasdjWGfe._nYtdBfyfKisx2KGFXwkyoL1KOm1();
			nYtdBfyfKisx2KGFXwkyoL1KOm._easpZVayN5ydKLsnOCE0XkadELG = (checkBox.Tag as string);
			if (checkBox.Checked)
			{
				Settings.Default.AntiLagIgnoredEffects = Settings.Default.AntiLagIgnoredEffects.Concat(new string[]
				{
					nYtdBfyfKisx2KGFXwkyoL1KOm._easpZVayN5ydKLsnOCE0XkadELG
				}).ToArray<string>();
				return;
			}
			Settings.Default.AntiLagIgnoredEffects = Settings.Default.AntiLagIgnoredEffects.Where(new Func<string, bool>(nYtdBfyfKisx2KGFXwkyoL1KOm._woo1b7SmTgP1iT4qVxmomoeGIkb)).ToArray<string>();
		}
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0001FF70 File Offset: 0x0001E170
	private void _sp2qhEDZIuPCoFyern2xaqtXdFd(object sender, FormClosedEventArgs e)
	{
		Settings.Default.Save();
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001FF88 File Offset: 0x0001E188
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_MRAqRiBsXVmIrTUhEyVasdjWGfe));
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF = new Panel();
		this._lQk2zvwLPDQUFqithAOzmFMjQCg = new Label();
		base.SuspendLayout();
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.AutoScroll = true;
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.BackColor = Color.FromArgb(34, 21, 42);
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.BorderStyle = BorderStyle.FixedSingle;
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Location = new Point(17, 37);
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Name = "pnlEffects";
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.Size = new Size(450, 330);
		this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF.TabIndex = 16;
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.AutoSize = true;
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.BackColor = Color.Transparent;
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.ForeColor = Color.Gold;
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.Location = new Point(12, 9);
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.Name = "lblEffects";
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.Size = new Size(203, 25);
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.TabIndex = 15;
		this._lQk2zvwLPDQUFqithAOzmFMjQCg.Text = "Ignored Game Effects";
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = SystemColors.ActiveCaptionText;
		this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.ClientSize = new Size(484, 386);
		base.Controls.Add(this._iBcTaJqHSJ0N7KFM8wK7HqsxIyF);
		base.Controls.Add(this._lQk2zvwLPDQUFqithAOzmFMjQCg);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ForeColor = Color.Gainsboro;
		base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FrmSettingsIgnoredEffects";
		base.StartPosition = FormStartPosition.Manual;
		this.Text = "RealmStock Multi-Tool";
		base.FormClosed += this._sp2qhEDZIuPCoFyern2xaqtXdFd;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040006CE RID: 1742
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x040006CF RID: 1743
	private Panel _iBcTaJqHSJ0N7KFM8wK7HqsxIyF;

	// Token: 0x040006D0 RID: 1744
	private Label _lQk2zvwLPDQUFqithAOzmFMjQCg;

	// Token: 0x020000D2 RID: 210
	[CompilerGenerated]
	private sealed class _nYtdBfyfKisx2KGFXwkyoL1KOm1
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x00020244 File Offset: 0x0001E444
		internal bool _woo1b7SmTgP1iT4qVxmomoeGIkb(string name)
		{
			return name != this._easpZVayN5ydKLsnOCE0XkadELG;
		}

		// Token: 0x040006D1 RID: 1745
		public string _easpZVayN5ydKLsnOCE0XkadELG;
	}
}
