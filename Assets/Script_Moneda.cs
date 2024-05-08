using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Moneda : MonoBehaviour
{
    public float velocidad;
    private Collider col_moneda;
    private Collider col_player;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5;

        //Obtenemos el collider de la moneda
        col_moneda = GetComponent<Collider>();

    }
    // Update is called once per frame
    void Update()
    {

        //Llamamos a la funcion movimiento
        InvokeRepeating("Movimiento", 0, 2);
        
    }

//Funcion movimiento
public void Movimiento()
{
    //Movimiento aleatorio
    int direccion = Random.Range(0, 2);
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
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        } else {
            Destroy(gameObject, 6f);
        }
    }
}
