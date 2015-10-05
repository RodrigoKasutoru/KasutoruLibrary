using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using katSharp.Componets;
namespace katSharp.Controls
{
    [ToolboxBitmap(@"C:\Users\Rodrigo\Videos\KasutoruTools\KasutoruLibrary\KasutoruControls\bin\Debug\log.png")]
    public partial class katnumberBox: TextBox,ConvertirTipoDeDatos
    {
        public katnumberBox()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
            //base.OnKeyPress(e);
        }
        public byte BYTE()
        {
            return Convert.ToByte(Text);
        }
        public byte BYTE(char a)
        {
            return Convert.ToByte(a);
        }
        public byte BYTE(double d)
        {
            return Convert.ToByte(d);
        }
        public byte BYTE(Int16 i)
        {
            return Convert.ToByte(i);
        }
        public byte BYTE(int i)
        {
            return Convert.ToByte(i);
        }
        public byte BYTE(Int64 i)
        {
            return Convert.ToByte(i);
        }
        public byte BYTE(string s)
        {
            return Convert.ToByte(s);
        }
        public char CHAR()
        {
            return Convert.ToChar(Text);
        }
        public char CHAR(byte b)
        {
            return Convert.ToChar(b);
        }
        public char CHAR(double d)
        {
            return Convert.ToChar(d);
        }
        public char CHAR(Int16 i)
        {
            return Convert.ToChar(i);
        }
        public char CHAR(int i)
        {
            return Convert.ToChar(i);
        }
        public char CHAR(Int64 i)
        {
            return Convert.ToChar(i);
        }
        public char CHAR(string s)
        {
            return Convert.ToChar(s);
        }
        public double DOUBLE()
        {
            return Convert.ToDouble(Text);
        }
        public double DOUBLE(byte b)
        {
            return Convert.ToDouble(b);
        }
        public double DOUBLE(char c)
        {
            return Convert.ToDouble(c);
        }
        public double DOUBLE(Int16 i)
        {
            return Convert.ToDouble(i);
        }
        public double DOUBLE(int i)
        {
            return Convert.ToDouble(i);
        }
        public double DOUBLE(Int64 i)
        {
            return Convert.ToDouble(i);
        }
        public double DOUBLE(string s)
        {
            return Convert.ToDouble(s);
        }
        public Int16 INT16()
        {
            return Convert.ToInt16(Text);
        }
        public Int16 INT16(byte b)
        {
            return Convert.ToInt16(b);
        }
        public Int16 INT16(char c)
        {
            return Convert.ToInt16(c);
        }
        public Int16 INT16(double d)
        {
            return Convert.ToInt16(d);
        }
        public Int16 INT16(string s)
        {
            return Convert.ToInt16(s);
        }
        public int INT32()
        {
            return Convert.ToInt32(Text);
        }
        public int INT32(byte b)
        {
            return Convert.ToInt32(b);
        }
        public int INT32(char c)
        {
            return Convert.ToInt32(c);
        }
        public int INT32(double d)
        {
            return Convert.ToInt32(d);
        }
        public int INT32(string s)
        {
            return Convert.ToInt32(s);
        }
        public Int64 INT64()
        {
            return Convert.ToInt64(Text);
        }
        public Int64 INT64(byte b)
        {
            return Convert.ToInt64(b);
        }
        public Int64 INT64(char c)
        {
            return Convert.ToInt64(c);
        }
        public Int64 INT64(double d)
        {
            return Convert.ToInt64(d);
        }
        public Int64 INT64(string s)
        {
            return Convert.ToInt64(s);
        }
        public string STRING()
        {
            return Convert.ToString(Text);
        }
        public string STRING(byte b)
        {
            return Convert.ToString(b);
        }
        public string STRING(char c)
        {
            return Convert.ToString(c);
        }
        public string STRING(double d)
        {
            return Convert.ToString(d);
        }
        public string STRING(Int16 i)
        {
            return Convert.ToString(i);
        }
        public string STRING(int i)
        {
            return Convert.ToString(i);
        }
        public string STRING(Int64 i)
        {
            return Convert.ToString(i);
        }
        public void addText(int i)
        {
            Text = STRING(i);

        }
    }
}
