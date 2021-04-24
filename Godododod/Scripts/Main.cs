using Godot;
using Godododod.Entities;
using System;

public class Main : Node
{
	private Player _Player;
	private TileMap _Dung;

	public override void _Ready()
	{
		_Player = new Player();

		_Dung = (TileMap)GetNode("TileMap");
		_Player.ConnectToNode(_Dung);
	}

}
