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

			struct transformation
			{
				float4 worldPosition : TEXCOORD0;
				float4 coordPosition : SV_POSITION;
			};

			struct vertex
			{
				float4 vertex : POSITION;
			};

			transformation vert(vertex data)
			{
				transformation trans;
				trans.coordPosition = UnityObjectToClipPos(data.vertex);
				trans.worldPosition = mul(unity_ObjectToWorld,data.vertex);
				return trans;
			}

			float4 frag(transformation data) : COLOR
			{
				float maxAllowedDistance = 20;
				float actualDistance = distance(data.worldPosition, _WorldSpaceCameraPos);
				float normedVector = (actualDistance / maxAllowedDistance);
				return float4(normedVector, normedVector, normedVector, 1.0);
			}
			ENDCG
		}
	}
}