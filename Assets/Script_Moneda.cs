using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Moneda : MonoBehaviour
{
    public float velocidad;
    public Collider col_moneda;
    public Collider col_player;
    private int direccion;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 150;

        //Obtenemos el collider de la moneda
        col_moneda = GetComponent<Collider>();

 InvokeRepeating("Movimiento", 0, 2);
    }
    // Update is called once per frame
    void Update()
    {

    }

//Funcion movimiento
public void Movimiento()
{
    //Movimiento aleatorio
    direccion = Random.Range(0, 2);
    switch (direccion)
    {
        case 0:
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            break;
        case 1:
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            break;
    }
}

    // Funcion uncollider
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag.Equals("Player"))
    {
        Destroy(gameObject);
    } 
 
 Destroy(gameObject, 6f);
}
}
