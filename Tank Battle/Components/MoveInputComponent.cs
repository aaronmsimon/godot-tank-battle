using Godot;

public partial class MoveInputComponent : Node
{
    [Export] private MoveComponent moveComponent;
    [Export] private TankStats tankStats;

    public override void _Input(InputEvent @event)
    {
        float inputMove = Input.GetAxis("move_backward", "move_forward");
        moveComponent.velocity = inputMove * tankStats.moveSpeed;

        float inputRotate = Input.GetAxis("rotate_left", "rotate_right");
        moveComponent.rotation = inputRotate * tankStats.rotateSpeed;
    }
}