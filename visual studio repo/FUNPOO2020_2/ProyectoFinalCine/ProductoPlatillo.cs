using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCine
{
    internal class ProductoPlatillo:Producto
    {
        #region Campos
        string platillo;
        Producto[] ingredientes;
        int cantidadPlatillo;
        float precioPlatillo;
        #endregion

        #region Propiedades
        public string Platillo { get => platillo; set => platillo = value; }
        public int CantidadPlatillo { get => cantidadPlatillo; set => cantidadPlatillo = value; }
        public float PrecioPlatillo { get => precioPlatillo; set => precioPlatillo = value; }
        internal Producto[] Ingredientes { get => ingredientes; set => ingredientes = value; }
        #endregion

        #region Metodos
        public bool GenerarPlatillo() { 
                switch (platillo.ToUpper())
                {
                    case "CREPA":
                        for (int i = 0; i < ingredientes.Length; i++)
                        {
                            if (ingredientes[i].Nombre == "MASA" && ingredientes[i].Cantidad > 0)
                            {
                                if (ingredientes[i + 1].Nombre == "MERMELADA" && ingredientes[i].Cantidad > 0)
                                {
                                    if (ingredientes[i + 2].Nombre == "QUESO CREMA" && ingredientes[i].Cantidad > 0)
                                    {
                                        precioPlatillo = 70.5f;
                                        cantidadPlatillo++;
                                        return true;
                                    }
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        break;
                    case "FRAPPE":
                        for (int i = 0; i < ingredientes.Length; i++)
                        {
                            if (ingredientes[i].Nombre == "LECHE" && ingredientes[i].Cantidad > 0)
                            {
                                if (ingredientes[i + 1].Nombre == "HIELO" && ingredientes[i].Cantidad > 0)
                                {
                                    if (ingredientes[i + 2].Nombre == "CAFE" && ingredientes[i].Cantidad > 0)
                                    {
                                        precioPlatillo = 40.3f;
                                        cantidadPlatillo++;
                                        return true;
                                    }
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        break;
                    case "CROISSANT":
                        for (int i = 0; i < ingredientes.Length; i++)
                        {
                            if (ingredientes[i].Nombre == "CUERNO" && ingredientes[i].Cantidad > 0)
                            {
                                if (ingredientes[i + 1].Nombre == "JAMON" && ingredientes[i].Cantidad > 0)
                                {
                                    if (ingredientes[i + 2].Nombre == "QUESO" && ingredientes[i].Cantidad > 0)
                                    {
                                        precioPlatillo = 35.0f;
                                        cantidadPlatillo++;
                                        return true;
                                    }
                                    else
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                        break;
                    default:
                    return false;
                }
            return true;
        }

        #endregion
    }
}
