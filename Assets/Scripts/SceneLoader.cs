using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Este método carga cualquier escena cuyo nombre escribas en el botón
    public void LoadSceneByName(string sceneName)
    {
        // Verifica que el string no esté vacío
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("SceneLoader: No se ha proporcionado un nombre de escena.");
        }
    }

    // Opcional: puedes agregar métodos rápidos sin parámetros si quieres
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}