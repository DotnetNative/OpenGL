using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace OpenGL;
public unsafe static class GL
{
    static GL() => UpdateInterface();

    public static GLInterface* Interface;
    public static void UpdateInterface()
    {
        if (Interface is not null)
            Marshal.FreeCoTaskMem((nint)Interface);

        Interface = (GLInterface*)Marshal.AllocCoTaskMem(sizeof(GLInterface));
        Interface->Init();
    }

    [MethodImpl(AggressiveInlining)] public static void Accum(Op op, float value) => Interface->glAccum(op, value);
    [MethodImpl(AggressiveInlining)] public static void AlphaFunc(Func func, float @ref) => Interface->glAlphaFunc(func, @ref);
    [MethodImpl(AggressiveInlining)]
    public static byte AreTexturesResident(int n, uint[] textures, byte[] residences)
    {
        fixed (uint* texturesPtr = textures)
        fixed (byte* residencesPtr = residences)
            return Interface->glAreTexturesResident(n, texturesPtr, residencesPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static byte AreTexturesResident(int n, uint* textures, byte* residences)
                                        => Interface->glAreTexturesResident(n, textures, residences);
    [MethodImpl(AggressiveInlining)] public static void ArrayElement(int i) => Interface->glArrayElement(i);
    [MethodImpl(AggressiveInlining)] public static void Begin(Mode mode) => Interface->glBegin(mode);
    [MethodImpl(AggressiveInlining)] public static void BindTexture(TexPTarget target, uint texture) => Interface->glBindTexture(target, texture);
    [MethodImpl(AggressiveInlining)]
    public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
    {
        fixed (byte* bitmapPtr = bitmap)
            Interface->glBitmap(width, height, xorig, yorig, xmove, ymove, bitmapPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) 
        => Interface->glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
    [MethodImpl(AggressiveInlining)] public static void BlendFunc(FactorEnum sfactor, FactorEnum dfactor) => Interface->glBlendFunc(sfactor, dfactor);
    [MethodImpl(AggressiveInlining)] public static void CallList(uint list) => Interface->glCallList(list);
    [MethodImpl(AggressiveInlining)] public static void CallLists(int n, Enums.DataType type, pointer lists) => Interface->glCallLists(n, type, lists);
    [MethodImpl(AggressiveInlining)] public static void Clear(uint mask) => Interface->glClear(mask);
    [MethodImpl(AggressiveInlining)] public static void ClearAccum(float red, float green, float blue, float alpha) => Interface->glClearAccum(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void ClearColor(float red, float green, float blue, float alpha) => Interface->glClearColor(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void ClearDepth(double depth) => Interface->glClearDepth(depth);
    [MethodImpl(AggressiveInlining)] public static void ClearIndex(float c) => Interface->glClearIndex(c);
    [MethodImpl(AggressiveInlining)] public static void ClearStencil(int s) => Interface->glClearStencil(s);
    [MethodImpl(AggressiveInlining)]
    public static void ClipPlane(PlaneOrdinal plane, double[] equation)
    {
        fixed (double* equationPtr = equation)
            Interface->glClipPlane(plane, equationPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(sbyte red, sbyte green, sbyte blue) => Interface->glColor3b(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(sbyte* pointer) => Interface->glColor3bv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface->glColor3bv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(double red, double green, double blue) => Interface->glColor3d(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(double* pointer) => Interface->glColor3dv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glColor3dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(float red, float green, float blue) => Interface->glColor3f(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(float* pointer) => Interface->glColor3fv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glColor3fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(int red, int green, int blue) => Interface->glColor3i(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(int* pointer) => Interface->glColor3iv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glColor3iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(short red, short green, short blue) => Interface->glColor3s(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(short* pointer) => Interface->glColor3sv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glColor3sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(byte red, byte green, byte blue) => Interface->glColor3ub(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(byte* pointer) => Interface->glColor3ubv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(byte[] v)
    {
        fixed (byte* vPtr = v)
            Interface->glColor3ubv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(uint red, uint green, uint blue) => Interface->glColor3ui(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(uint* pointer) => Interface->glColor3uiv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(uint[] v)
    {
        fixed (uint* vPtr = v)
            Interface->glColor3uiv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(ushort red, ushort green, ushort blue) => Interface->glColor3us(red, green, blue);
    [MethodImpl(AggressiveInlining)] public static void Color3(ushort* pointer) => Interface->glColor3usv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color3(ushort[] v)
    {
        fixed (ushort* vPtr = v)
            Interface->glColor3usv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(sbyte red, sbyte green, sbyte blue, sbyte alpha) => Interface->glColor4b(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(sbyte* pointer) => Interface->glColor4bv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface->glColor4bv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(double red, double green, double blue, double alpha) => Interface->glColor4d(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(double* pointer) => Interface->glColor4dv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glColor4dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(float red, float green, float blue, float alpha) => Interface->glColor4f(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(float* pointer) => Interface->glColor4fv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glColor4fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(int red, int green, int blue, int alpha) => Interface->glColor4i(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(int* pointer) => Interface->glColor4iv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glColor4iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(short red, short green, short blue, short alpha) => Interface->glColor4s(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(short* pointer) => Interface->glColor4sv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glColor4sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(byte red, byte green, byte blue, byte alpha) => Interface->glColor4ub(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(byte* pointer) => Interface->glColor4ubv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(byte[] v)
    {
        fixed (byte* vPtr = v)
            Interface->glColor4ubv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(uint red, uint green, uint blue, uint alpha) => Interface->glColor4ui(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(uint* pointer) => Interface->glColor4uiv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(uint[] v)
    {
        fixed (uint* vPtr = v)
            Interface->glColor4uiv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Color(ushort red, ushort green, ushort blue, ushort alpha) => Interface->glColor4us(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void Color4(ushort* pointer) => Interface->glColor4usv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Color4(ushort[] v)
    {
        fixed (ushort* vPtr = v)
            Interface->glColor4usv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void ColorMask(byte red, byte green, byte blue, byte alpha) => Interface->glColorMask(red, green, blue, alpha);
    [MethodImpl(AggressiveInlining)] public static void ColorMaterial(FaceEnum face, MaterialParam mode) => Interface->glColorMaterial(face, mode);
    [MethodImpl(AggressiveInlining)] public static void ColorPointer(int size, BType type, int stride, pointer pointer) => Interface->glColorPointer(size, type, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static void CopyPixels(int x, int y, int width, int height, CopyType type) => Interface->glCopyPixels(x, y, width, height, type);
    [MethodImpl(AggressiveInlining)]
    public static void CopyTexImage1D(TexPTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int border)
                                        => Interface->glCopyTexImage1D(target, level, internalFormat, x, y, width, border);
    [MethodImpl(AggressiveInlining)]
    public static void CopyTexImage2D(TexPTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int height, int border)
        => Interface->glCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
    [MethodImpl(AggressiveInlining)]
    public static void CopyTexSubImage1D(TexPTarget target, int level, int xoffset, int x, int y, int width)
        => Interface->glCopyTexSubImage1D(target, level, xoffset, x, y, width);
    [MethodImpl(AggressiveInlining)]
    public static void CopyTexSubImage2D(TexPTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        => Interface->glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
    [MethodImpl(AggressiveInlining)] public static void CullFace(FaceEnum mode) => Interface->glCullFace(mode);
    [MethodImpl(AggressiveInlining)] public static void DeleteLists(uint list, int range) => Interface->glDeleteLists(list, range);
    [MethodImpl(AggressiveInlining)]
    public static void DeleteTextures(int n, uint[] textures)
    {
        fixed (uint* texturesPtr = textures)
            Interface->glDeleteTextures(n, texturesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void DeleteTextures(int n, uint* textures) => Interface->glDeleteTextures(n, textures);
    [MethodImpl(AggressiveInlining)] public static void DepthFunc(Func func) => Interface->glDepthFunc(func);
    [MethodImpl(AggressiveInlining)] public static void DepthMask(byte flag) => Interface->glDepthMask(flag);
    [MethodImpl(AggressiveInlining)] public static void DepthRange(double zNear, double zFar) => Interface->glDepthRange(zNear, zFar);
    [MethodImpl(AggressiveInlining)]
    public static void Set(Cap cap, bool state)
    {
        if (state)
            Interface->glEnable(cap);
        else Interface->glDisable(cap);
    }
    [MethodImpl(AggressiveInlining)] public static void Disable(Cap cap) => Interface->glDisable(cap);
    [MethodImpl(AggressiveInlining)] public static void DisableClientState(ArrayState array) => Interface->glDisableClientState(array);
    [MethodImpl(AggressiveInlining)] public static void DrawArrays(Mode mode, int first, int count) => Interface->glDrawArrays(mode, first, count);
    [MethodImpl(AggressiveInlining)] public static void DrawBuffer(Mode mode) => Interface->glDrawBuffer(mode);
    [MethodImpl(AggressiveInlining)] public static void DrawElements(Mode mode, int count, BUType type, pointer indices) => Interface->glDrawElements(mode, count, type, indices);
    [MethodImpl(AggressiveInlining)]
    public static void DrawPixels(int width, int height, ImageFormat format, BType type, pointer pixels)
        => Interface->glDrawPixels(width, height, format, type, pixels);
    [MethodImpl(AggressiveInlining)] public static void EdgeFlag(byte flag) => Interface->glEdgeFlag(flag);
    [MethodImpl(AggressiveInlining)] public static void EdgeFlagPointer(int stride, pointer pointer) => Interface->glEdgeFlagPointer(stride, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void EdgeFlag(byte[] flag)
    {
        fixed (byte* flagPtr = flag)
            Interface->glEdgeFlagv(flagPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void EdgeFlag(byte* flag) => Interface->glEdgeFlagv(flag);
    [MethodImpl(AggressiveInlining)] public static void Enable(Cap cap) => Interface->glEnable(cap);
    [MethodImpl(AggressiveInlining)] public static void EnableClientState(ArrayState array) => Interface->glEnableClientState(array);
    [MethodImpl(AggressiveInlining)] public static void End() => Interface->glEnd();
    [MethodImpl(AggressiveInlining)] public static void EndList() => Interface->glEndList();
    [MethodImpl(AggressiveInlining)] public static void EvalCoord1(double u) => Interface->glEvalCoord1d(u);
    [MethodImpl(AggressiveInlining)] public static void EvalCoord1(double* pointer) => Interface->glEvalCoord1dv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void EvalCoord1(double[] u)
    {
        fixed (double* uPtr = u)
            Interface->glEvalCoord1dv(uPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void EvalCoord(float u) => Interface->glEvalCoord1f(u);
    [MethodImpl(AggressiveInlining)] public static void EvalCoord1(float* pointer) => Interface->glEvalCoord1fv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void EvalCoord1(float[] u)
    {
        fixed (float* uPtr = u)
            Interface->glEvalCoord1fv(uPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void EvalCoord(double u, double v) => Interface->glEvalCoord2d(u, v);
    [MethodImpl(AggressiveInlining)] public static void EvalCoord2(double* pointer) => Interface->glEvalCoord2dv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void EvalCoord2(double[] u)
    {
        fixed (double* uPtr = u)
            Interface->glEvalCoord2dv(uPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void EvalCoord(float u, float v) => Interface->glEvalCoord2f(u, v);
    [MethodImpl(AggressiveInlining)] public static void EvalCoord2(float* pointer) => Interface->glEvalCoord2fv(pointer);
    [MethodImpl(AggressiveInlining)]
    public static void EvalCoord2(float[] u)
    {
        fixed (float* uPtr = u)
            Interface->glEvalCoord2fv(uPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void EvalMesh(EMesh mode, int i1, int i2) => Interface->glEvalMesh1(mode, i1, i2);
    [MethodImpl(AggressiveInlining)] public static void EvalMesh(MeshType mode, int i1, int i2, int j1, int j2) => Interface->glEvalMesh2(mode, i1, i2, j1, j2);
    [MethodImpl(AggressiveInlining)] public static void EvalPoint(int i) => Interface->glEvalPoint1(i);
    [MethodImpl(AggressiveInlining)] public static void EvalPoint(int i, int j) => Interface->glEvalPoint2(i, j);
    [MethodImpl(AggressiveInlining)]
    public static void FeedbackBuffer(int size, VertexType type, float[] buffer)
    {
        fixed (float* bufferPtr = buffer)
            Interface->glFeedbackBuffer(size, type, bufferPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Finish() => Interface->glFinish();
    [MethodImpl(AggressiveInlining)] public static void Flush() => Interface->glFlush();
    [MethodImpl(AggressiveInlining)] public static void Fogf(Fog pname, float param) => Interface->glFogf(pname, param);
    [MethodImpl(AggressiveInlining)] public static void Fogf(Fog pname, float* pointer) => Interface->glFogfv(pname, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Fogf(Fog pname, float[] @params)
    {
        fixed (float* paramsPtr = @params)
            Interface->glFogfv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Fogi(Fog pname, int param) => Interface->glFogi(pname, param);
    [MethodImpl(AggressiveInlining)] public static void Fogf(Fog pname, int* pointer) => Interface->glFogiv(pname, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void Fogi(Fog pname, int[] @params)
    {
        fixed (int* paramsPtr = @params)
            Interface->glFogiv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void FrontFace(FaceMode mode) => Interface->glFrontFace(mode);
    [MethodImpl(AggressiveInlining)]
    public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
                                         => Interface->glFrustum(left, right, bottom, top, zNear, zFar);
    [MethodImpl(AggressiveInlining)] public static uint GenLists(int range) => Interface->glGenLists(range);
    [MethodImpl(AggressiveInlining)] public static void GenTextures(int n, uint* textures) => Interface->glGenTextures(n, textures);
    [MethodImpl(AggressiveInlining)]
    public static void GenTextures(int n, uint[] textures)
    {
        fixed (uint* texturesPtr = textures)
            Interface->glGenTextures(n, texturesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetBoolean(PName pname, byte* @params) => Interface->glGetBooleanv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetBoolean(PName pname, byte[] @params)
    {
        fixed (byte* @paramsPtr = @params)
            Interface->glGetBooleanv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void GetClipPlane(PlaneOrdinal plane, double[] equation)
    {
        fixed (double* equationPtr = equation)
            Interface->glGetClipPlane(plane, equationPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetDouble(PName pname, double* @params) => Interface->glGetDoublev(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetDouble(PName pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface->glGetDoublev(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static Error GetError() => Interface->glGetError();
    [MethodImpl(AggressiveInlining)] public static void GetFloat(PName pname, float* @params) => Interface->glGetFloatv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetFloat(PName pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetFloatv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetInteger(PName pname, int* @params) => Interface->glGetIntegerv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetInteger(PName pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetIntegerv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetLight(LightOrdinal light, LightN pname, float* @params) => Interface->glGetLightfv(light, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetLight(LightOrdinal light, LightN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetLightfv(light, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetLight(LightOrdinal light, LightN pname, int* @params) => Interface->glGetLightiv(light, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetLight(LightOrdinal light, LightN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetLightiv(light, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetMap(MapTarget target, QueryType query, double* pointer) => Interface->glGetMapdv(target, query, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetMap(MapTarget target, QueryType query, double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glGetMapdv(target, query, vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetMap(MapTarget target, QueryType query, float* pointer) => Interface->glGetMapfv(target, query, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetMap(MapTarget target, QueryType query, float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glGetMapfv(target, query, vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetMap(MapTarget target, QueryType query, int* pointer) => Interface->glGetMapiv(target, query, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetMap(MapTarget target, QueryType query, int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glGetMapiv(target, query, vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetMaterial(SideEnum face, MaterialParam pname, float* pointer) => Interface->glGetMaterialfv(face, pname, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetMaterial(SideEnum face, MaterialParam pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetMaterialfv(face, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetMaterial(SideEnum face, MaterialParam pname, int* pointer) => Interface->glGetMaterialiv(face, pname, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetMaterial(SideEnum face, MaterialParam pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetMaterialiv(face, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetPixelMap(MapType map, float* pointer) => Interface->glGetPixelMapfv(map, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetPixelMap(MapType map, float[] values)
    {
        fixed (float* valuesPtr = values)
            Interface->glGetPixelMapfv(map, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetPixelMap(MapType map, uint* pointer) => Interface->glGetPixelMapuiv(map, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetPixelMap(MapType map, uint[] values)
    {
        fixed (uint* valuesPtr = values)
            Interface->glGetPixelMapuiv(map, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetPixelMap(MapType map, ushort* pointer) => Interface->glGetPixelMapusv(map, pointer);
    [MethodImpl(AggressiveInlining)]
    public static void GetPixelMap(MapType map, ushort[] values)
    {
        fixed (ushort* valuesPtr = values)
            Interface->glGetPixelMapusv(map, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetPointer(PNamePtr pname, pointer* @params) => Interface->glGetPointerv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetPointer(PNamePtr pname, pointer[] @params)
    {
        fixed (pointer* @paramsPtr = @params)
            Interface->glGetPointerv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetPolygonStipple(byte* mask) => Interface->glGetPolygonStipple(mask);
    [MethodImpl(AggressiveInlining)]
    public static void GetPolygonStipple(byte[] mask)
    {
        fixed (byte* maskPtr = mask)
            Interface->glGetPolygonStipple(maskPtr);
    }
    [MethodImpl(AggressiveInlining)] public static byte* GetString(StringName name) => Interface->glGetString(name);
    [MethodImpl(AggressiveInlining)] public static void GetTexEnv(TexEnvN pname, float* @params) => Interface->glGetTexEnvfv(TextureEnv, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexEnv(TexEnvN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetTexEnvfv(TextureEnv, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexEnv(TexEnvN pname, int* @params) => Interface->glGetTexEnviv(TextureEnv, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexEnv(TexEnvN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetTexEnviv(TextureEnv, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexGen(CoordsEnum coord, TexGenN pname, double* @params) => Interface->glGetTexGendv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexGen(CoordsEnum coord, TexGenN pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface->glGetTexGendv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexGen(CoordsEnum coord, TexGenN pname, float* @params) => Interface->glGetTexGenfv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexGen(CoordsEnum coord, TexGenN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetTexGenfv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexGen(CoordsEnum coord, TexGenN pname, int* @params) => Interface->glGetTexGeniv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexGen(CoordsEnum coord, TexGenN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetTexGeniv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexImage(TexTarget target, int level, ImagePixelType format, BType type, pointer pixels) => Interface->glGetTexImage(target, level, format, type, pixels);
    [MethodImpl(AggressiveInlining)] public static void GetTexLevelParameter(TexPTarget target, int level, TexN pname, float* @params) => Interface->glGetTexLevelParameterfv(target, level, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexLevelParameter(TexPTarget target, int level, TexN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetTexLevelParameterfv(target, level, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexLevelParameter(TexPTarget target, int level, TexN pname, int* @params) => Interface->glGetTexLevelParameteriv(target, level, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexLevelParameter(TexPTarget target, int level, TexN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetTexLevelParameteriv(target, level, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexParameter(TexTarget target, TexNV pname, float* @params) => Interface->glGetTexParameterfv(target, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexParameter(TexTarget target, TexNV pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glGetTexParameterfv(target, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void GetTexParameter(TexTarget target, TexNV pname, int* @params) => Interface->glGetTexParameteriv(target, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void GetTexParameter(TexTarget target, TexNV pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glGetTexParameteriv(target, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Hint(Hint target, CalcType mode) => Interface->glHint(target, mode);
    [MethodImpl(AggressiveInlining)] public static void IndexMask(uint mask) => Interface->glIndexMask(mask);
    [MethodImpl(AggressiveInlining)] public static void IndexPointer(TexType type, int stride, pointer pointer) => Interface->glIndexPointer(type, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static void Index(double c) => Interface->glIndexd(c);
    [MethodImpl(AggressiveInlining)] public static void Index(double* c) => Interface->glIndexdv(c);
    [MethodImpl(AggressiveInlining)]
    public static void Index(double[] c)
    {
        fixed (double* cPtr = c)
            Interface->glIndexdv(cPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Index(float* c) => Interface->glIndexfv(c);
    [MethodImpl(AggressiveInlining)] public static void Index(float c) => Interface->glIndexf(c);
    [MethodImpl(AggressiveInlining)]
    public static void Index(float[] c)
    {
        fixed (float* cPtr = c)
            Interface->glIndexfv(cPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Index(int c) => Interface->glIndexi(c);
    [MethodImpl(AggressiveInlining)] public static void Index(int* c) => Interface->glIndexiv(c);
    [MethodImpl(AggressiveInlining)]
    public static void Index(int[] c)
    {
        fixed (int* cPtr = c)
            Interface->glIndexiv(cPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Index(short c) => Interface->glIndexs(c);
    [MethodImpl(AggressiveInlining)] public static void Index(short* c) => Interface->glIndexsv(c);
    [MethodImpl(AggressiveInlining)]
    public static void Index(short[] c)
    {
        fixed (short* cPtr = c)
            Interface->glIndexsv(cPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Index(byte c) => Interface->glIndexub(c);
    [MethodImpl(AggressiveInlining)] public static void Index(byte* c) => Interface->glIndexubv(c);
    [MethodImpl(AggressiveInlining)]
    public static void Index(byte[] c)
    {
        fixed (byte* cPtr = c)
            Interface->glIndexubv(cPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void InitNames() => Interface->glInitNames();
    [MethodImpl(AggressiveInlining)] public static void InterleavedArrays(ArrayFormat format, int stride, pointer pointer) => Interface->glInterleavedArrays(format, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static bool IsEnabled(Cap cap) => Interface->glIsEnabled(cap) == 1;
    [MethodImpl(AggressiveInlining)] public static byte IsList(uint list) => Interface->glIsList(list);
    [MethodImpl(AggressiveInlining)] public static byte IsTexture(uint texture) => Interface->glIsTexture(texture);
    [MethodImpl(AggressiveInlining)] public static void LightModel(LightModel pname, float param) => Interface->glLightModelf(pname, param);
    [MethodImpl(AggressiveInlining)] public static void LightModel(LightModel pname, float* @params) => Interface->glLightModelfv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void LightModel(LightModel pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glLightModelfv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void LightModel(LightModel pname, int param) => Interface->glLightModeli(pname, param);
    [MethodImpl(AggressiveInlining)] public static void LightModel(LightModel pname, int* @params) => Interface->glLightModeliv(pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void LightModel(LightModel pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glLightModeliv(pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Light(LightOrdinal light, LightN pname, float param) => Interface->glLightf(light, pname, param);
    [MethodImpl(AggressiveInlining)] public static void Light(LightOrdinal light, LightN pname, float* @params) => Interface->glLightfv(light, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void Light(LightOrdinal light, LightN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glLightfv(light, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Light(LightOrdinal light, LightN pname, int param) => Interface->glLighti(light, pname, param);
    [MethodImpl(AggressiveInlining)] public static void Light(LightOrdinal light, LightN pname, int* @params) => Interface->glLightiv(light, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void Light(LightOrdinal light, LightN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glLightiv(light, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void LineStipple(int factor, ushort pattern) => Interface->glLineStipple(factor, pattern);
    [MethodImpl(AggressiveInlining)] public static void LineWidth(float width) => Interface->glLineWidth(width);
    [MethodImpl(AggressiveInlining)] public static void ListBase(uint @base) => Interface->glListBase(@base);
    [MethodImpl(AggressiveInlining)] public static void LoadIdentity() => Interface->glLoadIdentity();
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(double[] m)
    {
        fixed (double* mPtr = m)
            Interface->glLoadMatrixd(mPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void LoadMatrix(double* m) => Interface->glLoadMatrixd(m);
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(MatrixType mode, double* m)
    {
        Interface->glMatrixMode(mode);
        Interface->glLoadMatrixd(m);
    }
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(MatrixType mode, double[] m)
    {
        Interface->glMatrixMode(mode);
        fixed (double* mPtr = m)
            Interface->glLoadMatrixd(mPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void LoadModelview(double* m) => LoadMatrix(MatrixType.Modelview, m);
    [MethodImpl(AggressiveInlining)] public static void LoadProjection(double* m) => LoadMatrix(MatrixType.Projection, m);
    [MethodImpl(AggressiveInlining)]
    public static double[] LoadModelviewd()
    {
        var m = new double[16];
        fixed (double* mPtr = m)
            LoadModelview(mPtr);
        return m;
    }
    [MethodImpl(AggressiveInlining)]
    public static double[] LoadProjectiond()
    {
        var m = new double[16];
        fixed (double* mPtr = m)
            LoadProjection(mPtr);
        return m;
    }
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(float[] m)
    {
        fixed (float* mPtr = m)
            Interface->glLoadMatrixf(mPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void LoadMatrix(float* m) => Interface->glLoadMatrixf(m);
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(MatrixType mode, float* m)
    {
        Interface->glMatrixMode(mode);
        Interface->glLoadMatrixf(m);
    }
    [MethodImpl(AggressiveInlining)]
    public static void LoadMatrix(MatrixType mode, float[] m)
    {
        Interface->glMatrixMode(mode);
        fixed (float* mPtr = m)
            Interface->glLoadMatrixf(mPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static float[] LoadModelviewf()
    {
        var m = new float[16];
        fixed (float* mPtr = m)
            LoadModelview(mPtr);
        return m;
    }
    [MethodImpl(AggressiveInlining)]
    public static float[] LoadProjectionf()
    {
        var m = new float[16];
        fixed (float* mPtr = m)
            LoadProjection(mPtr);
        return m;
    }
    [MethodImpl(AggressiveInlining)] public static void LoadModelview(float* m) => LoadMatrix(MatrixType.Modelview, m);
    [MethodImpl(AggressiveInlining)] public static void LoadProjection(float* m) => LoadMatrix(MatrixType.Projection, m);
    [MethodImpl(AggressiveInlining)] public static void LoadName(uint name) => Interface->glLoadName(name);
    [MethodImpl(AggressiveInlining)] public static void LogicOp(OpCode opcode) => Interface->glLogicOp(opcode);
    [MethodImpl(AggressiveInlining)] public static void Map(Map1Target target, double u1, double u2, int stride, int order, double* points) => Interface->glMap1d(target, u1, u2, stride, order, points);
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, double u1, double u2, int stride, int order, double[] points)
    {
        fixed (double* pointsPtr = points)
            Interface->glMap1d(target, u1, u2, stride, order, pointsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Map(Map1Target target, float u1, float u2, int stride, int order, float* points) => Interface->glMap1f(target, u1, u2, stride, order, points);
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, float u1, float u2, int stride, int order, float[] points)
    {
        fixed (float* pointsPtr = points)
            Interface->glMap1f(target, u1, u2, stride, order, pointsPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
        => Interface->glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
    {
        fixed (double* pointsPtr = points)
            Interface->glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
        => Interface->glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
    [MethodImpl(AggressiveInlining)]
    public static void Map(Map1Target target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
    {
        fixed (float* pointsPtr = points)
            Interface->glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void MapGrid(int un, double u1, double u2) => Interface->glMapGrid1d(un, u1, u2);
    [MethodImpl(AggressiveInlining)] public static void MapGrid(int un, float u1, float u2) => Interface->glMapGrid1f(un, u1, u2);
    [MethodImpl(AggressiveInlining)] public static void MapGrid(int un, double u1, double u2, int vn, double v1, double v2) => Interface->glMapGrid2d(un, u1, u2, vn, v1, v2);
    [MethodImpl(AggressiveInlining)] public static void MapGrid(int un, float u1, float u2, int vn, float v1, float v2) => Interface->glMapGrid2f(un, u1, u2, vn, v1, v2);
    [MethodImpl(AggressiveInlining)] public static void Material(SideEnum face, float param) => Interface->glMaterialf(face, Shininess, param);
    [MethodImpl(AggressiveInlining)] public static void Material(SideEnum face, MaterialParam pname, float* @params) => Interface->glMaterialfv(face, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void Material(SideEnum face, MaterialParam pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glMaterialfv(face, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Material(SideEnum face, MaterialParam pname, int param) => Interface->glMateriali(face, pname, param);
    [MethodImpl(AggressiveInlining)] public static void Material(SideEnum face, MaterialParam pname, int* @params) => Interface->glMaterialiv(face, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void Material(SideEnum face, MaterialParam pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glMaterialiv(face, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void MatrixMode(MatrixType mode) => Interface->glMatrixMode(mode);
    [MethodImpl(AggressiveInlining)] public static void MultMatrix(double* m) => Interface->glMultMatrixd(m);
    [MethodImpl(AggressiveInlining)]
    public static void MultMatrix(double[] m)
    {
        fixed (double* mPtr = m)
            Interface->glMultMatrixd(mPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void MultMatrix(float* m) => Interface->glMultMatrixf(m);
    [MethodImpl(AggressiveInlining)]
    public static void MultMatrix(float[] m)
    {
        fixed (float* mPtr = m)
            Interface->glMultMatrixf(mPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void NewList(uint list, CompileState mode) => Interface->glNewList(list, mode);
    [MethodImpl(AggressiveInlining)] public static void Normal(sbyte nx, sbyte ny, sbyte nz) => Interface->glNormal3b(nx, ny, nz);
    [MethodImpl(AggressiveInlining)] public static void Normal3(sbyte* v) => Interface->glNormal3bv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Normal3(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface->glNormal3bv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Normal(double nx, double ny, double nz) => Interface->glNormal3d(nx, ny, nz);
    [MethodImpl(AggressiveInlining)] public static void Normal3(double* v) => Interface->glNormal3dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Normal3(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glNormal3dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Normal(float nx, float ny, float nz) => Interface->glNormal3f(nx, ny, nz);
    [MethodImpl(AggressiveInlining)] public static void Normal3(float* v) => Interface->glNormal3fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Normal3(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glNormal3fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Normal(int nx, int ny, int nz) => Interface->glNormal3i(nx, ny, nz);
    [MethodImpl(AggressiveInlining)] public static void Normal3(int* v) => Interface->glNormal3iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Normal3(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glNormal3iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Normal(short nx, short ny, short nz) => Interface->glNormal3s(nx, ny, nz);
    [MethodImpl(AggressiveInlining)] public static void Normal3(short* v) => Interface->glNormal3sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Normal3(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glNormal3sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void NormalPointer(PtrType type, int stride, pointer pointer) => Interface->glNormalPointer(type, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar) => Interface->glOrtho(left, right, bottom, top, zNear, zFar);
    [MethodImpl(AggressiveInlining)] public static void PassThrough(float token) => Interface->glPassThrough(token);
    [MethodImpl(AggressiveInlining)] public static void PixelMap(MapType map, int mapsize, float* values) => Interface->glPixelMapfv(map, mapsize, values);
    [MethodImpl(AggressiveInlining)]
    public static void PixelMap(MapType map, int mapsize, float[] values)
    {
        fixed (float* valuesPtr = values)
            Interface->glPixelMapfv(map, mapsize, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void PixelMap(MapType map, int mapsize, uint* values) => Interface->glPixelMapuiv(map, mapsize, values);
    [MethodImpl(AggressiveInlining)]
    public static void PixelMap(MapType map, int mapsize, uint[] values)
    {
        fixed (uint* valuesPtr = values)
            Interface->glPixelMapuiv(map, mapsize, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void PixelMapu(MapType map, int mapsize, ushort* values) => Interface->glPixelMapusv(map, mapsize, values);
    [MethodImpl(AggressiveInlining)]
    public static void PixelMapu(MapType map, int mapsize, ushort[] values)
    {
        fixed (ushort* valuesPtr = values)
            Interface->glPixelMapusv(map, mapsize, valuesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void PixelStore(StoreN pname, float param) => Interface->glPixelStoref(pname, param);
    [MethodImpl(AggressiveInlining)] public static void PixelStore(StoreN pname, int param) => Interface->glPixelStorei(pname, param);
    [MethodImpl(AggressiveInlining)] public static void PixelTransfer(TransferN pname, float param) => Interface->glPixelTransferf(pname, param);
    [MethodImpl(AggressiveInlining)] public static void PixelTransfer(TransferN pname, int param) => Interface->glPixelTransferi(pname, param);
    [MethodImpl(AggressiveInlining)] public static void PixelZoom(float xfactor, float yfactor) => Interface->glPixelZoom(xfactor, yfactor);
    [MethodImpl(AggressiveInlining)] public static void PointSize(float size) => Interface->glPointSize(size);
    [MethodImpl(AggressiveInlining)] public static void PolygonMode(MaterialFace face, MeshType mode) => Interface->glPolygonMode(face, mode);
    [MethodImpl(AggressiveInlining)] public static void PolygonOffset(float factor, float units) => Interface->glPolygonOffset(factor, units);
    [MethodImpl(AggressiveInlining)] public static void PolygonStipple(byte* mask) => Interface->glPolygonStipple(mask);
    [MethodImpl(AggressiveInlining)]
    public static void PolygonStipple(byte[] mask)
    {
        fixed (byte* maskPtr = mask)
            Interface->glPolygonStipple(maskPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void PopAttrib() => Interface->glPopAttrib();
    [MethodImpl(AggressiveInlining)] public static void PopClientAttrib() => Interface->glPopClientAttrib();
    [MethodImpl(AggressiveInlining)] public static void PopMatrix() => Interface->glPopMatrix();
    [MethodImpl(AggressiveInlining)] public static void PopName() => Interface->glPopName();
    [MethodImpl(AggressiveInlining)] public static void PrioritizeTextures(int n, uint* textures, float* priorities) => Interface->glPrioritizeTextures(n, textures, priorities);
    [MethodImpl(AggressiveInlining)]
    public static void PrioritizeTextures(int n, uint[] textures, float[] priorities)
    {
        fixed (uint* texturesPtr = textures)
        fixed (float* prioritiesPtr = priorities)
            Interface->glPrioritizeTextures(n, texturesPtr, prioritiesPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void PushAttrib(uint mask) => Interface->glPushAttrib(mask);
    [MethodImpl(AggressiveInlining)] public static void PushClientAttrib(uint mask) => Interface->glPushClientAttrib(mask);
    [MethodImpl(AggressiveInlining)] public static void PushMatrix() => Interface->glPushMatrix();
    [MethodImpl(AggressiveInlining)] public static void PushName(uint name) => Interface->glPushName(name);
    [MethodImpl(AggressiveInlining)] public static void RasterPos(double x, double y) => Interface->glRasterPos2d(x, y);
    [MethodImpl(AggressiveInlining)] public static void RasterPos2(double* v) => Interface->glRasterPos2dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos2(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glRasterPos2dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(float x, float y) => Interface->glRasterPos2f(x, y);
    [MethodImpl(AggressiveInlining)] public static void RasterPos2(float* v) => Interface->glRasterPos2fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos2(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glRasterPos2fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(int x, int y) => Interface->glRasterPos2i(x, y);
    [MethodImpl(AggressiveInlining)] public static void RasterPos2(int* v) => Interface->glRasterPos2iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos2(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glRasterPos2iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(short x, short y) => Interface->glRasterPos2s(x, y);
    [MethodImpl(AggressiveInlining)] public static void RasterPos2(short* v) => Interface->glRasterPos2sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos2(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glRasterPos2sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(double x, double y, double z) => Interface->glRasterPos3d(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void RasterPos3(double* v) => Interface->glRasterPos3dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos3(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glRasterPos3dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(float x, float y, float z) => Interface->glRasterPos3f(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void RasterPos3(float* v) => Interface->glRasterPos3fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos3(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glRasterPos3fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(int x, int y, int z) => Interface->glRasterPos3i(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void RasterPos3(int* v) => Interface->glRasterPos3iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos3(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glRasterPos3iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(short x, short y, short z) => Interface->glRasterPos3s(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void RasterPos3(short* v) => Interface->glRasterPos3sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos3(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glRasterPos3sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(double x, double y, double z, double w) => Interface->glRasterPos4d(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void RasterPos4(double* v) => Interface->glRasterPos4dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos4(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glRasterPos4dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(float x, float y, float z, float w) => Interface->glRasterPos4f(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void RasterPos4(float* v) => Interface->glRasterPos4fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos4(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glRasterPos4fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(int x, int y, int z, int w) => Interface->glRasterPos4i(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void RasterPos4(int* v) => Interface->glRasterPos4iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos4(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glRasterPos4iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void RasterPos(short x, short y, short z, short w) => Interface->glRasterPos4s(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void RasterPos4(short* v) => Interface->glRasterPos4sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void RasterPos4(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glRasterPos4sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void ReadBuffer(BufType mode) => Interface->glReadBuffer(mode);
    [MethodImpl(AggressiveInlining)] public static void ReadPixels(int x, int y, int width, int height, ImagePixelType format, ReadType type, pointer pixels) => Interface->glReadPixels(x, y, width, height, format, type, pixels);
    [MethodImpl(AggressiveInlining)] public static void Rect(double x1, double y1, double x2, double y2) => Interface->glRectd(x1, y1, x2, y2);
    [MethodImpl(AggressiveInlining)] public static void Rect(double* v1, double* v2) => Interface->glRectdv(v1, v2);
    [MethodImpl(AggressiveInlining)]
    public static void Rect(double[] v1, double[] v2)
    {
        fixed (double* v1Ptr = v1)
        fixed (double* v2Ptr = v2)
            Interface->glRectdv(v1Ptr, v2Ptr);
    }
    [MethodImpl(AggressiveInlining)] public static void Rect(float x1, float y1, float x2, float y2) => Interface->glRectf(x1, y1, x2, y2);
    [MethodImpl(AggressiveInlining)] public static void Rect(float* v1, float* v2) => Interface->glRectfv(v1, v2);
    [MethodImpl(AggressiveInlining)]
    public static void Rect(float[] v1, float[] v2)
    {
        fixed (float* v1Ptr = v1)
        fixed (float* v2Ptr = v2)
            Interface->glRectfv(v1Ptr, v2Ptr);
    }
    [MethodImpl(AggressiveInlining)] public static void Rect(int x1, int y1, int x2, int y2) => Interface->glRecti(x1, y1, x2, y2);
    [MethodImpl(AggressiveInlining)] public static void Rect(int* v1, int* v2) => Interface->glRectiv(v1, v2);
    [MethodImpl(AggressiveInlining)]
    public static void Rect(int[] v1, int[] v2)
    {
        fixed (int* v1Ptr = v1)
        fixed (int* v2Ptr = v2)
            Interface->glRectiv(v1Ptr, v2Ptr);
    }
    [MethodImpl(AggressiveInlining)] public static void Rect(short x1, short y1, short x2, short y2) => Interface->glRects(x1, y1, x2, y2);
    [MethodImpl(AggressiveInlining)] public static void Rect(short* v1, short* v2) => Interface->glRectsv(v1, v2);
    [MethodImpl(AggressiveInlining)]
    public static void Rect(short[] v1, short[] v2)
    {
        fixed (short* v1Ptr = v1)
        fixed (short* v2Ptr = v2)
            Interface->glRectsv(v1Ptr, v2Ptr);
    }
    [MethodImpl(AggressiveInlining)] public static int RenderMode(RenderEnum mode) => Interface->glRenderMode(mode);
    [MethodImpl(AggressiveInlining)] public static void Rotate(double angle, double x, double y, double z) => Interface->glRotated(angle, x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Rotate(float angle, float x, float y, float z) => Interface->glRotatef(angle, x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Scale(double x, double y, double z) => Interface->glScaled(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Scale(float x, float y, float z) => Interface->glScalef(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Scissor(int x, int y, int width, int height) => Interface->glScissor(x, y, width, height);
    [MethodImpl(AggressiveInlining)] public static void SelectBuffer(int size, uint* buffer) => Interface->glSelectBuffer(size, buffer);
    [MethodImpl(AggressiveInlining)]
    public static void SelectBuffer(int size, uint[] buffer)
    {
        fixed (uint* bufferPtr = buffer)
            Interface->glSelectBuffer(size, bufferPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void ShadeModel(FillType mode) => Interface->glShadeModel(mode);
    [MethodImpl(AggressiveInlining)] public static void StencilFunc(Func func, int @ref, uint mask) => Interface->glStencilFunc(func, @ref, mask);
    [MethodImpl(AggressiveInlining)] public static void StencilMask(uint mask) => Interface->glStencilMask(mask);
    [MethodImpl(AggressiveInlining)] public static void StencilOp(FailType fail, FailType zfail, FailType zpass) => Interface->glStencilOp(fail, zfail, zpass);
    [MethodImpl(AggressiveInlining)] public static void TexCoord(double s) => Interface->glTexCoord1d(s);
    [MethodImpl(AggressiveInlining)] public static void TexCoord1(double* v) => Interface->glTexCoord1dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord1(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glTexCoord1dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(float s) => Interface->glTexCoord1f(s);
    [MethodImpl(AggressiveInlining)] public static void TexCoord1(float* v) => Interface->glTexCoord1fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord1(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glTexCoord1fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(int s) => Interface->glTexCoord1i(s);
    [MethodImpl(AggressiveInlining)] public static void TexCoord1(int* v) => Interface->glTexCoord1iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord1(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glTexCoord1iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(short s) => Interface->glTexCoord1s(s);
    [MethodImpl(AggressiveInlining)] public static void TexCoord1(short* v) => Interface->glTexCoord1sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord1(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glTexCoord1sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(double s, double t) => Interface->glTexCoord2d(s, t);
    [MethodImpl(AggressiveInlining)] public static void TexCoord2(double* v) => Interface->glTexCoord2dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord2(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glTexCoord2dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(float s, float t) => Interface->glTexCoord2f(s, t);
    [MethodImpl(AggressiveInlining)] public static void TexCoord2(float* v) => Interface->glTexCoord2fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord2(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glTexCoord2fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(int s, int t) => Interface->glTexCoord2i(s, t);
    [MethodImpl(AggressiveInlining)] public static void TexCoord2(int* v) => Interface->glTexCoord2iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord2(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glTexCoord2iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(short s, short t) => Interface->glTexCoord2s(s, t);
    [MethodImpl(AggressiveInlining)] public static void TexCoord2(short* v) => Interface->glTexCoord2sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord2(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glTexCoord2sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(double s, double t, double r) => Interface->glTexCoord3d(s, t, r);
    [MethodImpl(AggressiveInlining)] public static void TexCoord3(double* v) => Interface->glTexCoord3dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord3(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glTexCoord3dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(float s, float t, float r) => Interface->glTexCoord3f(s, t, r);
    [MethodImpl(AggressiveInlining)] public static void TexCoord3(float* v) => Interface->glTexCoord3fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord3(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glTexCoord3fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(int s, int t, int r) => Interface->glTexCoord3i(s, t, r);
    [MethodImpl(AggressiveInlining)] public static void TexCoord3(int* v) => Interface->glTexCoord3iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord3(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glTexCoord3iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(short s, short t, short r) => Interface->glTexCoord3s(s, t, r);
    [MethodImpl(AggressiveInlining)] public static void TexCoord3(short* v) => Interface->glTexCoord3sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord3(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glTexCoord3sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(double s, double t, double r, double q) => Interface->glTexCoord4d(s, t, r, q);
    [MethodImpl(AggressiveInlining)] public static void TexCoord4(double* v) => Interface->glTexCoord4dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord4(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glTexCoord4dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(float s, float t, float r, float q) => Interface->glTexCoord4f(s, t, r, q);
    [MethodImpl(AggressiveInlining)] public static void TexCoord4(float* v) => Interface->glTexCoord4fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord4(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glTexCoord4fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(int s, int t, int r, int q) => Interface->glTexCoord4i(s, t, r, q);
    [MethodImpl(AggressiveInlining)] public static void TexCoord4(int* v) => Interface->glTexCoord4iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord4(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glTexCoord4iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoord(short s, short t, short r, short q) => Interface->glTexCoord4s(s, t, r, q);
    [MethodImpl(AggressiveInlining)] public static void TexCoord4(short* v) => Interface->glTexCoord4sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void TexCoord4(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glTexCoord4sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexCoordPointer(int size, TexType type, int stride, pointer pointer) => Interface->glTexCoordPointer(size, type, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static void TexEnv(TexEnvN pname, float param) => Interface->glTexEnvf(TextureEnv, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexEnv(TexEnvN pname, float* @params) => Interface->glTexEnvfv(TextureEnv, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexEnv(TexEnvN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glTexEnvfv(TextureEnv, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexEnv(TexEnvN pname, int param) => Interface->glTexEnvi(TextureEnv, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexEnv(TexEnvN pname, int* @params) => Interface->glTexEnviv(TextureEnv, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexEnv(TexEnvN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glTexEnviv(TextureEnv, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, double param) => Interface->glTexGend(coord, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, double* @params) => Interface->glTexGendv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexGen(CoordsEnum coord, TexGen pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface->glTexGendv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, float param) => Interface->glTexGenf(coord, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, float* @params) => Interface->glTexGenfv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexGen(CoordsEnum coord, TexGen pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glTexGenfv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, int param) => Interface->glTexGeni(coord, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexGen(CoordsEnum coord, TexGen pname, int* @params) => Interface->glTexGeniv(coord, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexGen(CoordsEnum coord, TexGen pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glTexGeniv(coord, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void TexImage(int level, InternalFormat internalformat, int width, int border, ImageFormat format, ImageType type, pointer pixels)
        => Interface->glTexImage1D(TexPTarget.Texture1D, level, internalformat, width, border, format, type, pixels);
    [MethodImpl(AggressiveInlining)]
    public static void TexImage(int level, InternalFormat internalformat, int width, int height, int border, ImageFormat format, ImageType type, pointer pixels)
        => Interface->glTexImage2D(TexPTarget.Texture2D, level, internalformat, width, height, border, format, type, pixels);
    [MethodImpl(AggressiveInlining)] public static void TexParameter(TexTarget target, TexNV2 pname, float param) => Interface->glTexParameterf(target, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexParameter(TexTarget target, TexNV2 pname, float* @params) => Interface->glTexParameterfv(target, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexParameter(TexTarget target, TexNV2 pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface->glTexParameterfv(target, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void TexParameter(TexTarget target, TexNV2 pname, int param) => Interface->glTexParameteri(target, pname, param);
    [MethodImpl(AggressiveInlining)] public static void TexParameter(TexTarget target, TexNV2 pname, int* @params) => Interface->glTexParameteriv(target, pname, @params);
    [MethodImpl(AggressiveInlining)]
    public static void TexParameter(TexTarget target, TexNV2 pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface->glTexParameteriv(target, pname, @paramsPtr);
    }
    [MethodImpl(AggressiveInlining)]
    public static void TexSubImage(int level, int xoffset, int width, ImageFormat format, ImageType type, pointer pixels)
        => Interface->glTexSubImage1D((int)TexTarget.Texture1D, level, xoffset, width, format, type, pixels);
    [MethodImpl(AggressiveInlining)]
    public static void TexSubImage(int level, int xoffset, int yoffset, int width, int height, ImageFormat format, ImageType type, pointer pixels)
        => Interface->glTexSubImage2D((int)TexTarget.Texture2D, level, xoffset, yoffset, width, height, format, type, pixels);
    [MethodImpl(AggressiveInlining)] public static void Translate(double x, double y, double z) => Interface->glTranslated(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Translate(float x, float y, float z) => Interface->glTranslatef(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Vertex(double x, double y) => Interface->glVertex2d(x, y);
    [MethodImpl(AggressiveInlining)] public static void Vertex2(double* v) => Interface->glVertex2dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex2(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glVertex2dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(float x, float y) => Interface->glVertex2f(x, y);
    [MethodImpl(AggressiveInlining)] public static void Vertex2(float* v) => Interface->glVertex2fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex2(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glVertex2fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(int x, int y) => Interface->glVertex2i(x, y);
    [MethodImpl(AggressiveInlining)] public static void Vertex2(int* v) => Interface->glVertex2iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex2(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glVertex2iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(short x, short y) => Interface->glVertex2s(x, y);
    [MethodImpl(AggressiveInlining)] public static void Vertex2(short* v) => Interface->glVertex2sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex2(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glVertex2sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(double x, double y, double z) => Interface->glVertex3d(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Vertex3(double* v) => Interface->glVertex3dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex3(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glVertex3dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(float x, float y, float z) => Interface->glVertex3f(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Vertex3(float* v) => Interface->glVertex3fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex3(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glVertex3fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(int x, int y, int z) => Interface->glVertex3i(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Vertex3(int* v) => Interface->glVertex3iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex3(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glVertex3iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(short x, short y, short z) => Interface->glVertex3s(x, y, z);
    [MethodImpl(AggressiveInlining)] public static void Vertex3(short* v) => Interface->glVertex3sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex3(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glVertex3sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(double x, double y, double z, double w) => Interface->glVertex4d(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void Vertex4(double* v) => Interface->glVertex4dv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex4(double[] v)
    {
        fixed (double* vPtr = v)
            Interface->glVertex4dv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(float x, float y, float z, float w) => Interface->glVertex4f(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void Vertex4(float* v) => Interface->glVertex4fv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex4(float[] v)
    {
        fixed (float* vPtr = v)
            Interface->glVertex4fv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(int x, int y, int z, int w) => Interface->glVertex4i(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void Vertex4(int* v) => Interface->glVertex4iv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex4(int[] v)
    {
        fixed (int* vPtr = v)
            Interface->glVertex4iv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void Vertex(short x, short y, short z, short w) => Interface->glVertex4s(x, y, z, w);
    [MethodImpl(AggressiveInlining)] public static void Vertex4(short* v) => Interface->glVertex4sv(v);
    [MethodImpl(AggressiveInlining)]
    public static void Vertex4(short[] v)
    {
        fixed (short* vPtr = v)
            Interface->glVertex4sv(vPtr);
    }
    [MethodImpl(AggressiveInlining)] public static void VertexPointer(int size, TexType type, int stride, pointer pointer) => Interface->glVertexPointer(size, type, stride, pointer);
    [MethodImpl(AggressiveInlining)] public static void Viewport(int x, int y, int width, int height) => Interface->glViewport(x, y, width, height);

    /* wgl flavor-functions */
    [MethodImpl(AggressiveInlining)] public static bool CopyContext(nint source, nint dest, uint mask) => Interface->wglCopyContext(source, dest, mask);
    [MethodImpl(AggressiveInlining)] public static nint CreateContext(nint hdc) => Interface->wglCreateContext(hdc);
    [MethodImpl(AggressiveInlining)] public static nint CreateLayerContext(nint hdc, int layerPlane) => Interface->wglCreateLayerContext(hdc, layerPlane);
    [MethodImpl(AggressiveInlining)] public static bool DeleteContext(nint context) => Interface->wglDeleteContext(context);
    [MethodImpl(AggressiveInlining)] public static nint GetCurrentContext() => Interface->wglGetCurrentContext();
    [MethodImpl(AggressiveInlining)] public static nint GetCurrentDC() => Interface->wglGetCurrentDC();
    [MethodImpl(AggressiveInlining)] public static nint GetProcAddress(byte* name) => Interface->wglGetProcAddress(name);
    [MethodImpl(AggressiveInlining)] public static bool MakeCurrent(nint hdc, nint context) => Interface->wglMakeCurrent(hdc, context);
    [MethodImpl(AggressiveInlining)] public static bool ShareLists(nint context1, nint context2) => Interface->wglShareLists(context1, context2);
    [MethodImpl(AggressiveInlining)] public static bool UseFontBitmapsA(nint hdc, uint first, uint count, uint listBase) => Interface->wglUseFontBitmapsA(hdc, first, count, listBase);
    [MethodImpl(AggressiveInlining)] public static bool UseFontBitmapsW(nint hdc, uint first, uint count, uint listBase) => Interface->wglUseFontBitmapsW(hdc, first, count, listBase);
    [MethodImpl(AggressiveInlining)] public static bool UseFontBitmaps(nint hdc, uint first, uint count, uint listBase) => Interface->wglUseFontBitmapsW(hdc, first, count, listBase);
    [MethodImpl(AggressiveInlining)] public static bool SwapBuffers(nint hdc) => Interface->wglSwapBuffers(hdc);
}