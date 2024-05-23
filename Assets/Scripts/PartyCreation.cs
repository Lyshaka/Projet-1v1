using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyCreation : MonoBehaviour
{
	[Tooltip("Object to instantiate (the player UI object)")]
	[SerializeField] GameObject playerObject;
	
	[Tooltip("The parent panel of the player UI object")]
	[SerializeField] GameObject panel;

	[Tooltip("Button to add a player")]
	[SerializeField] GameObject addPlayerButton;

	public void AddPlayer()
	{
		GameObject obj = Instantiate(playerObject, panel.transform);
		obj.transform.SetAsLastSibling();
		addPlayerButton.transform.SetAsLastSibling();
	}
}
