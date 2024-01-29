using System;
using UnityEngine;

[Serializable]
public class IDData
{
	[SerializeField] string id;

	public string ID { get => id; set => id = value; }

	public IDData() { ID = Guid.NewGuid().ToString(); }
	public override bool Equals(object obj)
	{
		if (obj is IDData compare)
			return ID.Equals(compare.ID);
		return false;
	}
	public override int GetHashCode() => string.IsNullOrEmpty(ID) ? 0 : ID.GetHashCode();
	public static bool operator ==(IDData a, IDData b)
	{
		if (a is null || string.IsNullOrEmpty(a.ID))
			return b is null || string.IsNullOrEmpty(b.ID);
		return a.Equals(b);
	}
	public static bool operator !=(IDData a, IDData b) => !(a == b);
}