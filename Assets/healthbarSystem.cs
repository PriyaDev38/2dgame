using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarSystem : MonoBehaviour
{
    public Slider healthSlider;

    

    public void RemoveHealth(float health) {
        healthSlider.value = health;
    }

    public void resetHealth() {
        healthSlider.value = 1f;
    }
}
