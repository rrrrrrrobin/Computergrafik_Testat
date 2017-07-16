// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/she1" {
	Properties{
		top("Top", Range(0,2)) = 1
		bottom("Bottom", Range(0,2)) = 1
	}
		SubShader{

		// Draw ourselves after all opaque geometry
		Tags{ "Queue" = "Transparent" }

		// Grab the screen behind the object into _GrabTexture
		GrabPass{}

		// Render the object with the texture generated above
		Pass{


		CGPROGRAM
#pragma debug
#pragma vertex vert
#pragma fragment frag
#pragma target 3.0

		sampler2D _GrabTexture : register(s0);
	float top;
	float bottom;

	struct data {

		float4 vertex : POSITION;

		float3 normal : NORMAL;

	};



	struct v2f {

		float4 position : POSITION;

		float4 screenPos : TEXCOORD0;

	};



	v2f vert(data i) {

		v2f o;

		o.position = UnityObjectToClipPos(i.vertex);

		o.screenPos = o.position;

		return o;

	}



	half4 frag(v2f i) : COLOR

	{

		float2 screenPos = i.screenPos.xy / i.screenPos.w;
		float _half = (top + bottom) * 0.5;
		float _diff = (bottom - top) * 0.5;
		screenPos.x = screenPos.x * (_half + _diff * screenPos.y);
		screenPos.x = (screenPos.x + 1) * 0.5;
		screenPos.y = 1 - (screenPos.y + 1) * 0.5;
		half4 sum = half4(0.0h,0.0h,0.0h,0.0h);
		sum = tex2D(_GrabTexture, screenPos);
		return sum;

	}
		ENDCG
	}
	}

		Fallback Off
}