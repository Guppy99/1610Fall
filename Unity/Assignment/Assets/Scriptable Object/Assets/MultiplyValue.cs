using UnityEngine;

[CreateAssetMenu]

public class MultiplyValue : ScriptableObject
{
	public FloatData Data;

	public void TimesValue(FloatData data)
	{
		data.Value *= Data.Value;
	}
}