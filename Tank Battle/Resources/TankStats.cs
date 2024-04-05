using Godot;

public partial class TankStats : Resource
{
    [Export] public float moveSpeed { get; set; }
    [Export] public float rotateSpeed { get; set; }

    public TankStats()
    {
        moveSpeed = 100f;
        rotateSpeed = 10f;
    }
}