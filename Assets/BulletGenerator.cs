using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bulletPrefab; //프리팹을 지정하는 변수


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) //마우스 왼쪽 버튼 틀릭 인식
        {
            //프리팹을 이용하여 오브젝트 생성
            GameObject bullet = Instantiate (bulletPrefab, transform.position, transform.rotation);

            //BulletController 스크립트를 찾아서 Shoot() 함수 호출(총알 발사)
            bullet.GetComponent<BulletController> ().Shoot(new Vector3 (0, 0, 100));
        }
        
    }
}
