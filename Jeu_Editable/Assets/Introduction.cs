using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public string SceneToLoad;

    void Start()
    {
        // Activer la bo�te de dialogue au d�but de la sc�ne
        dialogueBox.SetActive(true);
    }

    void Update()
    {
        // V�rifier si la bo�te de dialogue est active et si le joueur appuie sur une touche pour passer au dialogue suivant
        if (!dialogueBox)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
