using UnityEngine;
using System.Collections;

public class RotateLock10 : MonoBehaviour
{


    // Use this for initialization
    int numberOfChars = 10;
    char[] currentChar = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
    int currentIndex;
    string pwd;

    void Start()
    {
        currentIndex = 0;
        pwd = getPwd();
        Debug.Log("Current pass is: " + pwd);
    }

    // Update is called once per frame
    void Update()
    {
        rotate(numberOfChars);
    }

    string getPwd()
    {
        int fstCharAscii = (int)'a';
        int sndCharAscii = fstCharAscii + numberOfChars;
        char pwdChar = ((char)Random.Range(fstCharAscii, sndCharAscii));
        return pwdChar.ToString();
    }

    void rotate(int numOfCharacters)
    {
        float rotation = 360 / numOfCharacters;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -rotation);
            if (currentIndex == 0)
            {
                currentIndex = 9;
            }
            else
            {
                currentIndex--;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotation);
            if (currentIndex == 9)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }
        }

        if (Input.GetKeyDown("return"))
        {
            if (pwd.Equals(currentChar[currentIndex].ToString()))
            {
                Debug.Log("Nice!");
            }
            else
            {
                Debug.Log("You Suck!");
            }
        }
    }
}
