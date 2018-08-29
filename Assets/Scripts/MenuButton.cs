using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

    public RectTransform menuPanel;
    public Vector3 openedPos;
    public Vector3 closedPos;

    [Header("Animation")]
    float timeOfTravel = 5;
    float currentTime = 0;
    float normalizedValue;
    RectTransform rectTransform;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnMouseDown()
    {
        if (menuPanel.position == openedPos)
            Invoke("LerpObject1", 0f);
        else if (menuPanel.position == closedPos)
            Invoke("LerpObject2", 0f);
    }

    IEnumerator LerpObject2()
    {

        while (currentTime <= timeOfTravel)
        {
            currentTime += Time.deltaTime;
            normalizedValue = currentTime / timeOfTravel; // we normalize our time 

            rectTransform.anchoredPosition = Vector3.Lerp(closedPos, openedPos, normalizedValue);
            yield return null;
        }
    }

    IEnumerator LerpObject1()
    {

        while (currentTime <= timeOfTravel)
        {
            currentTime += Time.deltaTime;
            normalizedValue = currentTime / timeOfTravel; // we normalize our time 

            rectTransform.anchoredPosition = Vector3.Lerp(openedPos, closedPos, normalizedValue);
            yield return null;
        }
    }
}
