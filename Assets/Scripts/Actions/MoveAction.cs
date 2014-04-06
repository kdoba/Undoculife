using UnityEngine;
using System.Collections;

/// <summary>
/// Action to move a game object
/// </summary>
[System.Serializable]
public class MoveAction : BaseAction {

	/// <summary>
	/// The position to move to.
	/// </summary>
	public Vector3 pos;

	/// <summary>
	/// Whether the "other" game object passed into the action.
	/// </summary>
	public bool moveOther = false;

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj) {
		if (moveOther) {
			obj.transform.position = pos;
		} else {
			gameObject.transform.position = pos;
		}
	}
}
