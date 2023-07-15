using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayer : MonoBehaviour
{
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject cam2;
    [SerializeField] GameObject cam3;
    [SerializeField] GameObject cam4;

    [SerializeField] GameObject mainPlatform;

    private void Start()
    {

    }


    public void Update()
    {
        switch (GameSettings.instance.activePlayerNr)
        {
            case 1:
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                mainPlatform.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
                case 2:
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                cam4.SetActive(false);
                mainPlatform.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
                break;
            case 3:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                cam4.SetActive(false);
                mainPlatform.gameObject.transform.rotation = Quaternion.Euler(0, -180, 0);
                break;
            case 4:
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(true);
                mainPlatform.gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
                break;

        }
    }
}
