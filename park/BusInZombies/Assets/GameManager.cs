using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PlayerMove player;
    public TextMeshProUGUI gameOverText;

    void Start()
    {
        
    }

    void Update()
    {
        if (!player.isAlive)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
