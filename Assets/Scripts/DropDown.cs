using UnityEngine;

public class DropDown : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {
        //������� ����������� �������� ������ ��������
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("������� ��������� � Player");            
            Destroy(gameObject);
        }
        else if(other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("������� ��������� � Ground");
           // playerHP.health--;
            Destroy(gameObject);
        }
    }
}

