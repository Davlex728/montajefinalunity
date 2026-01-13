using UnityEngine;

public class PlayerSpawnData : MonoBehaviour
{
    // Variable estática para compartir la posición entre escenas
    public static Vector2 NextSpawnPosition = Vector2.zero;

    private void Start()
    {
        // Si se ha establecido una posición, usamos esa
        transform.position = NextSpawnPosition;
    }
}
