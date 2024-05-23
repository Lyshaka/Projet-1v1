using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
	public string name { get; private set; }
	public Color color { get; private set; }
	public Image icon { get; private set; }

	public void SetName(string _name) { name = _name; }
	public void SetColor(Color _color) { color = _color;}
	public void SetIcon(Image _icon) { icon = _icon; }

	public Player(string _name, Color _color, Image _icon)
	{
		name = _name;
		color = _color;
		icon = _icon;
	}
}
