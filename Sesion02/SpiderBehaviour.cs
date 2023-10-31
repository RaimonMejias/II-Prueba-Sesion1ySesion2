using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBehaviour : MonoBehaviour
{
    void OnPointerEnter() {
        if (ScoreController.scoreValue >= 20 && gameObject.activeSelf) {
            gameObject.SetActive(false);
            ScoreController.scoreValue += 100;
        }
    }

    void OnPointerExit() {}

    void OnPointerClick() {}
}
