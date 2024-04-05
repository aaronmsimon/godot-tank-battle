using Godot;

public partial class MoveComponent : Node
{
    [Export] private Node2D actor;
    [Export] public float velocity { get; set; }
    [Export] public float rotation { get; set; }

    public override void _Process(double delta)
    {
        Vector2 direction = new Vector2(Mathf.Cos(actor.Rotation), Mathf.Sin(actor.Rotation));
        Vector2 movement = direction * velocity * (float)delta;
        actor.Translate(movement);

        actor.Rotate(rotation * (float)delta);
    }
}