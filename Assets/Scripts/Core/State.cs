using UnityEngine;
using System.Collections;

/// <summary>
/// Contains state for an object.
/// </summary>
public class State : MonoBehaviour {

	/// <summary>
	/// A disabled state for an object.
	/// </summary>
	public const string DISABLED = "DISABLED";

	/// <summary>
	/// The current state.
	/// </summary>
	public string state = null;
}
