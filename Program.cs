using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace proyecto12023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES  PARA REPORTE DE FACTURA
            int numerodefactura = 0;
            int numerodefactura3 = 0;
            int numerodefactura2 = 0;
            int panfrancesfinal = 0;
            int librasazucarfinal = 0;
            int galletasfinal = 0;
            int granolafinal = 0;
            int naranjafinal = 0;
            double guardar = 0;
            double guardar1 = 0;
        Menu:
            // MENU PRINCIPAL 
            
            Console.Clear();
            Console.WriteLine("Universidad Rafael Landivar ");
            Console.WriteLine("                                       ||         BIENVENIDO           ||                       ");
            Console.WriteLine("                                       ||   SUPERMERCADO  PUBLICMART   ||                       ");
            Console.WriteLine("1. FACTURACION");
            Console.WriteLine("2. REPORTES DE FACTURACION");
            Console.WriteLine("3. CERRAR EL PROGRAMA");
            Console.WriteLine(" ");
            //VARIABLES GENERALES DE TOTALES           
            int i = Convert.ToInt32(Console.ReadLine());
            int p = 0;           
            double  total = 0;
            double total1 = 0;
            double total2 = 0;
            double total3 = 0;
            double total4 =0;
            double total5 = 0;
            double cantprimera = 0;
            double cannumero1 = 0;
            double can3 = 0;
            double cantidad4 = 0;
            double cantfinal = 0;
            int suman = 0;
            int suman5 = 0;
            int suman4 = 0;
            int suman3 = 0;
            int suman2 = 0;
            int suman1 = 0;
            // DATOS INGRESADOS POR EL USUARIO
            switch (i)
            {   
                case 1:
                    Console.WriteLine("Ingresar numero de NIT");
                    string Nit1 = Console.ReadLine();
                    Console.WriteLine("Ingresar Email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingresar Nombre");
                    string nombre = Console.ReadLine();
                    //TABLA DE PRODUCTOS 
                    Console.WriteLine("     |°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine("     |         001         |PAN FRANCES                             |    Q1.10       |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine("     |         002         |LIBRA DE AZUCAR                         |    Q5.00       |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine("     |         003         |CAJA DE GALLETAS                        |    Q7.30       |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine("     |         004         |CAJA DE GRANOLA                         |    Q32.50      |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine("     |         005         |LITRO DE JUGO DE NARANJA                |    Q17.95      |");
                    Console.WriteLine("     |---------------------|----------------------------------------|----------------|");
                    Console.WriteLine();
                    Console.Write("                                  INGRESE CODIGO DE PRODUCTO:    ");    
                    
                    string realizaciondeoperaciones = " ";      
                    

                    
                    //CONTADORES INICIO DE CICLO
                    do
                    {                        
                        string seleccion1 = "";
                        seleccion1 = Console.ReadLine();
                        switch (seleccion1)
                        {
                            //CODIGO DE PAN
                            
                            case "001":
                                Console.WriteLine("     .................................................................................");
                                Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                                Console.WriteLine("     |.....................|........................................|................|");
                                Console.WriteLine("     |         001         |PAN FRANCES                             |    Q1.10       |");
                                Console.WriteLine("     |<><><><><><><><><><><|<><><><><><><><><><><><><><><><><><><><>|<><><><><><><><>|");
                                Console.WriteLine("");
                                Console.Write("                     INGRESE LA CANTIDAD DE PAN FRANCES QUE NECESITA:     ");
                                int panfrances = Convert.ToInt32(Console.ReadLine());
                                double panfrances1 = 0;
                                double preciopan = 0;
                                if (panfrances <= 0)
                                {
                                    Console.WriteLine(" NO INGRESO NINGUNA CANTIDAD");
                                }
                                else
                                {
                                    double cantidadno1 = 1.10;
                                    total1 = total1 + cantidadno1;                                    
                                    //OPERACIONES + CONTADORES DE PAN FRANCES
                                    suman1 = suman1 + panfrances;
                                    panfrances1 = Convert.ToDouble(panfrances);
                                    preciopan = Convert.ToDouble(cantidadno1);
                                    cantprimera =preciopan * panfrances1+cantprimera;
                                }
                                Console.Write("   INGRESE OTRO PRODUCTO, SINO DESEA AGREGAR COLOQUE 006 PARA REALIZAR LA FACTURA:  ");
                                break;
                            //CODIGO DE AZUCAR
                            case "002":
                                Console.WriteLine("     .................................................................................");
                                Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                                Console.WriteLine("     |.....................|........................................|................|");
                                Console.WriteLine("     |         002         |LIBRA DE AZUCAR                         |    Q5.00       |");
                                Console.WriteLine("     |<><><><><><><><><><><|<><><><><><><><><><><><><><><><><><><><>|<><><><><><><><>|");
                                Console.WriteLine("");
                                Console.Write("                     INGRESE LAS LIBRAS DE AZUCAR QUE NECESITA:     ");
                                int libazucar = Convert.ToInt32(Console.ReadLine());
                                double libazucar1 = 0;
                                double precioazucar = 0;
                                if (libazucar <= 0)
                                {
                                    Console.WriteLine(" NO INGRESO NINGUNA CANTIDAD");
                                }
                                else
                                {   //OPERACIONES  + CONTADORES DE AZUCAR
                                    double cantidadno2 = 5;
                                    total2 = total2 + cantidadno2;                                                                  
                                    suman2 = suman2 + libazucar;
                                    libazucar1 = Convert.ToDouble(libazucar);
                                    precioazucar = Convert.ToDouble(cantidadno2);
                                    cannumero1 = precioazucar *  libazucar1 + cannumero1;
                                }
                                Console.WriteLine("");
                                Console.Write("   INGRESE OTRO PRODUCTO, SINO DESEA AGREGAR COLOQUE 006 PARA REALIZAR LA FACTURA:  ");
                                break;
                            //CODIGO GALLETAS
                            case "003":
                                Console.WriteLine("     .................................................................................");
                                Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                                Console.WriteLine("     |.....................|........................................|................|");
                                Console.WriteLine("     |         003         |CAJA DE GALLETAS                        |    Q7.30       |");
                                Console.WriteLine("     |<><><><><><><><><><><|<><><><><><><><><><><><><><><><><><><><>|<><><><><><><><>|");
                                Console.WriteLine("");
                                Console.Write("                     INGRESE CAJAS DE GALLETA  QUE NECESITA:     ");
                                int galleta = Convert.ToInt32(Console.ReadLine());
                                double galleta1 = 0;
                                double preciogalleta = 0;
                                if (galleta <= 0)
                                {
                                    Console.WriteLine(" NO INGRESO NINGUNA CANTIDAD");
                                }
                                else
                                {  //OPERACIONES BASICAS GALLETA
                                    double cantidadno3 = 7.30;
                                    total3 = total3 + cantidadno3;                                    
                                    suman3 = suman3 + galleta;
                                    galleta1 = Convert.ToDouble(galleta);
                                    preciogalleta = Convert.ToDouble(cantidadno3);
                                    can3 = preciogalleta * galleta1+ can3;
                                }
                                Console.WriteLine("");
                                Console.Write("   INGRESE OTRO PRODUCTO, SINO DESEA AGREGAR COLOQUE 006 PARA REALIZAR LA FACTURA:  ");

                                break;
                            // CODIGO GRANOLA
                            case "004":
                                Console.WriteLine("     .................................................................................");
                                Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                                Console.WriteLine("     |.....................|........................................|................|");
                                Console.WriteLine("     |         004         |CAJA DE GRANOLA                         |    Q32.50      |");
                                Console.WriteLine("     |<><><><><><><><><><><|<><><><><><><><><><><><><><><><><><><><>|<><><><><><><><>|");
                                Console.WriteLine("");
                                Console.Write("                     INGRESE CAJAS DE GRANOLA  QUE NECESITA:     ");

                                int granola = Convert.ToInt32(Console.ReadLine());
                                double granola1 = 0;
                                double preciogranola = 0;
                                if (granola <= 0)
                                {
                                    Console.WriteLine(" NO INGRESO NINGUNA CANTIDAD");
                                }
                                else
                                {   //OPERACIONES GRANOLAS
                                    double cantidadno4 = 32.50;
                                    total4 = total4 + cantidadno4;                                
                                    suman4 = suman4 + granola;
                                    granola1 = Convert.ToDouble(granola);
                                    preciogranola = Convert.ToDouble(cantidadno4);
                                    cantidad4 = preciogranola * granola1+ cantidad4;
                                }
                                Console.WriteLine("");
                                Console.Write("   INGRESE OTRO PRODUCTO, SINO DESEA AGREGAR COLOQUE 006 PARA REALIZAR LA FACTURA:  ");
                                break;
                            //CODIGO NARANJA
                            case "005":
                                Console.WriteLine("     .................................................................................");
                                Console.WriteLine("     |CODIGO DEL PRODUCTO  |                  PRODUCTO              |    PRECIO      |");
                                Console.WriteLine("     |.....................|........................................|................|");
                                Console.WriteLine("     |         005         |LITRO DE JUGO DE NARANJA                |    Q17.95      |");
                                Console.WriteLine("     |<><><><><><><><><><><|<><><><><><><><><><><><><><><><><><><><>|<><><><><><><><>|");
                                Console.WriteLine("");
                                Console.Write("                     INGRESE LITROS DE JUGO DE NARANJA:      ");
                                int jnaranja = Convert.ToInt32(Console.ReadLine());
                                double naranja = 0;
                                double naranja1 = 0;
                                
                                if (jnaranja <= 0)

                                {
                                    Console.WriteLine(" NO INGRESO NINGUNA CANTIDAD");
                                }
                                else
                                {   //OPERACIONES CONTADORES NARANJA 
                                    double cantidadno5 = 17.95;
                                    total5 = total5 + cantidadno5;                                  
                                    suman5 = suman5 + jnaranja;
                                    naranja = Convert.ToDouble(cantidadno5);
                                    naranja1 = Convert.ToDouble(jnaranja);
                                    cantfinal =  naranja *  naranja1 +cantfinal ;                                   
                                }
                                Console.Write("   INGRESE OTRO PRODUCTO, SINO DESEA AGREGAR COLOQUE 006 PARA REALIZAR LA FACTURA:  ");
                                
                                break;

                            //PARA EMITIR  FACTURA
                            case "006":
                                                              
                                Console.WriteLine("");
                                Console.WriteLine("            °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                                Console.WriteLine("            INGRESE SU METODO DE PAGO " + "1.EFECTIVO | 2.TARJETA DE CREDITO");
                                panfrancesfinal = panfrancesfinal + suman1;
                                librasazucarfinal = librasazucarfinal + suman2;
                                galletasfinal = galletasfinal + suman3;
                                granolafinal = granolafinal + suman4;
                                naranjafinal = naranjafinal + suman5;
                                // DATOS DE FACTURA PARA OPCION (1) DE EFECTIVO                               
                                string x = Console.ReadLine();
                                switch (x)
                                {
                                    case "1":
                                        //PUNTOS OBTENIDOS EN LA COMPRA
                                        suman = suman1 + suman2 + suman3 + suman4 + suman5;
                                        total = cantprimera + cannumero1 + can3 + cantidad4 + cantfinal;
                                        //IMPUESTOS AGREGADOS.
                                        double isr1 = 5;
                                        double porcentaje1 = 0;
                                        porcentaje1 = (total * isr1) / 100;
                                        double iva1 = 12;
                                        double porcentajeiva = 0;
                                        porcentajeiva = (total * iva1) / 100;
                                        double totalidadapagar;
                                        totalidadapagar = porcentaje1 + porcentajeiva + total;
                                        //NUMERO DE FACTURA FORMULA.
                                        Random aleatorio = new Random();
                                        int valoraleatorio = aleatorio.Next(1, 1000);
                                        
                                        numerodefactura = ((2 * valoraleatorio + 0) + (2021 + suman)) % 10000;
                                        //DATOS GUARDADOS PARA EMITIR FACTURA
                                        Console.Clear();
                                        Console.WriteLine("                                     SUPERCADO PUBLICMART ");
                                        Console.WriteLine("                        NUMERO DE FACTURA:       " + numerodefactura);
                                        Console.WriteLine("                        FECHA            :       " + DateTime.Today);
                                        Console.WriteLine("                        NIT              :       " + Nit1);
                                        Console.WriteLine("                        NOMBRE           :       " + nombre);
                                        Console.WriteLine("                        FACTURA AL CORREO:       " + email);
                                        // DATOS GUARDADOS DE PRODUCTOS PARA FACTURA
                                        Console.WriteLine(realizaciondeoperaciones);
                                        Console.WriteLine("                        UNIDADES DE PAN FRANCES      :=  " + suman1);
                                        Console.WriteLine("                        UNIDADES DE LIBRAS DE AZUCAR :=  " + suman2);
                                        Console.WriteLine("                        UNIDADES CAJAS DE GALLETAS   :=  " + suman3);
                                        Console.WriteLine("                        UNIDADES CAJAS DE GRANOLA    :=  " + suman4);
                                        Console.WriteLine("                        LITROS DE JUGO DE NARANJA    :=  " + suman5);                                        
                                        Console.WriteLine("                        CANTIDAD DE PRODUCTOS GENERAL:=  " + suman);
                                        Console.WriteLine("                        SALDO TOTAL SIN IMPUESTOS     = Q" + total);
                                        Console.WriteLine("                        5%  DE ISR                  = Q " + porcentaje1);
                                        Console.WriteLine("                        12% DE IVA                  = Q " + porcentajeiva);
                                        Console.WriteLine("                        PRECIO TOTAL A PAGAR        = Q " +(Math.Round( totalidadapagar,2)+ " (INCLUYE IVA / ISR)"));
                                        Console.WriteLine("                        PAGO EN EFECTIVO ");
                                        //DATO GUARDADO PARA EL REPORTE DE FACTURACION
                                        guardar = guardar + totalidadapagar;
                                        numerodefactura2 = (numerodefactura3 * 0) + numerodefactura2 + 1;
                                        
                                      

                                        Console.Write("                        ESCRIBA EL NUMERO 1 PARA REGRESAR AL MENU PRINCIPAL:  ");
                                        // CONDICIONAL PARA REGRESAR AL MENU 
                                        string deside = Console.ReadLine();
                                        if (deside == "1")
                                        {
                                            goto Menu;
                                        }
                                        break;
                                    case "2":
                                        //PUNTOS OBTENIDOS EN LA COMPRA
                                        suman = suman1 + suman2 + suman3 + suman4 + suman5;
                                        total = cantprimera + cannumero1 + can3 + cantidad4 + cantfinal;
                                        //IMPUESTOS AGREGADOS + VARIABLES.
                                        double isr = 5;
                                        double porcentaje = 0;
                                        porcentaje = (total * isr) / 100;

                                        double iva = 12;
                                        double ivaporcentaje = 0;
                                        ivaporcentaje = (total * iva) / 100;

                                        double sumadeiva = 0;
                                        sumadeiva = porcentaje + ivaporcentaje + total;

                                        double puntos0 = 0;
                                        int puntos1 = 0;
                                        int can2 = 0;
                                        int puntosacumulados = 0;
                                        double cantidad50 = 0;
                                        double cantidad150 = 0;
                                        int puntos3 = 0;
                                        double cantidadmas = 0;
                                        //PROCESO PARA OBTENCION DE PUNTOS EN TARJETA DE CREDITO 
                                        if (sumadeiva < 10)
                                        {

                                            puntos0 = sumadeiva - sumadeiva;
                                            puntos1 = Convert.ToInt32(puntos0);

                                        }
                                        //PROCESO MENOR DE Q50  1 PUNTO POR CADA Q10.00
                                        if (sumadeiva <= 50 && sumadeiva > 10)
                                        {
                                            cantidad50 = (sumadeiva - sumadeiva % 10) / 10;
                                            puntos1 = Convert.ToInt32(cantidad50);
                                            puntosacumulados = (puntos1);

                                        }
                                        //PROCESO MAYOR DE 50 Y MENOS DE 150 2 PUNTOS  POR CADA Q10.00
                                        if (sumadeiva > 50 && sumadeiva < 150)
                                        {
                                            cantidad150 = (sumadeiva-sumadeiva %10) / 10;
                                            can2 = Convert.ToInt32(cantidad150);
                                            puntosacumulados = can2*2;
                                        }
                                        //PROCESO MAYOR A 150 3 PUNTOS POR CADA Q15.00
                                        if (sumadeiva >= 150)
                                        {

                                            cantidadmas = (sumadeiva - sumadeiva %10) / 15;
                                            puntos3 = Convert.ToInt32(cantidadmas);
                                            puntosacumulados = puntos3 * 3;

                                        }
                                        //FORMULA PARA FACTURA REQUERIDA
                                        Random aleatorio1 = new Random();
                                        int valoraleatorio1 = aleatorio1.Next(1, 1000);
                                        int valorentero1 = Convert.ToInt32(valoraleatorio1);
                                        int numerodefactura1 = 0;

                                        numerodefactura1 = ((2 * valorentero1 + (puntosacumulados * puntosacumulados)) + (2021 + suman)) % 10000;
                                        //DATOS DE FACTURACION
                                        numerodefactura3 = numerodefactura1 + numerodefactura;

                                        Console.Clear();
                                        Console.WriteLine("                                          FACTURA         ");
                                        Console.WriteLine("                                     SUPERCADO PUBLICMART ");
                                        Console.WriteLine("                        NUMERO DE FACTURA:       " + numerodefactura1);
                                        Console.WriteLine("                        FECHA            :       " + DateTime.Today);
                                        Console.WriteLine("                        NIT              :       " + Nit1);
                                        Console.WriteLine("                        NOMBRE           :       " + nombre);
                                        Console.WriteLine("                        FACTURA AL CORREO:       " + email);
                                        Console.WriteLine(realizaciondeoperaciones);
                                        
                                        //COMPRAS
                                        Console.WriteLine("                        UNIDADES DE PAN FRANCES      :=  " + suman1);
                                        Console.WriteLine("                        UNIDADES DE LIBRAS DE AZUCAR :=  " + suman2);
                                        Console.WriteLine("                        UNIDADES CAJAS DE GALLETAS   :=  " + suman3);
                                        Console.WriteLine("                        UNIDADES CAJAS DE GRANOLA    :=  " + suman4);
                                        Console.WriteLine("                        LITROS DE JUGO DE NARANJA    :=  " + suman5);
                                        //PRODUCTOS TOTALIDAD
                                        Console.WriteLine("                        CANTIDAD DE PRODUCTOS GENERAL:=  " + suman);

                                        Console.WriteLine("                        SALDO TOTAL SIN IMPUESTOS   = Q " + total);
                                        Console.WriteLine("                        5%  DE ISR                  = Q " + porcentaje);
                                        Console.WriteLine("                        12% DE IVA                  = Q " + ivaporcentaje);
                                        Console.WriteLine("                        PRECIO TOTAL A PAGAR        = Q "+(Math.Round(sumadeiva,2) + " (INCLUYE IVA / ISR)"));
                                        Console.WriteLine("                        PUNTOS ACUMULADOS           = " + puntosacumulados);
                                        Console.WriteLine("                        PAGO EN TARJETA DE CREDITO" +   "");
                                        Console.Write("                        ESCRIBA EL NUMERO 1 PARA REGRESAR AL MENU PRINCIPAL:  ");
                                        //PROCESO VARIABLES PARA REPORTE DE FACTURACION OPCION 2
                                        guardar = guardar + sumadeiva;
                                        guardar1 = guardar1 + puntosacumulados;
                                        numerodefactura2 = (numerodefactura3 * 0) + numerodefactura2 + 1;

                                        string deside1 = Console.ReadLine();
                                        
                                        if (deside1 == "1")

                                        {

                                            goto Menu;
                                        }
                                       
                                        break;                                       
                                }            
                                
                                break;                               
                        }
                        //PROCESOS ALGEBRAICOS PARA GUARDAR LAS VARIABLES Y APAREZCAN EN REPORTE DE FACTURAS
                        
                        
                       

                    } while (p < 1);
                    

                    break;

                    //REPORTES DE FACTURACION
                case 2:
                    Console.Clear();
                    Console.WriteLine("               °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° ");
                    Console.WriteLine("               ° °  °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°  ° °");
                    Console.WriteLine("               ° °         °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°                       ° °");
                    Console.WriteLine("               ° °       || REPORTE GENERAL  DE PRODUCTOS VENDIDOS ||                     ° °");
                    Console.WriteLine("               ° °          °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°                        ° °");
                    Console.WriteLine("               ° °        UNIDADES DE PAN FRANCES      :=  " + panfrancesfinal);
                    Console.WriteLine("               ° °        UNIDADES DE LIBRAS DE AZUCAR :=  " + librasazucarfinal);
                    Console.WriteLine("               ° °        UNIDADES CAJAS DE GALLETAS   :=  " + galletasfinal );
                    Console.WriteLine("               ° °        UNIDADES CAJAS DE GRANOLA    :=  " + granolafinal);
                    Console.WriteLine("               ° °        LITROS DE JUGO DE NARANJA    :=  " + naranjafinal);
                    Console.WriteLine("               ° °        TOTAL  GENERAL DE COMPRAS CONSUMIDAS : Q  " +(Math.Round( guardar,2)));
                    Console.WriteLine("               ° °        PUNTOS GENERALES DE COMPRAS CON  TC  : " + guardar1 );
                    
                    Console.WriteLine("                          FACTURAS ACUMULADAS          := " + numerodefactura2);
                    Console.WriteLine("                          GRACIAS POR SU COMPRA VUELVA PRONTO!!!.");
                    break;


                    
            }
            Console.ReadKey();


        }
    }
}
