using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnEnable()
    {
        Player.onDamageReceived += UpdateHealth;
    }

    public void UpdateHealth(int health)
    {
        //display updated health here
        Debug.Log("Current health: " + health);
    }
}
