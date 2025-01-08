using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Projeto_fixe
{
    internal class Program
    {

        struct dados
        {
            public string nome;
            public string email;
            public string password;
            public int pontos;
            public int score;

        }
        struct posicao
        {
            public int x;
            public int y;

        }

        static dados[] info = new dados[1];
        static bool compradonut = false;
        static bool nomegratis = false;
        static bool compracobrinhaa = false;
        static bool compracompadivinha = false;
        static bool compracompadivinha100 = false;
        static bool compranumeromagico = false;
        static bool compranumeromagic1a100 = false;
        static bool comprapedrapapeltesoura = false;
        static void Main(string[] args)
        {

            string op, op2, op3, login = "", password, email;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------GAMEBOY-----------");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("-----------------------------");
                Console.Write("R: ");
                op3 = Console.ReadLine();
                switch (op3)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Login");
                            Console.WriteLine("-----------------------------");
                            Console.Write("Email: ");
                            email = Console.ReadLine();
                            Console.Write("Password: ");
                            password = "";
                            ConsoleKeyInfo key;
                            do
                            {
                                key = Console.ReadKey(true);
                                if (!char.IsControl(key.KeyChar))
                                {
                                    Console.Write("*");
                                    password += key.KeyChar;
                                }
                                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                                {
                                    password = password.Remove(password.Length - 1);
                                    Console.Write("\b \b");
                                }
                            } while (key.Key != ConsoleKey.Enter);
                            if (email == info[0].email)
                            {
                                if (password == info[0].password)
                                {
                                    Console.WriteLine("\nLogin Válido!");
                                    Console.WriteLine("-----------------------------");
                                    login = "Sucesso";
                                }

                            }
                            else
                            {
                                Console.WriteLine("\nEmail ou password Errada!");
                                Console.WriteLine("-----------------------------");
                                Primatecla();
                            }
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Email();
                            Console.WriteLine("\nPassword Válida!");
                            Primatecla();
                        }
                        break;

                }
            } while (login != "Sucesso");
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Bem-Vindo {info[0].nome}!\n");
            do
            {
                Console.WindowWidth = 120;
                Console.WindowHeight = 30;
                Menu();
                op = Console.ReadLine();
                if (op == "99") info[0].pontos += 10000;
                Console.Clear();
                switch (op)
                {
                    case "1":
                        {
                            do
                            {
                                Console.Clear();
                                Console.WindowWidth = 120;
                                Console.WindowHeight = 30;
                                listadejogos();
                                op2 = Console.ReadLine();
                                switch (op2)
                                {
                                    case "1":
                                        {
                                            Coc();
                                            Console.Clear();
                                        }
                                        break;
                                    case "2":
                                        {
                                            if (!comprapedrapapeltesoura)
                                            {
                                                Comprappt();
                                            }
                                            else Pedrapapeltesoura();
                                            Primatecla();
                                            Console.Clear();
                                        }
                                        break;
                                    case "3":
                                        {
                                            string res = null;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Computador_Adivinha");
                                                Console.WriteLine("-----------------------------");
                                                Console.WriteLine("Escolha umas das opções");
                                                Console.WriteLine("1. Número de 1 a 10");
                                                Console.WriteLine("2. Número de 1 a 100");
                                                Console.WriteLine("0. Voltar");
                                                Console.WriteLine("-----------------------------");
                                                Console.Write("R: ");
                                                res = Console.ReadLine();
                                                switch (res)
                                                {
                                                    case "1":
                                                        {
                                                            if (!compracompadivinha)
                                                            {
                                                                compradocomputadoradivinha();
                                                            }
                                                            else computadoradivinha();

                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case "2":
                                                        {
                                                            if (!compracompadivinha100)
                                                            {
                                                                compracomputadoradivinha100();
                                                            }
                                                            else computadoradivinha100();

                                                            Console.Clear();

                                                        }
                                                        break;
                                                }
                                            } while (res != "0");
                                        }
                                        break;
                                    case "4":
                                        {
                                            string res;
                                            do
                                            {
                                                Console.Clear();
                                                listadeacertarnumero();
                                                res = Console.ReadLine();
                                                switch (res)
                                                {
                                                    case "1":
                                                        {
                                                            if (!compranumeromagico)
                                                            {
                                                                CompraNumeromagico();
                                                            }
                                                            else Acertanumero();
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case "2":
                                                        {
                                                            if (!compranumeromagic1a100)
                                                            {
                                                                CompraNumeromagico1a100();
                                                            }
                                                            else Acertanumero1100();
                                                            Console.Clear();
                                                        }
                                                        break;
                                                }
                                            } while (res != "0");

                                        }
                                        break;
                                    case "5":
                                        {
                                            if (!compracobrinhaa)
                                            {
                                                compracobrinha();
                                            }
                                            else Cobrinha();
                                            Console.Clear();

                                        }
                                        break;
                                }
                            } while (op2 != "0");

                            Console.Clear();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Créditos");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine($"O/A {info[0].nome} tem {info[0].pontos} créditos!");
                            Console.WriteLine("\n--------------------------");
                            Primatecla();
                            Console.Clear();
                        }
                        break;
                    case "3":
                        {
                            string op7;
                            Console.Clear();
                            Console.WriteLine("Loja");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Escolha uma das opções:");
                            Console.WriteLine("1. Donut");
                            Console.WriteLine("0.Voltar");
                            Console.WriteLine("--------------------------");
                            Console.Write("R: ");
                            op7 = Console.ReadLine();
                            switch (op7)
                            {
                                case "1":
                                    {
                                        if (!compradonut)
                                        {
                                            compradonuts();
                                        }
                                        else donut();
                                    }
                                    break;

                            }

                            Console.Clear();

                        }
                        break;
                    case "4":
                        {
                            leaderboard();
                            Console.Clear();
                        }
                        break;
                    case "5":
                        {
                            string op5, op6;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Opções");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("Escolha uma das opções:");
                                Console.WriteLine("1. Mudar de nome");
                                Console.WriteLine("2. Mudar de palavra-passe");
                                Console.WriteLine("\n0. Voltar");
                                Console.WriteLine("--------------------------");
                                Console.Write("R: ");
                                op5 = Console.ReadLine();
                                Console.Clear();
                                switch (op5)
                                {
                                    case "1":
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Mudar de nome");
                                            Console.WriteLine("--------------------------");
                                            Console.WriteLine("Deseja mudar de nome (s/n)?");
                                            Console.WriteLine("Primeira vez é grátis!");
                                            Console.WriteLine("--------------------------");
                                            op6 = Console.ReadLine();
                                            if (op6 == "s")
                                            {
                                                Console.Clear();
                                                if (nomegratis)
                                                {
                                                    Console.WriteLine("--------------------------");
                                                    Console.WriteLine("Custará 100 créditos para mudar de nome!");
                                                    Console.WriteLine("Deseja comprar? (s/n)");
                                                    Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
                                                    Console.WriteLine("--------------------------");
                                                    Console.Write("R: ");
                                                    string res = Console.ReadLine();
                                                    Console.Clear();
                                                    Console.WriteLine("--------------------------\n");
                                                    res.ToLower();
                                                    if (res == "s")
                                                    {
                                                        if (info[0].pontos >= 100)
                                                        {
                                                            info[0].pontos -= 100;
                                                            Console.Clear();
                                                            Console.WriteLine("Nome");
                                                            Console.WriteLine("--------------------------");
                                                            Console.WriteLine("Insira o novo nome\n");
                                                            Console.WriteLine("--------------------------");
                                                            Console.Write("R: ");
                                                            info[0].nome = Console.ReadLine();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Créditos Insuficiente!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Não comprou!");
                                                    }
                                                }
                                                if (!nomegratis)
                                                {
                                                    Console.WriteLine("Nome");
                                                    Console.WriteLine("--------------------------");
                                                    Console.WriteLine("Insira o novo nome\n");
                                                    Console.WriteLine("--------------------------");
                                                    Console.Write("R: ");
                                                    info[0].nome = Console.ReadLine();
                                                    Console.Clear();
                                                    nomegratis = true;
                                                }
                                            }
                                            Console.WriteLine("--------------------------");
                                            Primatecla();
                                        }
                                        break;
                                    case "2":
                                        {
                                            string op8;
                                            Console.Clear();
                                            Console.WriteLine("Mudar de password");
                                            Console.WriteLine("--------------------------");
                                            Console.WriteLine("Deseja mudar de password (s/n)?\n");
                                            Console.WriteLine("--------------------------");
                                            op8 = Console.ReadLine();
                                            switch (op8)
                                            {
                                                case "s":
                                                    {
                                                        int tamanho;
                                                        bool carac = false;
                                                        bool digito = false;
                                                        bool letmasc = false;
                                                        bool simbolo = false;
                                                        Console.Clear();
                                                        Console.WriteLine("Password");
                                                        Console.WriteLine("--------------------------");
                                                        Console.WriteLine("Insira a nova password");
                                                        Console.WriteLine("\n--------------------------");
                                                        do
                                                        {
                                                            password = "";
                                                            ConsoleKeyInfo key;
                                                            do
                                                            {
                                                                key = Console.ReadKey(true);
                                                                if (!char.IsControl(key.KeyChar))
                                                                {
                                                                    Console.Write("*");
                                                                    password += key.KeyChar;
                                                                }
                                                                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                                                                {
                                                                    password = password.Remove(password.Length - 1);
                                                                    Console.Write("\b \b");
                                                                }
                                                            } while (key.Key != ConsoleKey.Enter);
                                                            info[0].password = password;
                                                            tamanho = info[0].password.Length;
                                                            foreach (char l in info[0].password)
                                                            {
                                                                if (tamanho >= 7) carac = true;
                                                                if (l >= (char)48 && l <= (char)71) digito = true;
                                                                if (l >= (char)65 && l <= (char)90) letmasc = true;
                                                                if (l >= (char)33 && l <= (char)47 || l == (char)63 || l == (char)64) simbolo = true;

                                                            }
                                                            if (carac && digito && letmasc && simbolo)
                                                            {
                                                                Console.WriteLine("\nPassword Válida!");
                                                                Console.WriteLine("-----------------------------");
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\nPassword Inválida: ");
                                                                Console.WriteLine("-----------------------------");
                                                                if (!carac) Console.WriteLine("-Tem de ter 7 caracteres");
                                                                if (!digito) Console.WriteLine("-Tem de ter 1 digito");
                                                                if (!letmasc) Console.WriteLine("-Tem de ter 1 Letra Maiscula");
                                                                if (!simbolo) Console.WriteLine("-Tem de ter 1 simbolo");
                                                                Console.WriteLine("-----------------------------");
                                                                Console.Write("R: ");
                                                            }

                                                        } while (!carac || !digito || !letmasc || !simbolo);


                                                    }
                                                    break;
                                            }
                                            Primatecla();
                                        }
                                        break;

                                }
                            } while (op5 != "0");
                        }
                        break;
                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Ajuda");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Como jogar?");
                            Console.WriteLine("\nNesta Console Application experimental feita pelos devidos desenvolvedores(opção 7), o objetivo pode variar entre conseguir todos os jogos começando com o jogo gratuito ou subir as de momento desfuncionais leaderboards.");
                            Console.WriteLine("\nO que fazer com os créditos?");
                            Console.WriteLine("Usas os créditos para comprar jogos novos ou o donut(disponivel na loja).");
                            Console.WriteLine("\nO que fazer com o Score?");
                            Console.WriteLine("O Score serve meramente para te posicionares na leaderboard.");
                            Console.WriteLine("Se estiver se a perguntar, nao, as contas nao se guardam o register e o login são só demonstrações das nossas abilidades, BOA SORTE :D");
                            Console.WriteLine("Caso ainda precises ajuda podes ligar para o numero 112");
                            Console.WriteLine("\n--------------------------");
                            Primatecla();
                            Console.Clear();
                        }
                        break;
                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Desenvolvedores: ");
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("1ºTGPSI");
                            Console.WriteLine("Pedro Costa");
                            Console.WriteLine("Luis Petrenko\n");
                            Console.WriteLine("--------------------------");
                            Primatecla();
                            Console.Clear();
                        }
                        break;
                }
            } while (op != "0");
        }
        static void compradonuts()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 1500 créditos para comprar o donut!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();

            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 1500)
                {
                    info[0].pontos -= 1500;
                    compradonut = true;

                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o donut!");
            }
            Primatecla();
        }
        static void compracobrinha()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 500 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 500)
                {
                    info[0].pontos -= 500;
                    compracobrinhaa = true;
                    Cobrinha();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Console.WriteLine("\n--------------------------");
            Primatecla();
            Console.Clear();
        }

        static void CorrVisuais(int jaltura, int jlargura)
        {
            Console.SetCursorPosition(jlargura - 1, 0);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write(" ");
            Console.SetCursorPosition(jlargura - 1, jaltura - 3);
            Console.Write(" ");
            Console.SetCursorPosition(jlargura - 1, jaltura - 2);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write(" ");
            Console.SetCursorPosition(jlargura - 1, jaltura - 1);
            Console.Write(" ");
            Console.SetCursorPosition(0, jaltura - 3);
            Console.Write(" ");
            Console.SetCursorPosition(0, jaltura - 1);
            Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write(" ");
        }
        static void Cobrinha()
        {
            Console.CursorVisible = false;
            string direcao = "right";
            int jaltura = Console.WindowHeight = 16;
            int jlargura = Console.WindowWidth = 32;
            Random al = new Random();
            int pont = 3;
            posicao cabeca = new posicao();
            cabeca.x = jlargura / 2;
            cabeca.y = jaltura / 2;
            List<int> corpox = new List<int>();
            List<int> corpoy = new List<int>();
            int frutinhax = al.Next(2, jlargura - 3);
            int frutinhay = al.Next(2, jaltura - 3);
            bool ativo = false;
            while (!ativo)
            {
                Console.Clear();
                Console.SetCursorPosition(0, jaltura - 2);
                Console.Write($"Pontos:{pont - 3}");
                if (cabeca.x == jlargura - 3 || cabeca.x == 1 || cabeca.y == jaltura - 4 || cabeca.y == 1)
                {
                    ativo = true;
                }
                for (int i = 0; i < jaltura; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("|");
                    Console.SetCursorPosition(jlargura - 1, i);
                    Console.Write("|");
                }
                for (int i = 0; i < jlargura; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("=");
                    Console.SetCursorPosition(i, jaltura - 3);
                    Console.Write("=");
                }
                if (frutinhax == cabeca.x && frutinhay == cabeca.y)
                {
                    pont++;
                    frutinhax = al.Next(2, jlargura - 3);
                    frutinhay = al.Next(2, jaltura - 3);
                }
                CorrVisuais(jaltura, jlargura);
                Console.SetCursorPosition(0, jaltura - 2);
                Console.Write($"Pontos:{pont - 3}");

                for (int i = 0; i < corpox.Count(); i++)
                {
                    Console.SetCursorPosition(corpox[i], corpoy[i]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("o");
                    if (corpox[i] == cabeca.x && corpoy[i] == cabeca.y)
                    {
                        ativo = true;
                    }
                }

                Console.SetCursorPosition(cabeca.x, cabeca.y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("O");
                Console.SetCursorPosition(frutinhax, frutinhay);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Q");
                var rel = Stopwatch.StartNew();
                while (rel.ElapsedMilliseconds <= 400)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo tecla = Console.ReadKey(true);
                        if (tecla.Key.Equals(ConsoleKey.UpArrow) && direcao != "down")
                        {
                            direcao = "up";
                        }
                        if (tecla.Key.Equals(ConsoleKey.DownArrow) && direcao != "up")
                        {
                            direcao = "down";
                        }
                        if (tecla.Key.Equals(ConsoleKey.LeftArrow) && direcao != "right")
                        {
                            direcao = "left";
                        }
                        if (tecla.Key.Equals(ConsoleKey.RightArrow) && direcao != "left")
                        {
                            direcao = "right";
                        }
                    }
                }
                corpox.Add(cabeca.x);
                corpoy.Add(cabeca.y);
                if (corpox.Count() > pont)
                {
                    corpox.RemoveAt(0);
                    corpoy.RemoveAt(0);
                }
                switch (direcao)
                {
                    case "up":
                        cabeca.y--;
                        break;
                    case "down":
                        cabeca.y++;
                        break;
                    case "left":
                        cabeca.x--;
                        break;
                    case "right":
                        cabeca.x++;
                        break;
                }
            }
            Console.Clear();
            Console.CursorVisible = true;
            Console.WindowWidth = 40;
            Console.SetCursorPosition(jlargura / 2 - 6, jaltura / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"GAMEOVER!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(jlargura / 2 - 6, jaltura / 2 + 1);
            Console.Write($"Pontos:{pont}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(jlargura / 2 - 6, jaltura / 2 + 2);
            Console.Write($"+{pont * 2} créditos");
            info[0].pontos += pont * 2;
            Console.ForegroundColor = ConsoleColor.White;
            Primatecla();
        }
        static void Email()
        {
            int tamanho;
            bool flagnome = false;
            bool flag = false;

            do
            {
                Console.WriteLine("Registro");
                Console.WriteLine("-----------------------------");
                Console.Write("Nickname: ");
                info[0].nome = Console.ReadLine();
                if (info[0].nome.Length > 2)
                {
                    Console.WriteLine("Nickname Válido");
                    flagnome = true;
                }
                else
                {
                    Console.WriteLine("Nickname Inválido");
                    Console.WriteLine("\nPrecisa de ter mais de 2 caracteres!");
                    Console.WriteLine("Prima qualquer tecla para tentar novamente!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!flagnome);
            do
            {
                Console.Write("\nEscreva o seu email: ");
                info[0].email = Console.ReadLine();
                foreach (char letra in info[0].email)
                {
                    if (letra == (char)64) flag = true;
                }
                if (flag) Console.WriteLine("Email Válido!");
                else
                {
                    Console.Clear();
                    Console.WriteLine("Register");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Nickname: " + info[0].nome);
                    Console.WriteLine("\nEmail Inválido!");
                    Console.WriteLine("È preciso ter um @!");
                    Console.WriteLine("Prima qualquer tecla para tentar novamente!");
                    Console.ReadLine();
                }

            } while (!flag);


            string password = "";
            ConsoleKeyInfo key;
            Console.Write("\nPassword: ");
            do
            {
                key = Console.ReadKey(true);
                if (!char.IsControl(key.KeyChar))
                {
                    Console.Write("*");
                    password += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            info[0].password = password;
            tamanho = info[0].password.Length;





        }
        static void leaderboard()
        {
            string op4;
            do
            {

                Console.Clear();
                Console.WriteLine("Leaderboard");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Escolha uma das opções:\n");
                Console.WriteLine("1. Créditos\n2. Score\n\n0. Voltar");
                Console.WriteLine("--------------------------");
                Console.Write("R: ");
                op4 = Console.ReadLine();
                switch (op4)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Leaderboard de Créditos");
                            Console.WriteLine("--------------------------");
                            for (int i = 0; i < info.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. " + info[i].nome + "- " + info[i].pontos + " créditos");
                            }
                            Console.WriteLine("\n--------------------------");
                            Primatecla();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Leaderboard de Score");
                            Console.WriteLine("--------------------------");
                            for (int i = 0; i < info.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. " + info[i].nome + "- " + info[i].score + " score");
                            }
                            Console.WriteLine("\n--------------------------");
                            Primatecla();
                            Console.Clear();

                        }
                        break;
                }
            } while (op4 != "0");
        }
        static void listadeacertarnumero()
        {
            Console.WriteLine("Acertar o numero");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("1. Numero de 1 a 10");
            Console.WriteLine("2. Numero de 1 a 100");
            Console.WriteLine("\n0. Voltar");
            Console.WriteLine("\n--------------------------");
            Console.Write("R: ");
        }
        static void Menu()
        {
            Console.WriteLine("-----------MENU-----------");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Créditos");
            Console.WriteLine("3. Loja");
            Console.WriteLine("4. Leaderboard");
            Console.WriteLine("5. Opções");
            Console.WriteLine("6. Ajuda");
            Console.WriteLine("7. Desenvolvedores");
            Console.WriteLine("\n0. Sair");
            Console.WriteLine("--------------------------");
            Console.Write("\nR: ");
        }
        static void listadejogos()
        {
            Console.WriteLine("Jogos");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Escolha uma das opções:\n");
            Console.WriteLine("1. Cara ou Coroa");
            Console.WriteLine("2. Pedra, papel ou tesoura");
            Console.WriteLine("3. Computador Advinha");
            Console.WriteLine("4. Acertar o número");
            Console.WriteLine("5. Cobrinha");
            Console.WriteLine("\n0. Voltar");
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
        }
        static void Coc()
        {
            string op = "";
            int chance = 0;
            while (op != "0")
            {
                Random coc = new Random();
                chance = coc.Next(1, 3);
                Console.Clear();
                Console.WriteLine("Cara&Coroa");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("\n1.Cara\n2.Coroa\n\n0. Voltar");
                Console.WriteLine("--------------------------");
                Console.Write("\nR: ");
                op = Console.ReadLine();
                op.ToLower();
                if (op != "0" || op == "1" || op == "2")
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                    Console.WriteLine("..");
                    Thread.Sleep(100);
                    Console.WriteLine("...");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    if (chance == 1 && op == "1")
                    {
                        Console.WriteLine("GANHASTE!\n+10 Score\n+5 Créditos");
                        info[0].score += 10;
                        info[0].pontos += 5;
                    }
                    else if (chance == 2 && op == "2")
                    {
                        Console.WriteLine("GANHASTE!");

                        Console.WriteLine("+10 Score\n+5 Créditos");
                        info[0].pontos += 5;
                        info[0].score += 10;
                    }
                    else Console.WriteLine("Perdeste");
                    Primatecla();
                }
            }
        }
        static void Pedrapapeltesoura()
        {
            Console.Clear();
            string resposta;
            Random random = new Random();
            int numerorandom = random.Next(1, 4);
            Console.WriteLine("Pedra&Papel&Tesoura");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Escolhe uma das opções: ");
            Console.WriteLine("1. Pedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tesoura");
            Console.WriteLine("\n0. Voltar");
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            resposta = Console.ReadLine();
            Console.WriteLine(".");
            Thread.Sleep(100);
            Console.WriteLine("..");
            Thread.Sleep(100);
            Console.WriteLine("...");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("--------------------------");
            if (resposta == "1" && numerorandom == 1 || resposta == "2" && numerorandom == 2 || resposta == "3" && numerorandom == 3)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Empate!");
                Console.WriteLine("+10 Score\n+5 Créditos");
                info[0].pontos += 5;
                info[0].score += 10;
                Console.WriteLine("--------------------------");
            }
            if (resposta == "2" && numerorandom == 1 || resposta == "3" && numerorandom == 2 || resposta == "1" && numerorandom == 3)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("GANHASTE!");
                Console.WriteLine("+20 Score\n+10 Créditos");
                info[0].pontos += 10;
                info[0].score += 20;
                Console.WriteLine("--------------------------");
            }
            if (resposta == "3" && numerorandom == 1 || resposta == "1" && numerorandom == 2 || resposta == "2" && numerorandom == 3)
            {
                Console.WriteLine("Perdeste!");

            }
        }
        /// <summary>
        /// Faz coisas
        /// </summary>
        static void compradocomputadoradivinha()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 80 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 80)
                {
                    info[0].pontos -= 80;
                    compracompadivinha = true;
                    computadoradivinha();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Primatecla();
            Console.Clear();

        }
        static void Comprappt()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 50 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 50)
                {
                    info[0].pontos -= 50;
                    comprapedrapapeltesoura = true;
                    Pedrapapeltesoura();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Primatecla();
            Console.Clear();
        }
        static void compracomputadoradivinha100()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 350 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 350)
                {
                    info[0].pontos -= 350;
                    compracompadivinha100 = true;
                    computadoradivinha100();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Primatecla();
            Console.Clear();
        }
        static void computadoradivinha100()
        {
            int score = 0;
            int num, numsecret = 0, contartentativas = 0;
            string res = "";
            Console.Clear();
            Console.WriteLine("COMPUTADOR ADIVINHA");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nBEM VINDO AO COMPUTADOR ADIVINHA!");
            Random NumPC = new Random();
            numsecret = NumPC.Next(1, 100);
            do
            {
                Console.WriteLine("Insira um número de 1 a 100");
                Console.WriteLine("--------------------------");
                Console.Write("R: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 || num <= 100)
                {
                    Console.WriteLine($"É este o seu numero {numsecret}? (s/n)");
                    res = Console.ReadLine();
                    res.ToLower();
                    switch (res)
                    {
                        case "s":
                            {
                                if (num == numsecret)
                                {
                                    Console.WriteLine(".");
                                    Thread.Sleep(100);
                                    Console.WriteLine("..");
                                    Thread.Sleep(100);
                                    Console.WriteLine("...");
                                    Thread.Sleep(100);
                                    Console.Clear();
                                    Console.WriteLine("COMPUTADOR ADIVINHA");
                                    Console.WriteLine("--------------------------");
                                    Console.WriteLine("O computador adivinhou!!");
                                    contartentativas = contartentativas * 5;
                                    score = 250 - contartentativas;
                                    info[0].pontos += score * 2;
                                    if (score < 0)
                                    {
                                        score = 0;
                                    }
                                    Console.WriteLine($"+{score * 2} Créditos");
                                    Console.WriteLine($"Score: {score}");
                                    Console.WriteLine("0.Voltar");
                                }
                                else Console.WriteLine("TRAPALHÃO");
                                Console.Clear();
                            }
                            break;
                        case "n":
                            {
                                Console.WriteLine(".");
                                Thread.Sleep(100);
                                Console.WriteLine("..");
                                Thread.Sleep(100);
                                Console.WriteLine("...");
                                Thread.Sleep(100);
                                Console.Clear();
                                contartentativas++;
                                Console.WriteLine("O computador falhou...");
                                numsecret = NumPC.Next(1, 100);
                            }
                            break;
                    }
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1.Continuar\n0.Voltar");
                    res = Console.ReadLine();
                    Console.Clear();
                }
            } while (res != "0");
        }
        static void computadoradivinha()
        {
            int score = 0;
            int num, numsecret = 0, contartentativas = 0;
            string res = " ";
            Console.Clear();
            Console.WriteLine("COMPUTADOR ADIVINHA");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nBEM VINDO AO COMPUTADOR ADIVINHA!");
            Random NumPC = new Random();
            numsecret = NumPC.Next(1, 10);
            do
            {
                Console.WriteLine("Insira um número de 1 a 10");
                Console.WriteLine("--------------------------");
                Console.Write("R: ");
                num = Convert.ToInt32(Console.ReadLine());


                if (num > 0 || num <= 10)
                {
                    Console.WriteLine($"É este o seu numero {numsecret}? (s/n)");
                    res = Console.ReadLine();
                    res.ToLower();
                    switch (res)
                    {
                        case "s":
                            {
                                if (num == numsecret)
                                {
                                    Console.WriteLine(".");
                                    Thread.Sleep(100);
                                    Console.WriteLine("..");
                                    Thread.Sleep(100);
                                    Console.WriteLine("...");
                                    Thread.Sleep(100);
                                    Console.Clear();
                                    Console.WriteLine("COMPUTADOR ADIVINHA");
                                    Console.WriteLine("--------------------------");
                                    Console.WriteLine("O computador adivinhou!!");
                                    score = 20 - contartentativas;
                                    if (score < 0)
                                    {
                                        score = 0;
                                    }
                                    info[0].pontos += score * 2;
                                    Console.WriteLine($"+{score * 2} Créditos");
                                    Console.WriteLine($"Score: {score}\n0.Voltar");

                                }
                                else Console.WriteLine("TRAPALHAO\n0.Voltar");
                            }
                            break;
                        case "n":
                            {
                                Console.WriteLine(".");
                                Thread.Sleep(100);
                                Console.WriteLine("..");
                                Thread.Sleep(100);
                                Console.WriteLine("...");
                                Thread.Sleep(100);
                                Console.Clear();
                                contartentativas++;
                                Console.WriteLine("O computador falhou...");
                                numsecret = NumPC.Next(1, 10);
                            }
                            break;
                    }
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1.Continuar\n0.Voltar");
                    res = Console.ReadLine();
                    Console.Clear();
                }
            } while (res != "0");
        }

        static void Acertanumero1100()
        {
            int score = 0;
            int num, numsecret = 0, contartentativas = 0;
            Console.Clear();
            Console.WriteLine("NUMERO MAGICO");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nBEM VINDO AO NUMERO MAGICO!");
            do
            {
                Random NumPC = new Random();
                numsecret = NumPC.Next(1, 100);
                Console.Write("DE 1 A 100, INSIRA O NUMERO QUE ACHA QUE É!");
                Console.WriteLine("\n\n--------------------------");
                Console.Write("R: ");
                num = int.Parse(Console.ReadLine());



                if (num == numsecret) // Acertou
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                    Console.WriteLine("..");
                    Thread.Sleep(100);
                    Console.WriteLine("...");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("PARABENS, ACERTASTE!\n");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"ADIVINHOU EM : {contartentativas} TENTATIVAS");
                    contartentativas = contartentativas * 5;
                    score = 250 - contartentativas;
                    info[0].pontos += score * 2;
                    Console.WriteLine("Créditos: " + score * 2);
                    Console.WriteLine($"Score: {score}");
                }
                else // Errou
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                    Console.WriteLine("..");
                    Thread.Sleep(100);
                    Console.WriteLine("...");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("ERRASTE, TENTA NOVAMENTE!\n");
                }
                contartentativas++;
                Console.WriteLine($"\nO NÚMERO ERA: {numsecret}\n");
                Console.WriteLine("1.Continuar\n0. Voltar");
                num = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (num > 0 && num <= 100);
        }
        static void Acertanumero()
        {
            int score = 0;
            int num, numsecret = 0, contartentativas = 0;
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nBEM VINDO AO NUMERO MAGICO!");
            do
            {
                Random NumPC = new Random();
                numsecret = NumPC.Next(1, 10);
                Console.Write("DE 1 A 10, INSIRA O NUMERO QUE ACHA QUE É!");
                Console.WriteLine("\n\n--------------------------");
                Console.Write("R: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == numsecret) // Acertou
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                    Console.WriteLine("..");
                    Thread.Sleep(100);
                    Console.WriteLine("...");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.WriteLine("PARABENS, ACERTASTE!\n");
                    Console.WriteLine($"+{score * 2} Créditos");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"ADIVINHOU EM : {contartentativas} TENTATIVAS");
                    score = 20 - contartentativas;
                    if (score < 0)
                    {
                        score = 0;
                    }
                    info[0].pontos += score * 2;
                    Console.WriteLine($"Score: {score}");
                    Console.WriteLine($"\nO NÚMERO ERA: {numsecret}\n");
                }
                else // Errou
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                    Console.WriteLine("..");
                    Thread.Sleep(100);
                    Console.WriteLine("...");
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("ERRASTE, TENTA NOVAMENTE!\n ");
                }
                contartentativas++;
                Console.WriteLine("1.Continuar\n0.Voltar");
                num = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (num > 0 && num <= 10);
        }
        static void CompraNumeromagico1a100()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 350 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 350)
                {
                    info[0].pontos -= 350;
                    compranumeromagic1a100 = true;
                    Acertanumero1100();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Console.WriteLine("\n--------------------------");
        }
        static void CompraNumeromagico()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Custará 100 créditos para comprar o jogo!");
            Console.WriteLine("Deseja comprar? (s/n)");
            Console.WriteLine("\nCréditos que possuí: " + info[0].pontos);
            Console.WriteLine("--------------------------");
            Console.Write("R: ");
            string res = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("--------------------------\n");
            res.ToLower();
            if (res == "s")
            {
                if (info[0].pontos >= 100)
                {
                    info[0].pontos -= 100;
                    compranumeromagico = true;
                    Acertanumero();
                }
                else
                {
                    Console.WriteLine("Créditos Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Não comprou o jogo!");
            }
            Console.WriteLine("\n--------------------------");
        }
        static void Primatecla()
        {
            Console.WriteLine("\n\nPrima qualquer tecla para continuar");
            Console.ReadLine();
        }
        static void donut()
        {
            double A = 0, B = 0, i, j;
            var z = new double[1760];
            var b = new char[1760];
            const int width = 80;
            const int height = 22;
            var parar = Stopwatch.StartNew();

            while (parar.ElapsedMilliseconds <= 10000)
            {
                memset(b, ' ', 1760);
                memset(z, 0.0f, 1760);

                for (j = 0; 6.28 > j; j += 0.07)
                {
                    for (i = 0; 6.28 > i; i += 0.02)
                    {
                        double c = Math.Sin(i);
                        double d = Math.Cos(j);
                        double e = Math.Sin(A);
                        double f = Math.Sin(j);
                        double g = Math.Cos(A);
                        double h = d + 2;
                        double D = 1 / (c * h * e + f * g + 5);
                        double l = Math.Cos(i);
                        double m = Math.Cos(B);
                        double n = Math.Sin(B);
                        double t = c * h * g - f * e;

                        int x = (int)(40 + 30 * D * (l * h * m - t * n));
                        int y = (int)(11 + 15 * D * (l * h * n + t * m));
                        int o = x + width * y;
                        int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));

                        if (height > y && y > 0 && width > x && x > 0 && D > z[o])
                        {
                            z[o] = D;
                            b[o] = "shadow.burro"[N > 0 ? N : 0];
                        }
                    }
                }

                Console.SetCursorPosition(0, 0);
                nl(b);
                Console.Write(b);

                A += 0.04;
                B += 0.02;


                Thread.Sleep(20);
            }
        }

        static void memset<T>(T[] buf, T val, int bufsz)
        {
            if (buf == null)
            {
                buf = new T[bufsz];
            }

            for (int i = 0; i < bufsz; i++)
            {
                buf[i] = val;
            }
        }

        static void nl(char[] b)
        {
            for (int i = 80; 1760 > i; i += 80)
            {
                b[i] = '\n';
            }
        }
    }
}