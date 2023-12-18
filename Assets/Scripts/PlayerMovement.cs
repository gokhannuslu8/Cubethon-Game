using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardForce = 2000f; 
    public float sidewaysForce = 500f; // objenin sağa sola kayması için sabit değerimiz oluyor.

    // Start is called before the first frame update
    void Start()
    {
        // Rb.useGravity = false; // use Gravity false olur ve cismin yer çekimi kaldırılır.
        //Rb.AddForce(0, 200, 500); // Cisim belirtilen kordinatlar kadar ileri bir kuvvetle uçar.
    }

    // Update is called once per frame
    void FixedUpdate() // hareket ve çarpışma algılaması gibi fizikle ilgili işlemleri bu metot içinde güvenle gerçekleştirebilirsiniz.
    {
        //Rb.AddForce(0, 0, 2000 * Time.deltaTime); // Bu değer, oyunun hızının değişken olması durumunda kullanılır.

        // Burada artık forwardForce tanımladık ve Unity içerisinden objenin hızını ayarlayabiliriz. 
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
// buradan sonraki kısımda if kullanarak w,a,s,d tuşlarıyla objeye yöne verme işlemi yapıyoruz.
        if (Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}