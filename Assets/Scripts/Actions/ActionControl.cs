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
	/// Cached state.
	/// </summary>
	private State _state;

	void Start() {
		_state = GetComponent<State>();
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update() {
		// check for disabled state
		if (_state != null && _state.state == State.DISABLED) {
			return;
		}
		if (onMouseDown && Input.GetMouseButton(0)) {
			ActionData data = new ActionData();
			data.pos = MouseUtil.GetMouseWorldPos(); //Input.mousePosition;
			action.Execute(gameObject, data);
		}
	}
}
