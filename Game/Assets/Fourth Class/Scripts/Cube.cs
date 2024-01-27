using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float mana = 100;

    public void skill(float mana)
    {
        this.mana -= mana;

        Debug.Log("Use Skill");
        Debug.Log("current Mana: " + this.mana);
    }
}
