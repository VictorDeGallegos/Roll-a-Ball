using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public GameObject player;

  private Vector3 offset;

  // El inicio se manda a llamar antes de la primera actualización del cuadro
  void Start()
  {
    offset = transform.position - player.transform.position;
  }

  // La actualización se hace cuadro por cuadro
  void LateUpdate()
  {
    transform.position = player.transform.position + offset;
  }
}
