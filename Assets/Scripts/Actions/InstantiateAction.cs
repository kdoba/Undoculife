using UnityEngine;
using System.Collections;

/// <summary>
/// Action to instantiate a game object
/// </summary>
[System.Serializable]
public class InstantiateAction : BaseAction {

	/// <summary>
	/// The object to instantiate.
	/// </summary>
	public GameObject objToInstantiate;

	/// <summary>
	/// The spawn position.
	/// </summary>
	public Vector3 pos;

	/// <summary>
	/// The spawn rotation.
	/// </summary>
	public Quaternion rotation = Quaternion.identity;

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj, ActionData data = new ActionData()) {
		Instantiate(objToInstantiate, pos, rotation);
	}
}
