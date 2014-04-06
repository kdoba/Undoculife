using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
			int responseIndex = activeConversation.UpdateGUI();
			if (responseIndex >= 0) {
				Conversation oldConversation = activeConversation;
				activeConversation = null;

				if (responseIndex < oldConversation.responses.Length) {
					oldConversation.responses[responseIndex].Execute(gameObject);
				}
			}
		}
	}

	/// <summary>
	/// Sends a conversation message on collision.
	/// </summary>
	void OnCollisionEnter2D(Collision2D collision) {
		StartConversation(collision.collider.gameObject);
	}

	/// <summary>
	/// Starts the conversation with another game object.
	/// </summary>
	/// <param name="obj">Object.</param>
	public void StartConversation(GameObject obj) {
		ConversationSet conversationSet = obj.GetComponent<ConversationSet>();
		if (conversationSet != null) {
			activeConversation = conversationSet.GetActiveConversation();
		}
		obj.SendMessage(eventName, SendMessageOptions.DontRequireReceiver);
	}
}
