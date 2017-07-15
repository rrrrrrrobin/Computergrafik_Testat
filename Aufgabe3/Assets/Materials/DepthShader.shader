Shader "Unlit/DepthShader"
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
			// make depth-grayscale work
			
			struct vertex
			{
				float4 vertex : POSITION;
			};

			struct transformation
			{
				float4 worldPosition : TEXCOORD0;
				float4 coordPosition : SV_POSITION;
			};

			transformation vertex()
			{

			}


			ENDCG
		}
	}
}