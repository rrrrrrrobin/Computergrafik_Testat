Shader "Unlit/ThermalShader"
{
	Properties
	{
		_TemperaturePosition ("TemperaturePosition", Vector) = (0, 0, 0, 0)

	}
		SubShader
	{
		Tags{ "RenderType" = "Opaque" }
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

		transformation vert(vertex data) // coordinates to world coordinates transformation
		{
			transformation trans;
			trans.coordPosition = UnityObjectToClipPos(data.vertex);
			trans.worldPosition = mul(unity_ObjectToWorld,data.vertex);

			return trans;
		}

		float4 frag(transformation data) : COLOR  
		{
			float maxAllowedDistance = 20; // Adjusted the max. allowed distance
			float3 actualDistance = distance(data.worldPosition, _TemperaturePosition);
			float normedVector = (distance / maxAllowedDistance);

		if (normedVector < 0) 
		{
			//TODO
		}

		return float4(normedVector, normedVector, normedVector, 1.0); // Return grayscale value
		}
			ENDCG
		}
	}
}