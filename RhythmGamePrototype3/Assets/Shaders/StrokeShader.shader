// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/StrokeShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        
        _OutLine ("OutLine ",Range(0,0.05))=0.01
        _OutLineColor("OutLineColor",Color)=(245,229,27,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque"  "Queue"="Geometry"}
        LOD 100
        
        Pass{
            NAME "OUTLINE"
            
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            
            float _OutLine;
            fixed4 _OutLineColor;
            
            struct a2v{
                 float4 vertex: POSITION;
                 float3 normal : NORMAL;
            };
            struct v2f{
                 float4 pos : SV_POSITION;
            };
            
            v2f vert(a2v v)
            {
                 v2f o;
                 float4 pos = mul(UNITY_MATRIX_MV, v.vertex);
                 float3 normal = mul( (float3x3)UNITY_MATRIX_IT_MV,v.normal);
                 //normal.z = -0.5f;
                 pos = pos+ float4( normalize(normal),0) * _OutLine;
                 
                 o.pos = mul(UNITY_MATRIX_P,pos);
                 
                 return o;
            }
            
            float4 frag(v2f i) : SV_Target {
                return float4(_OutLineColor.rgb,1);
            }
            
            ENDCG
        
        }

        Pass
        {
           
          // CULL Back
        
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
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
            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);               
                return col;
            }
            ENDCG
        }
    }
}
