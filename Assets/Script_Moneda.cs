//using UnityEngine;
//
//public class Script_Moneda : MonoBehaviour
//{
//    private int velocidad = 6;
//    private int direccion;
//    private static int monedasTocadas = 0;
//
//    // Start is called before the first frame update
//    void Start()
//    {
//        InvokeRepeating("Movimiento", 0, 2);
//        Destroy(gameObject, 6f);
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//        // Actualiza el marcador de monedas tocadas
//        Debug.Log("Monedas tocadas: " + monedasTocadas);
//    }
//
//    //Funcion movimiento
//    public void Movimiento()
//    {
//        //Movimiento aleatorio
//        direccion = Random.Range(0, 4);
//        Vector3 movimiento = Vector3.zero;
//        switch (direccion)
//        {
//            case 0:
//                movimiento = (Vector3.right + Vector3.up).normalized * velocidad * Time.deltaTime;
//                break;
//            case 1:
//                movimiento = (Vector3.right + Vector3.down).normalized * velocidad * Time.deltaTime;
//                break;
//            case 2:
//                movimiento = (Vector3.left + Vector3.down).normalized * velocidad * Time.deltaTime;
//                break;
//            case 3:
//                movimiento = (Vector3.left + Vector3.up).normalized * velocidad * Time.deltaTime;
//                break;
//        }
//        transform.position += movimiento;
//    }
//
//    // Funcion untrigger
//    private void OnTriggerEnter(Collider otñher)
//    {
//        if (Collider.gameObject.tag.Equals("Player"))
//        {
//            Destroy(gameObject);
//            monedasTocadas++;
//        }
//    }
//} 