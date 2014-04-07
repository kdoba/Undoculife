using UnityEngine;
using System.Collections;

/// <summary>
/// Triggers an action based on input.
/// </summary>
[System.Serializable]
public class ActionControl : MonoBehaviour {

	/// <summary>
	/// True if triggered by mouse down.
	/// </summary>
	public bool onMouseDown = true;

	/// <summary>
	/// The action to execute.
	/// </summary>
	public BaseAction action = null;

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update() {
		if (onMouseDown && Input.GetMouseButton(0)) {
			ActionData data = new ActionData();
			data.pos = MouseUtil.GetMouseWorldPos(); //Input.mousePosition;
			action.Execute(gameObject, data);
		}
	}
}
