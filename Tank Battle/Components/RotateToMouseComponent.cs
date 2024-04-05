using Godot;

public partial class RotateToMouseComponent : Node
{
    [Export] private Node2D actor;
    [Export] private Node2D rotateActor;

    private float _radians;
    public float Radians
    {
        get
        {
            return _radians;
        }
    }

    public override void _Process(double delta)
    {
        Vector2 mousePosition = GetViewport().GetMousePosition();
        Vector2 direction = (mousePosition - actor.GlobalPosition).Normalized();
        float angle = Mathf.Atan2(direction.Y, direction.X);
        _radians = angle - actor.Rotation;
        rotateActor.Rotation = _radians;
    }
}