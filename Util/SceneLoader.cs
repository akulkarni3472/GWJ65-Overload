using Godot;
using System;

public partial class SceneLoader : Node {
	[Export] private string _sceneFolder;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		//
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		//
	}
	
	public void ChangeToScene(string sceneName) {
		string f = _sceneFolder == "" ? "" : $"{_sceneFolder}/";
		GetTree().ChangeSceneToFile($"res://{f}{sceneName}");
	}
}
