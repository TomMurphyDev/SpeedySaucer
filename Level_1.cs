 using Godot;
using System;

public partial class Level_1 : Node2D
{
	private RigidBody2D _player;
	private PackedScene  _scene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_scene = ResourceLoader.Load<PackedScene>("res://Level_1.tscn");
		if (_scene == null)
		{
			GD.Print("Scene not loaded problems ahead ....");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public async void OnBodyExited(Node2D node){
		GD.Print("Level.cs>Level>_on_maze_body_exited(): ");
		await ToSignal(GetTree().CreateTimer(0.1), "timeout"); //Give some time to remove collision object.
		GetTree().ReloadCurrentScene();
	} 
}
