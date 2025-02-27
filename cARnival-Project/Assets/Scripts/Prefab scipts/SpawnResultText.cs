using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnResultText : MonoBehaviour
{
    public GameObject correctIndicator;
    public GameObject incorrectIndicator;
    public float scale = 1f;

    public void AnsweredCorrect(Vector3 position)
    {
        Debug.Log(position);
        Instantiate(correctIndicator, position, Quaternion.identity);
    }

    public void AnsweredIncorrect(Vector3 position)
    {
        Instantiate(incorrectIndicator, position, Quaternion.identity);
    }
}
