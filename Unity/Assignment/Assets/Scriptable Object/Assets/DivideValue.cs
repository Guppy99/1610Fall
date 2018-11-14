using UnityEngine;

[CreateAssetMenu]

public class DivideValue : ScriptableObject
{
    public FloatData Data;

    public void PartValue(FloatData data)
    {
        data.Value /= Data.Value;
    }
}