using System;
namespace practica_primer_parcial
{
	public class Producto
	{
        protected EMarcaProducto _marca;
        protected float _precio;
        protected int _codigoDebarras;


		public Producto()
		{
            this._marca = (EMarcaProducto)0;
            this._precio = 0;
            this._codigoDebarras = 0;
		}

        public abstract float CalcularCostoDeProduccion{
            get;
        };

        protected EMarcaProducto Marca
		{
			get
			{
				return _marca;
			}
		}

		protected float Precio
		{
			get
			{
				return _precio;
			}
		}


		static public bool operator ==(Producto prodUno, Producto prodDos)
		{
			return true;
		}

		static public bool operator !=(Producto prodUno, Producto prodDos)
		{
            return false;
            
		}

        static public bool operator ==(Producto prodUno, EMarcaProducto marca){
            if(prodUno._marca == marca){
                return true;
            }
            return false;
        }

		static public bool operator !=(Producto prodUno, EMarcaProducto marca)
		{
            if (prodUno._marca != marca)
			{
				return false;
			}
            return true;

		}

		public override bool Equals(object o)
		{
			try
			{
                return (bool)(this == (Producto)o);
			}
			catch
			{
				return false;
			}
		}


		static public implicit operator int(Producto producto)
		{
            return producto._codigoDebarras;
		}

		static public explicit operator string(Producto producto)
		{
            return producto.MostrarProducto();
		}

        private string MostrarProducto(){
            return "Marca: " + this._marca + "| Precio" + this._precio;
        }
	}
}