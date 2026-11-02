using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    // Velocidad de movimiento del águila.
    public float speed = 5f;

    // Componente físico del águila.
    private Rigidbody2D rb;

    // Dirección en la que se mueve el águila.
    private Vector2 movement;

    // Obtiene el Rigidbody2D al iniciar.
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Detecta las teclas de movimiento.
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Evita que el movimiento diagonal sea más rápido.
        movement = movement.normalized;
    }

    // Actualiza el movimiento físico.
    void FixedUpdate()
    {
        Vector2 newPosition = rb.position +
            movement * speed * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
}