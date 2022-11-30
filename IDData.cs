using System;
using UnityEngine;

[Serializable]
public class IDData
{
	[SerializeField] string id;

	public string ID { get => id; private set => id = value; }

	public IDData() { ID = Guid.NewGuid().ToString(); }
	public static bool operator ==(IDData a, IDData b) => Equals(a, b);
	public static bool operator !=(IDData a, IDData b) => !Equals(a, b);
	public static bool Equals(IDData a, IDData b)
	{
		if (IsNull(a))
			return IsNull(b);
		else
		{
			if (IsNull(b))
				return false;
			return a.Equals(b);
		}
	}
	public static bool IsNull(IDData data) => data is null || string.IsNullOrEmpty(data.ID);
	public override bool Equals(object obj) => ID == (obj as IDData).ID;
	public override int GetHashCode() => ID.GetHashCode();
}