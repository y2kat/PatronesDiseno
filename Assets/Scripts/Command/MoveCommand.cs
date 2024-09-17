using UnityEngine;

public class MoveCommand : ICommand
{
    private Player player;
    private Vector3 direction;

    public MoveCommand(Player player, Vector3 direction)
    {
        this.player = player;
        this.direction = direction;
    }

    public void Execute()
    {
        player.Move(direction);
    }
}

