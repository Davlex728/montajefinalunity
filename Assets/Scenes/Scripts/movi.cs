using UnityEngine;

// Esta línea añade automáticamente un Rigidbody2D si el objeto no lo tiene
[RequireComponent(typeof(Rigidbody2D))]
public class movi : MonoBehaviour
{
    [Header("Configuración")]
    public float velocidad = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // CONFIGURACIÓN AUTOMÁTICA:
        // 1. Quita la gravedad para que el objeto no caiga (flote)
        rb.gravityScale = 0;
        // 2. Congela la rotación para que el objeto no ruede al moverse
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Detecta las teclas A (-1) y D (+1) o Flechas
        float inputX = Input.GetAxis("Horizontal");

        // Aplica el movimiento.
        // Mantenemos la velocidad Y actual (rb.velocity.y) en 0 para que no suba/baje
        rb.linearVelocity = new Vector2(inputX * velocidad, 0f);
    }
}
