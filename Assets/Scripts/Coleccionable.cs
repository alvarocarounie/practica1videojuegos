using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo ha tocado la moneda: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Es el jugador");
            GameManager.Instance.AddCoin();
            Destroy(gameObject);
        }
    }
}