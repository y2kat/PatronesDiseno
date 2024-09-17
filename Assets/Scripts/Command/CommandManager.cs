using UnityEngine;

public class CommandManager : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ExecuteCommand(new MoveCommand(player, Vector3.forward));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteCommand(new MoveCommand(player, Vector3.back));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ExecuteCommand(new MoveCommand(player, Vector3.left));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ExecuteCommand(new MoveCommand(player, Vector3.right));
        }
    }

    void ExecuteCommand(ICommand command)
    {
        command.Execute();
    }
}

