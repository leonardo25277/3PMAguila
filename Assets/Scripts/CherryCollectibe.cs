using UnityEngine;

public class CherryCollectible : MonoBehaviour
{
    // Evita recoger la misma cereza más de una vez.
    private bool collected = false;

    // Detecta cuando otro objeto entra en el Trigger.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        // Comprueba que el objeto sea el águila.
        if (!other.CompareTag("Player")) return;

        // Busca el administrador del juego.
        GameManager manager =
            FindFirstObjectByType<GameManager>();

        if (manager == null)
        {
            Debug.LogError("No se encontró GameManager");
            return;
        }

        collected = true;

        // Resta 5 puntos al recoger la cereza.
        manager.AddPoints(-5);

        // Elimina la cereza de la escena.
        Destroy(gameObject);
    }
}