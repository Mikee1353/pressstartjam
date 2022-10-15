using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public static int playerHealth = 12;
    public GameObject checkBox;


    private float _distanceBetween;
    private float _trueDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        _distanceBetween = Vector2.Distance(transform.position, checkBox.transform.position);
        //Debug.Log(_distanceBetween);
        ButtonandDistanceCheck();

    }

    public void healthCheck()
    {
        playerHealth--;
        Debug.Log(playerHealth);
    }

    public void ButtonandDistanceCheck()
    {

        //B BUTTON
        if (CompareTag("BButton"))
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("You press B");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance) //burda mathf.abs kullan
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    healthCheck();
                }
            }
        }


        //Y BUTTON
        else if (CompareTag("YButton"))
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Debug.Log("You press Y");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    healthCheck();
                }
            }
        }


        //U BUTTON
        else if (CompareTag("UButton"))
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Debug.Log("You press U");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    healthCheck();
                }
            }
        }


        //I BUTTON
        else if (CompareTag("IButton"))
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("You press I");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    healthCheck();
                }
            }
        }


        //O BUTTON
        else if (CompareTag("OButton"))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("You press O");
                if (_distanceBetween <= _trueDistance && _distanceBetween >= -_trueDistance)
                {
                    Debug.Log("You Got It!");
                    Destroy(gameObject);
                }
                else
                {
                    healthCheck();
                }
            }
        }


    }
}
