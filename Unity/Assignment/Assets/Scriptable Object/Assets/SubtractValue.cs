using UnityEngine;

[CreateAssetMenu]

public class SubtractValue : ScriptableObject
{
	public FloatData Data;
	
	public void LessValue (FloatData data)
	{
		data.Value -= Data.Value;
	}
}
