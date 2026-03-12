using TMPro;
using UnityEngine;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI livesText;

    void Start()
    {
        // Suscribirse a los eventos del GameManager
        GameManager.Instance.OnCoinsChanged += UpdateCoins;
        GameManager.Instance.OnLivesChanged += UpdateLives;

        // Actualizar la UI al empezar
        UpdateCoins(GameManager.Instance.GetCoins());
        UpdateLives(GameManager.Instance.GetLives());
    }

    void UpdateCoins(int coins)
    {
        coinsText.text = "Coins: " + coins;
    }

    void UpdateLives(int lives)
    {
        livesText.text = "Lives: " + lives;
    }
}