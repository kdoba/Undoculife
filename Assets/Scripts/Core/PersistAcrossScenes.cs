using UnityEngine;
using System.Collections;

/// <summary>
/// Causes the game object to not be destroyed on changing scenes.
/// </summary>
public class PersistAcrossScenes : MonoBehaviour {
	
	void Start() {
		Object.DontDestroyOnLoad(gameObject);
	}
}
