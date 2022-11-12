using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EjPolimorfismo1
{
    abstract class Vehiculo//Clase abstracta
    {
        //Atributos con propiedades
        private int _intCaballosFuerza;

        public int CaballosFuerza
        {
            get { return _intCaballosFuerza; }
            set { _intCaballosFuerza = value; }
        }
        private int _intCantidadPuertas;

        public int CantidadPuertas
        {
            get { return _intCantidadPuertas; }
            set { _intCantidadPuertas = value; }
        }


        //Constructores
        public Vehiculo()
        {
            _intCaballosFuerza = 0;
            _intCantidadPuertas = 0;
        }
        public Vehiculo(int cf, int cp)
        {
            _intCaballosFuerza = cf;
            _intCantidadPuertas = cp;
        }
        //Metodo
        public void Encender()
        {
            MessageBox.Show("El vehiculo de " + CantidadPuertas + " puertas, ha arrancado");
        }
        public virtual void Avanzar()
        {
            MessageBox.Show("El vehiculo esta avanzando");
        }
    }
    class Carro : Vehiculo
    {
        //Atributos con propiedades
        private int _intLlantas;

        public int Llantas
        {
            get { return _intLlantas; }
            set { _intLlantas = value; }
        }
        private double _dblVelocidad;

        public double Velocidad
        {
            get { return _dblVelocidad; }
            set { _dblVelocidad = value; }
        }

        //Constructor
        public Carro(int cf, int puertas, double vel, int Llan) : base(cf, puertas)
        {
            CaballosFuerza = cf;
            CantidadPuertas = puertas;
            Velocidad = vel;
            Llantas = Llan;
        }

        //Polimorfismo parametrico
        public void Capturar()
        {   //informacion default
            Velocidad = 40;
            Llantas = 4;
        }

        public void Capturar(double v, int ll)
        {   //informacion capturada
            Velocidad = v;
            Llantas = ll;
        }
        //Metodos
        public new void Encender()
        {
            MessageBox.Show("El carro ha arrancado... velocidad: " + Velocidad);
        }

        public override void Avanzar()
        {
            //base.Avanzar();
            MessageBox.Show("El CARRO esta avanzando");
        }
        public virtual void MostrarMensaje()
        {
            MessageBox.Show("El carro con "+ Llantas+" llantas,con "+CaballosFuerza+" caballos de fuerza,\ncon "+CantidadPuertas+" puertas,corre a una velocidad de "+Velocidad+" k/h.");
        }
    }
    }
