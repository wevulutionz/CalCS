Calculadora cal = new Calculadora();
Console.WriteLine("Ingrese N1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese N2");
int n2= int.Parse(Console.ReadLine());
Console.WriteLine("Seleccione: Dividir D,Restar R,Multiplicar M, Sumar S");//agregar operacion con la letra 
string op=Console.ReadLine();
int res= op=="D"?cal.Dividir(n1,n2):op=="R"?cal.Restar(n1,n2): op == "M" ? cal.Multiplicar(n1, n2):op == "D" ? cal.Dividir(n1, n2):0;//aumentar condicional siempre al final con :0
Console.WriteLine("resultado " + res);