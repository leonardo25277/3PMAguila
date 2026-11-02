using UnityEngine;

public class GemCollectible : MonoBehaviour
{
    // Evita recoger la misma gema más de una vez.
    private bool collected = false;

    // Detecta cuando otro objeto entra en el Trigger.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        // Comprueba que el objeto sea el águila.
        if (other.CompareTag("Player"))
        {
            // Busca el administrador del juego.
            GameManager manager =
                FindFirstObjectByType<GameManager>();

            if (manager != null)
            {
                collected = true;

                // Registra la gema y suma 10 puntos.
                manager.CollectGem();

                // Elimina la gema del escenario.
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("No se encontró GameManager");
            }
        }
    }
}