using System;
using UnityEngine;

namespace Behaviours.Singleton
{
    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        public bool EstaMovimentando { get; set; }
        public bool EstaPulando { get; set; }
        public bool EstaAtacando { get; set; }

        public Vector3 Direcao { get; set; }


        private void Update()
        {
            VerificaMovimento();
            VerificaPulo();
            VerificaAtaque();
            VerificaDirecao();
        }

        public void VerificaDirecao()
        {
            Direcao = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        }

        public void VerificaMovimento()
        {
            if (Math.Abs(Input.GetAxis("Horizontal")) > 0)
                EstaMovimentando = true;
            else
                EstaMovimentando = false;
        }

        public void VerificaPulo()
        {
            EstaPulando = Input.GetKeyDown(KeyCode.Space);
        }

        public void VerificaAtaque()
        {
            EstaAtacando = Input.GetKeyDown(KeyCode.J);
        }
    }
}