namespace OpenGL;
class Interop
{
    const string kernel = "kernel32";

    [DllImport(kernel, CharSet = CharSet.Unicode)]
    internal static extern
        nint GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string name);

    [DllImport(kernel, CharSet = CharSet.Ansi, ExactSpelling = true)]
    internal static extern
        nint GetProcAddress(nint module, string name);
}