using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Object = System.Object;

[CreateAssetMenu]
public class AddtoCollection : ScriptableObject
{
	public ObjectCollection Collection;
	
	public void Call(ScriptableObject obj)
	{
		Collection.ObjectList.Add(obj);
	}
}
