using Godot;
using System;

public partial class main_menu : Control {
	private Button playButton;
	private Button quitButton;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		playButton = GetNode<Button>("MarginContainer/VBoxContainer/Play");
		quitButton = GetNode<Button>("MarginContainer/VBoxContainer/Quit");
	}

	public override void _Process(double delta) {
		_onPlayPressed();
		_on_quit_pressed();
	}

	public void _onPlayPressed() {
		 playButton.Pressed += () =>
			GetTree().ChangeSceneToFile("Levels/prototype.tscn");
	}

	public void _on_quit_pressed() {
		quitButton.Pressed += () =>
			GetTree().Quit();
	}
}
