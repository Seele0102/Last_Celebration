using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrops : MonoBehaviour
{
    public GameObject[] gos;

    public void GenItem()
    {
        Vector3 pos = transform.position;
        Instantiate(gos[Random.Range(0,gos.Length)],pos,Quaternion.identity);
        Destroy(gameObject);
    }
    /*��ɫ�ű�����������д
    if(other.gameObject.CompareTag("Enemy")){
        other.GetComponent<ItemDrops>().GenItem();
    }
    */


}
