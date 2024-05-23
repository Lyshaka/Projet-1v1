using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreation : MonoBehaviour
{
	[SerializeField] GameObject playerIcon;
	[SerializeField] GameObject playerName;

	public void DeletePlayer()
	{
		Destroy(gameObject);
	}
}
