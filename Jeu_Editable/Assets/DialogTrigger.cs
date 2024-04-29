using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogBox; // R�f�rence � la bo�te de dialogue � afficher
    private bool inRange = false; // Pour suivre si le joueur est en contact avec le GameObject

    void Start()
    {
        // Optionnel: D�sactivez le Canvas au d�but si pas d�j� fait dans l'�diteur
        dialogBox.SetActive(false);
    }

    void Update()
        {
            // V�rifier si le joueur est en contact et s'il appuie sur la touche "E"
            if (inRange && Input.GetKeyDown(KeyCode.E))
            {
                // Afficher la bo�te de dialogue
                dialogBox.SetActive(true);
                Time.timeScale = 0f;
            }
        }

    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifier si le joueur est en collision avec le GameObject
        if (other.CompareTag("Player"))
        {
            inRange = true; // Le joueur est en contact
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // V�rifier si le joueur sort de la collision avec le GameObject
        if (other.CompareTag("Player"))
        {
            inRange = false; // Le joueur n'est plus en contact
        }
    }
}
