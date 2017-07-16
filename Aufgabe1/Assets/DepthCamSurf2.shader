// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/DepthCamSurf2"
{
	Properties{
		_MainTex("Texture", 2D) = "white" {}
	_Amount("Extrusion Amount", Range(-1,1)) = 0.5
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		Lighting Off

		CGPROGRAM
		// Upgrade NOTE: excluded shader from OpenGL ES 2.0 because it uses non-square matrices
#pragma exclude_renderers gles
#pragma surface surf Lambert vertex:vert
#include "UnityCG.cginc"

		struct Input {
		//          float2 uv_MainTex;
		float2 uv_MainTex;

		//            float3 depth;
		float4 pos;
		//            float3 viewDir;
		float3 color;
		float3 worldPos;
		//            float3 worldRefl;
		//            float3 worldNormal;
		//            float4 screenPos;
		INTERNAL_DATA
	};
	//    struct v2f {
	//        float4 pos : POSITION;
	//        float4 color : COLOR;
	//    };      


	float _Amount;

	void vert(inout appdata_full v, out Input o) {
		//          v.vertex.xyz += v.normal * _Amount;
		o.pos = UnityObjectToClipPos(v.vertex);
		//            float3 viewNormal = mul((float3x3)glstate.matrix.invtrans.modelview[0], v.normal);
		float z = (mul((float3x4)UNITY_MATRIX_MV, v.vertex).z + 9);

		o.color.rgb = float3(z,z,z); //viewNormal * 0.5 + 0.5;
									 //o.color.a = 1; //-z / _ProjectionParams.z;

	}

	sampler2D _MainTex;

	void surf(Input IN, inout SurfaceOutput o) {

		half3 col = IN.color;

		// could use as "scanner effect" (laser line moves across screen)
		if (IN.worldPos.x >= 2 && IN.worldPos.x <= 2.1)
		{
			col = float3(1,0,0);
		}

		o.Albedo = col; //tex2D (_MainTex, IN.uv_MainTex).rgb;
	}
	ENDCG
	}
		Fallback "Diffuse"
}