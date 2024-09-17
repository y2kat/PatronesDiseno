using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //Cuando el objeto (enemigo) se habilita, se suscribe al evento
    void OnEnable()
    {
        Jugador.OnPlayerDetected += ReactToPlayer;
    }

    //Cuando el objeto (enemigo) se deshabilita, se desuscribe del evento
    void OnDisable()
    {
        Jugador.OnPlayerDetected -= ReactToPlayer;
    }

    void ReactToPlayer()
    {
        Debug.Log("Detectao");
    }
}

