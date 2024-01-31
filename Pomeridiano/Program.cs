namespace Pomeridiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto in BancaPasca");
            Console.WriteLine("Inserire Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserire cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserire versamento");
            int versamento = int.Parse(Console.ReadLine());
            bool end = false;
            if(versamento < 1000)
            {
                end = true;
                Console.WriteLine("Valore non raggiunto");

            } 
            ContoCorrente userBank1 = new ContoCorrente(nome,cognome, versamento);
             
            while(!end)
            {
                Console.WriteLine("Preleva 1");
                Console.WriteLine("Versa 2");
                Console.WriteLine("3 - Esci");
                Console.WriteLine("4 - Saldo totale"); 

                Console.WriteLine("Scegli l'opzione: ");
                string option = Console.ReadLine();
                Console.Clear();

 

                switch (option)
                {
                    case "1":
                        userBank1.Prelievo();
                        break;

                    case "4":
                        Console.WriteLine("il tuo saldo disponibile é: " + userBank1.Saldo + "$");
                        break;

                    case "2":
                        userBank1.Versamento();
                        break;


                    case "3":
                        return;

                    default:
                        Console.WriteLine("Valore non accettato");
                        break;
                }

            }

        }
    }

        }


        class ContoCorrente
        {
            string _name;
            string _surname;
            int _saldo;



            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Surname
            {
                get { return _surname; }
                set { _surname = value; }
            }
            public int Saldo
            {
                get { return _saldo; }
                set
                {
                  
                        _saldo = value;
                    
                         
                }

            }

            public ContoCorrente(string name, string surname, int saldo)
            {
                Name = name;
                Surname = surname;
                Saldo = saldo;

            }

            public void Prelievo ()
            {
                Console.WriteLine("quanto vuoi prelevare?");
                int tot = int.Parse(Console.ReadLine());
                if(tot > Saldo) 
                {
                    Console.WriteLine("Soldi insufficienti");

                } else if(tot == 0)
                {
                    Console.WriteLine("Inserisci un importo maggiore di 0");
                        } else
                {
                        Saldo = Saldo - tot;
                    Console.WriteLine($"Il saldo disponibile é: {Saldo}");
                }
              
            }

            public void Versamento()
            {
                Console.WriteLine($"Quanto vuoi versare? il tuo saldo disponibile é {Saldo}");
                int tot = int.Parse(Console.ReadLine());
               
        
        if(tot == 0)
                {
                    Console.WriteLine("importo insufficiente");
                }
                else
                {
                    Saldo = Saldo + tot;
            Console.WriteLine($"Hai versato il tuo saldo disponibile é {Saldo}");
                }
            }


        }

    

