using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		double results = 0;
		string operation = "";
		bool enter_value = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Width = 323;
			txtDisplay.Width = 287;
		}

		private void FileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Width = 323;
			txtDisplay.Width = 287;
		}

		private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Width = 633;
			txtDisplay.Width = 594;
		}

		private void btn_Click(object sender, EventArgs e)
		{
			if ((txtDisplay.Text == "0") || (enter_value))
				txtDisplay.Text = "";
			enter_value = false;
			Button num = (Button)sender;
			if (num.Text == ".")
			{
				if (!txtDisplay.Text.Contains("."))
					txtDisplay.Text = txtDisplay.Text + num.Text;
			}
			else txtDisplay.Text = txtDisplay.Text + num.Text;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
			}
			if (txtDisplay.Text=="")
			{
				txtDisplay.Text = "0";
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "0";
			lblShow.Text = "";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "0";
			lblShow.Text = "";
		}

		private void Pheptinh_operator(object sender, EventArgs e)
		{
			
		}

		private void Button18_Click(object sender, EventArgs e)
		{
			lblShow.Text = "";
			switch (operation)
			{
				case "+":
					txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "-":
					txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "*":
					txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "/":
					txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "Mod":
					txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "Exp":
					double i = Double.Parse(txtDisplay.Text);
					double q;
					q = (results);
					txtDisplay.Text = Math.Exp(i* Math.Log(q*4)).ToString();
					break;

			}
		}

		private void Button32_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "3,1415926535897";
		}

		private void Button31_Click(object sender, EventArgs e)
		{
			double ilog = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
			ilog = Math.Log10(ilog);
			txtDisplay.Text = System.Convert.ToString(ilog);
			
		}

		private void Button30_Click(object sender, EventArgs e)
		{
			double isq = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
			isq = Math.Sqrt(isq);
			txtDisplay.Text = System.Convert.ToString(isq);
		}

		private void Button28_Click(object sender, EventArgs e)
		{
			double sinh = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
			sinh = Math.Sinh(sinh);
			txtDisplay.Text = System.Convert.ToString(sinh);
		}

		private void Button27_Click(object sender, EventArgs e)
		{
			double sin = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
			sin = Math.Sinh(sin);
			txtDisplay.Text = System.Convert.ToString(sin);
		}

		private void Button24_Click(object sender, EventArgs e)
		{
			double cosh = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
			cosh = Math.Cosh(cosh);
			txtDisplay.Text = System.Convert.ToString(cosh);
		}

		private void Button23_Click(object sender, EventArgs e)
		{
			double cos = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
			cos = Math.Cos(cos);
			txtDisplay.Text = System.Convert.ToString(cos);
		}

		private void Button36_Click(object sender, EventArgs e)
		{
			double tanh = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
			tanh = Math.Tanh(tanh);
			txtDisplay.Text = System.Convert.ToString(tanh);
		}

		private void Button35_Click(object sender, EventArgs e)
		{
			double tan = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
			tan = Math.Tan(tan);
			txtDisplay.Text = System.Convert.ToString(tan);
		}

		private void Button26_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("dec" + "(" + (txtDisplay.Text) + ")");
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button22_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("bin" + "(" + (txtDisplay.Text) + ")");
			txtDisplay.Text = System.Convert.ToString(a,2);
		}

		private void Button34_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("hex" + "(" + (txtDisplay.Text) + ")");
			txtDisplay.Text = System.Convert.ToString(a,16);
		}

		private void Button38_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("oct" + "(" + (txtDisplay.Text) + ")");
			txtDisplay.Text = System.Convert.ToString(a,8);
		}

		private void Button29_Click(object sender, EventArgs e)
		{
			double a;
			a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button25_Click(object sender, EventArgs e)
		{
			double a;
			a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button21_Click(object sender, EventArgs e)
		{
			double a;
			a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button33_Click(object sender, EventArgs e)
		{
			double a = Double.Parse(txtDisplay.Text);
			lblShow.Text = System.Convert.ToString("in" + "(" + (txtDisplay.Text) + ")");
			a = Math.Log(a);
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button37_Click(object sender, EventArgs e)
		{
			double a;
			a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			double a;
			a = Convert.ToDouble(txtDisplay.Text)- 2*Convert.ToDouble(txtDisplay.Text);
			txtDisplay.Text = System.Convert.ToString(a);
		}

		private void Button40_Click(object sender, EventArgs e)
		{
			
		}

		private void Button39_Click(object sender, EventArgs e)
		{

		}

		private void Button5_Click(object sender, EventArgs e)
		{
			Button num = (Button)sender;
			operation = num.Text;
			results = double.Parse(txtDisplay.Text);
			txtDisplay.Text = "";
			lblShow.Text = System.Convert.ToString(results) + " " + operation;
		}
	}
}
