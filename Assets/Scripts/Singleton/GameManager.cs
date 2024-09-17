using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Mantener entre escenas
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void GameFunctionality()
    {
        Debug.Log("Singleton's working :-)");
    }

    public void UpdateScore(int points)
    {
        score += points;
        Debug.Log("Puntaje actualizado: " + score);
    }
}

