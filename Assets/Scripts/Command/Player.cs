using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    public void Move(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}

