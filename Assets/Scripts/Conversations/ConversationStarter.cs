using UnityEngine;
using System.Collections;

/// <summary>
/// A script for a player to start conversations with other npcs.
/// </summary>
public class ConversationStarter : MonoBehaviour {

	/// <summary>
	/// The name of the event to raise on collision.
	/// </summary>
	public string eventName = "OnConversation";

	/// <summary>
	/// The active conversation.
	/// </summary>
	private Conversation activeConversation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	/// <summary>
	/// Updates gui.
	/// </summary>
	void OnGUI() {
		if (activeConversation != null) {
			if (activeConversation.UpdateGUI() >= 0) {
				activeConversation = null;
			}
		}
	}

	/// <summary>
	/// Sends a conversation message on collision.
	/// </summary>
	void OnCollisionEnter2D(Collision2D collision) {
		Conversation conversation = collision.collider.gameObject.GetComponent<Conversation>();
		if (conversation != null) {
			activeConversation = conversation;
		}
		collision.collider.gameObject.SendMessage(eventName, SendMessageOptions.DontRequireReceiver);
	}
}
