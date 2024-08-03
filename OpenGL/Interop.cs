unsafe class Interop
{
    const string kernel = "kernel32";

    [DllImport(kernel)] public static extern
        nint GetModuleHandle(string name);

    [DllImport(kernel)] public static extern
        nint GetProcAddress(nint module, byte* name);

    [DllImport(kernel)] public static extern
        nint LoadLibrary(string dll);
}