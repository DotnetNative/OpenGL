using System.Runtime.InteropServices;

namespace OpenGL;
internal class Interop
{
    const string kernel = "kernel32";

    [DllImport(kernel, CharSet = CharSet.Unicode)] internal static extern 
        nint GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string moduleName);

    [DllImport(kernel, CharSet = CharSet.Ansi, ExactSpelling = true)] internal static extern 
        nint GetProcAddress(nint module, string name);
}