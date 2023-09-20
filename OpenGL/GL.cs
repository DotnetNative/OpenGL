using static OpenGL.Enums;

namespace OpenGL;
public unsafe static class GL
{
    public static GLInterface Interface = new GLInterface();

    public static void Accum(Op op, float value) => Interface.glAccum(op, value);
    public static void AlphaFunc(Func func, float @ref) => Interface.glAlphaFunc(func, @ref);
    public static byte AreTexturesResident(int n, uint[] textures, byte[] residences)
    {
        fixed (uint* texturesPtr = textures)
        fixed (byte* residencesPtr = residences)
            return Interface.glAreTexturesResident(n, texturesPtr, residencesPtr);
    }
    public static byte AreTexturesResident(int n, uint* textures, byte* residences) => Interface.glAreTexturesResident(n, textures, residences);
    public static void ArrayElement(int i) => Interface.glArrayElement(i);
    public static void Begin(Mode mode) => Interface.glBegin(mode);
    public static void BindTexture(TexPTarget target, uint texture) => Interface.glBindTexture(target, texture);
    public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
    {
        fixed (byte* bitmapPtr = bitmap)
            Interface.glBitmap(width, height, xorig, yorig, xmove, ymove, bitmapPtr);
    }
    public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) => Interface.glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
    public static void BlendFunc(Factor sfactor, Factor dfactor) => Interface.glBlendFunc(sfactor, dfactor);
    public static void CallList(uint list) => Interface.glCallList(list);
    public static void CallLists(int n, Enums.Type type, void* lists) => Interface.glCallLists(n, type, lists);
    public static void Clear(uint mask) => Interface.glClear(mask);
    public static void ClearAccum(float red, float green, float blue, float alpha) => Interface.glClearAccum(red, green, blue, alpha);
    public static void ClearColor(float red, float green, float blue, float alpha) => Interface.glClearColor(red, green, blue, alpha);
    public static void ClearDepth(double depth) => Interface.glClearDepth(depth);
    public static void ClearIndex(float c) => Interface.glClearIndex(c);
    public static void ClearStencil(int s) => Interface.glClearStencil(s);
    public static void ClipPlane(Plane plane, double[] equation)
    {
        fixed (double* equationPtr = equation)
            Interface.glClipPlane(plane, equationPtr);
    }
    public static void Color3b(sbyte red, sbyte green, sbyte blue) => Interface.glColor3b(red, green, blue);
    public static void Color3bv(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface.glColor3bv(vPtr);
    }
    public static void Color3d(double red, double green, double blue) => Interface.glColor3d(red, green, blue);
    public static void Color3dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glColor3dv(vPtr);
    }
    public static void Color3f(float red, float green, float blue) => Interface.glColor3f(red, green, blue);
    public static void Color3fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glColor3fv(vPtr);
    }
    public static void Color3i(int red, int green, int blue) => Interface.glColor3i(red, green, blue);
    public static void Color3iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glColor3iv(vPtr);
    }
    public static void Color3s(short red, short green, short blue) => Interface.glColor3s(red, green, blue);
    public static void Color3sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glColor3sv(vPtr);
    }
    public static void Color3ub(byte red, byte green, byte blue) => Interface.glColor3ub(red, green, blue);
    public static void Color3ubv(byte[] v)
    {
        fixed (byte* vPtr = v)
            Interface.glColor3ubv(vPtr);
    }
    public static void Color3ui(uint red, uint green, uint blue) => Interface.glColor3ui(red, green, blue);
    public static void Color3uiv(uint[] v)
    {
        fixed (uint* vPtr = v)
            Interface.glColor3uiv(vPtr);
    }
    public static void Color3us(ushort red, ushort green, ushort blue) => Interface.glColor3us(red, green, blue);
    public static void Color3usv(ushort[] v)
    {
        fixed (ushort* vPtr = v)
            Interface.glColor3usv(vPtr);
    }
    public static void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) => Interface.glColor4b(red, green, blue, alpha);
    public static void Color4bv(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface.glColor4bv(vPtr);
    }
    public static void Color4d(double red, double green, double blue, double alpha) => Interface.glColor4d(red, green, blue, alpha);
    public static void Color4dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glColor4dv(vPtr);
    }
    public static void Color4f(float red, float green, float blue, float alpha) => Interface.glColor4f(red, green, blue, alpha);
    public static void Color4fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glColor4fv(vPtr);
    }
    public static void Color4i(int red, int green, int blue, int alpha) => Interface.glColor4i(red, green, blue, alpha);
    public static void Color4iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glColor4iv(vPtr);
    }
    public static void Color4s(short red, short green, short blue, short alpha) => Interface.glColor4s(red, green, blue, alpha);
    public static void Color4sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glColor4sv(vPtr);
    }        
    public static void Color4ub(byte red, byte green, byte blue, byte alpha) => Interface.glColor4ub(red, green, blue, alpha);
    public static void Color4ubv(byte[] v)
    {
        fixed (byte* vPtr = v)
            Interface.glColor4ubv(vPtr);
    }
    public static void Color4ui(uint red, uint green, uint blue, uint alpha) => Interface.glColor4ui(red, green, blue, alpha);
    public static void Color4uiv(uint[] v)
    {
        fixed (uint* vPtr = v)
            Interface.glColor4uiv(vPtr);
    }
    public static void Color4us(ushort red, ushort green, ushort blue, ushort alpha) => Interface.glColor4us(red, green, blue, alpha);
    public static void Color4usv(ushort[] v)
    {
        fixed (ushort* vPtr = v)
            Interface.glColor4usv(vPtr);
    }
    public static void ColorMask(byte red, byte green, byte blue, byte alpha) => Interface.glColorMask(red, green, blue, alpha);
    public static void ColorMaterial(Face face, MaterialParam mode) => Interface.glColorMaterial(face, mode);
    public static void ColorPointer(int size, BType type, int stride, void* pointer) => Interface.glColorPointer(size, type, stride, pointer);
    public static void CopyPixels(int x, int y, int width, int height, CopyType type) => Interface.glCopyPixels(x, y, width, height, type);
    public static void CopyTexImage1D(TexPTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int border) => Interface.glCopyTexImage1D(target, level, internalFormat, x, y, width, border);
    public static void CopyTexImage2D(TexPTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int height, int border) => Interface.glCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
    public static void CopyTexSubImage1D(TexPTarget target, int level, int xoffset, int x, int y, int width) => Interface.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
    public static void CopyTexSubImage2D(TexPTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => Interface.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
    public static void CullFace(Face mode) => Interface.glCullFace(mode);
    public static void DeleteLists(uint list, int range) => Interface.glDeleteLists(list, range);
    public static void DeleteTextures(int n, uint[] textures)
    {
        fixed (uint* texturesPtr = textures)
            Interface.glDeleteTextures(n, texturesPtr);
    }
    public static void DepthFunc(Func func) => Interface.glDepthFunc(func);
    public static void DepthMask(byte flag) => Interface.glDepthMask(flag);
    public static void DepthRange(double zNear, double zFar) => Interface.glDepthRange(zNear, zFar);
    public static void Set(Cap cap, bool state)
    {
        if (state)
            Interface.glEnable(cap);
        else Interface.glDisable(cap);
    }
    public static void Disable(Cap cap) => Interface.glDisable(cap);
    public static void DisableClientState(ArrayState array) => Interface.glDisableClientState(array);
    public static void DrawArrays(Mode mode, int first, int count) => Interface.glDrawArrays(mode, first, count);
    public static void DrawBuffer(Mode mode) => Interface.glDrawBuffer(mode);
    public static void DrawElements(Mode mode, int count, BUType type, void* indices) => Interface.glDrawElements(mode, count, type, indices);
    public static void DrawPixels(int width, int height, ImageFormat format, BType type, void* pixels) => Interface.glDrawPixels(width, height, format, type, pixels);
    public static void EdgeFlag(byte flag) => Interface.glEdgeFlag(flag);
    public static void EdgeFlagPointer(int stride, void* pointer) => Interface.glEdgeFlagPointer(stride, pointer);
    public static void EdgeFlagv(byte[] flag)
    {
        fixed (byte* flagPtr = flag)
            Interface.glEdgeFlagv(flagPtr);
    }
    public static void Enable(Cap cap) => Interface.glEnable(cap);
    public static void EnableClientState(ArrayState array) => Interface.glEnableClientState(array);
    public static void End() => Interface.glEnd();
    public static void EndList() => Interface.glEndList();
    public static void EvalCoord1d(double u) => Interface.glEvalCoord1d(u);
    public static void EvalCoord1dv(double[] u)
    {
        fixed (double* uPtr = u)
            Interface.glEvalCoord1dv(uPtr);
    }
    public static void EvalCoord1f(float u) => Interface.glEvalCoord1f(u);
    public static void EvalCoord1fv(float[] u)
    {
        fixed (float* uPtr = u)
            Interface.glEvalCoord1fv(uPtr);
    }
    public static void EvalCoord2d(double u, double v) => Interface.glEvalCoord2d(u, v);
    public static void EvalCoord2dv(double[] u)
    {
        fixed (double* uPtr = u)
            Interface.glEvalCoord2dv(uPtr);
    }
    public static void EvalCoord2f(float u, float v) => Interface.glEvalCoord2f(u, v);
    public static void EvalCoord2fv(float[] u)
    {
        fixed (float* uPtr = u)
            Interface.glEvalCoord2fv(uPtr);
    }
    public static void EvalMesh1(EMesh mode, int i1, int i2) => Interface.glEvalMesh1(mode, i1, i2);
    public static void EvalMesh2(Mesh mode, int i1, int i2, int j1, int j2) => Interface.glEvalMesh2(mode, i1, i2, j1, j2);
    public static void EvalPoint1(int i) => Interface.glEvalPoint1(i);
    public static void EvalPoint2(int i, int j) => Interface.glEvalPoint2(i, j);
    public static void FeedbackBuffer(int size, Vertex type, float[] buffer)
    {
        fixed (float* bufferPtr = buffer)
            Interface.glFeedbackBuffer(size, type, bufferPtr);
    }
    public static void Finish() => Interface.glFinish();
    public static void Flush() => Interface.glFlush();
    public static void Fogf(Fog pname, float param) => Interface.glFogf(pname, param);
    public static void Fogfv(Fog pname, float[] @params)
    {
        fixed (float* paramsPtr = @params)
            Interface.glFogfv(pname, @paramsPtr);
    }
    public static void Fogi(Fog pname, int param) => Interface.glFogi(pname, param);
    public static void Fogiv(Fog pname, int[] @params)
    {

        fixed (int* paramsPtr = @params)
            Interface.glFogiv(pname, @paramsPtr);
    }
    public static void FrontFace(FaceMode mode) => Interface.glFrontFace(mode);
    public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar) => Interface.glFrustum(left, right, bottom, top, zNear, zFar);
    public static uint GenLists(int range) => Interface.glGenLists(range);
    public static void GenTextures(int n, uint[] textures)
    {
        fixed (uint* texturesPtr = textures)
            Interface.glGenTextures(n, texturesPtr);
    }
    public static void GetBooleanv(PName pname, byte* @params) => Interface.glGetBooleanv(pname, @params);
    public static void GetBooleanv(PName pname, byte[] @params)
    {
        fixed (byte* @paramsPtr = @params)
            Interface.glGetBooleanv(pname, @paramsPtr);
    }
    public static void GetClipPlane(Plane plane, double[] equation)
    {
        fixed (double* equationPtr = equation)
            Interface.glGetClipPlane(plane, equationPtr);
    }
    public static void GetDoublev(PName pname, double* @params) => Interface.glGetDoublev(pname, @params);
    public static void GetDoublev(PName pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface.glGetDoublev(pname, @paramsPtr);
    }
    public static Error GetError() => Interface.glGetError();
    public static void GetFloatv(PName pname, float* @params) => Interface.glGetFloatv(pname, @params);
    public static void GetFloatv(PName pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetFloatv(pname, @paramsPtr);
    }
    public static void GetIntegerv(PName pname, int* @params) => Interface.glGetIntegerv(pname, @params);
    public static void GetIntegerv(PName pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetIntegerv(pname, @paramsPtr);
    }
    public static void GetLightfv(Light light, LightN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetLightfv(light, pname, @paramsPtr);
    }
    public static void GetLightiv(Light light, LightN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetLightiv(light, pname, @paramsPtr);
    }
    public static void GetMapdv(MapTarget target, Query query, double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glGetMapdv(target, query, vPtr);
    }
    public static void GetMapfv(MapTarget target, Query query, float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glGetMapfv(target, query, vPtr);
    }
    public static void GetMapiv(MapTarget target, Query query, int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glGetMapiv(target, query, vPtr);
    }
    public static void GetMaterialfv(Side face, MaterialParam pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetMaterialfv(face, pname, @paramsPtr);
    }
    public static void GetMaterialiv(Side face, MaterialParam pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetMaterialiv(face, pname, @paramsPtr);
    }
    public static void GetPixelMapfv(Map map, float[] values)
    {
        fixed (float* valuesPtr = values)
            Interface.glGetPixelMapfv(map, valuesPtr);
    }
    public static void GetPixelMapuiv(Map map, uint[] values)
    {
        fixed (uint* valuesPtr = values)
            Interface.glGetPixelMapuiv(map, valuesPtr);
    }
    public static void GetPixelMapusv(Map map, ushort[] values)
    {
        fixed (ushort* valuesPtr = values)
            Interface.glGetPixelMapusv(map, valuesPtr);
    }
    public static void GetPointerv(PNamePtr pname, void** @params) => Interface.glGetPointerv(pname, @params);
    public static void GetPolygonStipple(byte[] mask)
    {
        fixed (byte* maskPtr = mask)
            Interface.glGetPolygonStipple(maskPtr);
    }
    public static byte* GetString(StringName name) => Interface.glGetString(name);
    public static void GetTexEnvfv(TexEnvN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetTexEnvfv(TextureEnv, pname, @paramsPtr);
    }
    public static void GetTexEnviv(TexEnvN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetTexEnviv(TextureEnv, pname, @paramsPtr);
    }
    public static void GetTexGendv(Coords coord, TexGenN pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface.glGetTexGendv(coord, pname, @paramsPtr);
    }
    public static void GetTexGenfv(Coords coord, TexGenN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetTexGenfv(coord, pname, @paramsPtr);
    }
    public static void GetTexGeniv(Coords coord, TexGenN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetTexGeniv(coord, pname, @paramsPtr);
    }
    public static void GetTexImage(TexTarget target, int level, Image format, BType type, void* pixels) => Interface.glGetTexImage(target, level, format, type, pixels);
    public static void GetTexLevelParameterfv(TexPTarget target, int level, TexN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetTexLevelParameterfv(target, level, pname, @paramsPtr);
    }
    public static void GetTexLevelParameteriv(TexPTarget target, int level, TexN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetTexLevelParameteriv(target, level, pname, @paramsPtr);
    }
    public static void GetTexParameterfv(TexTarget target, TexNV pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glGetTexParameterfv(target, pname, @paramsPtr);
    }
    public static void GetTexParameteriv(TexTarget target, TexNV pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glGetTexParameteriv(target, pname, @paramsPtr);
    }
    public static void Hint(Hint target, Calc mode) => Interface.glHint(target, mode);
    public static void IndexMask(uint mask) => Interface.glIndexMask(mask);
    public static void IndexPointer(TexType type, int stride, void* pointer) => Interface.glIndexPointer(type, stride, pointer);
    public static void Indexd(double c) => Interface.glIndexd(c);
    public static void Indexdv(double[] c)
    {
        fixed (double* cPtr = c)
            Interface.glIndexdv(cPtr);
    }
    public static void Indexf(float c) => Interface.glIndexf(c);
    public static void Indexfv(float[] c)
    {
        fixed (float* cPtr = c)
            Interface.glIndexfv(cPtr);
    }
    public static void Indexi(int c) => Interface.glIndexi(c);
    public static void Indexiv(int[] c)
    {
        fixed (int* cPtr = c)
            Interface.glIndexiv(cPtr);
    }
    public static void Indexs(short c) => Interface.glIndexs(c);
    public static void Indexsv(short[] c)
    {
        fixed (short* cPtr = c)
            Interface.glIndexsv(cPtr);
    }
    public static void Indexub(byte c) => Interface.glIndexub(c);
    public static void Indexubv(byte[] c)
    {
        fixed (byte* cPtr = c)
            Interface.glIndexubv(cPtr);
    }
    public static void InitNames() => Interface.glInitNames();
    public static void InterleavedArrays(ArrayFormat format, int stride, void* pointer) => Interface.glInterleavedArrays(format, stride, pointer);
    public static bool IsEnabled(Cap cap) => Interface.glIsEnabled(cap) == 1;
    public static byte IsList(uint list) => Interface.glIsList(list);
    public static byte IsTexture(uint texture) => Interface.glIsTexture(texture);
    public static void LightModelf(LightModel pname, float param) => Interface.glLightModelf(pname, param);
    public static void LightModelfv(LightModel pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glLightModelfv(pname, @paramsPtr);
    }
    public static void LightModeli(LightModel pname, int param) => Interface.glLightModeli(pname, param);
    public static void LightModeliv(LightModel pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glLightModeliv(pname, @paramsPtr);
    }
    public static void Lightf(Light light, LightN pname, float param) => Interface.glLightf(light, pname, param);
    public static void Lightfv(Light light, LightN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glLightfv(light, pname, @paramsPtr);
    }
    public static void Lighti(Light light, LightN pname, int param) => Interface.glLighti(light, pname, param);
    public static void Lightiv(Light light, LightN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glLightiv(light, pname, @paramsPtr);
    }
    public static void LineStipple(int factor, ushort pattern) => Interface.glLineStipple(factor, pattern);
    public static void LineWidth(float width) => Interface.glLineWidth(width);
    public static void ListBase(uint @base) => Interface.glListBase(@base);
    public static void LoadIdentity() => Interface.glLoadIdentity();
    public static void LoadMatrixd(double[] m)
    {
        fixed (double* mPtr = m)
            Interface.glLoadMatrixd(mPtr);
    }
    public static void LoadMatrixd(double* m) => Interface.glLoadMatrixd(m);
    public static void LoadMatrixd(Matrix mode, double* m)
    {
        Interface.glMatrixMode(mode);
        Interface.glLoadMatrixd(m);
    }
    public static void LoadMatrixf(float[] m)
    {
        fixed (float* mPtr = m)
            Interface.glLoadMatrixf(mPtr);
    }
    public static void LoadMatrixf(float* m) => Interface.glLoadMatrixf(m);
    public static void LoadMatrixf(Matrix mode, float* m)
    {
        Interface.glMatrixMode(mode);
        Interface.glLoadMatrixf(m);
    }
    public static void LoadName(uint name) => Interface.glLoadName(name);
    public static void LogicOp(OpCode opcode) => Interface.glLogicOp(opcode);
    public static void Map1d(Map1Target target, double u1, double u2, int stride, int order, double[] points)
    {
        fixed (double* pointsPtr = points)
            Interface.glMap1d(target, u1, u2, stride, order, pointsPtr);
    }
    public static void Map1f(Map1Target target, float u1, float u2, int stride, int order, float[] points)
    {
        fixed (float* pointsPtr = points)
            Interface.glMap1f(target, u1, u2, stride, order, pointsPtr);
    }
    public static void Map2d(Map1Target target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
    {
        fixed (double* pointsPtr = points)
            Interface.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
    }
    public static void Map2f(Map1Target target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
    {
        fixed (float* pointsPtr = points)
            Interface.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
    }
    public static void MapGrid1d(int un, double u1, double u2) => Interface.glMapGrid1d(un, u1, u2);
    public static void MapGrid1f(int un, float u1, float u2) => Interface.glMapGrid1f(un, u1, u2);
    public static void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) => Interface.glMapGrid2d(un, u1, u2, vn, v1, v2);
    public static void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) => Interface.glMapGrid2f(un, u1, u2, vn, v1, v2);
    public static void Materialf(Side face, float param) => Interface.glMaterialf(face, Shininess, param);
    public static void Materialfv(Side face, MaterialParam pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glMaterialfv(face, pname, @paramsPtr);
    }
    public static void Materiali(Side face, MaterialParam pname, int param) => Interface.glMateriali(face, pname, param);
    public static void Materialiv(Side face, MaterialParam pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glMaterialiv(face, pname, @paramsPtr);
    }
    public static void MatrixMode(Matrix mode) => Interface.glMatrixMode(mode);
    public static void MultMatrixd(double[] m)
    {
        fixed (double* mPtr = m)
            Interface.glMultMatrixd(mPtr);
    }
    public static void MultMatrixf(float[] m)
    {
        fixed (float* mPtr = m)
            Interface.glMultMatrixf(mPtr);
    }
    public static void NewList(uint list, Compile mode) => Interface.glNewList(list, mode);
    public static void Normal3b(sbyte nx, sbyte ny, sbyte nz) => Interface.glNormal3b(nx, ny, nz);
    public static void Normal3bv(sbyte[] v)
    {
        fixed (sbyte* vPtr = v)
            Interface.glNormal3bv(vPtr);
    }
    public static void Normal3d(double nx, double ny, double nz) => Interface.glNormal3d(nx, ny, nz);
    public static void Normal3dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glNormal3dv(vPtr);
    }
    public static void Normal3f(float nx, float ny, float nz) => Interface.glNormal3f(nx, ny, nz);
    public static void Normal3fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glNormal3fv(vPtr);
    }
    public static void Normal3i(int nx, int ny, int nz) => Interface.glNormal3i(nx, ny, nz);
    public static void Normal3iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glNormal3iv(vPtr);
    }
    public static void Normal3s(short nx, short ny, short nz) => Interface.glNormal3s(nx, ny, nz);
    public static void Normal3sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glNormal3sv(vPtr);
    }
    public static void NormalPointer(PtrType type, int stride, void* pointer) => Interface.glNormalPointer(type, stride, pointer);
    public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar) => Interface.glOrtho(left, right, bottom, top, zNear, zFar);
    public static void PassThrough(float token) => Interface.glPassThrough(token);
    public static void PixelMapfv(Map map, int mapsize, float[] values)
    {
        fixed (float* valuesPtr = values)
            Interface.glPixelMapfv(map, mapsize, valuesPtr);
    }
    public static void PixelMapuiv(Map map, int mapsize, uint[] values)
    {
        fixed (uint* valuesPtr = values)
            Interface.glPixelMapuiv(map, mapsize, valuesPtr);
    }
    public static void PixelMapusv(Map map, int mapsize, ushort[] values)
    {
        fixed (ushort* valuesPtr = values)
            Interface.glPixelMapusv(map, mapsize, valuesPtr);
    }
    public static void PixelStoref(StoreN pname, float param) => Interface.glPixelStoref(pname, param);
    public static void PixelStorei(StoreN pname, int param) => Interface.glPixelStorei(pname, param);
    public static void PixelTransferf(TransferN pname, float param) => Interface.glPixelTransferf(pname, param);
    public static void PixelTransferi(TransferN pname, int param) => Interface.glPixelTransferi(pname, param);
    public static void PixelZoom(float xfactor, float yfactor) => Interface.glPixelZoom(xfactor, yfactor);
    public static void PointSize(float size) => Interface.glPointSize(size);
    public static void PolygonMode(MaterialFace face, Mesh mode) => Interface.glPolygonMode(face, mode);
    public static void PolygonOffset(float factor, float units) => Interface.glPolygonOffset(factor, units);
    public static void PolygonStipple(byte[] mask)
    {
        fixed (byte* maskPtr = mask)
            Interface.glPolygonStipple(maskPtr);
    }
    public static void PopAttrib() => Interface.glPopAttrib();
    public static void PopClientAttrib() => Interface.glPopClientAttrib();
    public static void PopMatrix() => Interface.glPopMatrix();
    public static void PopName() => Interface.glPopName();
    public static void PrioritizeTextures(int n, uint[] textures, float[] priorities)
    {
        fixed (uint* texturesPtr = textures)
        fixed (float* prioritiesPtr = priorities)
            Interface.glPrioritizeTextures(n, texturesPtr, prioritiesPtr);
    }
    public static void PushAttrib(uint mask) => Interface.glPushAttrib(mask);
    public static void PushClientAttrib(uint mask) => Interface.glPushClientAttrib(mask);
    public static void PushMatrix() => Interface.glPushMatrix();
    public static void PushName(uint name) => Interface.glPushName(name);
    public static void RasterPos2d(double x, double y) => Interface.glRasterPos2d(x, y);
    public static void RasterPos2dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glRasterPos2dv(vPtr);
    }
    public static void RasterPos2f(float x, float y) => Interface.glRasterPos2f(x, y);
    public static void RasterPos2fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glRasterPos2fv(vPtr);
    }
    public static void RasterPos2i(int x, int y) => Interface.glRasterPos2i(x, y);
    public static void RasterPos2iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glRasterPos2iv(vPtr);
    }
    public static void RasterPos2s(short x, short y) => Interface.glRasterPos2s(x, y);
    public static void RasterPos2sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glRasterPos2sv(vPtr);
    }
    public static void RasterPos3d(double x, double y, double z) => Interface.glRasterPos3d(x, y, z);
    public static void RasterPos3dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glRasterPos3dv(vPtr);
    }
    public static void RasterPos3f(float x, float y, float z) => Interface.glRasterPos3f(x, y, z);
    public static void RasterPos3fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glRasterPos3fv(vPtr);
    }
    public static void RasterPos3i(int x, int y, int z) => Interface.glRasterPos3i(x, y, z);
    public static void RasterPos3iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glRasterPos3iv(vPtr);
    }
    public static void RasterPos3s(short x, short y, short z) => Interface.glRasterPos3s(x, y, z);
    public static void RasterPos3sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glRasterPos3sv(vPtr);
    }
    public static void RasterPos4d(double x, double y, double z, double w) => Interface.glRasterPos4d(x, y, z, w);
    public static void RasterPos4dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glRasterPos4dv(vPtr);
    }
    public static void RasterPos4f(float x, float y, float z, float w) => Interface.glRasterPos4f(x, y, z, w);
    public static void RasterPos4fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glRasterPos4fv(vPtr);
    }
    public static void RasterPos4i(int x, int y, int z, int w) => Interface.glRasterPos4i(x, y, z, w);
    public static void RasterPos4iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glRasterPos4iv(vPtr);
    }
    public static void RasterPos4s(short x, short y, short z, short w) => Interface.glRasterPos4s(x, y, z, w);
    public static void RasterPos4sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glRasterPos4sv(vPtr);
    }
    public static void ReadBuffer(Buf mode) => Interface.glReadBuffer(mode);
    public static void ReadPixels(int x, int y, int width, int height, Image format, ReadType type, void* pixels) => Interface.glReadPixels(x, y, width, height, format, type, pixels);
    public static void Rectd(double x1, double y1, double x2, double y2) => Interface.glRectd(x1, y1, x2, y2);
    public static void Rectdv(double[] v1, double[] v2)
    {
        fixed (double* v1Ptr = v1)
        fixed (double* v2Ptr = v2)
            Interface.glRectdv(v1Ptr, v2Ptr);
    }
    public static void Rectf(float x1, float y1, float x2, float y2) => Interface.glRectf(x1, y1, x2, y2);
    public static void Rectfv(float[] v1, float[] v2)
    {
        fixed (float* v1Ptr = v1)
        fixed (float* v2Ptr = v2)
            Interface.glRectfv(v1Ptr, v2Ptr);
    }
    public static void Recti(int x1, int y1, int x2, int y2) => Interface.glRecti(x1, y1, x2, y2);
    public static void Rectiv(int[] v1, int[] v2)
    {
        fixed (int* v1Ptr = v1)
        fixed (int* v2Ptr = v2)
            Interface.glRectiv(v1Ptr, v2Ptr);
    }
    public static void Rects(short x1, short y1, short x2, short y2) => Interface.glRects(x1, y1, x2, y2);
    public static void Rectsv(short[] v1, short[] v2)
    {
        fixed (short* v1Ptr = v1)
        fixed (short* v2Ptr = v2)
            Interface.glRectsv(v1Ptr, v2Ptr);
    }
    public static int RenderMode(Render mode) => Interface.glRenderMode(mode);
    public static void Rotated(double angle, double x, double y, double z) => Interface.glRotated(angle, x, y, z);
    public static void Rotatef(float angle, float x, float y, float z) => Interface.glRotatef(angle, x, y, z);
    public static void Scaled(double x, double y, double z) => Interface.glScaled(x, y, z);
    public static void Scalef(float x, float y, float z) => Interface.glScalef(x, y, z);
    public static void Scissor(int x, int y, int width, int height) => Interface.glScissor(x, y, width, height);
    public static void SelectBuffer(int size, uint[] buffer)
    {
        fixed (uint* bufferPtr = buffer)
            Interface.glSelectBuffer(size, bufferPtr);
    }
    public static void ShadeModel(Fill mode) => Interface.glShadeModel(mode);
    public static void StencilFunc(Func func, int @ref, uint mask) => Interface.glStencilFunc(func, @ref, mask);
    public static void StencilMask(uint mask) => Interface.glStencilMask(mask);
    public static void StencilOp(Fail fail, Fail zfail, Fail zpass) => Interface.glStencilOp(fail, zfail, zpass);
    public static void TexCoord1d(double s) => Interface.glTexCoord1d(s);
    public static void TexCoord1dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glTexCoord1dv(vPtr);
    }
    public static void TexCoord1f(float s) => Interface.glTexCoord1f(s);
    public static void TexCoord1fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glTexCoord1fv(vPtr);  
    }
    public static void TexCoord1i(int s) => Interface.glTexCoord1i(s);
    public static void TexCoord1iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glTexCoord1iv(vPtr);
    }
    public static void TexCoord1s(short s) => Interface.glTexCoord1s(s);
    public static void TexCoord1sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glTexCoord1sv(vPtr);
    }
    public static void TexCoord2d(double s, double t) => Interface.glTexCoord2d(s, t);
    public static void TexCoord2dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glTexCoord2dv(vPtr);
    }
    public static void TexCoord2f(float s, float t) => Interface.glTexCoord2f(s, t);
    public static void TexCoord2fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glTexCoord2fv(vPtr);
    }
    public static void TexCoord2i(int s, int t) => Interface.glTexCoord2i(s, t);
    public static void TexCoord2iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glTexCoord2iv(vPtr);
    }
    public static void TexCoord2s(short s, short t) => Interface.glTexCoord2s(s, t);
    public static void TexCoord2sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glTexCoord2sv(vPtr);
    }
    public static void TexCoord3d(double s, double t, double r) => Interface.glTexCoord3d(s, t, r);
    public static void TexCoord3dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glTexCoord3dv(vPtr);
    }
    public static void TexCoord3f(float s, float t, float r) => Interface.glTexCoord3f(s, t, r);
    public static void TexCoord3fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glTexCoord3fv(vPtr);
    }
    public static void TexCoord3i(int s, int t, int r) => Interface.glTexCoord3i(s, t, r);
    public static void TexCoord3iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glTexCoord3iv(vPtr);
    }
    public static void TexCoord3s(short s, short t, short r) => Interface.glTexCoord3s(s, t, r);
    public static void TexCoord3sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glTexCoord3sv(vPtr);
    }
    public static void TexCoord4d(double s, double t, double r, double q) => Interface.glTexCoord4d(s, t, r, q);
    public static void TexCoord4dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glTexCoord4dv(vPtr);
    }
    public static void TexCoord4f(float s, float t, float r, float q) => Interface.glTexCoord4f(s, t, r, q);
    public static void TexCoord4fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glTexCoord4fv(vPtr);
    }
    public static void TexCoord4i(int s, int t, int r, int q) => Interface.glTexCoord4i(s, t, r, q);
    public static void TexCoord4iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glTexCoord4iv(vPtr);
    }
    public static void TexCoord4s(short s, short t, short r, short q) => Interface.glTexCoord4s(s, t, r, q);
    public static void TexCoord4sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glTexCoord4sv(vPtr);
    }
    public static void TexCoordPointer(int size, TexType type, int stride, void* pointer) => Interface.glTexCoordPointer(size, type, stride, pointer);
    public static void TexEnvf(TexEnvN pname, float param) => Interface.glTexEnvf(TextureEnv, pname, param);
    public static void TexEnvfv(TexEnvN pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glTexEnvfv(TextureEnv, pname, @paramsPtr);
    }
    public static void TexEnvi(TexEnvN pname, int param) => Interface.glTexEnvi(TextureEnv, pname, param);
    public static void TexEnviv(TexEnvN pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glTexEnviv(TextureEnv, pname, @paramsPtr);
    }
    public static void TexGend(Coords coord, TexGen pname, double param) => Interface.glTexGend(coord, pname, param);
    public static void TexGendv(Coords coord, TexGen pname, double[] @params)
    {
        fixed (double* @paramsPtr = @params)
            Interface.glTexGendv(coord, pname, @paramsPtr);
    }
    public static void TexGenf(Coords coord, TexGen pname, float param) => Interface.glTexGenf(coord, pname, param);
    public static void TexGenfv(Coords coord, TexGen pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glTexGenfv(coord, pname, @paramsPtr);
    }
    public static void TexGeni(Coords coord, TexGen pname, int param) => Interface.glTexGeni(coord, pname, param);
    public static void TexGeniv(Coords coord, TexGen pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glTexGeniv(coord, pname, @paramsPtr);
    }
    public static void TexImage1D(int level, InternalFormat internalformat, int width, int border, ImageFormat format, ImageType type, void* pixels) => Interface.glTexImage1D(TexPTarget.Texture1D, level, internalformat, width, border, format, type, pixels);
    public static void TexImage2D(int level, InternalFormat internalformat, int width, int height, int border, ImageFormat format, ImageType type, void* pixels) => Interface.glTexImage2D(TexPTarget.Texture2D, level, internalformat, width, height, border, format, type, pixels);
    public static void TexParameterf(TexTarget target, TexNV2 pname, float param) => Interface.glTexParameterf(target, pname, param);
    public static void TexParameterfv(TexTarget target, TexNV2 pname, float[] @params)
    {
        fixed (float* @paramsPtr = @params)
            Interface.glTexParameterfv(target, pname, @paramsPtr);
    }
    public static void TexParameteri(TexTarget target, TexNV2 pname, int param) => Interface.glTexParameteri(target, pname, param);
    public static void TexParameteriv(TexTarget target, TexNV2 pname, int[] @params)
    {
        fixed (int* @paramsPtr = @params)
            Interface.glTexParameteriv(target, pname, @paramsPtr);
    }
    public static void TexSubImage1D(int level, int xoffset, int width, ImageFormat format, ImageType type, void* pixels) => Interface.glTexSubImage1D((int)TexTarget.Texture1D, level, xoffset, width, format, type, pixels);
    public static void TexSubImage2D(int level, int xoffset, int yoffset, int width, int height, ImageFormat format, ImageType type, void* pixels) => Interface.glTexSubImage2D((int)TexTarget.Texture2D, level, xoffset, yoffset, width, height, format, type, pixels);
    public static void Translated(double x, double y, double z) => Interface.glTranslated(x, y, z);
    public static void Translatef(float x, float y, float z) => Interface.glTranslatef(x, y, z);
    public static void Vertex2d(double x, double y) => Interface.glVertex2d(x, y);
    public static void Vertex2dv(double* v) => Interface.glVertex2dv(v);
    public static void Vertex2dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glVertex2dv(vPtr);
    }
    public static void Vertex2f(float x, float y) => Interface.glVertex2f(x, y);
    public static void Vertex2fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glVertex2fv(vPtr);
    }
    public static void Vertex2i(int x, int y) => Interface.glVertex2i(x, y);
    public static void Vertex2iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glVertex2iv(vPtr);
    }
    public static void Vertex2s(short x, short y) => Interface.glVertex2s(x, y);
    public static void Vertex2sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glVertex2sv(vPtr);
    }
    public static void Vertex3d(double x, double y, double z) => Interface.glVertex3d(x, y, z);
    public static void Vertex3dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glVertex3dv(vPtr);
    }
    public static void Vertex3f(float x, float y, float z) => Interface.glVertex3f(x, y, z);
    public static void Vertex3fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glVertex3fv(vPtr);
    }
    public static void Vertex3i(int x, int y, int z) => Interface.glVertex3i(x, y, z);
    public static void Vertex3iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glVertex3iv(vPtr);
    }
    public static void Vertex3s(short x, short y, short z) => Interface.glVertex3s(x, y, z);
    public static void Vertex3sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glVertex3sv(vPtr);
    }
    public static void Vertex4d(double x, double y, double z, double w) => Interface.glVertex4d(x, y, z, w);
    public static void Vertex4dv(double[] v)
    {
        fixed (double* vPtr = v)
            Interface.glVertex4dv(vPtr);
    }
    public static void Vertex4f(float x, float y, float z, float w) => Interface.glVertex4f(x, y, z, w);
    public static void Vertex4fv(float[] v)
    {
        fixed (float* vPtr = v)
            Interface.glVertex4fv(vPtr);
    }
    public static void Vertex4i(int x, int y, int z, int w) => Interface.glVertex4i(x, y, z, w);
    public static void Vertex4iv(int[] v)
    {
        fixed (int* vPtr = v)
            Interface.glVertex4iv(vPtr);
    }
    public static void Vertex4s(short x, short y, short z, short w) => Interface.glVertex4s(x, y, z, w);
    public static void Vertex4sv(short[] v)
    {
        fixed (short* vPtr = v)
            Interface.glVertex4sv(vPtr);
    }
    public static void VertexPointer(int size, TexType type, int stride, void* pointer) => Interface.glVertexPointer(size, type, stride, pointer);
    public static void Viewport(int x, int y, int width, int height) => Interface.glViewport(x, y, width, height);

    /* After OpenGL 1.1 */

    public static void GenBuffers(int n, uint[] buffers)
    {
        fixed (uint* buffersPtr = buffers)
            Interface.glGenBuffers(n, buffersPtr);
    }
    public static void DeleteBuffers(int n, uint[] buffers)
    {
        fixed (uint* buffersPtr = buffers)
            Interface.glDeleteBuffers(n, buffersPtr);
    }
    public static void BindBuffer(Enums.Buffer type, uint buffer) => Interface.glBindBuffer(type, buffer);
    public static void BufferData(Enums.Buffer type, int size, void* data, BufferUsage usage) => Interface.glBufferData(type, size, data, usage);
}