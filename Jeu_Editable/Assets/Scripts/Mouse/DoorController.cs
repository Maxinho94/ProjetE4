using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DoorController : MonoBehaviour
{
    // Nom de la sc�ne � charger
    public string sceneToLoad;
    public GameObject dialogBox; // R�f�rence � la bo�te de dialogue � afficher

    void Start()
    {
        // Optionnel: D�sactivez le Canvas au d�but si pas d�j� fait dans l'�diteur
        dialogBox.SetActive(false);
    }

    // Fonction de d�tection de collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // V�rifier si le joueur entre en collision avec la porte
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(DialogueCoroutine());
        }
    }

    IEnumerator DialogueCoroutine()
    {
        dialogBox.SetActive(true);
        Time.timeScale = 0f;

        // Attendre que la bo�te de dialogue soit enti�rement lue avant de changer de sc�ne
        while (dialogBox.activeSelf)
        {
            yield return null;
        }

        // Une fois que la bo�te de dialogue est d�sactiv�e, charger la nouvelle sc�ne
        SceneManager.LoadScene(sceneToLoad);
    }
}
