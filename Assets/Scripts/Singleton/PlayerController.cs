using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.GameFunctionality();

        GameManager.Instance.UpdateScore(10);
    }
}
