using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katSharp.Componets
{
   public abstract class  ConvertirDatos : ConvertirTipoDeDatos
    {
        public abstract byte BYTE();
        
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
        public abstract char CHAR();
        
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
        public abstract double DOUBLE();
        
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
        public abstract Int16 INT16();
       
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
        public abstract int INT32();
       
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
        public abstract Int64 INT64();
        
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
        public abstract string STRING();
        
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
       
    }
}
