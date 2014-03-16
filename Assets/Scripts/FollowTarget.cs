using UnityEngine;
using System.Collections;

/// <summary>
/// Updates the object's position to be an offset from its target.
/// </summary>
public class FollowTarget : MonoBehaviour {

	/// <summary>
	/// The target to follow.
	/// </summary>
	public GameObject target;

	/// <summary>
	/// The offset from the target.
	/// </summary>
	public Vector3 offset = new Vector3(0, 0, -3);
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + offset;
	}
}
