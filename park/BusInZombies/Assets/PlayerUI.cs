using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    // �ν����Ϳ��� ������ UI Slider
    public Slider staminaBar;
    public Slider hpBar;

    // �ν����Ϳ��� ������ PlayerMove ��ũ��Ʈ
    public PlayerMove player;

    void Update()
    {
        staminaBar.value = player.stamina;
        hpBar.value = player.hp / player.maxHp;
    }
}
