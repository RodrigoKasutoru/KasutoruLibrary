using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katSharp.Componets
{
    public interface ConvertirTipoDeDatos
    {
        byte BYTE();
        byte BYTE(char c);
        byte BYTE(double d);
        byte BYTE(Int16 i);
        byte BYTE(int i);
        byte BYTE(Int64 i);
        byte BYTE(string s);
        char CHAR();
        char CHAR(byte b);
        char CHAR(double d);
        char CHAR(Int16 i);
        char CHAR(int i);
        char CHAR(Int64 i);
        char CHAR(string s);
        double DOUBLE();
        double DOUBLE(byte b);
        double DOUBLE(char c);
        double DOUBLE(Int16 i);
        double DOUBLE(int i);
        double DOUBLE(string s);
        Int16 INT16();
        Int16 INT16(byte b);
        Int16 INT16(char c);
        Int16 INT16(double d);
        Int16 INT16(string s);
        int INT32();
        int INT32(byte b);
        int INT32(char c);
        int INT32(double d);
        int INT32(string s);
        Int64 INT64();
        Int64 INT64(byte b);
        Int64 INT64(char c);
        Int64 INT64(double d);
        Int64 INT64(string s);
        string STRING();
        string STRING(byte b);
        string STRING(char c);
        string STRING(double d);
        string STRING(Int16 i);
        string STRING(int i);
        string STRING(Int64 b);
    }
}
