using System;
namespace practica_primer_parcial
{
    public class Jugo : Producto
	{
        private ESaborJugo _sabor;
        private bool DeConsumo;
		


        public Jugo()
		{
            this._precio = 0;
            this._sabor = (ESaborJugo)0;
            this.DeConsumo = true;
		}

        public Jugo(int CodigoDeBarras, float precio, EMarcaProducto marca, ESaborJugo sabor){
			this._precio = precio;
			this._sabor = sabor;
            this._marca = marca;
			this.DeConsumo = true;
        }
	}
}
