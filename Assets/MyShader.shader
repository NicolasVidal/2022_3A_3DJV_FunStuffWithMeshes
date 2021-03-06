Shader "Unlit/Totu"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("MyColor", Color) = (0, 0, 0)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex pouetpouet
            #pragma fragment frpouetpouetag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            float4 _Color;

            v2f pouetpouet (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex + cos(_Time.w));
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frpouetpouetag (v2f i) : SV_Target
            {
                return fixed4(cos(_Time.w) / 2 + 1, 0, 0, 0);
                
                // // sample the texture
                
                // fixed4 col = tex2D(_MainTex, i.uv);
                // // apply fog
                // UNITY_APPLY_FOG(i.fogCoord, col);
                // return col;
            }
            ENDCG
        }
    }
}
