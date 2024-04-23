namespace HelloWord
{
    internal class Multitarea
    {
        public static void Main(string[] args)
        {
            //Hilos();

            //Bloqueos();

            //Completado();

            PoolThreads();

        }

        static void PoolThreads()
        {
            for (int i = 0; i < 500; i++)
            {
                /*Thread t = new Thread(Ejecutartarea);
                t.Start();*/
                //reutiliza threads
                ThreadPool.QueueUserWorkItem(Ejecutartarea,i);

            }

            Console.ReadLine();
        }

        static void Ejecutartarea(object o)
        {
            int nTarea = (int)o;

            Console.WriteLine($"Thread nº {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea nº {nTarea}");
            Thread.Sleep( 1000 );
            Console.WriteLine($"Thread nº {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea nº {nTarea}");
        }

        static void Completado()
        {
            var tareaTerminada= new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);


                }


                tareaTerminada.TrySetResult(true);

            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }


            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 3");
                    Thread.Sleep(1000);
                }


            });

            hilo1.Start();
            hilo2.Start();

            var resultado = tareaTerminada.Task.Result;
            hilo3.Start();

        }

        static void Bloqueos()
        {
            CuentaBancaria cuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];


            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                Thread t = new Thread(cuentaFamilia.VamosARetirarEfectivo);

                t.Name = i.ToString();

                hilosPersonas[i] = t;
            }


            for (int i = 0; i < hilosPersonas.Length; i++) hilosPersonas[i].Start();


        }

        static void Hilos()
        {
            Thread t = new Thread(MetodoSaludo);
            t.Start();
            t.Join(); // join es esperar a que termine el thread


            Console.WriteLine("Hola desde el hilo 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 1");



            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();
            t2.Join();

            //MetodoSaludo();

        }

        static void MetodoSaludo()
        {
            Console.WriteLine("Hola desde el hilo 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde el hilo 2");
        }


    }


    class CuentaBancaria
    {
        private Object bloqueaSaldoPositivo = new Object();

        double Saldo { get; set; }
        public CuentaBancaria(double Saldo)
        {

            this.Saldo = Saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if (Saldo - cantidad < 0)
            {
                Console.WriteLine($"Lo siento queda {Saldo} en la cuenta. Hilo:{Thread.CurrentThread.Name}");
                return Saldo;
            }

            lock (bloqueaSaldoPositivo)
            {

                if (Saldo >= cantidad)
                {
                    Console.WriteLine($"Retirado {cantidad} y queda {Saldo - cantidad}. Hilo: {Thread.CurrentThread.Name}");
                    Saldo -= cantidad;
                    return cantidad;

                }
            }
            return Saldo;
        }

        public void VamosARetirarEfectivo()
        {
            Console.WriteLine($"Está sacando dinero del hilo: {Thread.CurrentThread.Name}");
            RetirarEfectivo(500);
            RetirarEfectivo(500);
            RetirarEfectivo(500);
            RetirarEfectivo(500);
        }
    }
}
