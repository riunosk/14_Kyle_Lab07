using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject UpCube;
    public GameObject DownCube;
    public GameObject LeftCube;
    public GameObject RightCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
		{
            print("Up arrow pressed.");
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
		}
        else if (Input.GetKeyUp(KeyCode.UpArrow))
		{
            print("Up arrow released.");
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
		{
            print("Down arrow pressed.");
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
		{
            print("Down arrow released.");
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
            print("Left arrow pressed.");
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
		}
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            print("Down arrow released.");
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
		{
            print("Right arrow pressed.");
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
		}
        else if (Input.GetKeyUp(KeyCode.RightArrow))
		{
            print("Right arrow released.");
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W pressed.");
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            print("W released.");
            UpCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("S pressed.");
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            print("S released.");
            DownCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A pressed.");
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            print("A released.");
            LeftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            print("D pressed.");
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            print("D released.");
            RightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
