using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class MenuHighScore : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = "High Score = " + Preference.HighScore.ToString("0.#") + "m";
    }

}