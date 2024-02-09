Shader "Unlit/Blur"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
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
                fixed4  Color2 = tex2D(_MainTex, i.uv);

                fixed4  Color = tex2D(_MainTex, i.uv);
                float Pi = 6.28318530718; // Pi*2
                 
                 // GAUSSIAN BLUR SETTINGS {{{
                 float Directions = 16.0; // BLUR DIRECTIONS (Default 16.0 - More is better but slower)
                 float Quality = 3.0; // BLUR QUALITY (Default 4.0 - More is better but slower)
                 float Size = 8.0; // BLUR SIZE (Radius)
                 // GAUSSIAN BLUR SETTINGS }}}
                
                 float2 Radius = Size/float2(300,300);
                 
                 // Normalized pixel coordinates (from 0 to 1)
                 float2 uv = i.uv ;
                 // Pixel colour
                 // float4 Color = texture(iChannel0, uv);
                 
                 // Blur calculations
                 for( float d=0.0; d<Pi; d+=Pi/Directions)
                 {
                     for(float i=1.0/Quality; i<=1.0; i+=1.0/Quality)
                     {
                         Color += tex2D( _MainTex, uv+float2(cos(d),sin(d))*Radius*i);      
                     }
                 }
                 
                 // Output to screen
                 Color /= Quality * Directions - 15.0;
                 
                 return  Color;


            }
            ENDCG
        }
    }
}
