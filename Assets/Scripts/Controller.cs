using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Import java.io similar a java

// : es igual a extends

public class Controller : MonoBehaviour
{
  public float speed;
  public int contador;
  Rigidbody rb;
  public Text count;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    count.text = contador.ToString();
  }

  //Cada tiempo de maquina
  void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal"); //-1.0 0 1.0
    float moveVertical = Input.GetAxis("Vertical");

    //Vector3 = x,y,z
    Vector3 movimiento = new Vector3(moveHorizontal, 0.0f, moveVertical);
    rb.AddForce(movimiento * speed);
    count.text = contador.ToString();
  }

  //Cada Frame
  // Update is called once per frame
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("point"))
    {
      Destroy(other.gameObject);
      contador++;
    }
  }
}
