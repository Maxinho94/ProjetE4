using UnityEngine;
using UnityEngine.SceneManagement;

public class Buzer : MonoBehaviour
{
    // Nom de la sc�ne � charger
    public string sceneToLoad;

    // Fonction de d�tection de collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision d�tect�e");
        // V�rifier si le joueur entre en collision avec la porte
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // Charger la nouvelle sc�ne
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
