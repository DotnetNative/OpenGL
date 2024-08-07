﻿namespace OpenGL;
public unsafe struct GLInterface
{
    public static readonly byte[] FunctionsNames = (
        "glAccum\0glAlphaFunc\0glAreTexturesResident\0glArrayElement\0glBegin\0glBindTexture\0glBitmap\0glBlendFunc\0glCallList\0glCallLists\0glClear\0glClearAccum\0glClearColor\0"u8+
        "glClearDepth\0glClearIndex\0glClearStencil\0glClipPlane\0glColor3b\0glColor3bv\0glColor3d\0glColor3dv\0glColor3f\0glColor3fv\0glColor3i\0glColor3iv\0glColor3s\0glColor3sv\0"u8 +
        "glColor3ub\0glColor3ubv\0glColor3ui\0glColor3uiv\0glColor3us\0glColor3usv\0glColor4b\0glColor4bv\0glColor4d\0glColor4dv\0glColor4f\0glColor4fv\0glColor4i\0glColor4iv\0glColor4s\0"u8 +
        "glColor4sv\0glColor4ub\0glColor4ubv\0glColor4ui\0glColor4uiv\0glColor4us\0glColor4usv\0glColorMask\0glColorMaterial\0glColorPointer\0glCopyPixels\0glCopyTexImage1D\0glCopyTexImage2D\0"u8 +
        "glCopyTexSubImage1D\0glCopyTexSubImage2D\0glCullFace\0glDeleteLists\0glDeleteTextures\0glDepthFunc\0glDepthMask\0glDepthRange\0glDisable\0glDisableClientState\0glDrawArrays\0"u8 +
        "glDrawBuffer\0glDrawElements\0glDrawPixels\0glEdgeFlag\0glEdgeFlagPointer\0glEdgeFlagv\0glEnable\0glEnableClientState\0glEnd\0glEndList\0glEvalCoord1d\0glEvalCoord1dv\0"u8 +
        "glEvalCoord1f\0glEvalCoord1fv\0glEvalCoord2d\0glEvalCoord2dv\0glEvalCoord2f\0glEvalCoord2fv\0glEvalMesh1\0glEvalMesh2\0glEvalPoint1\0glEvalPoint2\0glFeedbackBuffer\0glFinish\0"u8 +
        "glFlush\0glFogf\0glFogfv\0glFogi\0glFogiv\0glFrontFace\0glFrustum\0glGenLists\0glGenTextures\0glGetBooleanv\0glGetClipPlane\0glGetDoublev\0glGetError\0glGetFloatv\0glGetIntegerv\0"u8 +
        "glGetLightfv\0glGetLightiv\0glGetMapdv\0glGetMapfv\0glGetMapiv\0glGetMaterialfv\0glGetMaterialiv\0glGetPixelMapfv\0glGetPixelMapuiv\0glGetPixelMapusv\0glGetPointerv\0"u8 +
        "glGetPolygonStipple\0glGetString\0glGetTexEnvfv\0glGetTexEnviv\0glGetTexGendv\0glGetTexGenfv\0glGetTexGeniv\0glGetTexImage\0glGetTexLevelParameterfv\0glGetTexLevelParameteriv\0"u8 +
        "glGetTexParameterfv\0glGetTexParameteriv\0glHint\0glIndexMask\0glIndexPointer\0glIndexd\0glIndexdv\0glIndexf\0glIndexfv\0glIndexi\0glIndexiv\0glIndexs\0glIndexsv\0glIndexub\0"u8 +
        "glIndexubv\0glInitNames\0glInterleavedArrays\0glIsEnabled\0glIsList\0glIsTexture\0glLightModelf\0glLightModelfv\0glLightModeli\0glLightModeliv\0glLightf\0glLightfv\0glLighti\0"u8 +
        "glLightiv\0glLineStipple\0glLineWidth\0glListBase\0glLoadIdentity\0glLoadMatrixd\0glLoadMatrixf\0glLoadName\0glLogicOp\0glMap1d\0glMap1f\0glMap2d\0glMap2f\0glMapGrid1d\0"u8 +
        "glMapGrid1f\0glMapGrid2d\0glMapGrid2f\0glMaterialf\0glMaterialfv\0glMateriali\0glMaterialiv\0glMatrixMode\0glMultMatrixd\0glMultMatrixf\0glNewList\0glNormal3b\0glNormal3bv\0"u8 +
        "glNormal3d\0glNormal3dv\0glNormal3f\0glNormal3fv\0glNormal3i\0glNormal3iv\0glNormal3s\0glNormal3sv\0glNormalPointer\0glOrtho\0glPassThrough\0glPixelMapfv\0glPixelMapuiv\0"u8 +
        "glPixelMapusv\0glPixelStoref\0glPixelStorei\0glPixelTransferf\0glPixelTransferi\0glPixelZoom\0glPointSize\0glPolygonMode\0glPolygonOffset\0glPolygonStipple\0glPopAttrib\0"u8 +
        "glPopClientAttrib\0glPopMatrix\0glPopName\0glPrioritizeTextures\0glPushAttrib\0glPushClientAttrib\0glPushMatrix\0glPushName\0glRasterPos2d\0glRasterPos2dv\0glRasterPos2f\0"u8 +
        "glRasterPos2fv\0glRasterPos2i\0glRasterPos2iv\0glRasterPos2s\0glRasterPos2sv\0glRasterPos3d\0glRasterPos3dv\0glRasterPos3f\0glRasterPos3fv\0glRasterPos3i\0glRasterPos3iv\0"u8 +
        "glRasterPos3s\0glRasterPos3sv\0glRasterPos4d\0glRasterPos4dv\0glRasterPos4f\0glRasterPos4fv\0glRasterPos4i\0glRasterPos4iv\0glRasterPos4s\0glRasterPos4sv\0glReadBuffer\0"u8 +
        "glReadPixels\0glRectd\0glRectdv\0glRectf\0glRectfv\0glRecti\0glRectiv\0glRects\0glRectsv\0glRenderMode\0glRotated\0glRotatef\0glScaled\0glScalef\0glScissor\0glSelectBuffer\0"u8 +
        "glShadeModel\0glStencilFunc\0glStencilMask\0glStencilOp\0glTexCoord1d\0glTexCoord1dv\0glTexCoord1f\0glTexCoord1fv\0glTexCoord1i\0glTexCoord1iv\0glTexCoord1s\0glTexCoord1sv\0"u8 +
        "glTexCoord2d\0glTexCoord2dv\0glTexCoord2f\0glTexCoord2fv\0glTexCoord2i\0glTexCoord2iv\0glTexCoord2s\0glTexCoord2sv\0glTexCoord3d\0glTexCoord3dv\0glTexCoord3f\0glTexCoord3fv\0"u8 +
        "glTexCoord3i\0glTexCoord3iv\0glTexCoord3s\0glTexCoord3sv\0glTexCoord4d\0glTexCoord4dv\0glTexCoord4f\0glTexCoord4fv\0glTexCoord4i\0glTexCoord4iv\0glTexCoord4s\0glTexCoord4sv\0"u8 +
        "glTexCoordPointer\0glTexEnvf\0glTexEnvfv\0glTexEnvi\0glTexEnviv\0glTexGend\0glTexGendv\0glTexGenf\0glTexGenfv\0glTexGeni\0glTexGeniv\0glTexImage1D\0glTexImage2D\0glTexParameterf\0"u8 +
        "glTexParameterfv\0glTexParameteri\0glTexParameteriv\0glTexSubImage1D\0glTexSubImage2D\0glTranslated\0glTranslatef\0glVertex2d\0glVertex2dv\0glVertex2f\0glVertex2fv\0glVertex2i\0"u8 +
        "glVertex2iv\0glVertex2s\0glVertex2sv\0glVertex3d\0glVertex3dv\0glVertex3f\0glVertex3fv\0glVertex3i\0glVertex3iv\0glVertex3s\0glVertex3sv\0glVertex4d\0glVertex4dv\0glVertex4f\0"u8 +
        "glVertex4fv\0glVertex4i\0glVertex4iv\0glVertex4s\0glVertex4sv\0glVertexPointer\0glViewport\0"u8 +
        "wglCopyContext\0wglCreateContext\0wglCreateLayerContext\0wglDeleteContext\0wglGetCurrentContext\0wglGetCurrentDC\0wglGetProcAddress\0wglMakeCurrent\0"u8 +
        "wglShareLists\0wglUseFontBitmapsA\0wglUseFontBitmapsW\0wglSwapBuffers\0"u8).ToArray();

    public void Init()
    {
        if ((ModuleHandle = GetModuleHandle("opengl32")) == 0 ||
            (ModuleHandle = LoadLibrary("opengl32.dll")) == 0)
            return;

        fixed (GLInterface* interfacePtr = &this)
        fixed (byte* namesPtr = FunctionsNames)
        {
            var index = 0;
            for (var i = 0; i < FunctionsNames.Length;)
            {
                ((nint*)interfacePtr)[index++] = GetProcAddress(ModuleHandle, namesPtr + i);

                while (namesPtr[i++] != 0) { }
            }
        }
    }

    public delegate* unmanaged<Op, float, void> glAccum;
    public delegate* unmanaged<Func, float, void> glAlphaFunc;
    public delegate* unmanaged<int, uint*, byte*, byte> glAreTexturesResident;
    public delegate* unmanaged<int, void> glArrayElement;
    public delegate* unmanaged<Mode, void> glBegin;
    public delegate* unmanaged<TexPTarget, uint, void> glBindTexture;
    public delegate* unmanaged<int, int, float, float, float, float, byte*, void> glBitmap;
    public delegate* unmanaged<FactorEnum, FactorEnum, void> glBlendFunc;
    public delegate* unmanaged<uint, void> glCallList;
    public delegate* unmanaged<int, Enums.DataType, pointer, void> glCallLists;
    public delegate* unmanaged<uint, void> glClear;
    public delegate* unmanaged<float, float, float, float, void> glClearAccum;
    public delegate* unmanaged<float, float, float, float, void> glClearColor;
    public delegate* unmanaged<double, void> glClearDepth;
    public delegate* unmanaged<float, void> glClearIndex;
    public delegate* unmanaged<int, void> glClearStencil;
    public delegate* unmanaged<PlaneOrdinal, double*, void> glClipPlane;
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
    public delegate* unmanaged<FaceEnum, MaterialParam, void> glColorMaterial;
    public delegate* unmanaged<int, BType, int, pointer, void> glColorPointer;
    public delegate* unmanaged<int, int, int, int, CopyType, void> glCopyPixels;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, int, void> glCopyTexImage1D;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, int, int, void> glCopyTexImage2D;
    public delegate* unmanaged<TexPTarget, int, int, int, int, int, void> glCopyTexSubImage1D;
    public delegate* unmanaged<TexPTarget, int, int, int, int, int, int, int, void> glCopyTexSubImage2D;
    public delegate* unmanaged<FaceEnum, void> glCullFace;
    public delegate* unmanaged<uint, int, void> glDeleteLists;
    public delegate* unmanaged<int, uint*, void> glDeleteTextures;
    public delegate* unmanaged<Func, void> glDepthFunc;
    public delegate* unmanaged<byte, void> glDepthMask;
    public delegate* unmanaged<double, double, void> glDepthRange;
    public delegate* unmanaged<Cap, void> glDisable;
    public delegate* unmanaged<ArrayState, void> glDisableClientState;
    public delegate* unmanaged<Mode, int, int, void> glDrawArrays;
    public delegate* unmanaged<Mode, void> glDrawBuffer;
    public delegate* unmanaged<Mode, int, BUType, pointer, void> glDrawElements;
    public delegate* unmanaged<int, int, ImageFormat, BType, pointer, void> glDrawPixels;
    public delegate* unmanaged<byte, void> glEdgeFlag;
    public delegate* unmanaged<int, pointer, void> glEdgeFlagPointer;
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
    public delegate* unmanaged<MeshType, int, int, int, int, void> glEvalMesh2;
    public delegate* unmanaged<int, void> glEvalPoint1;
    public delegate* unmanaged<int, int, void> glEvalPoint2;
    public delegate* unmanaged<int, VertexType, float*, void> glFeedbackBuffer;
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
    public delegate* unmanaged<PlaneOrdinal, double*, void> glGetClipPlane;
    public delegate* unmanaged<PName, double*, void> glGetDoublev;
    public delegate* unmanaged<Error> glGetError;
    public delegate* unmanaged<PName, float*, void> glGetFloatv;
    public delegate* unmanaged<PName, int*, void> glGetIntegerv;
    public delegate* unmanaged<LightOrdinal, LightN, float*, void> glGetLightfv;
    public delegate* unmanaged<LightOrdinal, LightN, int*, void> glGetLightiv;
    public delegate* unmanaged<MapTarget, QueryType, double*, void> glGetMapdv;
    public delegate* unmanaged<MapTarget, QueryType, float*, void> glGetMapfv;
    public delegate* unmanaged<MapTarget, QueryType, int*, void> glGetMapiv;
    public delegate* unmanaged<SideEnum, MaterialParam, float*, void> glGetMaterialfv;
    public delegate* unmanaged<SideEnum, MaterialParam, int*, void> glGetMaterialiv;
    public delegate* unmanaged<MapType, float*, void> glGetPixelMapfv;
    public delegate* unmanaged<MapType, uint*, void> glGetPixelMapuiv;
    public delegate* unmanaged<MapType, ushort*, void> glGetPixelMapusv;
    public delegate* unmanaged<PNamePtr, pointer*, void> glGetPointerv;
    public delegate* unmanaged<byte*, void> glGetPolygonStipple;
    public delegate* unmanaged<StringName, byte*> glGetString;
    public delegate* unmanaged<int, TexEnvN, float*, void> glGetTexEnvfv;
    public delegate* unmanaged<int, TexEnvN, int*, void> glGetTexEnviv;
    public delegate* unmanaged<CoordsEnum, TexGenN, double*, void> glGetTexGendv;
    public delegate* unmanaged<CoordsEnum, TexGenN, float*, void> glGetTexGenfv;
    public delegate* unmanaged<CoordsEnum, TexGenN, int*, void> glGetTexGeniv;
    public delegate* unmanaged<TexTarget, int, ImagePixelType, BType, pointer, void> glGetTexImage;
    public delegate* unmanaged<TexPTarget, int, TexN, float*, void> glGetTexLevelParameterfv;
    public delegate* unmanaged<TexPTarget, int, TexN, int*, void> glGetTexLevelParameteriv;
    public delegate* unmanaged<TexTarget, TexNV, float*, void> glGetTexParameterfv;
    public delegate* unmanaged<TexTarget, TexNV, int*, void> glGetTexParameteriv;
    public delegate* unmanaged<Hint, CalcType, void> glHint;
    public delegate* unmanaged<uint, void> glIndexMask;
    public delegate* unmanaged<TexType, int, pointer, void> glIndexPointer;
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
    public delegate* unmanaged<ArrayFormat, int, pointer, void> glInterleavedArrays;
    public delegate* unmanaged<Cap, byte> glIsEnabled;
    public delegate* unmanaged<uint, byte> glIsList;
    public delegate* unmanaged<uint, byte> glIsTexture;
    public delegate* unmanaged<LightModel, float, void> glLightModelf;
    public delegate* unmanaged<LightModel, float*, void> glLightModelfv;
    public delegate* unmanaged<LightModel, int, void> glLightModeli;
    public delegate* unmanaged<LightModel, int*, void> glLightModeliv;
    public delegate* unmanaged<LightOrdinal, LightN, float, void> glLightf;
    public delegate* unmanaged<LightOrdinal, LightN, float*, void> glLightfv;
    public delegate* unmanaged<LightOrdinal, LightN, int, void> glLighti;
    public delegate* unmanaged<LightOrdinal, LightN, int*, void> glLightiv;
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
    public delegate* unmanaged<SideEnum, int, float, void> glMaterialf;
    public delegate* unmanaged<SideEnum, MaterialParam, float*, void> glMaterialfv;
    public delegate* unmanaged<SideEnum, MaterialParam, int, void> glMateriali;
    public delegate* unmanaged<SideEnum, MaterialParam, int*, void> glMaterialiv;
    public delegate* unmanaged<MatrixType, void> glMatrixMode;
    public delegate* unmanaged<double*, void> glMultMatrixd;
    public delegate* unmanaged<float*, void> glMultMatrixf;
    public delegate* unmanaged<uint, CompileState, void> glNewList;
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
    public delegate* unmanaged<PtrType, int, pointer, void> glNormalPointer;
    public delegate* unmanaged<double, double, double, double, double, double, void> glOrtho;
    public delegate* unmanaged<float, void> glPassThrough;
    public delegate* unmanaged<MapType, int, float*, void> glPixelMapfv;
    public delegate* unmanaged<MapType, int, uint*, void> glPixelMapuiv;
    public delegate* unmanaged<MapType, int, ushort*, void> glPixelMapusv;
    public delegate* unmanaged<StoreN, float, void> glPixelStoref;
    public delegate* unmanaged<StoreN, int, void> glPixelStorei;
    public delegate* unmanaged<TransferN, float, void> glPixelTransferf;
    public delegate* unmanaged<TransferN, int, void> glPixelTransferi;
    public delegate* unmanaged<float, float, void> glPixelZoom;
    public delegate* unmanaged<float, void> glPointSize;
    public delegate* unmanaged<MaterialFace, MeshType, void> glPolygonMode;
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
    public delegate* unmanaged<BufType, void> glReadBuffer;
    public delegate* unmanaged<int, int, int, int, ImagePixelType, ReadType, pointer, void> glReadPixels;
    public delegate* unmanaged<double, double, double, double, void> glRectd;
    public delegate* unmanaged<double*, double*, void> glRectdv;
    public delegate* unmanaged<float, float, float, float, void> glRectf;
    public delegate* unmanaged<float*, float*, void> glRectfv;
    public delegate* unmanaged<int, int, int, int, void> glRecti;
    public delegate* unmanaged<int*, int*, void> glRectiv;
    public delegate* unmanaged<short, short, short, short, void> glRects;
    public delegate* unmanaged<short*, short*, void> glRectsv;
    public delegate* unmanaged<RenderEnum, int> glRenderMode;
    public delegate* unmanaged<double, double, double, double, void> glRotated;
    public delegate* unmanaged<float, float, float, float, void> glRotatef;
    public delegate* unmanaged<double, double, double, void> glScaled;
    public delegate* unmanaged<float, float, float, void> glScalef;
    public delegate* unmanaged<int, int, int, int, void> glScissor;
    public delegate* unmanaged<int, uint*, void> glSelectBuffer;
    public delegate* unmanaged<FillType, void> glShadeModel;
    public delegate* unmanaged<Func, int, uint, void> glStencilFunc;
    public delegate* unmanaged<uint, void> glStencilMask;
    public delegate* unmanaged<FailType, FailType, FailType, void> glStencilOp;
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
    public delegate* unmanaged<int, TexType, int, pointer, void> glTexCoordPointer;
    public delegate* unmanaged<int, TexEnvN, float, void> glTexEnvf;
    public delegate* unmanaged<int, TexEnvN, float*, void> glTexEnvfv;
    public delegate* unmanaged<int, TexEnvN, int, void> glTexEnvi;
    public delegate* unmanaged<int, TexEnvN, int*, void> glTexEnviv;
    public delegate* unmanaged<CoordsEnum, TexGen, double, void> glTexGend;
    public delegate* unmanaged<CoordsEnum, TexGen, double*, void> glTexGendv;
    public delegate* unmanaged<CoordsEnum, TexGen, float, void> glTexGenf;
    public delegate* unmanaged<CoordsEnum, TexGen, float*, void> glTexGenfv;
    public delegate* unmanaged<CoordsEnum, TexGen, int, void> glTexGeni;
    public delegate* unmanaged<CoordsEnum, TexGen, int*, void> glTexGeniv;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, ImageFormat, ImageType, pointer, void> glTexImage1D;
    public delegate* unmanaged<TexPTarget, int, InternalFormat, int, int, int, ImageFormat, ImageType, pointer, void> glTexImage2D;
    public delegate* unmanaged<TexTarget, TexNV2, float, void> glTexParameterf;
    public delegate* unmanaged<TexTarget, TexNV2, float*, void> glTexParameterfv;
    public delegate* unmanaged<TexTarget, TexNV2, int, void> glTexParameteri;
    public delegate* unmanaged<TexTarget, TexNV2, int*, void> glTexParameteriv;
    public delegate* unmanaged<int, int, int, int, ImageFormat, ImageType, pointer, void> glTexSubImage1D;
    public delegate* unmanaged<int, int, int, int, int, int, ImageFormat, ImageType, pointer, void> glTexSubImage2D;
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
    public delegate* unmanaged<int, TexType, int, pointer, void> glVertexPointer;
    public delegate* unmanaged<int, int, int, int, void> glViewport;

    /* wgl flavor-functions */
    public delegate* unmanaged<nint, nint, uint, bool> wglCopyContext;
    public delegate* unmanaged<nint, nint> wglCreateContext;
    public delegate* unmanaged<nint, int, nint> wglCreateLayerContext;
    public delegate* unmanaged<nint, bool> wglDeleteContext;
    public delegate* unmanaged<nint> wglGetCurrentContext;
    public delegate* unmanaged<nint> wglGetCurrentDC;
    public delegate* unmanaged<byte*, nint> wglGetProcAddress;
    public delegate* unmanaged<nint, nint, bool> wglMakeCurrent;
    public delegate* unmanaged<nint, nint, bool> wglShareLists;
    public delegate* unmanaged<nint, uint, uint, uint, bool> wglUseFontBitmapsA;
    public delegate* unmanaged<nint, uint, uint, uint, bool> wglUseFontBitmapsW;
    public delegate* unmanaged<nint, bool> wglSwapBuffers;

    public nint ModuleHandle;
}