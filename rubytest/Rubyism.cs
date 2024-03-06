using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rubytest
{
    internal class Rubyism
    {
        [DllImport("x64-msvcrt-ruby300.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ruby_init();

        [DllImport("x64-msvcrt-ruby300.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ruby_finalize();

        [DllImport("x64-msvcrt-ruby300.dll", CharSet=CharSet.Ansi, CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr rb_eval_string(String code);
        // VALUE rb_eval_string(const char* str)
        //void ruby_script(const char* name)
        [DllImport("x64-msvcrt-ruby300.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ruby_script(String scriptname);

        [DllImport("x64-msvcrt-ruby300.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr rb_eval_string_protect(String code, ref int state);

        [DllImport("x64-msvcrt-ruby300.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr rb_errinfo();

        [DllImport("x64-msvcrt-ruby300.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr rb_obj_as_string(IntPtr obj);
    }
}

