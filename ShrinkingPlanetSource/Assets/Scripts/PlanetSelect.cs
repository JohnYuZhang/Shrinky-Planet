using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelect : MonoBehaviour {

    //int noClick = Preference.CurrentPlanet;
    public GameObject[] objList;

    public void BtnClick()
    {
        objList[Preference.CurrentPlanet].SetActive(false);

        Preference.CurrentPlanet++;

        if ((Preference.CurrentPlanet) >= objList.Length)
        {
            Preference.CurrentPlanet = 0;
        }
        objList[Preference.CurrentPlanet].SetActive(true);
    }
    public void BtnClickPrev()
    {
        objList[Preference.CurrentPlanet].SetActive(false);

        Preference.CurrentPlanet--;

        if ((Preference.CurrentPlanet) < 0)
        {
            Preference.CurrentPlanet = objList.Length - 1 ;
        }
        objList[Preference.CurrentPlanet].SetActive(true);
    }
    public void Awake()
    {
        for(int i=0; i < objList.Length; i++)
        {
            if(i != Preference.CurrentPlanet)
            {
                objList[i].SetActive(false);
            }
            else
            {
               objList[i].SetActive(true);
            }
        }
    }
}
