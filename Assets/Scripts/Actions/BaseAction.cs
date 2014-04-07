using UnityEngine;
using System.Collections;

/// <summary>
/// Base action that handles executing arbitrary logic.
/// </summary>
[System.Serializable]
public class BaseAction : MonoBehaviour {

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	public virtual void Execute(GameObject obj, ActionData data = new ActionData()) {
	}
}
