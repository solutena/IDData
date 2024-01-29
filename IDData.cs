using System;
using UnityEngine;

[Serializable]
public class IDData
{
	public string id;

	public IDData() { id = Guid.NewGuid().ToString(); }
	public override bool Equals(object obj)
	{
		if (obj is IDData compare)
			return id.Equals(compare.id);
		return false;
	}
	public override int GetHashCode() => string.IsNullOrEmpty(id) ? 0 : id.GetHashCode();
	public static bool operator ==(IDData a, IDData b)
	{
		if (a is null || string.IsNullOrEmpty(a.id))
			return b is null || string.IsNullOrEmpty(b.id);
		return a.Equals(b);
	}
	public static bool operator !=(IDData a, IDData b) => !(a == b);
}