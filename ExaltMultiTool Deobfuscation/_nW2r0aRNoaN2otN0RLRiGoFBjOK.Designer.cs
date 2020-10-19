using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x020000D9 RID: 217
internal class _nW2r0aRNoaN2otN0RLRiGoFBjOK : UserControl
{
	// Token: 0x0600058A RID: 1418 RVA: 0x000228F8 File Offset: 0x00020AF8
	public _nW2r0aRNoaN2otN0RLRiGoFBjOK()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		this._nxkzm9whaVrDU5V474SB6kCbp43.Text = "Your Support ID: " + Settings.Default.ID.ToString();
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00022940 File Offset: 0x00020B40
	private void _hI2l0yj74zHtgqFzamYqxrZzBPd(object sender, EventArgs e)
	{
		Clipboard.SetText(Settings.Default.ID.ToString());
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0002296C File Offset: 0x00020B6C
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00022998 File Offset: 0x00020B98
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_nW2r0aRNoaN2otN0RLRiGoFBjOK));
		this._g2YdxLB2ckpzztCJSrvnHoAZets = new Label();
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn = new Label();
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf = new Label();
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW = new Label();
		this._JfqsPx77PRS6aM5V30NRxbjNJzF = new Label();
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd = new Label();
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd = new Label();
		this._5biwKoV5EFCGuApQjtasmexXO4d = new Label();
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M = new Label();
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T = new Label();
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB = new PictureBox();
		this._V37sZf1oSYWsQKSfOjBRlbceKZE = new PictureBox();
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl = new PictureBox();
		this._Paapk0hd0KX4M220ESjuQiZIzsg = new PictureBox();
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo = new PictureBox();
		this._nxkzm9whaVrDU5V474SB6kCbp43 = new Label();
		((ISupportInitialize)this._PzfXaQeyr0Ols2M3NNwohWOL1yB).BeginInit();
		((ISupportInitialize)this._V37sZf1oSYWsQKSfOjBRlbceKZE).BeginInit();
		((ISupportInitialize)this._CbtPHEwITJ2yBxfDKn3gCEegHWl).BeginInit();
		((ISupportInitialize)this._Paapk0hd0KX4M220ESjuQiZIzsg).BeginInit();
		((ISupportInitialize)this._AFFiqsZe9pnsvzFmOaaAos3LJoo).BeginInit();
		base.SuspendLayout();
		this._g2YdxLB2ckpzztCJSrvnHoAZets.AutoSize = true;
		this._g2YdxLB2ckpzztCJSrvnHoAZets.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._g2YdxLB2ckpzztCJSrvnHoAZets.ForeColor = Color.Gold;
		this._g2YdxLB2ckpzztCJSrvnHoAZets.Location = new Point(3, 22);
		this._g2YdxLB2ckpzztCJSrvnHoAZets.Name = "lblStep1";
		this._g2YdxLB2ckpzztCJSrvnHoAZets.Size = new Size(92, 32);
		this._g2YdxLB2ckpzztCJSrvnHoAZets.TabIndex = 0;
		this._g2YdxLB2ckpzztCJSrvnHoAZets.Text = "Step 1.";
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.AutoSize = true;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Font = new Font("Segoe UI", 10f);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Location = new Point(101, 34);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Name = "label1";
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Size = new Size(230, 19);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.TabIndex = 1;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Text = "Launch RotMG Exalt with our menu.";
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.AutoSize = true;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Font = new Font("Segoe UI", 10f);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Location = new Point(101, 222);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Name = "label2";
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Size = new Size(280, 19);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.TabIndex = 3;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Text = "Wait for our tool to attach and join in-game.";
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.AutoSize = true;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.ForeColor = Color.Gold;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Location = new Point(3, 210);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Name = "label3";
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Size = new Size(92, 32);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.TabIndex = 2;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Text = "Step 2.";
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.AutoSize = true;
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.Font = new Font("Segoe UI", 10f);
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.Location = new Point(101, 361);
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.Name = "label4";
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.Size = new Size(309, 19);
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.TabIndex = 5;
		this._JfqsPx77PRS6aM5V30NRxbjNJzF.Text = "Scroll down to 'Proxy Server' on the server menu.";
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.AutoSize = true;
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.ForeColor = Color.Gold;
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.Location = new Point(3, 349);
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.Name = "label5";
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.Size = new Size(92, 32);
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.TabIndex = 4;
		this._0B6AEp5LCuEqJqzXXfmQc5iVwdd.Text = "Step 3.";
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.AutoSize = true;
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.Font = new Font("Segoe UI", 10f);
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.Location = new Point(101, 499);
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.Name = "label6";
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.Size = new Size(274, 19);
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.TabIndex = 7;
		this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd.Text = "Enjoy all of the features of the proxy server.";
		this._5biwKoV5EFCGuApQjtasmexXO4d.AutoSize = true;
		this._5biwKoV5EFCGuApQjtasmexXO4d.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._5biwKoV5EFCGuApQjtasmexXO4d.ForeColor = Color.Gold;
		this._5biwKoV5EFCGuApQjtasmexXO4d.Location = new Point(3, 487);
		this._5biwKoV5EFCGuApQjtasmexXO4d.Name = "label7";
		this._5biwKoV5EFCGuApQjtasmexXO4d.Size = new Size(92, 32);
		this._5biwKoV5EFCGuApQjtasmexXO4d.TabIndex = 6;
		this._5biwKoV5EFCGuApQjtasmexXO4d.Text = "Step 4.";
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.AutoSize = true;
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.Font = new Font("Segoe UI", 10f);
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.Location = new Point(101, 587);
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.Name = "label8";
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.Size = new Size(299, 19);
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.TabIndex = 9;
		this._Txq6jNOBZTLyVrmaRtfJmr8OK9M.Text = "Use /con command to change servers instantly.";
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.AutoSize = true;
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.ForeColor = Color.Gold;
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.Location = new Point(3, 575);
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.Name = "label9";
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.Size = new Size(81, 32);
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.TabIndex = 8;
		this._mLXh0oRLsXXy7dfA33KfbrEUd1T.Text = "Extra!";
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.BorderStyle = BorderStyle.FixedSingle;
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.Image = (Image)componentResourceManager.GetObject("pbxStep4.Image");
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.Location = new Point(105, 521);
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.Name = "pbxStep4";
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.Size = new Size(300, 50);
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.SizeMode = PictureBoxSizeMode.CenterImage;
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.TabIndex = 10;
		this._PzfXaQeyr0Ols2M3NNwohWOL1yB.TabStop = false;
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.BorderStyle = BorderStyle.FixedSingle;
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.Image = (Image)componentResourceManager.GetObject("pbxStep3.Image");
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.Location = new Point(105, 384);
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.Name = "pbxStep3";
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.Size = new Size(300, 100);
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.SizeMode = PictureBoxSizeMode.StretchImage;
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.TabIndex = 12;
		this._V37sZf1oSYWsQKSfOjBRlbceKZE.TabStop = false;
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.BorderStyle = BorderStyle.FixedSingle;
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.Image = (Image)componentResourceManager.GetObject("pbxStep5.Image");
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.Location = new Point(105, 610);
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.Name = "pbxStep5";
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.Size = new Size(300, 50);
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.SizeMode = PictureBoxSizeMode.CenterImage;
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.TabIndex = 14;
		this._CbtPHEwITJ2yBxfDKn3gCEegHWl.TabStop = false;
		this._Paapk0hd0KX4M220ESjuQiZIzsg.BorderStyle = BorderStyle.FixedSingle;
		this._Paapk0hd0KX4M220ESjuQiZIzsg.Image = (Image)componentResourceManager.GetObject("pbxStep2.Image");
		this._Paapk0hd0KX4M220ESjuQiZIzsg.Location = new Point(105, 244);
		this._Paapk0hd0KX4M220ESjuQiZIzsg.Name = "pbxStep2";
		this._Paapk0hd0KX4M220ESjuQiZIzsg.Size = new Size(300, 100);
		this._Paapk0hd0KX4M220ESjuQiZIzsg.SizeMode = PictureBoxSizeMode.StretchImage;
		this._Paapk0hd0KX4M220ESjuQiZIzsg.TabIndex = 15;
		this._Paapk0hd0KX4M220ESjuQiZIzsg.TabStop = false;
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.BorderStyle = BorderStyle.FixedSingle;
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.Image = (Image)componentResourceManager.GetObject("pbxStep1.Image");
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.Location = new Point(105, 56);
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.Name = "pbxStep1";
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.Size = new Size(300, 150);
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.SizeMode = PictureBoxSizeMode.StretchImage;
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.TabIndex = 16;
		this._AFFiqsZe9pnsvzFmOaaAos3LJoo.TabStop = false;
		this._nxkzm9whaVrDU5V474SB6kCbp43.AutoSize = true;
		this._nxkzm9whaVrDU5V474SB6kCbp43.Cursor = Cursors.Hand;
		this._nxkzm9whaVrDU5V474SB6kCbp43.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
		this._nxkzm9whaVrDU5V474SB6kCbp43.ForeColor = Color.Gold;
		this._nxkzm9whaVrDU5V474SB6kCbp43.Location = new Point(5, 3);
		this._nxkzm9whaVrDU5V474SB6kCbp43.Name = "lblMachineGuid";
		this._nxkzm9whaVrDU5V474SB6kCbp43.Size = new Size(120, 19);
		this._nxkzm9whaVrDU5V474SB6kCbp43.TabIndex = 17;
		this._nxkzm9whaVrDU5V474SB6kCbp43.Text = "Your Support ID:";
		this._nxkzm9whaVrDU5V474SB6kCbp43.Click += this._hI2l0yj74zHtgqFzamYqxrZzBPd;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.AutoScroll = true;
		this.BackColor = Color.FromArgb(44, 31, 52);
		base.Controls.Add(this._nxkzm9whaVrDU5V474SB6kCbp43);
		base.Controls.Add(this._AFFiqsZe9pnsvzFmOaaAos3LJoo);
		base.Controls.Add(this._Paapk0hd0KX4M220ESjuQiZIzsg);
		base.Controls.Add(this._CbtPHEwITJ2yBxfDKn3gCEegHWl);
		base.Controls.Add(this._V37sZf1oSYWsQKSfOjBRlbceKZE);
		base.Controls.Add(this._PzfXaQeyr0Ols2M3NNwohWOL1yB);
		base.Controls.Add(this._Txq6jNOBZTLyVrmaRtfJmr8OK9M);
		base.Controls.Add(this._mLXh0oRLsXXy7dfA33KfbrEUd1T);
		base.Controls.Add(this._XiYvi0SOIBOA5Nh9Oy16rwAXCTd);
		base.Controls.Add(this._5biwKoV5EFCGuApQjtasmexXO4d);
		base.Controls.Add(this._JfqsPx77PRS6aM5V30NRxbjNJzF);
		base.Controls.Add(this._0B6AEp5LCuEqJqzXXfmQc5iVwdd);
		base.Controls.Add(this._BEFwFnaRw3Ak2YGQpfohIOtEIDf);
		base.Controls.Add(this._UQXpP3YbtvnD1q2FOAN2qS2ohxW);
		base.Controls.Add(this._tKBTSAORY4UWZkVWDYEkF4vaVRn);
		base.Controls.Add(this._g2YdxLB2ckpzztCJSrvnHoAZets);
		this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.ForeColor = Color.Gainsboro;
		base.Name = "InstructionsControl";
		base.Size = new Size(413, 687);
		((ISupportInitialize)this._PzfXaQeyr0Ols2M3NNwohWOL1yB).EndInit();
		((ISupportInitialize)this._V37sZf1oSYWsQKSfOjBRlbceKZE).EndInit();
		((ISupportInitialize)this._CbtPHEwITJ2yBxfDKn3gCEegHWl).EndInit();
		((ISupportInitialize)this._Paapk0hd0KX4M220ESjuQiZIzsg).EndInit();
		((ISupportInitialize)this._AFFiqsZe9pnsvzFmOaaAos3LJoo).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000701 RID: 1793
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x04000702 RID: 1794
	private Label _g2YdxLB2ckpzztCJSrvnHoAZets;

	// Token: 0x04000703 RID: 1795
	private Label _tKBTSAORY4UWZkVWDYEkF4vaVRn;

	// Token: 0x04000704 RID: 1796
	private Label _BEFwFnaRw3Ak2YGQpfohIOtEIDf;

	// Token: 0x04000705 RID: 1797
	private Label _UQXpP3YbtvnD1q2FOAN2qS2ohxW;

	// Token: 0x04000706 RID: 1798
	private Label _JfqsPx77PRS6aM5V30NRxbjNJzF;

	// Token: 0x04000707 RID: 1799
	private Label _0B6AEp5LCuEqJqzXXfmQc5iVwdd;

	// Token: 0x04000708 RID: 1800
	private Label _XiYvi0SOIBOA5Nh9Oy16rwAXCTd;

	// Token: 0x04000709 RID: 1801
	private Label _5biwKoV5EFCGuApQjtasmexXO4d;

	// Token: 0x0400070A RID: 1802
	private Label _Txq6jNOBZTLyVrmaRtfJmr8OK9M;

	// Token: 0x0400070B RID: 1803
	private Label _mLXh0oRLsXXy7dfA33KfbrEUd1T;

	// Token: 0x0400070C RID: 1804
	private PictureBox _PzfXaQeyr0Ols2M3NNwohWOL1yB;

	// Token: 0x0400070D RID: 1805
	private PictureBox _V37sZf1oSYWsQKSfOjBRlbceKZE;

	// Token: 0x0400070E RID: 1806
	private PictureBox _CbtPHEwITJ2yBxfDKn3gCEegHWl;

	// Token: 0x0400070F RID: 1807
	private PictureBox _Paapk0hd0KX4M220ESjuQiZIzsg;

	// Token: 0x04000710 RID: 1808
	private PictureBox _AFFiqsZe9pnsvzFmOaaAos3LJoo;

	// Token: 0x04000711 RID: 1809
	private Label _nxkzm9whaVrDU5V474SB6kCbp43;
}
