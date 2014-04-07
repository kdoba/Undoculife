using UnityEngine;
using System.Collections;

/// <summary>
/// Contains mouse utility functions.
/// </summary>
[System.Serializable]
public class MouseUtil : MonoBehaviour {

	/// <summary>
	/// True if triggered by mouse down.
	/// </summary>
	public bool onMouseDown = true;

	/// <summary>
	/// The action to execute.
	/// </summary>
	public BaseAction action = null;

	/// <summary>
	/// Gets the mouse world position.
	/// </summary>
	/// <returns>The mouse world position.</returns>
	public static Vector2 GetMouseWorldPos() {
		Plane xyPlane = new Plane(Vector3.forward, Vector3.zero);
		float distance;
		Ray mouseRay = GetMouseRay();
		Vector3 result = Vector3.zero;
		
		if (xyPlane.Raycast(mouseRay, out distance)) {
			result = mouseRay.GetPoint(distance);	
		}
		return result;
	}

	/// <summary>
	/// Gets the mouse ray.
	/// </summary>
	/// <returns>The mouse ray.</returns>
	public static Ray GetMouseRay() {
		return Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	}
}
