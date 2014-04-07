using UnityEngine;
using System.Collections;

/// <summary>
/// Action to open a new scene (.unity) file
/// </summary>
[System.Serializable]
public class OpenSceneAction : BaseAction {

	/// <summary>
	/// The name of the scene to open.
	/// </summary>
	public string sceneName;

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj, ActionData data = new ActionData()) {
		Application.LoadLevel(sceneName);
	}
}
