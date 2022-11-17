using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembox : MonoBehaviour
{
    public bool isOveraped = false;
    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;
    void Start()
    {
     myRenderer = GetComponent<Renderer>();   
        originalColor = myRenderer.material.color;
    }
    void Update()
    {
         
    }
    //Ʈ������ �ݶ��̴��� �浹�Ҷ� �ڵ����� ����
    //Enter �浹�� �� �� ����.
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
        
    }
    //Exit �پ��ִٰ� ��������

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

}
