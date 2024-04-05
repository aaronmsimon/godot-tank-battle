using Godot;

public partial class FireInputComponent : Node
{
    [Export] private PackedScene projectile;
    [Export] private Marker2D muzzle;
    [Export] private RotateToMouseComponent mouseRotation;

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("fire"))
        {
            Node2D instance = (Node2D)projectile.Instantiate();
            Node root = GetTree().CurrentScene;
            root.AddChild(instance);

            instance.GlobalPosition = muzzle.GlobalPosition;
            instance.Rotation = mouseRotation.Radians;
        }
    }
}