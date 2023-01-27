using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject bala;
    // Start is called before the first frame update
    public Vector3 pos1;
    public Vector3 resta= new Vector3(0.5f,0f,0f);
    void Start()
    {
        pos1= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)){
            IntanciarBala();
            IntanciarBala();
            
            }
        if (Input.GetKeyDown(KeyCode.K)){
            IntanciarBala();
            IntanciarBala();
            IntanciarBala();
            
            }
        if (Input.GetKeyDown(KeyCode.L)){
            IntanciarBala();
            IntanciarBala();
            IntanciarBala();
            IntanciarBala();
            
            }
        pos1= transform.position;
    }
    private void IntanciarBala(){
        Instantiate(bala,pos1,transform.rotation);
        pos1-=resta;
        Debug.Log("Holaa");
    }

}
