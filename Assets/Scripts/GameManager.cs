using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Puntuación actual del jugador.
    public int score = 0;

    // Cantidad de gemas recogidas.
    public int gemsCollected = 0;

    // Total de gemas del nivel.
    public int totalGems = 8;

    // Suma o resta puntos según el parámetro recibido.
    public void AddPoints(int points)
    {
        score += points;

        Debug.Log("Puntos: " + score);
    }

    // Se ejecuta cuando el águila recoge una gema.
    public void CollectGem()
    {
        gemsCollected++;

        AddPoints(10);

        Debug.Log("Gemas: " + gemsCollected + "/" + totalGems);

        if (gemsCollected >= totalGems)
        {
            Debug.Log("¡NIVEL COMPLETADO!");
        }
    }

    // Se ejecuta cuando el águila recoge una cereza.
    public void CollectCherry()
    {
        Debug.Log("¡Cereza recogida!");

        AddPoints(-5);
    }
}