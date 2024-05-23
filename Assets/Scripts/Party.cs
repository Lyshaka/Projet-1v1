using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party
{
	List<Player> players = new List<Player>();
	public int numberOfPlayer { get; private set; }

	public Party()
	{
		numberOfPlayer = 0;
	}

	public void AddPlayer(Player player)
	{
		players.Add(player);
		numberOfPlayer = players.Count;
	}

	public void RemovePlayer(Player player)
	{
		players.Remove(player);
		numberOfPlayer = players.Count;
	}
}
