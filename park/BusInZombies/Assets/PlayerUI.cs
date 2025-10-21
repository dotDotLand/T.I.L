using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    // 인스펙터에서 연결할 UI Slider
    public Slider staminaBar;
    public Slider hpBar;

    // 인스펙터에서 연결할 PlayerMove 스크립트
    public PlayerMove player;

    void Update()
    {
        staminaBar.value = player.stamina;
        hpBar.value = player.hp / player.maxHp;
    }
}
