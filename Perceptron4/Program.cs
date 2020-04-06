using System;

namespace Perceptron4
{
    class Program
    {
        static void Main(string[] args)
        {
            // TABLA DE VERDAD DE LA COMPUERTA "AND"

            int a1 = -1, b1 = -1, c1 = -1, d1= -1, dx1 = -1,
                a2 = -1, b2 = -1, c2 = -1, d2 = +1, dx2 = -1,
                a3 = -1, b3 = -1, c3 = +1, d3 = -1, dx3 = -1,
                a4 = -1, b4 = -1, c4 = +1, d4 = +1, dx4 = -1,
                a5 = -1, b5 = +1, c5 = -1, d5 = -1, dx5 = -1,
                a6 = -1, b6 = +1, c6 = -1, d6 = +1, dx6 = -1,
                a7 = -1, b7 = +1, c7 = +1, d7 = -1, dx7 = -1,
                a8 = -1, b8 = +1, c8 = +1, d8 = +1, dx8 = -1,
                a9 = +1, b9 = -1, c9 = -1, d9 = -1, dx9 = -1,
                a10 = +1, b10 = -1, c10 = -1, d10 = +1, dx10 = -1,
                a11 = +1, b11 = -1, c11 = +1, d11 = -1, dx11 = -1,
                a12 = +1, b12 = -1, c12 = +1, d12 = +1, dx12 = -1,
                a13 = +1, b13 = +1, c13 = -1, d13 = -1, dx13 = -1,
                a14 = +1, b14 = +1, c14 = -1, d14 = +1, dx14 = -1,
                a15 = +1, b15 = +1, c15 = +1, d15 = -1, dx15 = -1,
                a16 = +1, b16 = +1, c16 = +1, d16 = +1, dx16 = +1;
   
            double w1, w2, w3, w4;
            double nw1, nw2, nw3, nw4;
            double u;
            double nu;
            double r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16;
            double nr1, nr2, nr3, nr4, nr5, nr6, nr7, nr8, nr9, nr10, nr11, nr12, nr13, nr14, nr15, nr16;

            //w1: Valor
            //nw: Nuevo valor para w
            //r:  Recalcular 
            //nr: Nuevo recalcular

            Console.WriteLine("Ingresa el valor de W1");
            w1 = double.Parse(Console.ReadLine());
 
            Console.WriteLine("Ingrese el valor de W2");
            w2 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Ingrese el valor de W3");
            w3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de W4");
            w4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de U");
            u = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            r1 = ((a1 * w1) + (b1 * w2) + (c1 * w3) + (d1 * w4) + u);

            if (r1 <= dx1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx1 ({dx1})" );
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx1 * a1);
                nw2 = w2 + (dx1 * b1);
                nw3 = w3 + (dx1 * c1);
                nw4 = w4 + (dx1 * d1);
                nu = u + (dx1);

                nr1 = ((a1 * nw1) + (b1 * nw2) + (c1 * nw3) + (d1 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx1' ({dx1}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx1 es: {nw1}");
                Console.WriteLine($"'W2' para 'dx1 es: {nw2}");
                Console.WriteLine($"'W3' para 'dx1 es: {nw3}");
                Console.WriteLine($"'W4' para 'dx1 es: {nw4}");
                Console.WriteLine($"'U' para 'dx1 es: {nu}");
                Console.WriteLine($"El valor final de 'dx4' es: {nr1}");
                Console.WriteLine("\n");

            }

            r2 = ((a2 * w1) + (b2 * w2) + (c2 * w3) + (d2 * w4) + u);

            if (r2 <= dx2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx2 ({dx2})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx2 * a2);
                nw2 = w2 + (dx2 * b2);
                nw3 = w3 + (dx2 * c2);
                nw4 = w4 + (dx2 * d2);
                nu = u + (dx2);

                nr2 = ((a2 * nw1) + (b2 * nw2) + (c2 * nw3) + (d2 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx2 ({dx2}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx2 es: {nw1}");
                Console.WriteLine($"'W2' para 'dx2 es: {nw2}");
                Console.WriteLine($"'W3' para 'dx2 es: {nw3}");
                Console.WriteLine($"'W4' para 'dx2 es: {nw4}");
                Console.WriteLine($"'U' para 'dx2 es: {nu}");
                Console.WriteLine($"El valor final de 'dx2 es: {nr2}");
                Console.WriteLine("\n");

            }

            r3 = ((a3 * w1) + (b3 * w2) + (c3 * w3) + (d3 * w4) + u);

            if (r3 <= dx3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx3 ({dx3})");
                Console.WriteLine("\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx3 * a3);
                nw2 = w2 + (dx3 * b3);
                nw3 = w3 + (dx3 * c3);
                nw4 = w4 + (dx3 * d3);
                nu = u + (dx3);

                nr3 = ((a3 * nw1) + (b3 * nw2) + (c3 * nw3) + (d3 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx3' ({dx3}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx3' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx3' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx3' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx3' es: {nw4}");
                Console.WriteLine($"'U' para 'dx3' es: {nu}");
                Console.WriteLine($"El valor final de 'dx3' es: {nr3}");
                Console.WriteLine("\n");

            }

            r4 = ((a4 * w1) + (b4 * w2) + (c4 * w3) + (d4 * w4) + u);

            if (r4 <= dx4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx4 ({dx4})");
                Console.WriteLine("\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx4 * a4);
                nw2 = w2 + (dx4 * b4);
                nw3 = w3 + (dx4 * c4);
                nw4 = w4 + (dx4 * d4);
                nu = u + (dx4);

                nr4 = ((a4 * nw1) + (b4 * nw2) + (c4 * nw3) + (d4 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx4' ({dx4}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx4' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx4' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx4' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx4' es: {nw4}");
                Console.WriteLine($"'U' para 'dx4' es: {nu}");
                Console.WriteLine($"El valor final de 'dx4' es: {nr4}");
                Console.WriteLine("\n");

            }

            r5 = ((a5 * w1) + (b5 * w2) + (c5 * w3) + (d5 * w4) + u);

            if (r5 <= dx5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx5 ({dx5})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx5 * a5);
                nw2 = w2 + (dx5 * b5);
                nw3 = w3 + (dx5 * c5);
                nw4 = w4 + (dx5 * d5);
                nu = u + (dx5);

                nr5 = ((a5 * nw1) + (b5 * nw2) + (c5 * nw3) + (d5 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx5' ({dx5}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx5' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx5' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx5' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx5' es: {nw4}");
                Console.WriteLine($"'U' para 'dx5' es: {nu}");
                Console.WriteLine($"El valor final de 'dx5' es: {nr5}");
                Console.WriteLine("\n");
            }

            r6 = ((a6 * w1) + (b6 * w2) + (c6 * w3) + (d6 * w4) + u);


            if (r6 <= dx6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx6 ({dx6})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx6 * a6);
                nw2 = w2 + (dx6 * b6);
                nw3 = w3 + (dx6 * c6);
                nw4 = w4 + (dx6 * d6);
                nu = u + (dx6);

                nr6 = ((a6 * nw1) + (b6 * nw2) + (c6 * nw3) + (d6 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx6' ({dx6}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx6' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx6' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx6' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx6' es: {nw4}");
                Console.WriteLine($"'U' para 'dx6' es: {nu}");
                Console.WriteLine($"El valor final de 'dx6' es: {nr6}");
                Console.WriteLine("\n");
            }

            r7 = ((a7 * w1) + (b7 * w2) + (c7 * w3) + (d7 * w4) + u);


            if (r7 <= dx7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx7 ({dx7})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx7 * a7);
                nw2 = w2 + (dx7 * b7);
                nw3 = w3 + (dx7 * c7);
                nw4 = w4 + (dx7 * d7);
                nu = u + (dx7);

                nr7 = ((a7 * nw1) + (b7 * nw2) + (c7 * nw3) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx7' ({dx7}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx7' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx7' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx7' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx7' es: {nw3}");
                Console.WriteLine($"'U' para 'dx7' es: {nu}");
                Console.WriteLine($"El valor final de 'dx7' es: {nr7}");
                Console.WriteLine("\n");
            }

            r8 = ((a8 * w1) + (b8 * w2) + (c8 * w3) + (d8 * w4) + u);


            if (r8 <= dx8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx8 ({dx8})");
                Console.WriteLine("\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx8 * a8);
                nw2 = w2 + (dx8 * b8);
                nw3 = w3 + (dx8 * c8);
                nw4 = w4 + (dx8 * d8);
                nu = u + (dx8);

                nr8 = ((a8 * nw1) + (b8 * nw2) + (c8 * nw3) + (d8 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx8' ({dx8}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx8' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx8' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx8' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx8' es: {nw4}");
                Console.WriteLine($"'U' para 'dx8' es: {nu}");
                Console.WriteLine($"El valor final de 'dx4' es: {nr8}");
                Console.WriteLine("\n");
            }

            r9 = ((a9 * w1) + (b9 * w2) + (c9 * w3) + (d9 * w4) + u);


            if (r9 <= d9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx9 ({dx9})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx9 * a9);
                nw2 = w2 + (dx9 * b9);
                nw3 = w3 + (dx9 * c9);
                nw4 = w4 + (dx9 * d9);
                nu = u + (dx9);

                nr9 = ((a9 * nw1) + (b9 * nw2) + (c9 * nw3) + (d9 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx9' ({dx9}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx9' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx9' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx9' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx9' es: {nw4}");
                Console.WriteLine($"'U' para 'dx9' es: {nu}");
                Console.WriteLine($"El valor final de 'dx9' es: {nr9}");
                Console.WriteLine("\n");
            }

            r10 = ((a10 * w1) + (b10 * w2) + (c10 * w3) + (d10 * w4) + u);


            if (r10 <= dx10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx1 ({dx1})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx10 * a10);
                nw2 = w2 + (dx10 * b10);
                nw3 = w3 + (dx10 * c10);
                nw4 = w4 + (dx10 * d10);
                nu = u + (dx10);

                nr10 = ((a10 * nw1) + (b10 * nw2) + (c10 * nw3) + (d10 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx10' ({dx10}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx10' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx10' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx10' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx10' es: {nw4}");
                Console.WriteLine($"'U' para 'dx10' es: {nu}");
                Console.WriteLine($"El valor final de 'dx10' es: {nr10}");
                Console.WriteLine("\n");
            }

            r11 = ((a11 * w1) + (b11 * w2) + (c11 * w3) + (d11 * w4) + u);

            if (r11 <= dx11)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx11 ({dx11})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx11 * a11);
                nw2 = w2 + (dx11 * b11);
                nw3 = w3 + (dx11 * c11);
                nw4 = w4 + (dx11 * d11);
                nu = u + (dx11);


                nr11 = ((a11 * nw1) + (b11 * nw2) + (c11 * nw3) + (d11 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx11' ({dx11}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx11' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx11' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx11' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx11' es: {nw4}");
                Console.WriteLine($"'U' para 'dx11' es: {nu}");
                Console.WriteLine($"El valor final de 'dx11' es: {nr11}");
                Console.WriteLine("\n");
            }

            r12 = ((a12 * w1) + (b12 * w2) + (c12 * w3) + (d12 * w4) + u);

            if (r12 <= dx12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx12 ({dx12})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx12 * a12);
                nw2 = w2 + (dx12 * b12);
                nw3 = w3 + (dx12 * c12);
                nw4 = w4 + (dx12 * d12);
                nu = u + (dx12);

                nr12 = ((a12 * nw1) + (b12 * nw2) + (c12 * nw3) + (d12 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx12' ({dx12}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx12' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx12' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx12' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx12' es: {nw4}");
                Console.WriteLine($"'U' para 'dx12' es: {nu}");
                Console.WriteLine($"El valor final de 'dx12' es: {nr12}");
                Console.WriteLine("\n");
            }

            r13 = ((a13 * w1) + (b13 * w2) + (c13 * w3) + (d13 * w4) + u);

            if (r13 <= dx13)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx1 ({dx1})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx13 * a13);
                nw2 = w2 + (dx13 * b13);
                nw3 = w3 + (dx13 * c13);
                nw4 = w4 + (dx13 * d13);
                nu = u + (dx13);

                nr13 = ((a13 * nw1) + (b13 * nw2) + (c13 * nw3) + (d13 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx13' ({dx13}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx13' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx13' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx13' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx13' es: {nw4}");
                Console.WriteLine($"'U' para 'dx13' es: {nu}");
                Console.WriteLine($"El valor final de 'dx13' es: {nr13}");
                Console.WriteLine("\n");
            }

            r14 = ((a14 * w1) + (b14 * w2) + (c14 * w3) + (d14 * w4) + u);

            if (r14 <= dx14)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx14 ({dx14})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx14 * a14);
                nw2 = w2 + (dx14 * b14);
                nw3 = w3 + (dx14 * c14);
                nw4 = w4 + (dx14 * d14);
                nu = u + (dx14);

                nr14 = ((a14 * nw1) + (b14 * nw2) + (c14 * nw3) + (d14 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx14' ({dx14}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx14' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx14' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx14' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx14' es: {nw4}");
                Console.WriteLine($"'U' para 'dx14' es: {nu}");
                Console.WriteLine($"El valor final de 'dx14' es: {nr14}");
                Console.WriteLine("\n");
            }

            r15 = ((a15 * w1) + (b15 * w2) + (c15 * w3) + (d15 * w4) + u);

            if (r15 <= dx15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx15 ({dx15})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx15 * a15);
                nw2 = w2 + (dx15 * b15);
                nw3 = w3 + (dx15 * c15);
                nw4 = w4 + (dx15 * d15);
                nu = u + (dx1);

                nr15 = ((a15 * nw1) + (b15 * nw2) + (c15 * nw3) + (d15 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx15' ({dx15}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx15' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx15' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx15' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx15' es: {nw4}");
                Console.WriteLine($"'U' para 'dx15' es: {nu}");
                Console.WriteLine($"El valor final de 'dx15' es: {nr15}");
                Console.WriteLine("\n");
            }

            r16 = ((a16 * w1) + (b16 * w2) + (c16 * w3) + (d16 * w4) + u);

            if (r16 > dx16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"No se recalculo dx16 ({dx16})");
                Console.WriteLine("\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                nw1 = w1 + (dx16 * a16);
                nw2 = w2 + (dx16 * b16);
                nw3 = w3 + (dx16 * c16);
                nw4 = w4 + (dx16 * d16);
                nu = u + (dx16);

                nr16 = ((a16 * nw1) + (b16 * nw2) + (c16 * nw3) + (d16 * nw4) + nu);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Se recalculo 'dx16' ({dx16}) \n");
                Console.WriteLine("Los valore nuevos para 'W1', 'W2', 'W3', 'W4' y 'U' son: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"'W1' para 'dx16' es: {nw1}");
                Console.WriteLine($"'W2' para 'dx16' es: {nw2}");
                Console.WriteLine($"'W3' para 'dx16' es: {nw3}");
                Console.WriteLine($"'W4' para 'dx16' es: {nw4}");
                Console.WriteLine($"'U' para 'dx16' es: {nu}");
                Console.WriteLine($"El valor final de 'dx16' es: {nr16}");
                Console.WriteLine("\n");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}