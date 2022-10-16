using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playerHealth = 12;

    public void HealthDecrease()
    {
        playerHealth--;
        Debug.Log(playerHealth);
    }
}
