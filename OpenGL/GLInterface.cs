using static OpenGL.Enums;
using static OpenGL.Interop;

namespace OpenGL;
public unsafe struct GLInterface
{
    nint ProcAddr(string name) => GetProcAddress(Module, name);

    public static string[] FunctionsNames = 
@"glAccum glAlphaFunc glAreTexturesResident glArrayElement glBegin glBindTexture glBitmap glBlendFunc glCallList glCallLists glClear glClearAccum glClearColor
glClearDepth glClearIndex glClearStencil glClipPlane glColor3b glColor3bv glColor3d glColor3dv glColor3f glColor3fv glColor3i glColor3iv glColor3s glColor3sv
glColor3ub glColor3ubv glColor3ui glColor3uiv glColor3us glColor3usv glColor4b glColor4bv glColor4d glColor4dv glColor4f glColor4fv glColor4i glColor4iv glColor4s
glColor4sv glColor4ub glColor4ubv glColor4ui glColor4uiv glColor4us glColor4usv glColorMask glColorMaterial glColorPointer glCopyPixels glCopyTexImage1D glCopyTexImage2D
glCopyTexSubImage1D glCopyTexSubImage2D glCullFace glDeleteLists glDeleteTextures glDepthFunc glDepthMask glDepthRange glDisable glDisableClientState glDrawArrays
glDrawBuffer glDrawElements glDrawPixels glEdgeFlag glEdgeFlagPointer glEdgeFlagv glEnable glEnableClientState glEnd glEndList glEvalCoord1d glEvalCoord1dv
glEvalCoord1f glEvalCoord1fv glEvalCoord2d glEvalCoord2dv glEvalCoord2f glEvalCoord2fv glEvalMesh1 glEvalMesh2 glEvalPoint1 glEvalPoint2 glFeedbackBuffer glFinish
glFlush glFogf glFogfv glFogi glFogiv glFrontFace glFrustum glGenLists glGenTextures glGetBooleanv glGetClipPlane glGetDoublev glGetError glGetFloatv glGetIntegerv
glGetLightfv glGetLightiv glGetMapdv glGetMapfv glGetMapiv glGetMaterialfv glGetMaterialiv glGetPixelMapfv glGetPixelMapuiv glGetPixelMapusv glGetPointerv
glGetPolygonStipple glGetString glGetTexEnvfv glGetTexEnviv glGetTexGendv glGetTexGenfv glGetTexGeniv glGetTexImage glGetTexLevelParameterfv glGetTexLevelParameteriv
glGetTexParameterfv glGetTexParameteriv glHint glIndexMask glIndexPointer glIndexd glIndexdv glIndexf glIndexfv glIndexi glIndexiv glIndexs glIndexsv glIndexub
glIndexubv glInitNames glInterleavedArrays glIsEnabled glIsList glIsTexture glLightModelf glLightModelfv glLightModeli glLightModeliv glLightf glLightfv glLighti
glLightiv glLineStipple glLineWidth glListBase glLoadIdentity glLoadMatrixd glLoadMatrixf glLoadName glLogicOp glMap1d glMap1f glMap2d glMap2f glMapGrid1d
glMapGrid1f glMapGrid2d glMapGrid2f glMaterialf glMaterialfv glMateriali glMaterialiv glMatrixMode glMultMatrixd glMultMatrixf glNewList glNormal3b glNormal3bv
glNormal3d glNormal3dv glNormal3f glNormal3fv glNormal3i glNormal3iv glNormal3s glNormal3sv glNormalPointer glOrtho glPassThrough glPixelMapfv glPixelMapuiv
glPixelMapusv glPixelStoref glPixelStorei glPixelTransferf glPixelTransferi glPixelZoom glPointSize glPolygonMode glPolygonOffset glPolygonStipple glPopAttrib
glPopClientAttrib glPopMatrix glPopName glPrioritizeTextures glPushAttrib glPushClientAttrib glPushMatrix glPushName glRasterPos2d glRasterPos2dv glRasterPos2f
glRasterPos2fv glRasterPos2i glRasterPos2iv glRasterPos2s glRasterPos2sv glRasterPos3d glRasterPos3dv glRasterPos3f glRasterPos3fv glRasterPos3i glRasterPos3iv
glRasterPos3s glRasterPos3sv glRasterPos4d glRasterPos4dv glRasterPos4f glRasterPos4fv glRasterPos4i glRasterPos4iv glRasterPos4s glRasterPos4sv glReadBuffer
glReadPixels glRectd glRectdv glRectf glRectfv glRecti glRectiv glRects glRectsv glRenderMode glRotated glRotatef glScaled glScalef glScissor glSelectBuffer
glShadeModel glStencilFunc glStencilMask glStencilOp glTexCoord1d glTexCoord1dv glTexCoord1f glTexCoord1fv glTexCoord1i glTexCoord1iv glTexCoord1s glTexCoord1sv
glTexCoord2d glTexCoord2dv glTexCoord2f glTexCoord2fv glTexCoord2i glTexCoord2iv glTexCoord2s glTexCoord2sv glTexCoord3d glTexCoord3dv glTexCoord3f glTexCoord3fv
glTexCoord3i glTexCoord3iv glTexCoord3s glTexCoord3sv glTexCoord4d glTexCoord4dv glTexCoord4f glTexCoord4fv glTexCoord4i glTexCoord4iv glTexCoord4s glTexCoord4sv
glTexCoordPointer glTexEnvf glTexEnvfv glTexEnvi glTexEnviv glTexGend glTexGendv glTexGenf glTexGenfv glTexGeni glTexGeniv glTexImage1D glTexImage2D glTexParameterf
glTexParameterfv glTexParameteri glTexParameteriv glTexSubImage1D glTexSubImage2D glTranslated glTranslatef glVertex2d glVertex2dv glVertex2f glVertex2fv glVertex2i
glVertex2iv glVertex2s glVertex2sv glVertex3d glVertex3dv glVertex3f glVertex3fv glVertex3i glVertex3iv glVertex3s glVertex3sv glVertex4d glVertex4dv glVertex4f
glVertex4fv glVertex4i glVertex4iv glVertex4s glVertex4sv glVertexPointer glViewport glGenBuffers glDeleteBuffers glBindBuffer glBufferData".Replace("\r", "").Split(' ', '\n');
    public static int FunctionsCount = FunctionsNames.Length;

    public void Init(nint* ptr)
    {
        Module = GetModuleHandle("opengl32");
        if (Module == 0)
            return;

        for (int i = 0; i < FunctionsCount; i++)
            ptr[i] = ProcAddr(FunctionsNames[i]);
    }

    public delegate* unmanaged<Op, float, void> glAccum;
    public delegate* unmanaged<Func, float, void> glAlphaFunc;
    public delegate* unmanaged<int, uint*, byte*, byte> glAreTexturesResident;
    public delegate* unmanaged<int, void> glArrayElement;
    public delegate* unmanaged<Mode, void> glBegin;
    public delegate* unmanaged<TexPTarget, uint, void> glBindTexture;
    public delegate* unmanaged<int, int, float, float, float, float, byte*, void> glBitmap;
    public delegate* unmanaged<Factor, Factor, void> glBlendFunc;
    public delegate* unmanaged<uint, void> glCallList;
    public delegate* unmanaged<int, Enums.Type, void*, void> glCallLists;
    public delegate* unmanaged<uint, void> glClear;
    public delegate* unmanaged<float, float, float, float, void> glClearAccum;
    public delegate* unmanaged<float, float, float, float, void> glClearColor;
    public delegate* unmanaged<double, void> glClearDepth;
    public delegate* unmanaged<float, void> glClearIndex;
    public delegate* unmanaged<int, void> glClearStencil;
    public delegate* unmanaged<Plane, double*, void> glClipPlane;
    public delegate* unmanaged<sbyte, sbyte, sbyte, void> glColor3b;
    public delegate* unmanaged<sbyte*, void> glColor3bv;
    public delegate* unmanaged<double, double, double, void> glColor3d;
    public delegate* unmanaged<double*, void> glColor3dv;
    public delegate* unmanaged<float, float, float, void> glColor3f;
    public delegate* unmanaged<float*, void> glColor3fv;
    public delegate* unmanaged<int, int, int, void> glColor3i;
    public delegate* unmanaged<int*, void> glColor3iv;
    public delegate* unmanaged<short, short, short, void> glColor3s;
    public delegate* unmanaged<short*, void> glColor3sv;
    public delegate* unmanaged<byte, byte, byte, void> glColor3ub;
    public delegate* unmanaged<byte*, void> glColor3ubv;
    public delegate* unmanaged<uint, uint, uint, void> glColor3ui;
    public delegate* unmanaged<uint*, void> glColor3uiv;
    public delegate* unmanaged<ushort, ushort, ushort, void> glColor3us;
    public delegate* unmanaged<ushort*, void> glColor3usv;
    public delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void> glColor4b;
    public delegate* unmanaged<sbyte*, void> glColor4bv;
    public delegate* unmanaged<double, double, double, double, void> glColor4d;
    public delegate* unmanaged<double*, void> glColor4dv;
    public delegate* unmanaged<float, float, float, float, void> glColor4f;
    public delegate* unmanaged<float*, void> glColor4fv;
    public delegate* unmanaged<int, int, int, int, void> glColor4i;
    public delegate* unmanaged<int*, void> glColor4iv;
    public delegate* unmanaged<short, short, short, short, void> glColor4s;
    public delegate* unmanaged<short*, void> glColor4sv;
    public delegate* unmanaged<byte, byte, byte, byte, void> glColor4ub;
    public delegate* unmanaged<byte*, void> glColor4ubv;
    public delegate* unmanaged<uint, uint, uint, uint, void> glColor4ui;
    public delegate* unmanaged<uint*, void> glColor4uiv;
    public delegate* unmanaged<ushort, ushort, ushort, ushort, void> glColor4us;
    public delegate* unmanaged<ushort*, void> glColor4usv;
    public delegate* unmanaged<byte, byte, byte, byte, void> glColorMask;
    public delegate* unmanaged<Face, MaterialParam, void> glColorMaterial;
    public delegate* unmanaged<int, BType, int, void*, void> glColorPointer;
    public delegate* unmanaged<int, int, int, int, CopyType, void> glCopyPixels;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, int, void> glCopyTexImage1D;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, int, int, void> glCopyTexImage2D;
    public delegate* unmanaged<TexPTarget, int, int, int, int, int, void> glCopyTexSubImage1D;
    public delegate* unmanaged<TexPTarget, int, int, int, int, int, int, int, void> glCopyTexSubImage2D;
    public delegate* unmanaged<Face, void> glCullFace;
    public delegate* unmanaged<uint, int, void> glDeleteLists;
    public delegate* unmanaged<int, uint*, void> glDeleteTextures;
    public delegate* unmanaged<Func, void> glDepthFunc;
    public delegate* unmanaged<byte, void> glDepthMask;
    public delegate* unmanaged<double, double, void> glDepthRange;
    public delegate* unmanaged<Cap, void> glDisable;
    public delegate* unmanaged<ArrayState, void> glDisableClientState;
    public delegate* unmanaged<Mode, int, int, void> glDrawArrays;
    public delegate* unmanaged<Mode, void> glDrawBuffer;
    public delegate* unmanaged<Mode, int, BUType, void*, void> glDrawElements;
    public delegate* unmanaged<int, int, ImageFormat, BType, void*, void> glDrawPixels;
    public delegate* unmanaged<byte, void> glEdgeFlag;
    public delegate* unmanaged<int, void*, void> glEdgeFlagPointer;
    public delegate* unmanaged<byte*, void> glEdgeFlagv;
    public delegate* unmanaged<Cap, void> glEnable;
    public delegate* unmanaged<ArrayState, void> glEnableClientState;
    public delegate* unmanaged<void> glEnd;
    public delegate* unmanaged<void> glEndList;
    public delegate* unmanaged<double, void> glEvalCoord1d;
    public delegate* unmanaged<double*, void> glEvalCoord1dv;
    public delegate* unmanaged<float, void> glEvalCoord1f;
    public delegate* unmanaged<float*, void> glEvalCoord1fv;
    public delegate* unmanaged<double, double, void> glEvalCoord2d;
    public delegate* unmanaged<double*, void> glEvalCoord2dv;
    public delegate* unmanaged<float, float, void> glEvalCoord2f;
    public delegate* unmanaged<float*, void> glEvalCoord2fv;
    public delegate* unmanaged<EMesh, int, int, void> glEvalMesh1;
    public delegate* unmanaged<Mesh, int, int, int, int, void> glEvalMesh2;
    public delegate* unmanaged<int, void> glEvalPoint1;
    public delegate* unmanaged<int, int, void> glEvalPoint2;
    public delegate* unmanaged<int, Vertex, float*, void> glFeedbackBuffer;
    public delegate* unmanaged<void> glFinish;
    public delegate* unmanaged<void> glFlush;
    public delegate* unmanaged<Fog, float, void> glFogf;
    public delegate* unmanaged<Fog, float*, void> glFogfv;
    public delegate* unmanaged<Fog, int, void> glFogi;
    public delegate* unmanaged<Fog, int*, void> glFogiv;
    public delegate* unmanaged<FaceMode, void> glFrontFace;
    public delegate* unmanaged<double, double, double, double, double, double, void> glFrustum;
    public delegate* unmanaged<int, uint> glGenLists;
    public delegate* unmanaged<int, uint*, void> glGenTextures;
    public delegate* unmanaged<PName, byte*, void> glGetBooleanv;
    public delegate* unmanaged<Plane, double*, void> glGetClipPlane;
    public delegate* unmanaged<PName, double*, void> glGetDoublev;
    public delegate* unmanaged<Error> glGetError;
    public delegate* unmanaged<PName, float*, void> glGetFloatv;
    public delegate* unmanaged<PName, int*, void> glGetIntegerv;
    public delegate* unmanaged<Light, LightN, float*, void> glGetLightfv;
    public delegate* unmanaged<Light, LightN, int*, void> glGetLightiv;
    public delegate* unmanaged<MapTarget, Query, double*, void> glGetMapdv;
    public delegate* unmanaged<MapTarget, Query, float*, void> glGetMapfv;
    public delegate* unmanaged<MapTarget, Query, int*, void> glGetMapiv;
    public delegate* unmanaged<Side, MaterialParam, float*, void> glGetMaterialfv;
    public delegate* unmanaged<Side, MaterialParam, int*, void> glGetMaterialiv;
    public delegate* unmanaged<Map, float*, void> glGetPixelMapfv;
    public delegate* unmanaged<Map, uint*, void> glGetPixelMapuiv;
    public delegate* unmanaged<Map, ushort*, void> glGetPixelMapusv;
    public delegate* unmanaged<PNamePtr, void**, void> glGetPointerv;
    public delegate* unmanaged<byte*, void> glGetPolygonStipple;
    public delegate* unmanaged<StringName, byte*> glGetString;
    public delegate* unmanaged<int, TexEnvN, float*, void> glGetTexEnvfv;
    public delegate* unmanaged<int, TexEnvN, int*, void> glGetTexEnviv;
    public delegate* unmanaged<Coords, TexGenN, double*, void> glGetTexGendv;
    public delegate* unmanaged<Coords, TexGenN, float*, void> glGetTexGenfv;
    public delegate* unmanaged<Coords, TexGenN, int*, void> glGetTexGeniv;
    public delegate* unmanaged<TexTarget, int, Image, BType, void*, void> glGetTexImage;
    public delegate* unmanaged<TexPTarget, int, TexN, float*, void> glGetTexLevelParameterfv;
    public delegate* unmanaged<TexPTarget, int, TexN, int*, void> glGetTexLevelParameteriv;
    public delegate* unmanaged<TexTarget, TexNV, float*, void> glGetTexParameterfv;
    public delegate* unmanaged<TexTarget, TexNV, int*, void> glGetTexParameteriv;
    public delegate* unmanaged<Hint, Calc, void> glHint;
    public delegate* unmanaged<uint, void> glIndexMask;
    public delegate* unmanaged<TexType, int, void*, void> glIndexPointer;
    public delegate* unmanaged<double, void> glIndexd;
    public delegate* unmanaged<double*, void> glIndexdv;
    public delegate* unmanaged<float, void> glIndexf;
    public delegate* unmanaged<float*, void> glIndexfv;
    public delegate* unmanaged<int, void> glIndexi;
    public delegate* unmanaged<int*, void> glIndexiv;
    public delegate* unmanaged<short, void> glIndexs;
    public delegate* unmanaged<short*, void> glIndexsv;
    public delegate* unmanaged<byte, void> glIndexub;
    public delegate* unmanaged<byte*, void> glIndexubv;
    public delegate* unmanaged<void> glInitNames;
    public delegate* unmanaged<ArrayFormat, int, void*, void> glInterleavedArrays;
    public delegate* unmanaged<Cap, byte> glIsEnabled;
    public delegate* unmanaged<uint, byte> glIsList;
    public delegate* unmanaged<uint, byte> glIsTexture;
    public delegate* unmanaged<LightModel, float, void> glLightModelf;
    public delegate* unmanaged<LightModel, float*, void> glLightModelfv;
    public delegate* unmanaged<LightModel, int, void> glLightModeli;
    public delegate* unmanaged<LightModel, int*, void> glLightModeliv;
    public delegate* unmanaged<Light, LightN, float, void> glLightf;
    public delegate* unmanaged<Light, LightN, float*, void> glLightfv;
    public delegate* unmanaged<Light, LightN, int, void> glLighti;
    public delegate* unmanaged<Light, LightN, int*, void> glLightiv;
    public delegate* unmanaged<int, ushort, void> glLineStipple;
    public delegate* unmanaged<float, void> glLineWidth;
    public delegate* unmanaged<uint, void> glListBase;
    public delegate* unmanaged<void> glLoadIdentity;
    public delegate* unmanaged<double*, void> glLoadMatrixd;
    public delegate* unmanaged<float*, void> glLoadMatrixf;
    public delegate* unmanaged<uint, void> glLoadName;
    public delegate* unmanaged<OpCode, void> glLogicOp;
    public delegate* unmanaged<Map1Target, double, double, int, int, double*, void> glMap1d;
    public delegate* unmanaged<Map1Target, float, float, int, int, float*, void> glMap1f;
    public delegate* unmanaged<Map1Target, double, double, int, int, double, double, int, int, double*, void> glMap2d;
    public delegate* unmanaged<Map1Target, float, float, int, int, float, float, int, int, float*, void> glMap2f;
    public delegate* unmanaged<int, double, double, void> glMapGrid1d;
    public delegate* unmanaged<int, float, float, void> glMapGrid1f;
    public delegate* unmanaged<int, double, double, int, double, double, void> glMapGrid2d;
    public delegate* unmanaged<int, float, float, int, float, float, void> glMapGrid2f;
    public delegate* unmanaged<Side, int, float, void> glMaterialf;
    public delegate* unmanaged<Side, MaterialParam, float*, void> glMaterialfv;
    public delegate* unmanaged<Side, MaterialParam, int, void> glMateriali;
    public delegate* unmanaged<Side, MaterialParam, int*, void> glMaterialiv;
    public delegate* unmanaged<Matrix, void> glMatrixMode;
    public delegate* unmanaged<double*, void> glMultMatrixd;
    public delegate* unmanaged<float*, void> glMultMatrixf;
    public delegate* unmanaged<uint, Compile, void> glNewList;
    public delegate* unmanaged<sbyte, sbyte, sbyte, void> glNormal3b;
    public delegate* unmanaged<sbyte*, void> glNormal3bv;
    public delegate* unmanaged<double, double, double, void> glNormal3d;
    public delegate* unmanaged<double*, void> glNormal3dv;
    public delegate* unmanaged<float, float, float, void> glNormal3f;
    public delegate* unmanaged<float*, void> glNormal3fv;
    public delegate* unmanaged<int, int, int, void> glNormal3i;
    public delegate* unmanaged<int*, void> glNormal3iv;
    public delegate* unmanaged<short, short, short, void> glNormal3s;
    public delegate* unmanaged<short*, void> glNormal3sv;
    public delegate* unmanaged<PtrType, int, void*, void> glNormalPointer;
    public delegate* unmanaged<double, double, double, double, double, double, void> glOrtho;
    public delegate* unmanaged<float, void> glPassThrough;
    public delegate* unmanaged<Map, int, float*, void> glPixelMapfv;
    public delegate* unmanaged<Map, int, uint*, void> glPixelMapuiv;
    public delegate* unmanaged<Map, int, ushort*, void> glPixelMapusv;
    public delegate* unmanaged<StoreN, float, void> glPixelStoref;
    public delegate* unmanaged<StoreN, int, void> glPixelStorei;
    public delegate* unmanaged<TransferN, float, void> glPixelTransferf;
    public delegate* unmanaged<TransferN, int, void> glPixelTransferi;
    public delegate* unmanaged<float, float, void> glPixelZoom;
    public delegate* unmanaged<float, void> glPointSize;
    public delegate* unmanaged<MaterialFace, Mesh, void> glPolygonMode;
    public delegate* unmanaged<float, float, void> glPolygonOffset;
    public delegate* unmanaged<byte*, void> glPolygonStipple;
    public delegate* unmanaged<void> glPopAttrib;
    public delegate* unmanaged<void> glPopClientAttrib;
    public delegate* unmanaged<void> glPopMatrix;
    public delegate* unmanaged<void> glPopName;
    public delegate* unmanaged<int, uint*, float*, void> glPrioritizeTextures;
    public delegate* unmanaged<uint, void> glPushAttrib;
    public delegate* unmanaged<uint, void> glPushClientAttrib;
    public delegate* unmanaged<void> glPushMatrix;
    public delegate* unmanaged<uint, void> glPushName;
    public delegate* unmanaged<double, double, void> glRasterPos2d;
    public delegate* unmanaged<double*, void> glRasterPos2dv;
    public delegate* unmanaged<float, float, void> glRasterPos2f;
    public delegate* unmanaged<float*, void> glRasterPos2fv;
    public delegate* unmanaged<int, int, void> glRasterPos2i;
    public delegate* unmanaged<int*, void> glRasterPos2iv;
    public delegate* unmanaged<short, short, void> glRasterPos2s;
    public delegate* unmanaged<short*, void> glRasterPos2sv;
    public delegate* unmanaged<double, double, double, void> glRasterPos3d;
    public delegate* unmanaged<double*, void> glRasterPos3dv;
    public delegate* unmanaged<float, float, float, void> glRasterPos3f;
    public delegate* unmanaged<float*, void> glRasterPos3fv;
    public delegate* unmanaged<int, int, int, void> glRasterPos3i;
    public delegate* unmanaged<int*, void> glRasterPos3iv;
    public delegate* unmanaged<short, short, short, void> glRasterPos3s;
    public delegate* unmanaged<short*, void> glRasterPos3sv;
    public delegate* unmanaged<double, double, double, double, void> glRasterPos4d;
    public delegate* unmanaged<double*, void> glRasterPos4dv;
    public delegate* unmanaged<float, float, float, float, void> glRasterPos4f;
    public delegate* unmanaged<float*, void> glRasterPos4fv;
    public delegate* unmanaged<int, int, int, int, void> glRasterPos4i;
    public delegate* unmanaged<int*, void> glRasterPos4iv;
    public delegate* unmanaged<short, short, short, short, void> glRasterPos4s;
    public delegate* unmanaged<short*, void> glRasterPos4sv;
    public delegate* unmanaged<Buf, void> glReadBuffer;
    public delegate* unmanaged<int, int, int, int, Image, ReadType, void*, void> glReadPixels;
    public delegate* unmanaged<double, double, double, double, void> glRectd;
    public delegate* unmanaged<double*, double*, void> glRectdv;
    public delegate* unmanaged<float, float, float, float, void> glRectf;
    public delegate* unmanaged<float*, float*, void> glRectfv;
    public delegate* unmanaged<int, int, int, int, void> glRecti;
    public delegate* unmanaged<int*, int*, void> glRectiv;
    public delegate* unmanaged<short, short, short, short, void> glRects;
    public delegate* unmanaged<short*, short*, void> glRectsv;
    public delegate* unmanaged<Render, int> glRenderMode;
    public delegate* unmanaged<double, double, double, double, void> glRotated;
    public delegate* unmanaged<float, float, float, float, void> glRotatef;
    public delegate* unmanaged<double, double, double, void> glScaled;
    public delegate* unmanaged<float, float, float, void> glScalef;
    public delegate* unmanaged<int, int, int, int, void> glScissor;
    public delegate* unmanaged<int, uint*, void> glSelectBuffer;
    public delegate* unmanaged<Fill, void> glShadeModel;
    public delegate* unmanaged<Func, int, uint, void> glStencilFunc;
    public delegate* unmanaged<uint, void> glStencilMask;
    public delegate* unmanaged<Fail, Fail, Fail, void> glStencilOp;
    public delegate* unmanaged<double, void> glTexCoord1d;
    public delegate* unmanaged<double*, void> glTexCoord1dv;
    public delegate* unmanaged<float, void> glTexCoord1f;
    public delegate* unmanaged<float*, void> glTexCoord1fv;
    public delegate* unmanaged<int, void> glTexCoord1i;
    public delegate* unmanaged<int*, void> glTexCoord1iv;
    public delegate* unmanaged<short, void> glTexCoord1s;
    public delegate* unmanaged<short*, void> glTexCoord1sv;
    public delegate* unmanaged<double, double, void> glTexCoord2d;
    public delegate* unmanaged<double*, void> glTexCoord2dv;
    public delegate* unmanaged<float, float, void> glTexCoord2f;
    public delegate* unmanaged<float*, void> glTexCoord2fv;
    public delegate* unmanaged<int, int, void> glTexCoord2i;
    public delegate* unmanaged<int*, void> glTexCoord2iv;
    public delegate* unmanaged<short, short, void> glTexCoord2s;
    public delegate* unmanaged<short*, void> glTexCoord2sv;
    public delegate* unmanaged<double, double, double, void> glTexCoord3d;
    public delegate* unmanaged<double*, void> glTexCoord3dv;
    public delegate* unmanaged<float, float, float, void> glTexCoord3f;
    public delegate* unmanaged<float*, void> glTexCoord3fv;
    public delegate* unmanaged<int, int, int, void> glTexCoord3i;
    public delegate* unmanaged<int*, void> glTexCoord3iv;
    public delegate* unmanaged<short, short, short, void> glTexCoord3s;
    public delegate* unmanaged<short*, void> glTexCoord3sv;
    public delegate* unmanaged<double, double, double, double, void> glTexCoord4d;
    public delegate* unmanaged<double*, void> glTexCoord4dv;
    public delegate* unmanaged<float, float, float, float, void> glTexCoord4f;
    public delegate* unmanaged<float*, void> glTexCoord4fv;
    public delegate* unmanaged<int, int, int, int, void> glTexCoord4i;
    public delegate* unmanaged<int*, void> glTexCoord4iv;
    public delegate* unmanaged<short, short, short, short, void> glTexCoord4s;
    public delegate* unmanaged<short*, void> glTexCoord4sv;
    public delegate* unmanaged<int, TexType, int, void*, void> glTexCoordPointer;
    public delegate* unmanaged<int, TexEnvN, float, void> glTexEnvf;
    public delegate* unmanaged<int, TexEnvN, float*, void> glTexEnvfv;
    public delegate* unmanaged<int, TexEnvN, int, void> glTexEnvi;
    public delegate* unmanaged<int, TexEnvN, int*, void> glTexEnviv;
    public delegate* unmanaged<Coords, TexGen, double, void> glTexGend;
    public delegate* unmanaged<Coords, TexGen, double*, void> glTexGendv;
    public delegate* unmanaged<Coords, TexGen, float, void> glTexGenf;
    public delegate* unmanaged<Coords, TexGen, float*, void> glTexGenfv;
    public delegate* unmanaged<Coords, TexGen, int, void> glTexGeni;
    public delegate* unmanaged<Coords, TexGen, int*, void> glTexGeniv;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, ImageFormat, ImageType, void*, void> glTexImage1D;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, ImageFormat, ImageType, void*, void> glTexImage2D;
    public delegate* unmanaged<TexTarget, TexNV2, float, void> glTexParameterf;
    public delegate* unmanaged<TexTarget, TexNV2, float*, void> glTexParameterfv;
    public delegate* unmanaged<TexTarget, TexNV2, int, void> glTexParameteri;
    public delegate* unmanaged<TexTarget, TexNV2, int*, void> glTexParameteriv;
    public delegate* unmanaged<int, int, int, int, ImageFormat, ImageType, void*, void> glTexSubImage1D;
    public delegate* unmanaged<int, int, int, int, int, int, ImageFormat, ImageType, void*, void> glTexSubImage2D;
    public delegate* unmanaged<double, double, double, void> glTranslated;
    public delegate* unmanaged<float, float, float, void> glTranslatef;
    public delegate* unmanaged<double, double, void> glVertex2d;
    public delegate* unmanaged<double*, void> glVertex2dv;
    public delegate* unmanaged<float, float, void> glVertex2f;
    public delegate* unmanaged<float*, void> glVertex2fv;
    public delegate* unmanaged<int, int, void> glVertex2i;
    public delegate* unmanaged<int*, void> glVertex2iv;
    public delegate* unmanaged<short, short, void> glVertex2s;
    public delegate* unmanaged<short*, void> glVertex2sv;
    public delegate* unmanaged<double, double, double, void> glVertex3d;
    public delegate* unmanaged<double*, void> glVertex3dv;
    public delegate* unmanaged<float, float, float, void> glVertex3f;
    public delegate* unmanaged<float*, void> glVertex3fv;
    public delegate* unmanaged<int, int, int, void> glVertex3i;
    public delegate* unmanaged<int*, void> glVertex3iv;
    public delegate* unmanaged<short, short, short, void> glVertex3s;
    public delegate* unmanaged<short*, void> glVertex3sv;
    public delegate* unmanaged<double, double, double, double, void> glVertex4d;
    public delegate* unmanaged<double*, void> glVertex4dv;
    public delegate* unmanaged<float, float, float, float, void> glVertex4f;
    public delegate* unmanaged<float*, void> glVertex4fv;
    public delegate* unmanaged<int, int, int, int, void> glVertex4i;
    public delegate* unmanaged<int*, void> glVertex4iv;
    public delegate* unmanaged<short, short, short, short, void> glVertex4s;
    public delegate* unmanaged<short*, void> glVertex4sv;
    public delegate* unmanaged<int, TexType, int, void*, void> glVertexPointer;
    public delegate* unmanaged<int, int, int, int, void> glViewport;

    /* After OpenGL 1.1 */
    public delegate* unmanaged<int, uint*, void> glGenBuffers;
    public delegate* unmanaged<int, uint*, void> glDeleteBuffers;
    public delegate* unmanaged<Enums.Buffer, uint, void> glBindBuffer;
    public delegate* unmanaged<Enums.Buffer, int, void*, BufferUsage, void> glBufferData;

    public nint Module;
}