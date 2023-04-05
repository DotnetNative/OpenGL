using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL;

public unsafe static class Enums
{
    private const int GL_ACCUM = 256;
    private const int GL_LOAD = 257;
    private const int GL_RETURN = 258;
    private const int GL_MULT = 259;
    private const int GL_ADD = 260;
    public enum Op : int
    {
        Accum = GL_ACCUM,
        Load = GL_LOAD,
        Return = GL_RETURN,
        Mult = GL_MULT,
        Add = GL_ADD
    }

    private const int GL_POINTS = 0;
    private const int GL_LINES = 1;
    private const int GL_LINE_LOOP = 2;
    private const int GL_LINE_STRIP = 3;
    private const int GL_TRIANGLES = 4;
    private const int GL_TRIANGLE_STRIP = 5;
    private const int GL_TRIANGLE_FAN = 6;
    private const int GL_QUADS = 7;
    private const int GL_QUAD_STRIP = 8;
    private const int GL_POLYGON = 9;
    public enum Mode : int
    {
        Points = GL_POINTS,
        Lines = GL_LINES,
        LineLoop = GL_LINE_LOOP,
        LineStrip = GL_LINE_STRIP,
        Triangles = GL_TRIANGLES,
        TriangleStript = GL_TRIANGLE_STRIP,
        TriangleFan = GL_TRIANGLE_FAN,
        Quads = GL_QUADS,
        QuadStript = GL_QUAD_STRIP,
        Polygon = GL_POLYGON
    }

    private const int GL_NEVER = 512;
    private const int GL_LESS = 513;
    private const int GL_EQUAL = 514;
    private const int GL_LEQUAL = 515;
    private const int GL_GREATER = 516;
    private const int GL_NOTEQUAL = 517;
    private const int GL_GEQUAL = 518;
    private const int GL_ALWAYS = 519;
    public enum Func : int
    {
        Never = GL_NEVER,
        Less = GL_LESS,
        Equal = GL_EQUAL,
        Lequal = GL_LEQUAL,
        Greater = GL_GREATER,
        Notequal = GL_NOTEQUAL,
        Gequal = GL_GEQUAL,
        Always = GL_ALWAYS
    }

    private const int GL_CURRENT_BIT = 1;
    private const int GL_POINT_BIT = 2;
    private const int GL_LINE_BIT = 4;
    private const int GL_POLYGON_BIT = 8;
    private const int GL_POLYGON_STIPPLE_BIT = 16;
    private const int GL_PIXEL_MODE_BIT = 32;
    private const int GL_LIGHTING_BIT = 64;
    private const int GL_FOG_BIT = 128;
    private const int GL_DEPTH_BUFFER_BIT = 256;
    private const int GL_ACCUM_BUFFER_BIT = 512;
    private const int GL_STENCIL_BUFFER_BIT = 1024;
    private const int GL_VIEWPORT_BIT = 2048;
    private const int GL_TRANSFORM_BIT = 4096;
    private const int GL_ENABLE_BIT = 8192;
    private const int GL_COLOR_BUFFER_BIT = 16384;
    private const int GL_HINT_BIT = 32768;
    private const int GL_EVAL_BIT = 65536;
    private const int GL_LIST_BIT = 131072;
    private const int GL_TEXTURE_BIT = 262144;
    private const int GL_SCISSOR_BIT = 524288;
    private const int GL_ALL_ATTRIB_BITS = 1048575;
    public enum Mask : int
    {
        Current = GL_CURRENT_BIT,
        Point = GL_POINT_BIT,
        Line = GL_LINE_BIT,
        Polygon = GL_POLYGON_BIT,
        PolygonStipple = GL_POLYGON_STIPPLE_BIT,
        Pixel = GL_PIXEL_MODE_BIT,
        Lighting = GL_LIGHTING_BIT,
        Log = GL_FOG_BIT,
        Depth = GL_DEPTH_BUFFER_BIT,
        Accum = GL_ACCUM_BUFFER_BIT,
        Stencil = GL_STENCIL_BUFFER_BIT,
        Viewport = GL_VIEWPORT_BIT,
        Transform = GL_TRANSFORM_BIT,
        Enable = GL_ENABLE_BIT,
        Color = GL_COLOR_BUFFER_BIT,
        Hint = GL_HINT_BIT,
        Eval = GL_EVAL_BIT,
        List = GL_LIST_BIT,
        Texture = GL_TEXTURE_BIT,
        Scissor = GL_SCISSOR_BIT,
        All = GL_ALL_ATTRIB_BITS
    }

    public enum Light : int
    {
        Light0 = GL_LIGHT0,
        Light1 = GL_LIGHT1,
        Light2 = GL_LIGHT2,
        Light3 = GL_LIGHT3,
        Light4 = GL_LIGHT4,
        Light5 = GL_LIGHT5,
        Light6 = GL_LIGHT6,
        Light7 = GL_LIGHT7,
    }

    private const int GL_ZERO = 0;
    private const int GL_ONE = 1;
    private const int GL_SRC_COLOR = 768;
    private const int GL_ONE_MINUS_SRC_COLOR = 769;
    private const int GL_SRC_ALPHA = 770;
    private const int GL_ONE_MINUS_SRC_ALPHA = 771;
    private const int GL_DST_ALPHA = 772;
    private const int GL_ONE_MINUS_DST_ALPHA = 773;
    private const int GL_DST_COLOR = 774;
    private const int GL_ONE_MINUS_DST_COLOR = 775;
    private const int GL_SRC_ALPHA_SATURATE = 776;
    private const int GL_CONSTANT_COLOR = 32769;
    private const int GL_ONE_MINUS_CONSTANT_COLOR = 32770;
    private const int GL_CONSTANT_ALPHA = 32771;
    private const int GL_ONE_MINUS_CONSTANT_ALPHA = 32772;
    public enum Factor : int
    {
        Zero = GL_ZERO,
        One = GL_ONE,
        SrcColor = GL_SRC_COLOR,
        OneMinusSrcColor = GL_ONE_MINUS_SRC_COLOR,
        SrcAlpha = GL_SRC_ALPHA,
        OneMinusSrcAlpha = GL_ONE_MINUS_SRC_ALPHA,
        DstAlpha = GL_DST_ALPHA,
        OneMinusDstAlpha = GL_ONE_MINUS_DST_ALPHA,
        DstColor = GL_DST_COLOR,
        OneMinusDstColor = GL_ONE_MINUS_DST_COLOR,
        SrcAlphaSaturate = GL_SRC_ALPHA_SATURATE,
        ConstColor = GL_CONSTANT_COLOR,
        OneMinusConstColor = GL_ONE_MINUS_CONSTANT_COLOR,
        ConstAlpha = GL_CONSTANT_ALPHA,
        OneMinusConstAlpha = GL_ONE_MINUS_CONSTANT_ALPHA
    }

    private const int GL_TRUE = 1;
    private const int GL_FALSE = 0;
    public enum Bool : int
    {
        True = GL_TRUE, 
        False = GL_FALSE,
    }

    private const int GL_CLIP_PLANE0 = 12288;
    private const int GL_CLIP_PLANE1 = 12289;
    private const int GL_CLIP_PLANE2 = 12290;
    private const int GL_CLIP_PLANE3 = 12291;
    private const int GL_CLIP_PLANE4 = 12292;
    private const int GL_CLIP_PLANE5 = 12293;
    public enum Plane : int
    {
        Plane0 = GL_CLIP_PLANE0,
        Plane1 = GL_CLIP_PLANE1,
        Plane2 = GL_CLIP_PLANE2,
        Plane3 = GL_CLIP_PLANE3,
        Plane4 = GL_CLIP_PLANE4,
        Plane5 = GL_CLIP_PLANE5,
    }

    private const int GL_BYTE = 5120;
    private const int GL_UNSIGNED_BYTE = 5121;
    private const int GL_SHORT = 5122;
    private const int GL_UNSIGNED_SHORT = 5123;
    private const int GL_INT = 5124;
    private const int GL_UNSIGNED_INT = 5125;
    private const int GL_FLOAT = 5126;
    private const int GL_2_BYTES = 5127;
    private const int GL_3_BYTES = 5128;
    private const int GL_4_BYTES = 5129;
    private const int GL_DOUBLE = 5130;
    public enum Type : int 
    {
        Byte = GL_BYTE,
        UByte = GL_UNSIGNED_BYTE,
        Short = GL_SHORT,
        UShort = GL_UNSIGNED_SHORT,
        Int = GL_INT,
        UInt = GL_UNSIGNED_INT,
        Float = GL_FLOAT,
        I2 = GL_2_BYTES,
        I3 = GL_3_BYTES,
        I4 = GL_4_BYTES,
        Double = GL_DOUBLE    
    }  
    
    public enum BType : int
    {
        Byte = GL_BYTE,
        UByte = GL_UNSIGNED_BYTE,
        Short = GL_SHORT,
        UShort = GL_UNSIGNED_SHORT,
        Int = GL_INT,
        UInt = GL_UNSIGNED_INT,
        Float = GL_FLOAT,
        Double = GL_DOUBLE
    }

    public enum BUType : int 
    { 
        UByte = GL_UNSIGNED_BYTE,
        UShort = GL_UNSIGNED_SHORT,
        UInt = GL_UNSIGNED_INT,
    }

    public enum BSType : int
    {
        Byte = GL_BYTE,
        Short = GL_SHORT,
        Int = GL_INT,
    }

    public enum PtrType : int
    {
        Byte = GL_BYTE,
        Short = GL_SHORT,
        Int = GL_INT, 
        Float = GL_FLOAT,
        Double = GL_DOUBLE,
    }

    public enum TexType : int
    {
        Short = GL_SHORT,
        Int = GL_INT,
        Float = GL_FLOAT,
        Double = GL_DOUBLE
    }

    public enum ImageType : int 
    {
        Byte = GL_BYTE,
        UByte = GL_UNSIGNED_BYTE,
        Short = GL_UNSIGNED_SHORT,
        UShort = GL_SHORT,
        UInt = GL_UNSIGNED_INT,
        Int = GL_INT,
        Bitmap = GL_BITMAP,
    }

    public enum ReadType : int
    {
        Byte = GL_BYTE,
        UByte = GL_UNSIGNED_BYTE,
        Short = GL_UNSIGNED_SHORT,
        UShort = GL_SHORT,
        UInt = GL_UNSIGNED_INT,
        Int = GL_INT,
        Bitmap = GL_BITMAP,
        Float = GL_FLOAT
    }

    private const int GL_NONE = 0;
    private const int GL_FRONT_LEFT = 1024;
    private const int GL_FRONT_RIGHT = 1025;
    private const int GL_BACK_LEFT = 1026;
    private const int GL_BACK_RIGHT = 1027;
    private const int GL_FRONT = 1028;
    private const int GL_BACK = 1029;
    private const int GL_LEFT = 1030;
    private const int GL_RIGHT = 1031;
    private const int GL_FRONT_AND_BACK = 1032;
    private const int GL_AUX0 = 1033;
    private const int GL_AUX1 = 1034;
    private const int GL_AUX2 = 1035;
    private const int GL_AUX3 = 1036;
    public enum Buf : int
    {
        None = GL_NONE,
        FrontLeft = GL_FRONT_LEFT,
        FrontRight = GL_FRONT_RIGHT,
        BackLeft = GL_BACK_LEFT,
        BackRight = GL_BACK_RIGHT,
        Front = GL_FRONT,
        Back = GL_BACK,
        Left = GL_LEFT,
        Right = GL_RIGHT,
        FrontAndBack = GL_FRONT_AND_BACK,
        Aux0 = GL_AUX0,
        Aux1 = GL_AUX1,
        Aux2 = GL_AUX2,
        Aux3 = GL_AUX3
    }

    private const int GL_NO_ERROR = 0;
    private const int GL_INVALID_ENUM = 1280;
    private const int GL_INVALID_VALUE = 1281;
    private const int GL_INVALID_OPERATION = 1282;
    private const int GL_STACK_OVERFLOW = 1283;
    private const int GL_STACK_UNDERFLOW = 1284;
    private const int GL_OUT_OF_MEMORY = 1285;
    public enum Error : int
    {
        NoError = GL_NO_ERROR,
        InvalidEnum = GL_INVALID_ENUM,
        InvalidValue = GL_INVALID_VALUE,
        InvalidOperation = GL_INVALID_OPERATION,
        StackOverflow = GL_STACK_OVERFLOW,
        StackUnderflow = GL_STACK_UNDERFLOW,
        OutOfMemory = GL_OUT_OF_MEMORY
    }

    private const int GL_2D = 1536;
    private const int GL_3D = 1537;
    private const int GL_3D_COLOR = 1538;
    private const int GL_3D_COLOR_TEXTURE = 1539;
    private const int GL_4D_COLOR_TEXTURE = 1540;
    public enum Vertex : int
    {
        V2D = GL_2D,
        V3D = GL_3D,
        V3DColor = GL_3D_COLOR,
        V3DColorTexture = GL_3D_COLOR_TEXTURE,
        V4DColorTexture = GL_4D_COLOR_TEXTURE,
    }

    private const int GL_PASS_THROUGH_TOKEN = 1792;
    private const int GL_POINT_TOKEN = 1793;
    private const int GL_LINE_TOKEN = 1794;
    private const int GL_POLYGON_TOKEN = 1795;
    private const int GL_BITMAP_TOKEN = 1796;
    private const int GL_DRAW_PIXEL_TOKEN = 1797;
    private const int GL_COPY_PIXEL_TOKEN = 1798;
    private const int GL_LINE_RESET_TOKEN = 1799;
    public enum Token : int
    {
        PassThrough = GL_PASS_THROUGH_TOKEN,
        Point = GL_POINT_TOKEN,
        Line = GL_LINE_TOKEN,
        Polygon = GL_POLYGON_TOKEN,
        Bitmap = GL_BITMAP_TOKEN,
        DrawPixel = GL_DRAW_PIXEL_TOKEN,
        CopyPixel = GL_COPY_PIXEL_TOKEN,
        LineReset = GL_LINE_RESET_TOKEN
    }

    private const int GL_CW = 2304;
    private const int GL_CCW = 2305;
    public enum FaceMode : int
    {
        CW = GL_CW,
        CCW = GL_CCW
    }

    public enum Face : int
    {
        Front = GL_FRONT,
        Back = GL_BACK,
        FrontAndBack = GL_FRONT_AND_BACK
    }

    private const int GL_COEFF = 2560;
    private const int GL_ORDER = 2561;
    private const int GL_DOMAIN = 2562;
    public enum Query : int
    {
        Coeff = GL_COEFF,
        Order = GL_ORDER,
        Domain = GL_DOMAIN
    }

    private const int GL_MAP1_COLOR_4 = 3472;
    private const int GL_MAP1_INDEX = 3473;
    private const int GL_MAP1_NORMAL = 3474;
    private const int GL_MAP1_TEXTURE_COORD_1 = 3475;
    private const int GL_MAP1_TEXTURE_COORD_2 = 3476;
    private const int GL_MAP1_TEXTURE_COORD_3 = 3477;
    private const int GL_MAP1_TEXTURE_COORD_4 = 3478;
    private const int GL_MAP1_VERTEX_3 = 3479;
    private const int GL_MAP1_VERTEX_4 = 3480;
    private const int GL_MAP2_COLOR_4 = 3504;
    private const int GL_MAP2_INDEX = 3505;
    private const int GL_MAP2_NORMAL = 3506;
    private const int GL_MAP2_TEXTURE_COORD_1 = 3507;
    private const int GL_MAP2_TEXTURE_COORD_2 = 3508;
    private const int GL_MAP2_TEXTURE_COORD_3 = 3509;
    private const int GL_MAP2_TEXTURE_COORD_4 = 3510;
    private const int GL_MAP2_VERTEX_3 = 3511;
    private const int GL_MAP2_VERTEX_4 = 3512;
    private const int GL_MAP1_GRID_DOMAIN = 3536;
    private const int GL_MAP1_GRID_SEGMENTS = 3537;
    private const int GL_MAP2_GRID_DOMAIN = 3538;
    private const int GL_MAP2_GRID_SEGMENTS = 3539;
    public enum Target : int
    {
        Map1Color = GL_MAP1_COLOR_4,
        Map1Index = GL_MAP1_INDEX,
        Map1Normal = GL_MAP1_NORMAL,
        Map1TextureCoord1 = GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = GL_MAP1_TEXTURE_COORD_4,
        Map1Vertex3 = GL_MAP1_VERTEX_3,
        Map1Vertex4 = GL_MAP1_VERTEX_4,
        Map1GridDomain = GL_MAP1_GRID_DOMAIN,
        Map1GridSegments = GL_MAP1_GRID_SEGMENTS,
        Map2Color = GL_MAP2_COLOR_4,
        Map2Index = GL_MAP2_INDEX,
        Map2Normal = GL_MAP2_NORMAL,
        Map2TextureCoord1 = GL_MAP2_TEXTURE_COORD_1,
        Map2TextureCoord2 = GL_MAP2_TEXTURE_COORD_2,
        Map2TextureCoord3 = GL_MAP2_TEXTURE_COORD_3,
        Map2TextureCoord4 = GL_MAP2_TEXTURE_COORD_4,
        Map2Vertex3 = GL_MAP2_VERTEX_3,
        Map2Vertex4 = GL_MAP2_VERTEX_4,
        Map2GridDomain = GL_MAP2_GRID_DOMAIN,
        Map2GridSegments = GL_MAP2_GRID_SEGMENTS,
    }

    public enum Map1Target : int
    {
        Map1Vertex3 = GL_MAP1_VERTEX_3,
        Map1Vertex4 = GL_MAP1_VERTEX_4,
        Map1Color = GL_MAP1_COLOR_4,
        Map1Index = GL_MAP1_INDEX,
        Map1Normal = GL_MAP1_NORMAL,
        Map1TextureCoord1 = GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = GL_MAP1_TEXTURE_COORD_4,
    }

    public enum MapTarget : int
    {
        Map1Color = GL_MAP1_COLOR_4,
        Map1Index = GL_MAP1_INDEX,
        Map1Normal = GL_MAP1_NORMAL,
        Map1TextureCoord1 = GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = GL_MAP1_TEXTURE_COORD_4,
        Map1Vertex3 = GL_MAP1_VERTEX_3,
        Map1Vertex4 = GL_MAP1_VERTEX_4,
        Map2Color = GL_MAP2_COLOR_4,
        Map2Index = GL_MAP2_INDEX,
        Map2Normal = GL_MAP2_NORMAL,
        Map2TextureCoord1 = GL_MAP2_TEXTURE_COORD_1,
        Map2TextureCoord2 = GL_MAP2_TEXTURE_COORD_2,
        Map2TextureCoord3 = GL_MAP2_TEXTURE_COORD_3,
        Map2TextureCoord4 = GL_MAP2_TEXTURE_COORD_4,
        Map2Vertex3 = GL_MAP2_VERTEX_3,
        Map2Vertex4 = GL_MAP2_VERTEX_4,
    }

    private const int GL_CURRENT_COLOR = 2816;
    private const int GL_CURRENT_NORMAL = 2818;
    private const int GL_CURRENT_TEXTURE_COORDS = 2819;
    private const int GL_POINT_SIZE = 2833;
    private const int GL_LINE_WIDTH = 2849;
    private const int GL_LINE_STIPPLE_PATTERN = 2853;
    private const int GL_LINE_STIPPLE_REPEAT = 2854;
    private const int GL_MAX_LIST_NESTING = 2865;
    private const int GL_LIST_BASE = 2866;
    private const int GL_POLYGON_MODE = 2880;
    private const int GL_EDGE_FLAG = 2883;
    private const int GL_CULL_FACE_MODE = 2885;
    private const int GL_FRONT_FACE = 2886;
    private const int GL_SHADE_MODEL = 2900;
    private const int GL_COLOR_MATERIAL_PARAMETER = 2902;
    private const int GL_DEPTH_RANGE = 2928;
    private const int GL_DEPTH_WRITEMASK = 2930;
    private const int GL_DEPTH_CLEAR_VALUE = 2931;
    private const int GL_DEPTH_FUNC = 2932;
    private const int GL_ACCUM_CLEAR_VALUE = 2944;
    private const int GL_STENCIL_CLEAR_VALUE = 2961;
    private const int GL_STENCIL_FUNC = 2962;
    private const int GL_STENCIL_VALUE_MASK = 2963;
    private const int GL_STENCIL_FAIL = 2964;
    private const int GL_STENCIL_PASS_DEPTH_FAIL = 2965;
    private const int GL_STENCIL_PASS_DEPTH_PASS = 2966;
    private const int GL_STENCIL_REF = 2967;
    private const int GL_STENCIL_WRITEMASK = 2968;
    private const int GL_STENCIL_BITS = 3415;
    private const int GL_MATRIX_MODE = 2976;
    private const int GL_VIEWPORT = 2978;
    private const int GL_MODELVIEW_STACK_DEPTH = 2979;
    private const int GL_PROJECTION_STACK_DEPTH = 2980;
    private const int GL_TEXTURE_STACK_DEPTH = 2981;
    private const int GL_MODELVIEW_MATRIX = 2982;
    private const int GL_PROJECTION_MATRIX = 2983;
    private const int GL_TEXTURE_MATRIX = 2984;
    private const int GL_ATTRIB_STACK_DEPTH = 2992;
    private const int GL_MAX_ATTRIB_STACK_DEPTH = 3381;
    private const int GL_ACCUM_ALPHA_BITS = 3419;
    private const int GL_ACCUM_BLUE_BITS = 3418;
    private const int GL_ACCUM_GREEN_BITS = 3417;
    private const int GL_ACCUM_RED_BITS = 3416;
    private const int GL_ALPHA_BIAS = 3357;
    private const int GL_ALPHA_BITS = 3413;
    private const int GL_ALPHA_SCALE = 3356;
    private const int GL_ALPHA_TEST = 3008;
    private const int GL_ALPHA_TEST_FUNC = 3009;
    private const int GL_ALPHA_TEST_REF = 3010;
    private const int GL_AUTO_NORMAL = 3456;
    private const int GL_AUX_BUFFERS = 3072;
    private const int GL_BLEND_DST = 3040;
    private const int GL_BLEND_SRC = 3041;
    private const int GL_BLUE_BITS = 3412;
    private const int GL_BLUE_BIAS = 3355;
    private const int GL_BLUE_SCALE = 3354;
    private const int GL_CLIENT_ATTRIB_STACK_DEPTH = 2993;
    private const int GL_COLOR_ARRAY = 32886;
    private const int GL_COLOR_ARRAY_SIZE = 32897;
    private const int GL_COLOR_ARRAY_STRIDE = 32899;
    private const int GL_COLOR_ARRAY_TYPE = 32898;
    private const int GL_COLOR_CLEAR_VALUE = 3106;
    private const int GL_COLOR_MATERIAL = 2903;
    private const int GL_COLOR_WRITEMASK = 3107;
    private const int GL_CURRENT_INDEX = 2817;
    private const int GL_CURRENT_RASTER_DISTANCE = 2825;
    private const int GL_CURRENT_RASTER_INDEX = 2821;
    private const int GL_CURRENT_RASTER_POSITION = 2823;
    private const int GL_CURRENT_RASTER_POSITION_VALID = 2824;
    private const int GL_CURRENT_RASTER_TEXTURE_COORDS = 2822;
    private const int GL_DEPTH_BIAS = 3359;
    private const int GL_DEPTH_BITS = 3414;
    private const int GL_DEPTH_SCALE = 3358;
    private const int GL_DOUBLEBUFFER = 3122;
    private const int GL_DRAW_BUFFER = 3073;
    private const int GL_EDGE_FLAG_ARRAY = 32889;
    private const int GL_EDGE_FLAG_ARRAY_STRIDE = 32908;
    private const int GL_FOG = 2912;
    private const int GL_FOG_HINT = 3156;
    private const int GL_GREEN_BIAS = 3353;
    private const int GL_GREEN_BITS = 3411;
    private const int GL_GREEN_SCALE = 3352;
    private const int GL_INDEX_ARRAY = 32887;
    private const int GL_INDEX_ARRAY_TYPE = 32901;
    private const int GL_INDEX_ARRAY_STRIDE = 32902;
    private const int GL_INDEX_BITS = 3409;
    private const int GL_INDEX_CLEAR_VALUE = 3104;
    private const int GL_INDEX_MODE = 3120;
    private const int GL_INDEX_OFFSET = 3347;
    private const int GL_INDEX_SHIFT = 3346;
    private const int GL_INDEX_WRITEMASK = 3105;
    private const int GL_LIGHT0 = 16384;
    private const int GL_LIGHT1 = 16385;
    private const int GL_LIGHT2 = 16386;
    private const int GL_LIGHT3 = 16387;
    private const int GL_LIGHT4 = 16388;
    private const int GL_LIGHT5 = 16389;
    private const int GL_LIGHT6 = 16390;
    private const int GL_LIGHT7 = 16391;
    private const int GL_LINE_SMOOTH_HINT = 3154;
    private const int GL_LINE_WIDTH_RANGE = 2850;
    private const int GL_LINE_WIDTH_GRANULARITY = 2851;
    private const int GL_LIST_INDEX = 2867;
    private const int GL_LIST_MODE = 2864;
    private const int GL_LOGIC_OP = 3057;
    private const int GL_MAP_COLOR = 3344;
    private const int GL_MAP_STENCIL = 3345;
    private const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 3387;
    private const int GL_MAX_CLIP_PLANES = 3378;
    private const int GL_MAX_MODELVIEW_STACK_DEPTH = 3382;
    private const int GL_MAX_EVAL_ORDER = 3376;
    private const int GL_MAX_NAME_STACK_DEPTH = 3383;
    private const int GL_MAX_PIXEL_MAP_TABLE = 3380;
    private const int GL_MAX_PROJECTION_STACK_DEPTH = 3384;
    private const int GL_MAX_TEXTURE_SIZE = 3379;
    private const int GL_MAX_TEXTURE_STACK_DEPTH = 3385;
    private const int GL_MAX_VIEWPORT_DIMS = 3386;
    private const int GL_NAME_STACK_DEPTH = 3440;
    private const int GL_NORMAL_ARRAY = 32885;
    private const int GL_NORMAL_ARRAY_TYPE = 32894;
    private const int GL_NORMAL_ARRAY_STRIDE = 32895;
    private const int GL_PACK_ALIGNMENT = 3333;
    private const int GL_PACK_LSB_FIRST = 3329;
    private const int GL_PACK_ROW_LENGTH = 3330;
    private const int GL_PACK_SKIP_PIXELS = 3332;
    private const int GL_PACK_SKIP_ROWS = 3331;
    private const int GL_PACK_SWAP_BYTES = 3328;
    private const int GL_PERSPECTIVE_CORRECTION_HINT = 3152;
    private const int GL_PIXEL_MAP_I_TO_I_SIZE = 3248;
    private const int GL_PIXEL_MAP_S_TO_S_SIZE = 3249;
    private const int GL_PIXEL_MAP_I_TO_R_SIZE = 3250;
    private const int GL_PIXEL_MAP_I_TO_G_SIZE = 3251;
    private const int GL_PIXEL_MAP_I_TO_B_SIZE = 3252;
    private const int GL_PIXEL_MAP_I_TO_A_SIZE = 3253;
    private const int GL_PIXEL_MAP_R_TO_R_SIZE = 3254;
    private const int GL_PIXEL_MAP_G_TO_G_SIZE = 3255;
    private const int GL_PIXEL_MAP_B_TO_B_SIZE = 3256;
    private const int GL_PIXEL_MAP_A_TO_A_SIZE = 3257;
    private const int GL_POINT_SIZE_RANGE = 2834;
    private const int GL_POINT_SIZE_GRANULARITY = 2835;
    private const int GL_POLYGON_OFFSET_FACTOR = 32824;
    private const int GL_POLYGON_OFFSET_UNITS = 10752;
    private const int GL_POLYGON_SMOOTH_HINT = 3155;
    private const int GL_READ_BUFFER = 3074;
    private const int GL_RED_BIAS = 3349;
    private const int GL_RED_BITS = 3410;
    private const int GL_RED_SCALE = 3348;
    private const int GL_RENDER_MODE = 3136;
    private const int GL_RGBA_MODE = 3121;
    private const int GL_SCISSOR_BOX = 3088;
    private const int GL_STEREO = 3123;
    private const int GL_SUBPIXEL_BITS = 3408;
    private const int GL_TEXTURE_COORD_ARRAY = 32888;
    private const int GL_TEXTURE_COORD_ARRAY_SIZE = 32904;
    private const int GL_TEXTURE_COORD_ARRAY_TYPE = 32905;
    private const int GL_TEXTURE_COORD_ARRAY_STRIDE = 32906;
    private const int GL_TEXTURE_ENV_COLOR = 8705;
    private const int GL_TEXTURE_ENV_MODE = 8704;
    private const int GL_UNPACK_ALIGNMENT = 3317;
    private const int GL_UNPACK_LSB_FIRST = 3313;
    private const int GL_UNPACK_ROW_LENGTH = 3314;
    private const int GL_UNPACK_SKIP_PIXELS = 3316;
    private const int GL_UNPACK_SKIP_ROWS = 3315;
    private const int GL_UNPACK_SWAP_BYTES = 3312;
    private const int GL_VERTEX_ARRAY = 32884;
    private const int GL_VERTEX_ARRAY_SIZE = 32890;
    private const int GL_VERTEX_ARRAY_TYPE = 32891;
    private const int GL_VERTEX_ARRAY_STRIDE = 32892;
    private const int GL_ZOOM_X = 3350;
    private const int GL_ZOOM_Y = 3351;
    private const int GL_POINT_SMOOTH = 2832;
    private const int GL_POINT_SMOOTH_HINT = 3153;
    private const int GL_FEEDBACK_BUFFER_SIZE = 3569;
    private const int GL_SELECTION_BUFFER_SIZE = 3572;
    private const int GL_FEEDBACK_BUFFER_TYPE = 3570;
    public enum PName : int
    {
        AccumAlphaBits = GL_ACCUM_ALPHA_BITS,
        AccumBlueBits = GL_ACCUM_BLUE_BITS,
        AccumClearValue = GL_ACCUM_CLEAR_VALUE,
        AccumGreenBits = GL_ACCUM_GREEN_BITS,
        AccumRedBits = GL_ACCUM_RED_BITS,
        AlphaBias = GL_ALPHA_BIAS,
        AlphaBits = GL_ALPHA_BITS,
        AlphaScale = GL_ALPHA_SCALE,
        AlphaTest = GL_ALPHA_TEST,
        AlphaTestFunc = GL_ALPHA_TEST_FUNC,
        AlphaTestRef = GL_ALPHA_TEST_REF,
        AttribStackDepth = GL_ATTRIB_STACK_DEPTH,
        AutoNormal = GL_AUTO_NORMAL,
        AuxBuffers = GL_AUX_BUFFERS,
        Blend = GL_BLEND,
        BlendDst = GL_BLEND_DST,
        BlendSrc = GL_BLEND_SRC,
        BlueBias = GL_BLUE_BIAS,
        BlueBits = GL_BLUE_BITS,
        BlueScale = GL_BLUE_SCALE,
        ClientAttribStackDepth = GL_CLIENT_ATTRIB_STACK_DEPTH,
        ClipPlane0 = GL_CLIP_PLANE0,
        ClipPlane1 = GL_CLIP_PLANE1,
        ClipPlane2 = GL_CLIP_PLANE2,
        ClipPlane3 = GL_CLIP_PLANE3,
        ClipPlane4 = GL_CLIP_PLANE4,
        ClipPlane5 = GL_CLIP_PLANE5,
        ColorArray = GL_COLOR_ARRAY,
        ColorArraySize = GL_COLOR_ARRAY_SIZE,
        ColorArrayStride = GL_COLOR_ARRAY_STRIDE,
        ColorArrayType = GL_COLOR_ARRAY_TYPE,
        ColorClearValue = GL_COLOR_CLEAR_VALUE,
        ColorLogicOp = GL_COLOR_LOGIC_OP,
        ColorMaterial = GL_COLOR_MATERIAL,
        ColorMaterialFace = GL_COLOR_MATERIAL_FACE,
        ColorMaterialParameter = GL_COLOR_MATERIAL_PARAMETER,
        ColorWritemask = GL_COLOR_WRITEMASK,
        CullFace = GL_CULL_FACE,
        CullFaceMode = GL_CULL_FACE_MODE,
        CurrentColor = GL_CURRENT_COLOR,
        CurrentIndex = GL_CURRENT_INDEX,
        CurrentNormal = GL_CURRENT_NORMAL,
        CurrentRasterColor = GL_CURRENT_RASTER_COLOR,
        CurrentRasterDistance = GL_CURRENT_RASTER_DISTANCE,
        CurrentRasterIndex = GL_CURRENT_RASTER_INDEX,
        CurrentRasterPosition = GL_CURRENT_RASTER_POSITION,
        CurrentRasterPositionValid = GL_CURRENT_RASTER_POSITION_VALID,
        CurrentRasterTextureCoords = GL_CURRENT_RASTER_TEXTURE_COORDS,
        CurrentTextureCoords = GL_CURRENT_TEXTURE_COORDS,
        DepthBias = GL_DEPTH_BIAS,
        DepthBits = GL_DEPTH_BITS,
        DepthClearValue = GL_DEPTH_CLEAR_VALUE,
        DepthFunc = GL_DEPTH_FUNC,
        DepthRange = GL_DEPTH_RANGE,
        DepthScale = GL_DEPTH_SCALE,
        DepthTest = GL_DEPTH_TEST,
        DepthWritemask = GL_DEPTH_WRITEMASK,
        Dither = GL_DITHER,
        Doublebuffer = GL_DOUBLEBUFFER,
        DrawBuffer = GL_DRAW_BUFFER,
        EdgeFlag = GL_EDGE_FLAG,
        EdgeFlagArray = GL_EDGE_FLAG_ARRAY,
        EdgeFlagArrayStride = GL_EDGE_FLAG_ARRAY_STRIDE,
        Fog = GL_FOG,
        FogColor = GL_FOG_COLOR,
        FogDensity = GL_FOG_DENSITY,
        FogEnd = GL_FOG_END,
        FogHint = GL_FOG_HINT,
        FogIndex = GL_FOG_INDEX,
        FogMode = GL_FOG_MODE,
        FogStart = GL_FOG_START,
        FrontFace = GL_FRONT_FACE,
        GreenBias = GL_GREEN_BIAS,
        GreenBits = GL_GREEN_BITS,
        GreenScale = GL_GREEN_SCALE,
        IndexArray = GL_INDEX_ARRAY,
        IndexArrayStride = GL_INDEX_ARRAY_STRIDE,
        IndexArrayType = GL_INDEX_ARRAY_TYPE,
        IndexBits = GL_INDEX_BITS,
        IndexClearValue = GL_INDEX_CLEAR_VALUE,
        IndexLogicOp = GL_INDEX_LOGIC_OP,
        IndexMode = GL_INDEX_MODE,
        IndexOffset = GL_INDEX_OFFSET,
        IndexShift = GL_INDEX_SHIFT,
        IndexWritemask = GL_INDEX_WRITEMASK,
        Light0 = GL_LIGHT0,
        Light1 = GL_LIGHT1,
        Light2 = GL_LIGHT2,
        Light3 = GL_LIGHT3,
        Light4 = GL_LIGHT4,
        Light5 = GL_LIGHT5,
        Light6 = GL_LIGHT6,
        Light7 = GL_LIGHT7,
        Lighting = GL_LIGHTING,
        LightModelAmbient = GL_LIGHT_MODEL_AMBIENT,
        LightModelLocalViewer = GL_LIGHT_MODEL_LOCAL_VIEWER,
        LightModelTwoSide = GL_LIGHT_MODEL_TWO_SIDE,
        LineSmooth = GL_LINE_SMOOTH,
        LineSmoothHint = GL_LINE_SMOOTH_HINT,
        LineStipple = GL_LINE_STIPPLE,
        LineStipplePattern = GL_LINE_STIPPLE_PATTERN,
        LineStippleRepeat = GL_LINE_STIPPLE_REPEAT,
        LineWidth = GL_LINE_WIDTH,
        LineWidthGranularity = GL_LINE_WIDTH_GRANULARITY,
        LineWidthRange = GL_LINE_WIDTH_RANGE,
        ListBase = GL_LIST_BASE,
        ListIndex = GL_LIST_INDEX,
        ListMode = GL_LIST_MODE,
        LogicOp = GL_LOGIC_OP,
        LogicOpMode = GL_LOGIC_OP_MODE,
        Map1Color4 = GL_MAP1_COLOR_4,
        Map1GridDomain = GL_MAP1_GRID_DOMAIN,
        Map1GridSegments = GL_MAP1_GRID_SEGMENTS,
        Map1Index = GL_MAP1_INDEX,
        Map1Normal = GL_MAP1_NORMAL,
        Map1TextureCoord1 = GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = GL_MAP1_TEXTURE_COORD_4,
        Map1Vertex3 = GL_MAP1_VERTEX_3,
        Map1Vertex4 = GL_MAP1_VERTEX_4,
        Map2Color4 = GL_MAP2_COLOR_4,
        Map2GridDomain = GL_MAP2_GRID_DOMAIN,
        Map2GridSegments = GL_MAP2_GRID_SEGMENTS,
        Map2Index = GL_MAP2_INDEX,
        Map2Normal = GL_MAP2_NORMAL,
        Map2TextureCoord1 = GL_MAP2_TEXTURE_COORD_1,
        Map2TextureCoord2 = GL_MAP2_TEXTURE_COORD_2,
        Map2TextureCoord3 = GL_MAP2_TEXTURE_COORD_3,
        Map2TextureCoord4 = GL_MAP2_TEXTURE_COORD_4,
        Map2Vertex3 = GL_MAP2_VERTEX_3,
        Map2Vertex4 = GL_MAP2_VERTEX_4,
        MapColor = GL_MAP_COLOR,
        MapStencil = GL_MAP_STENCIL,
        MatrixMode = GL_MATRIX_MODE,
        MaxClientAttribStackDepth = GL_MAX_CLIENT_ATTRIB_STACK_DEPTH,
        MaxAttribStackDepth = GL_MAX_ATTRIB_STACK_DEPTH,
        MaxClipPlanes = GL_MAX_CLIP_PLANES,
        MaxEvalOrder = GL_MAX_EVAL_ORDER,
        MaxLights = GL_MAX_LIGHTS,
        MaxListNesting = GL_MAX_LIST_NESTING,
        MaxModelviewStackDepth = GL_MAX_MODELVIEW_STACK_DEPTH,
        MaxNameStackDepth = GL_MAX_NAME_STACK_DEPTH,
        MaxPixelMapTable = GL_MAX_PIXEL_MAP_TABLE,
        MaxProjectionStackDepth = GL_MAX_PROJECTION_STACK_DEPTH,
        MaxTextureSize = GL_MAX_TEXTURE_SIZE,
        MaxTextureStackDepth = GL_MAX_TEXTURE_STACK_DEPTH,
        MaxViewportDims = GL_MAX_VIEWPORT_DIMS,
        ModelviewMatrix = GL_MODELVIEW_MATRIX,
        ModelviewStackDepth = GL_MODELVIEW_STACK_DEPTH,
        NameStackDepth = GL_NAME_STACK_DEPTH,
        NormalArray = GL_NORMAL_ARRAY,
        NormalArrayStride = GL_NORMAL_ARRAY_STRIDE,
        NormalArrayType = GL_NORMAL_ARRAY_TYPE,
        Normalize = GL_NORMALIZE,
        PackAlignment = GL_PACK_ALIGNMENT,
        PackLsbFirst = GL_PACK_LSB_FIRST,
        PackRowLength = GL_PACK_ROW_LENGTH,
        PackSkipPixels = GL_PACK_SKIP_PIXELS,
        PackSkipRows = GL_PACK_SKIP_ROWS,
        PackSwapBytes = GL_PACK_SWAP_BYTES,
        PerspectiveCorrectionHint = GL_PERSPECTIVE_CORRECTION_HINT,
        PixelMapAToASize = GL_PIXEL_MAP_A_TO_A_SIZE,
        PixelMapBToBSize = GL_PIXEL_MAP_B_TO_B_SIZE,
        PixelMapGToGSize = GL_PIXEL_MAP_G_TO_G_SIZE,
        PixelMapIToASize = GL_PIXEL_MAP_I_TO_A_SIZE,
        PixelMapIToBSize = GL_PIXEL_MAP_I_TO_B_SIZE,
        PixelMapIToGSize = GL_PIXEL_MAP_I_TO_G_SIZE,
        PixelMapIToISize = GL_PIXEL_MAP_I_TO_I_SIZE,
        PixelMapIToRSize = GL_PIXEL_MAP_I_TO_R_SIZE,
        PixelMapRToRSize = GL_PIXEL_MAP_R_TO_R_SIZE,
        PixelMapSToSSize = GL_PIXEL_MAP_S_TO_S_SIZE,
        PointSize = GL_POINT_SIZE,
        PointSizeGranularity = GL_POINT_SIZE_GRANULARITY,
        PointSizeRange = GL_POINT_SIZE_RANGE,
        PointSmooth = GL_POINT_SMOOTH,
        PointSmoothHint = GL_POINT_SMOOTH_HINT,
        PolygonMode = GL_POLYGON_MODE,
        PolygonOffsetFactor = GL_POLYGON_OFFSET_FACTOR,
        PolygonOffsetUnits = GL_POLYGON_OFFSET_UNITS,
        PolygonOffsetFill = GL_POLYGON_OFFSET_FILL,
        PolygonOffsetLine = GL_POLYGON_OFFSET_LINE,
        PolygonOffsetPoint = GL_POLYGON_OFFSET_POINT,
        PolygonSmooth = GL_POLYGON_SMOOTH,
        PolygonSmoothHint = GL_POLYGON_SMOOTH_HINT,
        PolygonStipple = GL_POLYGON_STIPPLE,
        ProjectionMatrix = GL_PROJECTION_MATRIX,
        ProjectionStackDepth = GL_PROJECTION_STACK_DEPTH,
        ReadBuffer = GL_READ_BUFFER,
        RedBias = GL_RED_BIAS,
        RedBits = GL_RED_BITS,
        RedScale = GL_RED_SCALE,
        RenderMode = GL_RENDER_MODE,
        RgbaMode = GL_RGBA_MODE,
        ScissorBox = GL_SCISSOR_BOX,
        ScissorTest = GL_SCISSOR_TEST,
        ShadeModel = GL_SHADE_MODEL,
        StencilBits = GL_STENCIL_BITS,
        StencilClearValue = GL_STENCIL_CLEAR_VALUE,
        StencilFail = GL_STENCIL_FAIL,
        StencilFunc = GL_STENCIL_FUNC,
        StencilPassDepthFail = GL_STENCIL_PASS_DEPTH_FAIL,
        StencilPassDepthPass = GL_STENCIL_PASS_DEPTH_PASS,
        StencilRef = GL_STENCIL_REF,
        StencilTest = GL_STENCIL_TEST,
        StencilValueMask = GL_STENCIL_VALUE_MASK,
        StencilWritemask = GL_STENCIL_WRITEMASK,
        Stereo = GL_STEREO,
        SubpixelBits = GL_SUBPIXEL_BITS,
        Texture1D = GL_TEXTURE_1D,
        Texture2D = GL_TEXTURE_2D,
        TextureCoordArray = GL_TEXTURE_COORD_ARRAY,
        TextureCoordArraySize = GL_TEXTURE_COORD_ARRAY_SIZE,
        TextureCoordArrayStride = GL_TEXTURE_COORD_ARRAY_STRIDE,
        TextureCoordArrayType = GL_TEXTURE_COORD_ARRAY_TYPE,
        TextureEnvColor = GL_TEXTURE_ENV_COLOR,
        TextureEnvMode = GL_TEXTURE_ENV_MODE,
        TextureGenQ = GL_TEXTURE_GEN_Q,
        TextureGenR = GL_TEXTURE_GEN_R,
        TextureGenS = GL_TEXTURE_GEN_S,
        TextureGenT = GL_TEXTURE_GEN_T,
        TextureMatrix = GL_TEXTURE_MATRIX,
        TextureStackDepth = GL_TEXTURE_STACK_DEPTH,
        UnpackAlignment = GL_UNPACK_ALIGNMENT,
        UnpackLsbFirst = GL_UNPACK_LSB_FIRST,
        UnpackRowLength = GL_UNPACK_ROW_LENGTH,
        UnpackSkipPixels = GL_UNPACK_SKIP_PIXELS,
        UnpackSkipRows = GL_UNPACK_SKIP_ROWS,
        UnpackSwapBytes = GL_UNPACK_SWAP_BYTES,
        VertexArray = GL_VERTEX_ARRAY,
        VertexArraySize = GL_VERTEX_ARRAY_SIZE,
        VertexArrayStride = GL_VERTEX_ARRAY_STRIDE,
        VertexArrayType = GL_VERTEX_ARRAY_TYPE,
        Viewport = GL_VIEWPORT,
        ZoomX = GL_ZOOM_X,
        ZoomY = GL_ZOOM_Y,
        FeedbackBufferSize = GL_FEEDBACK_BUFFER_SIZE,
        SelectionBufferSize = GL_SELECTION_BUFFER_SIZE,
        FeedbackBufferType = GL_FEEDBACK_BUFFER_TYPE
    }

    private const int GL_BLEND = 3042;
    private const int GL_COLOR_LOGIC_OP = 3058;
    private const int GL_COLOR_MATERIAL_FACE = 2901;
    private const int GL_CULL_FACE = 2884;
    private const int GL_DEPTH_TEST = 2929;
    private const int GL_DITHER = 3024;
    private const int GL_INDEX_LOGIC_OP = 3057;
    private const int GL_LIGHTING = 2896;
    private const int GL_LINE_SMOOTH = 2848;
    private const int GL_LINE_STIPPLE = 2852;
    private const int GL_LOGIC_OP_MODE = 3056;
    private const int GL_NORMALIZE = 2977;
    private const int GL_POLYGON_OFFSET_FILL = 32823;
    private const int GL_POLYGON_OFFSET_LINE = 10754;
    private const int GL_POLYGON_OFFSET_POINT = 10753;
    private const int GL_POLYGON_SMOOTH = 2881;
    private const int GL_POLYGON_STIPPLE = 2882;
    private const int GL_SCISSOR_TEST = 3089;
    private const int GL_STENCIL_TEST = 2960;
    private const int GL_TEXTURE_1D = 3552;
    private const int GL_TEXTURE_2D = 3553;
    private const int GL_TEXTURE_GEN_Q = 3171;
    private const int GL_TEXTURE_GEN_S = 3168;
    private const int GL_TEXTURE_GEN_T = 3169;
    private const int GL_TEXTURE_GEN_R = 3170;
    public enum Cap : int
    {
        PointSmooth = GL_POINT_SMOOTH,
        AlphaTest = GL_ALPHA_TEST,
        Blend = GL_BLEND,
        ColorLogicOp = GL_COLOR_LOGIC_OP,
        ColorMaterialFace = GL_COLOR_MATERIAL_FACE,
        CullFace = GL_CULL_FACE,
        DepthTest = GL_DEPTH_TEST,
        Dither = GL_DITHER,
        Fog = GL_FOG,
        IndexLogicOp = GL_INDEX_LOGIC_OP,
        Lighting = GL_LIGHTING,
        LineSmooth = GL_LINE_SMOOTH,
        LineStipple = GL_LINE_STIPPLE,
        LogicOpMode = GL_LOGIC_OP_MODE,
        Normalize = GL_NORMALIZE,
        PointSmoothHint = GL_POINT_SMOOTH_HINT,
        PolygonOffsetFill = GL_POLYGON_OFFSET_FILL,
        PolygonOffsetLine = GL_POLYGON_OFFSET_LINE,
        PolygonOffsetPoint = GL_POLYGON_OFFSET_POINT,
        PolygonSmooth = GL_POLYGON_SMOOTH,
        PolygonStipple = GL_POLYGON_STIPPLE,
        ScissorTest = GL_SCISSOR_TEST,
        StencilTest = GL_STENCIL_TEST,
        Texture1D = GL_TEXTURE_1D,
        Texture2D = GL_TEXTURE_2D,
        TextureGenQ = GL_TEXTURE_GEN_Q,
        TextureGenS = GL_TEXTURE_GEN_S,
        TextureGenT = GL_TEXTURE_GEN_T,
        TextureGenR = GL_TEXTURE_GEN_R,
        ClipPlane0 = GL_CLIP_PLANE0,
        ClipPlane1 = GL_CLIP_PLANE1,
        ClipPlane2 = GL_CLIP_PLANE2,
        ClipPlane3 = GL_CLIP_PLANE3,
        ClipPlane4 = GL_CLIP_PLANE4,
        ClipPlane5 = GL_CLIP_PLANE5,
    }

    private const int GL_LIGHT_MODEL_LOCAL_VIEWER = 2897;
    private const int GL_LIGHT_MODEL_TWO_SIDE = 2898;
    public enum LightModel : int
    {
        LocalViewer = GL_LIGHT_MODEL_LOCAL_VIEWER,
        TwoSides = GL_LIGHT_MODEL_TWO_SIDE
    }

    private const int GL_LIGHT_MODEL_AMBIENT = 2899;
    public enum Ambient : int
    {
        LocalViewer = GL_LIGHT_MODEL_LOCAL_VIEWER,
        TwoSides = GL_LIGHT_MODEL_TWO_SIDE,
        Ambient = GL_LIGHT_MODEL_AMBIENT
    }

    private const int GL_FLAT = 7424;
    private const int GL_SMOOTH = 7425;
    public enum Fill : int
    {
        Flat = GL_FLAT,
        Smooth = GL_SMOOTH
    }

    public enum MaterialFace : int
    {
        Front = GL_FRONT,
        Back = GL_BACK,
        FrontAndBack = GL_FRONT_AND_BACK
    }

    public enum Side : int
    {
        Front = GL_FRONT,
        Back = GL_BACK
    }

    public enum TransferN : int
    {
        MapColor = GL_MAP_COLOR,
        MapStencil = GL_MAP_STENCIL,
        IndexShift = GL_INDEX_SHIFT,
        IndexOffset = GL_INDEX_OFFSET,
        RedScale = GL_RED_SCALE,
        GreenScale = GL_GREEN_SCALE,
        BlueScale = GL_BLUE_SCALE,
        AlphaScale = GL_ALPHA_SCALE,
        DepthScale = GL_DEPTH_SCALE,
        RedBias = GL_RED_BIAS,
        GreenBias = GL_GREEN_BIAS,
        BlueBias = GL_BLUE_BIAS,
        AlphaBias = GL_ALPHA_BIAS,
        DepthBias = GL_DEPTH_BIAS
    }

    private const int GL_EMISSION = 5632;
    private const int GL_AMBIENT = 4608;
    private const int GL_DIFFUSE = 4609;
    private const int GL_SPECULAR = 4610;
    private const int GL_AMBIENT_AND_DIFFUSE = 5634;
    public enum MaterialParam : int
    {
        Emission = GL_EMISSION,
        Ambient = GL_AMBIENT,
        Diffuse = GL_DIFFUSE,
        Specular = GL_SPECULAR,
        AmbientAndDiffuse = GL_AMBIENT_AND_DIFFUSE,
        Shininess = GL_SHININESS,
        ColorIndex = GL_COLOR_INDEX
    }

    public enum StoreN : int
    {
        SwapBytes = GL_PACK_SWAP_BYTES,
        LSBFirst = GL_PACK_LSB_FIRST,
        PackLength = GL_PACK_ROW_LENGTH,
        SkipPixels = GL_PACK_SKIP_PIXELS,
        SkipRows = GL_PACK_SKIP_PIXELS,
        Alignment = GL_PACK_ALIGNMENT
    }

    private const int GL_FOG_INDEX = 2913;
    private const int GL_FOG_DENSITY = 2914;
    private const int GL_FOG_START = 2915;
    private const int GL_FOG_END = 2916;
    private const int GL_FOG_MODE = 2917;
    public enum Fog : int
    {
        Index = GL_FOG_INDEX,
        Density = GL_FOG_DENSITY,
        Start = GL_FOG_START,
        End = GL_FOG_END,
        Mode = GL_FOG_MODE
    }

    private const int GL_FOG_COLOR = 2918;
    public enum FogV : int
    {
        Index = GL_FOG_INDEX,
        Density = GL_FOG_DENSITY,
        Start = GL_FOG_START,
        End = GL_FOG_END,
        Mode = GL_FOG_MODE,
        Color = GL_FOG_COLOR
    }

    public enum Hint : int
    {
        Fog = GL_FOG_HINT,
        LineSmooth = GL_LINE_SMOOTH_HINT,
        PerspectiveCorrection = GL_PERSPECTIVE_CORRECTION_HINT,
        PointSmooth = GL_POINT_SMOOTH_HINT,
        PolygonSmooth = GL_POLYGON_SMOOTH_HINT,
    }

    private const int GL_KEEP = 7680;
    private const int GL_REPLACE = 7681;
    private const int GL_INCR = 7682;
    private const int GL_DECR = 7683;
    private const int GL_INVERT = 5386;
    public enum Fail : int
    {
        Keep = GL_KEEP,
        Zero = GL_ZERO,
        Replace = GL_REPLACE,
        Incr = GL_INCR,
        Decr = GL_DECR,
        Invert = GL_INVERT
    }

    private const int GL_MODELVIEW = 5888;
    private const int GL_PROJECTION = 5889;
    private const int GL_TEXTURE = 5890;
    public enum Matrix : int
    {
        Modelview = GL_MODELVIEW,
        Projection = GL_PROJECTION,
        Texture = GL_TEXTURE,
    }

    private const int GL_PIXEL_MAP_I_TO_I = 3184;
    private const int GL_PIXEL_MAP_S_TO_S = 3185;
    private const int GL_PIXEL_MAP_I_TO_R = 3186;
    private const int GL_PIXEL_MAP_I_TO_G = 3187;
    private const int GL_PIXEL_MAP_I_TO_B = 3188;
    private const int GL_PIXEL_MAP_I_TO_A = 3189;
    private const int GL_PIXEL_MAP_R_TO_R = 3190;
    private const int GL_PIXEL_MAP_G_TO_G = 3191;
    private const int GL_PIXEL_MAP_B_TO_B = 3192;
    private const int GL_PIXEL_MAP_A_TO_A = 3193;
    public enum Map : int
    {
        IToI = GL_PIXEL_MAP_I_TO_I,
        SToS = GL_PIXEL_MAP_S_TO_S,
        IToR = GL_PIXEL_MAP_I_TO_R,
        IToG = GL_PIXEL_MAP_I_TO_G,
        IToB = GL_PIXEL_MAP_I_TO_B,
        IToA = GL_PIXEL_MAP_I_TO_A,
        RToR = GL_PIXEL_MAP_R_TO_R,
        GToG = GL_PIXEL_MAP_G_TO_G,
        BToB = GL_PIXEL_MAP_B_TO_B,
        AToA = GL_PIXEL_MAP_A_TO_A
    }

    private const int GL_COLOR_ARRAY_POINTER = 32912;
    private const int GL_EDGE_FLAG_ARRAY_POINTER = 32915;
    private const int GL_FEEDBACK_BUFFER_POINTER = 3568;
    private const int GL_INDEX_ARRAY_POINTER = 32913;
    private const int GL_NORMAL_ARRAY_POINTER = 32911;
    private const int GL_TEXTURE_COORD_ARRAY_POINTER = 32914;
    private const int GL_SELECTION_BUFFER_POINTER = 3571;
    private const int GL_VERTEX_ARRAY_POINTER = 32910;
    public enum PNamePtr : int
    {
        ColorArray = GL_COLOR_ARRAY_POINTER,
        EdgeFlagArray = GL_EDGE_FLAG_ARRAY_POINTER,
        FeedbackBuffer = GL_FEEDBACK_BUFFER_POINTER,
        IndexArray = GL_INDEX_ARRAY_POINTER,
        NormalArray = GL_NORMAL_ARRAY_POINTER,
        TextureCoordArray = GL_TEXTURE_COORD_ARRAY_POINTER,
        SelectionBuffer = GL_SELECTION_BUFFER_POINTER,
        VertexArray = GL_VERTEX_ARRAY_POINTER
    }

    private const int GL_PROXY_TEXTURE_1D = 32867;
    private const int GL_PROXY_TEXTURE_2D = 32868;
    public enum TexPTarget : int
    {
        Texture1D = GL_TEXTURE_1D,
        Texture2D = GL_TEXTURE_2D,
        ProxyTexture1D = GL_PROXY_TEXTURE_1D,
        ProxyTexture2D = GL_PROXY_TEXTURE_2D
    }

    public enum TexTarget : int
    {
        Texture1D = GL_TEXTURE_1D,
        Texture2D = GL_TEXTURE_2D
    }

    private const int GL_TEXTURE_WIDTH = 4096;
    private const int GL_TEXTURE_HEIGHT = 4097;
    private const int GL_TEXTURE_INTERNAL_FORMAT = 4099;
    private const int GL_TEXTURE_BORDER = 4101;
    private const int GL_TEXTURE_RED_SIZE = 32860;
    private const int GL_TEXTURE_GREEN_SIZE = 32861;
    private const int GL_TEXTURE_BLUE_SIZE = 32862;
    private const int GL_TEXTURE_ALPHA_SIZE = 32863;
    private const int GL_TEXTURE_LUMINANCE_SIZE = 32864;
    private const int GL_TEXTURE_INTENSITY_SIZE = 32865;
    private const int GL_TEXTURE_COMPONENTS = 4099;
    public enum TexN : int
    {
        Width = GL_TEXTURE_WIDTH,
        Height = GL_TEXTURE_HEIGHT,
        InternalFormat = GL_TEXTURE_INTERNAL_FORMAT,
        Border = GL_TEXTURE_BORDER,
        RedSize = GL_TEXTURE_RED_SIZE,
        GreenSize = GL_TEXTURE_GREEN_SIZE,
        BlueSize = GL_TEXTURE_BLUE_SIZE,
        AlphaSize = GL_TEXTURE_ALPHA_SIZE,
        LuminanceSize = GL_TEXTURE_LUMINANCE_SIZE,
        IntensitySize = GL_TEXTURE_INTENSITY_SIZE,
        Components = GL_TEXTURE_COMPONENTS
    }
    
    public enum TexEnvN : int
    {
        Mode = GL_TEXTURE_ENV_MODE,
        Color = GL_TEXTURE_ENV_COLOR,
    }

    private const int GL_TEXTURE_MAG_FILTER = 10240;
    private const int GL_TEXTURE_MIN_FILTER = 10241;
    private const int GL_TEXTURE_WRAP_S = 10242;
    private const int GL_TEXTURE_WRAP_T = 10243;
    private const int GL_TEXTURE_BORDER_COLOR = 4100;
    private const int GL_TEXTURE_PRIORITY = 32870;
    private const int GL_TEXTURE_RESIDENT = 32871;
    public enum TexNV : int
    {
        MagFilter = GL_TEXTURE_MAG_FILTER,
        MinFilter = GL_TEXTURE_MIN_FILTER,
        WrapS = GL_TEXTURE_WRAP_S,
        WrapT = GL_TEXTURE_WRAP_T,
        BorderColor = GL_TEXTURE_BORDER_COLOR,
        Priority = GL_TEXTURE_PRIORITY,
        Resident = GL_TEXTURE_RESIDENT
    }

    public enum TexNV2 : int
    {
        MinFilter = GL_TEXTURE_MIN_FILTER,
        MagFilter = GL_TEXTURE_MAG_FILTER,
        WrapS = GL_TEXTURE_WRAP_S,
        WrapT = GL_TEXTURE_WRAP_T,
        BorderColor = GL_TEXTURE_BORDER_COLOR,
        Priority = GL_TEXTURE_PRIORITY,
    }

    private const int GL_DONT_CARE = 4352;
    private const int GL_FASTEST = 4353;
    private const int GL_NICEST = 4354;
    public enum Calc : int 
    {
        DontCare = GL_DONT_CARE,
        Fastest = GL_FASTEST,
        Nicest = GL_NICEST
    }

    private const int GL_POSITION = 4611;
    private const int GL_SPOT_DIRECTION = 4612;
    private const int GL_SPOT_EXPONENT = 4613;
    private const int GL_SPOT_CUTOFF = 4614;
    private const int GL_CONSTANT_ATTENUATION = 4615;
    private const int GL_LINEAR_ATTENUATION = 4616;
    private const int GL_QUADRATIC_ATTENUATION = 4617;
    public enum LightN : int
    {
        Ambient = GL_AMBIENT,
        Diffuse = GL_DIFFUSE,
        Specular = GL_SPECULAR,
        Position = GL_POSITION,
        SpotDirection = GL_SPOT_DIRECTION,
        SpotExponent = GL_SPOT_EXPONENT,
        SpotCutoff = GL_SPOT_CUTOFF,
        ConstantAttenuation = GL_CONSTANT_ATTENUATION,
        LinearAttenuation = GL_LINEAR_ATTENUATION,
        QuadraticAttenuation = GL_QUADRATIC_ATTENUATION,
    }

    private const int GL_CLEAR = 5376;
    private const int GL_SET = 5391;
    private const int GL_COPY = 5379;
    private const int GL_COPY_INVERTED = 5388;
    private const int GL_NOOP = 5381;
    private const int GL_AND = 5377;
    private const int GL_NAND = 5390;
    private const int GL_OR = 5383;
    private const int GL_NOR = 5384;
    private const int GL_XOR = 5382;
    private const int GL_EQUIV = 5385;
    private const int GL_AND_REVERSE = 5378;
    private const int GL_AND_INVERTED = 5380;
    private const int GL_OR_REVERSE = 5387;
    private const int GL_OR_INVERTED = 5389;
    public enum OpCode : int
    {
        Clear = GL_CLEAR,
        Set = GL_SET,
        Copy = GL_COPY,
        CopyInverted = GL_COPY_INVERTED,
        Noop = GL_NOOP,
        Invert = GL_INVERT,
        And = GL_AND,
        NAnd = GL_NAND,
        Or = GL_OR,
        Nor = GL_NOR,
        Xor = GL_XOR,
        Equiv = GL_EQUIV,
        AndReverse = GL_AND_REVERSE,
        AndInverted = GL_AND_INVERTED,
        OrReverse = GL_OR_REVERSE,
        OrInverted = GL_OR_INVERTED,
    }

    private const int GL_SHININESS = 5633;
    private const int GL_COLOR_INDEXES = 5635;
    public enum ColorIndex : int
    {
        Shininess = GL_SHININESS,
        ColorIndexes = GL_COLOR_INDEXES,
    }

    private const int GL_COLOR_INDEX = 6400;
    private const int GL_RED = 6403;
    private const int GL_GREEN = 6404;
    private const int GL_BLUE = 6405;
    private const int GL_ALPHA = 6406;
    private const int GL_RGB = 6407;
    private const int GL_RGBA = 6408;
    private const int GL_LUMINANCE = 6409;
    private const int GL_LUMINANCE_ALPHA = 6410;
    public enum Image : int
    {
        ColorIndex = GL_COLOR_INDEX,
        Red = GL_RED,
        Green = GL_GREEN,
        Blue = GL_BLUE,
        Alpha = GL_ALPHA,
        RGB = GL_RGB,
        RGBA = GL_RGBA,
        Luminance = GL_LUMINANCE,
        LuminanceAlpha = GL_LUMINANCE_ALPHA
    }

    private const int GL_STENCIL_INDEX = 6401;
    private const int GL_DEPTH_COMPONENT = 6402;
    public enum Pixel : int
    {
        ColorIndex = GL_COLOR_INDEX,
        StencilIndex = GL_STENCIL_INDEX,
        DepthComponent = GL_DEPTH_COMPONENT,
        Red = GL_RED,
        Green = GL_GREEN,
        Blue = GL_BLUE,
        Alpha = GL_ALPHA,
        RGB = GL_RGB,
        RGBA = GL_RGBA,
        Luminance = GL_LUMINANCE,
        LuminanceAlpha = GL_LUMINANCE_ALPHA
    }

    private const int GL_COLOR = 6144;
    private const int GL_DEPTH = 6145;
    private const int GL_STENCIL = 6146;
    public enum CopyType : int
    {
        Color = GL_COLOR,
        Depth = GL_DEPTH,
        Stencil = GL_STENCIL
    }

    private const int GL_POINT = 6912;
    private const int GL_LINE = 6913;
    private const int GL_FILL = 6914;
    public enum Mesh : int 
    { 
        Point = GL_POINT,
        Line = GL_LINE,
        Fill = GL_FILL
    }

    public enum EMesh : int
    {
        Point = GL_POINT,
        Line = GL_LINE,
    }

    private const int GL_RENDER = 7168;
    private const int GL_FEEDBACK = 7169;
    private const int GL_SELECT = 7170;
    public enum Render : int 
    { 
        Render = GL_RENDER,
        Feedback = GL_FEEDBACK,
        Select = GL_SELECT
    }

    private const int GL_VENDOR = 7936;
    private const int GL_RENDERER = 7937;
    private const int GL_VERSION = 7938;
    private const int GL_EXTENSIONS = 7939;
    public enum StringName : int
    {
        Vendor = GL_VENDOR,
        Renderer = GL_RENDERER,
        Version = GL_VERSION,
        Extensions = GL_EXTENSIONS
    }

    private const int GL_S = 8192;
    private const int GL_T = 8193;
    private const int GL_R = 8194;
    private const int GL_Q = 8195;
    public enum Coords : int
    {
        S = GL_S,
        T = GL_T,
        R = GL_R,
        Q = GL_Q
    }

    private const int GL_MODULATE = 8448;
    private const int GL_DECAL = 8449;
    public enum TexEnv : int
    {
        Modulate = GL_MODULATE,
        Decal = GL_DECAL,
        Blend = GL_BLEND,
        Replace = GL_REPLACE
    }

    private const int GL_OBJECT_LINEAR = 9217;
    private const int GL_EYE_LINEAR = 9216;
    private const int GL_SPHERE_MAP = 9218;
    public enum TexGen : int
    {
        ObjectLinear = GL_OBJECT_LINEAR,
        EyeLinear = GL_EYE_LINEAR,
        SphereMap = GL_SPHERE_MAP
    }

    private const int GL_TEXTURE_GEN_MODE = 9472;
    private const int GL_OBJECT_PLANE = 9473;
    private const int GL_EYE_PLANE = 9474;
    public enum TexGenN : int
    {
        TextureGenMode = GL_TEXTURE_GEN_MODE,
        ObjectPlane = GL_OBJECT_PLANE,
        EyePlane = GL_EYE_PLANE
    }

    private const int GL_NEAREST = 9728;
    private const int GL_LINEAR = 9729;
    private const int GL_NEAREST_MIPMAP_NEAREST = 9984;
    private const int GL_LINEAR_MIPMAP_NEAREST = 9985;
    private const int GL_NEAREST_MIPMAP_LINEAR = 9986;
    private const int GL_LINEAR_MIPMAP_LINEAR = 9987;
    public enum TexParam : int
    {
        Nearest = GL_NEAREST,
        Linear = GL_LINEAR,
        NearestMipmapNearest = GL_NEAREST_MIPMAP_NEAREST,
        LinearMipmapNearest = GL_LINEAR_MIPMAP_NEAREST,
        NearestMipmapLinear = GL_NEAREST_MIPMAP_LINEAR,
        LinearMipmapLinear = GL_LINEAR_MIPMAP_LINEAR,
    }

    private const int GL_CLIENT_PIXEL_STORE_BIT = 1;
    private const int GL_CLIENT_VERTEX_ARRAY_BIT = 2;
    private const int GL_ALL_CLIENT_ATTRIB_BITS = -1;
    public enum ClientMask : int 
    {
        PixelStoreBit = GL_CLIENT_PIXEL_STORE_BIT,
        VertexArrayBit = GL_CLIENT_VERTEX_ARRAY_BIT,
        AllAttribBits = GL_ALL_CLIENT_ATTRIB_BITS
    }

    private const int GL_ALPHA4 = 32827;
    private const int GL_ALPHA8 = 32828;
    private const int GL_ALPHA12 = 32829;
    private const int GL_ALPHA16 = 32830;
    private const int GL_LUMINANCE4 = 32831;
    private const int GL_LUMINANCE8 = 32832;
    private const int GL_LUMINANCE12 = 32833;
    private const int GL_LUMINANCE16 = 32834;
    private const int GL_LUMINANCE4_ALPHA4 = 32835;
    private const int GL_LUMINANCE6_ALPHA2 = 32836;
    private const int GL_LUMINANCE8_ALPHA8 = 32837;
    private const int GL_LUMINANCE12_ALPHA4 = 32838;
    private const int GL_LUMINANCE12_ALPHA12 = 32839;
    private const int GL_LUMINANCE16_ALPHA16 = 32840;
    private const int GL_INTENSITY = 32841;
    private const int GL_INTENSITY4 = 32842;
    private const int GL_INTENSITY8 = 32843;
    private const int GL_INTENSITY12 = 32844;
    private const int GL_INTENSITY16 = 32845;
    private const int GL_R3_G3_B2 = 10768;
    private const int GL_RGB4 = 32847;
    private const int GL_RGB5 = 32848;
    private const int GL_RGB8 = 32849;
    private const int GL_RGB10 = 32850;
    private const int GL_RGB12 = 32851;
    private const int GL_RGB16 = 32852;
    private const int GL_RGBA2 = 32853;
    private const int GL_RGBA4 = 32854;
    private const int GL_RGB5_A1 = 32855;
    private const int GL_RGBA8 = 32856;
    private const int GL_RGB10_A2 = 32857;
    private const int GL_RGBA12 = 32858;
    private const int GL_RGBA16 = 32859;
    public enum InternalFormat : int
    {
        Alpha4 = GL_ALPHA4,
        Alpha8 = GL_ALPHA8,
        Alpha12 = GL_ALPHA12,
        Alpha16 = GL_ALPHA16,
        Luninance4 = GL_LUMINANCE4,
        Luninance8 = GL_LUMINANCE8,
        Luninance12 = GL_LUMINANCE12,
        Luninance16 = GL_LUMINANCE16,
        Luninance4Alpha4 = GL_LUMINANCE4_ALPHA4,
        Luninance6Alpha2 = GL_LUMINANCE6_ALPHA2,
        Luninance8Alpha8 = GL_LUMINANCE8_ALPHA8,
        Luninance12Alpha4 = GL_LUMINANCE12_ALPHA4,
        Luninance12Alpha12 = GL_LUMINANCE12_ALPHA12,
        Luninance16Alpha16 = GL_LUMINANCE16_ALPHA16,
        Intensity = GL_INTENSITY,
        Intensity4 = GL_INTENSITY4,
        Intensity8 = GL_INTENSITY8,
        Intensity12 = GL_INTENSITY12,
        Intensity16 = GL_INTENSITY16,
        R3G3B2 = GL_R3_G3_B2,
        RGB4 = GL_RGB4,
        RGB5 = GL_RGB5,
        RGB8 = GL_RGB8,
        RGB10 = GL_RGB10,
        RGB12 = GL_RGB12,
        RGB16 = GL_RGB16,
        RGBA2 = GL_RGBA2,
        RGBA4 = GL_RGBA4,
        RGB5A1 = GL_RGB5_A1,
        RGBA8 = GL_RGBA8,
        RGB10A2 = GL_RGB10_A2,
        RGBA12 = GL_RGBA12,
        RGBA16 = GL_RGBA16,
    }

    private const int GL_BGR_EXT = 32992;
    private const int GL_BGRA_EXT = 32993;
    public enum ImageFormat : int
    {
        ColorIndex = GL_COLOR_INDEX,
        StencilIndex = GL_STENCIL_INDEX,
        DepthComponent = GL_DEPTH_COMPONENT,
        Red = GL_RED,
        Green = GL_GREEN,
        Blue = GL_BLUE,
        Alpha = GL_ALPHA,
        RGB = GL_RGB,
        RGBA = GL_RGBA,
        Luminance = GL_LUMINANCE,
        BGRExt = GL_BGR_EXT,
        BGRAExt = GL_BGRA_EXT,
        LuminanceAlpha = GL_LUMINANCE_ALPHA
    }

    private const int GL_V2F = 10784;
    private const int GL_V3F = 10785;
    private const int GL_C4UB_V2F = 10786;
    private const int GL_C4UB_V3F = 10787;
    private const int GL_C3F_V3F = 10788;
    private const int GL_N3F_V3F = 10789;
    private const int GL_C4F_N3F_V3F = 10790;
    private const int GL_T2F_V3F = 10791;
    private const int GL_T4F_V4F = 10792;
    private const int GL_T2F_C4UB_V3F = 10793;
    private const int GL_T2F_C3F_V3F = 10794;
    private const int GL_T2F_N3F_V3F = 10795;
    private const int GL_T2F_C4F_N3F_V3F = 10796;
    private const int GL_T4F_C4F_N3F_V4F = 10797;
    public enum ArrayFormat : int
    {
        V2F = GL_V2F,
        V3F = GL_V3F,
        C4UBV2F = GL_C4UB_V2F,
        C4UBV3F = GL_C4UB_V3F,
        C3FV3F = GL_C3F_V3F,
        N3FV3F = GL_N3F_V3F,
        C4FN3FV3F = GL_C4F_N3F_V3F,
        T2FV3F = GL_T2F_V3F,
        T4FV4F = GL_T4F_V4F,
        T2FC4UBV3F = GL_T2F_C4UB_V3F,
        T2FC3FV3F = GL_T2F_C3F_V3F,
        T2FN3FV3F = GL_T2F_N3F_V3F,
        T2FC4FN3FV3F = GL_T2F_C4F_N3F_V3F,
        T4FC4FN3FV4F = GL_T4F_C4F_N3F_V4F
    }

    public enum ArrayState : int
    {
        Color = GL_COLOR_ARRAY,
        EdgeFlag = GL_EDGE_FLAG_ARRAY,
        Index = GL_INDEX_ARRAY,
        Normal = GL_NORMAL_ARRAY,
        TextureCoord = GL_TEXTURE_COORD_ARRAY,
        Vertex = GL_VERTEX_ARRAY
    }

    public enum Compile : int
    {
        Compile = GL_COMPILE,
        CompileAndExecute = GL_COMPILE_AND_EXECUTE
    }

    public enum Other : int
    {
        Exp = GL_EXP,
        Exp2 = GL_EXP2,
        MaxLights = GL_MAX_LIGHTS,
        CurrentPasterColor = GL_CURRENT_RASTER_COLOR,
        Compile = GL_COMPILE,
        CompileAndExecute = GL_COMPILE_AND_EXECUTE,
        Bitmap = GL_BITMAP,
        Clamp = GL_CLAMP,
        Repeat = GL_REPEAT,
        TextureBinding1D = GL_TEXTURE_BINDING_1D,
        TextureBinding2D = GL_TEXTURE_BINDING_2D,
    }

    /* Hasn't information */
    private const int GL_EXP = 2048;
    private const int GL_EXP2 = 2049;
    /*                    */

    private const int GL_MAX_LIGHTS = 3377;
    private const int GL_CURRENT_RASTER_COLOR = 2820;

    private const int GL_COMPILE = 4864;
    private const int GL_COMPILE_AND_EXECUTE = 4865;

    private const int GL_BITMAP = 6656;

    private const int GL_CLAMP = 10496;
    private const int GL_REPEAT = 10497;

    private const int GL_TEXTURE_BINDING_1D = 32872;
    private const int GL_TEXTURE_BINDING_2D = 32873;

    private const int GL_TEXTURE_ENV = 8960;

    public const int TextureEnv = GL_TEXTURE_ENV;
    public const int Shininess = GL_SHININESS;
}