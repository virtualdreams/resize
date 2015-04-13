using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using DllImport;
using System.Drawing.Drawing2D;

namespace ReSize
{
	public partial class ReSize : Form
	{
		private bool drag = false;
		private IntPtr oldhWnd = IntPtr.Zero;
	
		public ReSize()
		{
			InitializeComponent();

			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			toolTip.ShowAlways = true;

			toolTip.SetToolTip(cbClientArea, "If checked, the client area is set to the specified resolution.");
			toolTip.SetToolTip(btnSet, "Drag the icon over a window and release the mouse button.");
			toolTip.SetToolTip(cbNoTopLvl, "Don't resolve the top level window.");
			toolTip.SetToolTip(cbWndEnabler, "Enable or disable a window. This can have unexpected results.");
			toolTip.SetToolTip(cbWndEnable, "Set the state to enabled or disabled.");
		}

		private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar) ||
				char.IsSymbol(e.KeyChar) ||
				char.IsWhiteSpace(e.KeyChar) ||
				char.IsPunctuation(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar) ||
				char.IsSymbol(e.KeyChar) ||
				char.IsWhiteSpace(e.KeyChar) ||
				char.IsPunctuation(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnSet_MouseDown(object sender, MouseEventArgs e)
		{
			drag = true;
			btnSet.Cursor = Cursors.NoMove2D;
		}

		private void btnSet_MouseUp(object sender, MouseEventArgs e)
		{
			if(drag)
			{	
				if (!String.IsNullOrEmpty(tbWidth.Text) && !String.IsNullOrEmpty(tbHeight.Text))
				{
					IntPtr hWnd = WindowFromPoint(MousePosition.X, MousePosition.Y);

					if(!cbNoTopLvl.Checked)
					{
						hWnd = GetTopLevelWindow(hWnd);
					}

					if (GetTopLevelWindow(hWnd) != this.Handle)
					{
						SetSize(hWnd, Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text));
					}
				}

				if (cbWndEnabler.Checked && cbNoResize.Checked)
				{
					IntPtr hWnd = WindowFromPoint(MousePosition.X, MousePosition.Y);

					if (!cbNoTopLvl.Checked)
					{
						hWnd = GetTopLevelWindow(hWnd);
					}

					int enable = 0;
					if (cbWndEnable.Checked)
						enable = 1;

					EnableWindow(hWnd, enable);
				}
				
				btnSet.Cursor = Cursors.Default;
			}
		}
		
		private void SetSize(IntPtr hWnd, int width, int height)
		{
			if(cbNoResize.Checked)
				return;
			
			if(cbClientArea.Checked)
			{
				RECT rcClient = new RECT();
				RECT rcWindow = new RECT();

				user32.GetClientRect(hWnd, ref rcClient);
				user32.GetWindowRect(hWnd, ref rcWindow);

				int diffX = (rcWindow.right - rcWindow.left) - rcClient.right;
				int diffY = (rcWindow.bottom - rcWindow.top) - rcClient.bottom;
				user32.MoveWindow(hWnd, rcWindow.left, rcWindow.top, width + diffX, height + diffY, true);
			}
			else
			{
				RECT rcWindow = new RECT();
				user32.GetWindowRect(hWnd, ref rcWindow);
				user32.MoveWindow(hWnd, rcWindow.left, rcWindow.top, width, height, true);
			}
		}
		
		private void EnableWindow(IntPtr hWnd, int enable)
		{
			user32.EnableWindow(hWnd, enable);
		}
		
		private IntPtr WindowFromPoint(int x, int y)
		{
			POINT p = new POINT();
			p.x = MousePosition.X;
			p.y = MousePosition.Y;
			return user32.WindowFromPoint(p);
		}
		
		private IntPtr GetTopLevelWindow(IntPtr hWnd)
		{
			IntPtr child = hWnd;
			
			while (child != IntPtr.Zero)
			{
				hWnd = child;
				child = user32.GetParent(hWnd);
			}
			return hWnd;
		}

		private void lbSizes_SelectedIndexChanged(object sender, EventArgs e)
		{
			int idx = lbSizes.SelectedIndex;
			if(idx >= 0)
			{
				string[] values = ((string)lbSizes.Items[idx]).Split('x');
				
				tbWidth.Text = values[0];
				tbHeight.Text = values[1];
			}
		}

		private void btnSet_MouseMove(object sender, MouseEventArgs e)
		{
			if(drag)
			{
				IntPtr hWnd = WindowFromPoint(MousePosition.X, MousePosition.Y);

				if (!cbNoTopLvl.Checked)
				{
					hWnd = GetTopLevelWindow(hWnd);
				}
				
				if(oldhWnd != hWnd)
				{
					RECT rcWin = new RECT();
					RECT rcCli = new RECT();
					user32.GetWindowRect(hWnd, ref rcWin);
					user32.GetClientRect(hWnd, ref rcCli);
					
					lblOrgWinSize.Text = String.Format("{0}x{1}", rcWin.right - rcWin.left, rcWin.bottom - rcWin.top);
					lblOrgCliSize.Text = String.Format("{0}x{1}", rcCli.right - rcCli.left, rcCli.bottom - rcCli.top);

					tbClassName.Text = GetClassName(hWnd);
					tbWndText.Text = GetWindowText(hWnd);
					
					oldhWnd = hWnd;
				}
			}
		}
		
		private string GetClassName(IntPtr hWnd)
		{
			StringBuilder sb = new StringBuilder(1024);
			user32.GetClassNameW(hWnd, sb, sb.Capacity);
			return sb.ToString();
		}

		private string GetWindowText(IntPtr hWnd)
		{
			StringBuilder sb = new StringBuilder(1024);
			user32.GetWindowTextW(hWnd, sb, sb.Capacity);
			return sb.ToString();
		}

		private void cbNoTopLvl_CheckedChanged(object sender, EventArgs e)
		{
			if(cbNoTopLvl.Checked)
			{
				if(MessageBox.Show(this, "Enable this function doesn't resolve the top level window.\nThis can resize ANY window or control.\nUse it at your own risk!\n\nEnable this feature?", "ReSize", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
				{
					cbNoTopLvl.Checked = false;
				}
			}
		}

		private void cbWndEnabler_CheckStateChanged(object sender, EventArgs e)
		{
			if (cbWndEnabler.Checked)
			{
				cbNoResize.Checked = true;
				cbNoResize.Enabled = false;
				cbClientArea.Enabled = false;
				cbWndEnable.Enabled = true;
			}
			else
			{
				cbNoResize.Enabled = true;
				cbClientArea.Enabled = true;
				cbWndEnable.Enabled = false;
			}
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			this.Visible = !this.Visible;
			if (this.Visible && this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
		}
	}
}
