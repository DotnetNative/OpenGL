namespace OpenGL;
public class GLContext
{
    public GLContext(nint contextHandle)
    {
        ContextHandle = contextHandle;


    }

    public readonly nint ContextHandle;
}