using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu]
public class ChangeValue : ScriptableObject
{
	public FloatData Data;

	public void AddValue(FloatData obj)
	{
		Data.Value += obj.Value;
	}
	
	public void SubtractData(FloatData obj)
	{
		Data.Value -= obj.Value;
	}

}
		
