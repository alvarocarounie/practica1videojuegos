using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    // Monedas
    private int coins = 0;

    // Vidas
    public int lives = 3;

    // Referencias
    public Transform player;
    public Transform respawnPoint;

    // Eventos UI
    public event Action<int> OnCoinsChanged;
    public event Action<int> OnLivesChanged;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        OnCoinsChanged?.Invoke(coins);
        OnLivesChanged?.Invoke(lives);
    }

    // =========================
    // MONEDAS
    // =========================
    public void AddCoin()
    {
        coins++;
        OnCoinsChanged?.Invoke(coins);
    }

    public int GetCoins()
    {
        return coins;
    }

    // =========================
    // VIDAS
    // =========================
    public void LoseLife()
    {
        if (lives <= 0)
            return;

        lives--;

        OnLivesChanged?.Invoke(lives);

        if (lives > 0)
        {
            RespawnPlayer();
        }
        else
        {
            // Reinicia el nivel
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public int GetLives()
    {
        return lives;
    }

    // =========================
    // RESPAWN
    // =========================
    void RespawnPlayer()
    {
        player.position = respawnPoint.position;

        Rigidbody rb = player.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    // =========================
    // CHECKPOINT
    // =========================
    public void SetCheckpoint(Transform newCheckpoint)
    {
        respawnPoint = newCheckpoint;
    }
}