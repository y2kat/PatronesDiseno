using System.Collections.Generic;
using UnityEngine;

public enum GameEvent
{
    PlayerJump
}

public class EventQueue : MonoBehaviour
{
    private Queue<GameEvent> eventQueue = new Queue<GameEvent>();

    void Update()
    {
        // Procesamos eventos en la cola si hay alguno
        if (eventQueue.Count > 0)
        {
            ProcessEvent(eventQueue.Dequeue());
        }
    }

    // Añadir un evento a la cola
    public void EnqueueEvent(GameEvent gameEvent)
    {
        eventQueue.Enqueue(gameEvent);
        Debug.Log("Evento añadido a la cola: " + gameEvent);
    }

    // Procesar los eventos
    private void ProcessEvent(GameEvent gameEvent)
    {
        switch (gameEvent)
        {
            case GameEvent.PlayerJump:
                Debug.Log("Procesando evento de salto");
                GetComponent<PlayerJumping>().Jump();
                break;
            default:
                Debug.LogWarning("Evento no reconocido");
                break;
        }
    }
}
