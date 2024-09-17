using UnityEngine;

public class Jugador : MonoBehaviour
{
    public delegate void PlayerDetectedEventHandler();
    public static event PlayerDetectedEventHandler OnPlayerDetected;

    public float speed = 5f;
    public float rotationSpeed = 50f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            OnPlayerDetected?.Invoke();
        }
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;

        controller.Move(move * speed * Time.deltaTime);
    }
}


