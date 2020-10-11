using Behaviours.Singleton;
using UnityEngine;

namespace Behaviours.Controller
{
    public class JogadorController : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; set; }
        public GameObject chao;
        public BoxCollider sword;
        public bool estaMachucado;

        public void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            Movimentar();
            Rotacionar();
        }

        public void Rotacionar()
        {
            if (VirtualInputManager.Instance.Direcao.x > 0)
                transform.rotation = Quaternion.Euler(0, 90, 0);
            else if (VirtualInputManager.Instance.Direcao.x < 0)
                transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        public void Movimentar()
        {
            Rigidbody.MovePosition(Rigidbody.position +
                                   VirtualInputManager.Instance.Direcao *
                                   (JogadorManager.Instance.velocidade * Time.deltaTime));
        }

        public void Pular()
        {
            Rigidbody.AddForce(Vector3.up * JogadorManager.Instance.velocidadePulo);
        }

        public void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;

            Gizmos.DrawRay(chao.transform.position, Vector3.down * 0.7f);
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Acertou");

            if (other.CompareTag("damage"))
            {
                estaMachucado = true;
                Debug.Log("Acertou");
            }
        }
    }
}