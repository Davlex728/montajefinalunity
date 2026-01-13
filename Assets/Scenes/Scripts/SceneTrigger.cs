using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    [SerializeField] private string sceneName;      // Nombre de la escena destino
    [SerializeField] private Vector2 spawnPosition; // Posición donde quieres que aparezca el player

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¡Algo ha chocado conmigo: " + other.name + "!");
        if (!other.CompareTag("Player")) return;

        // Guardar posición para la próxima escena
        PlayerSpawnData.NextSpawnPosition = spawnPosition;

        // Cambiar de escena
        SceneManager.LoadScene(sceneName);
    }
}
